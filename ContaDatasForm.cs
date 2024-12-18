using System.ComponentModel;
using ContaDatas.Model;
using ContaDatas.Utils;

namespace ContaDatas
{
    public partial class Main : Form
    {
        private IList<DataGridViewObj> ListButtonSequence { get; set; } = [];

        public Main()
        {
            InitializeComponent();

            DadosIniciais();
            CreateDataGridView();
        }

        private void DadosIniciais()
        {
            dtpDataInicial.Value = DateTime.Today;
            txtQtdDias.Text = "30";
            chkDiasUteis.Checked = false;
            txtQtdParcelas.Text = "1";
            ListButtonSequence = [];
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
            e.Handled = !ValidateKeyPressIsValidNumber(e);
        }

        private void txtQtdParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !ValidateKeyPressIsValidNumber(e);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ListButtonSequence = [];

            if (!int.TryParse(txtQtdDias.Text, out int qtdDias)) MessageBox.Show("Quantidade de dias inválida", "Quantidade de dias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!int.TryParse(txtQtdParcelas.Text, out int qtdParcelas)) MessageBox.Show("Quantidade de parcelas inválida", "Quantidade de parcelas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (qtdDias <= 0) MessageBox.Show("Quantidade de dias deve ser maior que 0", "Quantidade de dias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (qtdParcelas <= 0) MessageBox.Show("Quantidade de parcelas deve ser maior que 0", "Quantidade de parcelas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var apenasDiasUteis = chkDiasUteis.Checked;
            var dataCalulada = dtpDataInicial.Value;
            for (int i = 0; i < qtdParcelas; i++)
            {
                dataCalulada = apenasDiasUteis ? SomaDiasUteis.Somar(dataCalulada, qtdDias) : dataCalulada.AddDays(qtdDias);
                ListButtonSequence.Add(new() { DataParcela = dataCalulada.ToShortDateString(), NumeroParcela = $"{i + 1}" });
            }

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

            //Text 
            dgvContagemDatas.Columns.Add(new DataGridViewColumn()
            {
                HeaderText = "Número da Parcela",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DataPropertyName = "NumeroParcela",
                CellTemplate = new DataGridViewTextBoxCell()
            });

            //Control
            dgvContagemDatas.Columns.Add(new DataGridViewColumn()
            {
                HeaderText = "Data da Parcela",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DataPropertyName = "DataParcela",
                CellTemplate = new DataGridViewTextBoxCell()
            });
        }
    }
}
