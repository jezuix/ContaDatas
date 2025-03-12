using System.ComponentModel;
using ContaDatas.Model;
using ContaDatas.Utils;

namespace ContaDatas
{
    public partial class Main : Form
    {
        private IList<DataGridViewObj> ListButtonSequence { get; set; } = [];
        private DateTime? UltimaDataCalculada { get; set; } = null;
        private int QuantidadeParcela { get; set; } = 0;

        public Main()
        {
            InitializeComponent();

            DadosIniciais();
            CreateDataGridView();
        }

        private void DadosIniciais()
        {
            dtpDataInicial.Value = DateTime.Today;
            dtpDataInicial.Enabled = true;

            txtQtdDias.Text = "30";

            chkDiasUteis.Checked = false;
            chkDiasUteis.Enabled = true;

            ListButtonSequence = [];
            UltimaDataCalculada = null;
            QuantidadeParcela = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DadosIniciais();
            UpdateDataGridView();
        }

        private static bool ValidateKeyPressIsValidNumber(KeyPressEventArgs e)
        {
            return char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar);
        }

        private void txtQtdDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnCalcular_Click(null!, null!);

                e.Handled = true;
            }
            else
            {
                e.Handled = !ValidateKeyPressIsValidNumber(e);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQtdDias.Text, out int qtdDias))
            {
                MessageBox.Show("Quantidade de dias inválida", "Quantidade de dias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (qtdDias <= 0 && UltimaDataCalculada.HasValue)
            {
                MessageBox.Show("Apenas o primeiro dia pode ser igual a 0, demais dias deve ser maior que 0", "Quantidade de dias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!UltimaDataCalculada.HasValue)
                UltimaDataCalculada = dtpDataInicial.Value;

            dtpDataInicial.Enabled = false;
            chkDiasUteis.Enabled = false;

            txtQtdDias.SelectAll();
            txtQtdDias.Focus();

            var apenasDiasUteis = chkDiasUteis.Checked;

            QuantidadeParcela++;

            UltimaDataCalculada = apenasDiasUteis ? SomaDiasUteis.Somar(UltimaDataCalculada.Value, qtdDias) : UltimaDataCalculada.Value.AddDays(qtdDias);
            ListButtonSequence.Add(new() { DataParcela = UltimaDataCalculada.Value.ToShortDateString(), NumeroParcela = $"{QuantidadeParcela}", Dias = $"{qtdDias}" });

            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dgvContagemDatas.DataSource = new BindingList<DataGridViewObj>(ListButtonSequence);
            dgvContagemDatas.Update();
        }

        private void CreateDataGridView()
        {
            dgvContagemDatas.RowHeadersVisible = false;
            dgvContagemDatas.AutoGenerateColumns = false;
            dgvContagemDatas.AllowUserToAddRows = false;

            //Número da Parcela 
            dgvContagemDatas.Columns.Add(new DataGridViewColumn()
            {
                HeaderText = "Número da Parcela",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DataPropertyName = "NumeroParcela",
                CellTemplate = new DataGridViewTextBoxCell()
            });

            //Data da Parcela
            dgvContagemDatas.Columns.Add(new DataGridViewColumn()
            {
                HeaderText = "Data da Parcela",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DataPropertyName = "DataParcela",
                CellTemplate = new DataGridViewTextBoxCell()
            });

            //Quantidade de Dias
            dgvContagemDatas.Columns.Add(new DataGridViewColumn()
            {
                HeaderText = "Dias",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DataPropertyName = "Dias",
                CellTemplate = new DataGridViewTextBoxCell()
            });
        }

        private void dtpDataInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnCalcular_Click(null!, null!);

                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void chkDiasUteis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnCalcular_Click(null!, null!);

                e.Handled = true;
            }
            else
                e.Handled = false;
        }
    }
}
