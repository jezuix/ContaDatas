namespace ContaDatas
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpDataInicial = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtQtdDias = new TextBox();
            txtQtdParcelas = new TextBox();
            chkDiasUteis = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnCalcular = new Button();
            btnLimpar = new Button();
            dgvContagemDatas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvContagemDatas).BeginInit();
            SuspendLayout();
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDataInicial.CustomFormat = "";
            dtpDataInicial.Format = DateTimePickerFormat.Short;
            dtpDataInicial.Location = new Point(343, 15);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(150, 31);
            dtpDataInicial.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 1;
            label1.Text = "Data Inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 2;
            label2.Text = "Quantidades de dias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(237, 25);
            label3.TabIndex = 3;
            label3.Text = "Considerar apenas dias úteis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 126);
            label4.Name = "label4";
            label4.Size = new Size(199, 25);
            label4.TabIndex = 4;
            label4.Text = "Quantidade de parcelas";
            // 
            // txtQtdDias
            // 
            txtQtdDias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtQtdDias.Location = new Point(343, 51);
            txtQtdDias.MaxLength = 3;
            txtQtdDias.Name = "txtQtdDias";
            txtQtdDias.Size = new Size(150, 31);
            txtQtdDias.TabIndex = 1;
            txtQtdDias.KeyPress += txtQtdDias_KeyPress;
            // 
            // txtQtdParcelas
            // 
            txtQtdParcelas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtQtdParcelas.Location = new Point(343, 123);
            txtQtdParcelas.MaxLength = 2;
            txtQtdParcelas.Name = "txtQtdParcelas";
            txtQtdParcelas.Size = new Size(150, 31);
            txtQtdParcelas.TabIndex = 3;
            txtQtdParcelas.KeyPress += txtQtdParcelas_KeyPress;
            // 
            // chkDiasUteis
            // 
            chkDiasUteis.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkDiasUteis.AutoSize = true;
            chkDiasUteis.Location = new Point(343, 92);
            chkDiasUteis.Name = "chkDiasUteis";
            chkDiasUteis.Size = new Size(22, 21);
            chkDiasUteis.TabIndex = 2;
            chkDiasUteis.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Enabled = false;
            label5.Location = new Point(111, 30);
            label5.Name = "label5";
            label5.Size = new Size(221, 1);
            label5.TabIndex = 8;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Enabled = false;
            label6.Location = new Point(188, 66);
            label6.Name = "label6";
            label6.Size = new Size(144, 1);
            label6.TabIndex = 9;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Enabled = false;
            label7.Location = new Point(250, 102);
            label7.Name = "label7";
            label7.Size = new Size(82, 1);
            label7.TabIndex = 10;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Enabled = false;
            label8.Location = new Point(212, 138);
            label8.Name = "label8";
            label8.Size = new Size(120, 1);
            label8.TabIndex = 11;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 161);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(481, 34);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(12, 411);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(481, 34);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar Tela";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // dgvContagemDatas
            // 
            dgvContagemDatas.AllowDrop = true;
            dgvContagemDatas.AllowUserToResizeColumns = false;
            dgvContagemDatas.AllowUserToResizeRows = false;
            dgvContagemDatas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContagemDatas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvContagemDatas.Location = new Point(12, 201);
            dgvContagemDatas.MultiSelect = false;
            dgvContagemDatas.Name = "dgvContagemDatas";
            dgvContagemDatas.ReadOnly = true;
            dgvContagemDatas.RowHeadersWidth = 62;
            dgvContagemDatas.Size = new Size(481, 204);
            dgvContagemDatas.TabIndex = 14;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 454);
            Controls.Add(dgvContagemDatas);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(dtpDataInicial);
            Controls.Add(txtQtdDias);
            Controls.Add(chkDiasUteis);
            Controls.Add(txtQtdParcelas);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Main";
            Text = "Contagem de Datas";
            ((System.ComponentModel.ISupportInitialize)dgvContagemDatas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDataInicial;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtQtdDias;
        private TextBox txtQtdParcelas;
        private CheckBox chkDiasUteis;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnCalcular;
        private Button btnLimpar;
        private DataGridView dgvContagemDatas;
    }
}
