namespace DOC_Projeto.Nascimento
{
    partial class Nascimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPesquisarN = new System.Windows.Forms.Button();
            this.BtnIncluirN = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblNomeN = new System.Windows.Forms.Label();
            this.TxtNomeN = new System.Windows.Forms.TextBox();
            this.TxtNomePaiN = new System.Windows.Forms.TextBox();
            this.TxtNomeMaeN = new System.Windows.Forms.TextBox();
            this.LblNomeMaeN = new System.Windows.Forms.Label();
            this.LblNomePaiN = new System.Windows.Forms.Label();
            this.MtxtDataN = new System.Windows.Forms.MaskedTextBox();
            this.MtxtDataPaiN = new System.Windows.Forms.MaskedTextBox();
            this.MtxtDataMaeN = new System.Windows.Forms.MaskedTextBox();
            this.LblDataN = new System.Windows.Forms.Label();
            this.LblDataPaiN = new System.Windows.Forms.Label();
            this.LblDataMaeN = new System.Windows.Forms.Label();
            this.LblCPFMaeN = new System.Windows.Forms.Label();
            this.MtxtCPFMaeN = new System.Windows.Forms.MaskedTextBox();
            this.MtxtCPFPaiN = new System.Windows.Forms.MaskedTextBox();
            this.LblCPFPaiN = new System.Windows.Forms.Label();
            this.MtxtDataRegistroN = new System.Windows.Forms.MaskedTextBox();
            this.LblDataRegistroN = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxtCPFInvalido = new System.Windows.Forms.Label();
            this.BtnData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPesquisarN
            // 
            this.BtnPesquisarN.Font = new System.Drawing.Font("Arial", 12F);
            this.BtnPesquisarN.Location = new System.Drawing.Point(15, 508);
            this.BtnPesquisarN.Name = "BtnPesquisarN";
            this.BtnPesquisarN.Size = new System.Drawing.Size(130, 45);
            this.BtnPesquisarN.TabIndex = 0;
            this.BtnPesquisarN.Text = "PESQUISAR";
            this.BtnPesquisarN.UseVisualStyleBackColor = true;
            this.BtnPesquisarN.Click += new System.EventHandler(this.BtnPesquisarN_Click);
            // 
            // BtnIncluirN
            // 
            this.BtnIncluirN.Font = new System.Drawing.Font("Arial", 12F);
            this.BtnIncluirN.Location = new System.Drawing.Point(632, 508);
            this.BtnIncluirN.Name = "BtnIncluirN";
            this.BtnIncluirN.Size = new System.Drawing.Size(130, 45);
            this.BtnIncluirN.TabIndex = 1;
            this.BtnIncluirN.Text = "INCLUIR";
            this.BtnIncluirN.UseVisualStyleBackColor = true;
            this.BtnIncluirN.Click += new System.EventHandler(this.BtnIncluirN_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Arial", 12F);
            this.BtnCancelar.Location = new System.Drawing.Point(787, 508);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(130, 45);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registro de Nascimento";
            // 
            // LblNomeN
            // 
            this.LblNomeN.AutoSize = true;
            this.LblNomeN.Font = new System.Drawing.Font("Arial", 12F);
            this.LblNomeN.Location = new System.Drawing.Point(3, 116);
            this.LblNomeN.Name = "LblNomeN";
            this.LblNomeN.Size = new System.Drawing.Size(58, 18);
            this.LblNomeN.TabIndex = 5;
            this.LblNomeN.Text = "Nome: ";
            // 
            // TxtNomeN
            // 
            this.TxtNomeN.Location = new System.Drawing.Point(120, 114);
            this.TxtNomeN.Name = "TxtNomeN";
            this.TxtNomeN.Size = new System.Drawing.Size(412, 20);
            this.TxtNomeN.TabIndex = 6;
            // 
            // TxtNomePaiN
            // 
            this.TxtNomePaiN.Location = new System.Drawing.Point(120, 202);
            this.TxtNomePaiN.Name = "TxtNomePaiN";
            this.TxtNomePaiN.Size = new System.Drawing.Size(412, 20);
            this.TxtNomePaiN.TabIndex = 7;
            // 
            // TxtNomeMaeN
            // 
            this.TxtNomeMaeN.Location = new System.Drawing.Point(120, 158);
            this.TxtNomeMaeN.Name = "TxtNomeMaeN";
            this.TxtNomeMaeN.Size = new System.Drawing.Size(412, 20);
            this.TxtNomeMaeN.TabIndex = 8;
            // 
            // LblNomeMaeN
            // 
            this.LblNomeMaeN.AutoSize = true;
            this.LblNomeMaeN.Font = new System.Drawing.Font("Arial", 12F);
            this.LblNomeMaeN.Location = new System.Drawing.Point(3, 159);
            this.LblNomeMaeN.Name = "LblNomeMaeN";
            this.LblNomeMaeN.Size = new System.Drawing.Size(111, 18);
            this.LblNomeMaeN.TabIndex = 9;
            this.LblNomeMaeN.Text = "Nome da Mãe:";
            // 
            // LblNomePaiN
            // 
            this.LblNomePaiN.AutoSize = true;
            this.LblNomePaiN.Font = new System.Drawing.Font("Arial", 12F);
            this.LblNomePaiN.Location = new System.Drawing.Point(3, 202);
            this.LblNomePaiN.Name = "LblNomePaiN";
            this.LblNomePaiN.Size = new System.Drawing.Size(104, 18);
            this.LblNomePaiN.TabIndex = 10;
            this.LblNomePaiN.Text = "Nome do Pai:";
            // 
            // MtxtDataN
            // 
            this.MtxtDataN.Location = new System.Drawing.Point(699, 114);
            this.MtxtDataN.Mask = "00/00/0000";
            this.MtxtDataN.Name = "MtxtDataN";
            this.MtxtDataN.Size = new System.Drawing.Size(71, 20);
            this.MtxtDataN.TabIndex = 11;
            // 
            // MtxtDataPaiN
            // 
            this.MtxtDataPaiN.Location = new System.Drawing.Point(699, 202);
            this.MtxtDataPaiN.Mask = "00/00/0000";
            this.MtxtDataPaiN.Name = "MtxtDataPaiN";
            this.MtxtDataPaiN.Size = new System.Drawing.Size(71, 20);
            this.MtxtDataPaiN.TabIndex = 12;
            this.MtxtDataPaiN.ValidatingType = typeof(System.DateTime);
            // 
            // MtxtDataMaeN
            // 
            this.MtxtDataMaeN.Location = new System.Drawing.Point(699, 159);
            this.MtxtDataMaeN.Mask = "00/00/0000";
            this.MtxtDataMaeN.Name = "MtxtDataMaeN";
            this.MtxtDataMaeN.Size = new System.Drawing.Size(71, 20);
            this.MtxtDataMaeN.TabIndex = 13;
            this.MtxtDataMaeN.ValidatingType = typeof(System.DateTime);
            // 
            // LblDataN
            // 
            this.LblDataN.AutoSize = true;
            this.LblDataN.Font = new System.Drawing.Font("Arial", 12F);
            this.LblDataN.Location = new System.Drawing.Point(538, 116);
            this.LblDataN.Name = "LblDataN";
            this.LblDataN.Size = new System.Drawing.Size(155, 18);
            this.LblDataN.TabIndex = 14;
            this.LblDataN.Text = "Data de Nascimento:";
            // 
            // LblDataPaiN
            // 
            this.LblDataPaiN.AutoSize = true;
            this.LblDataPaiN.Font = new System.Drawing.Font("Arial", 12F);
            this.LblDataPaiN.Location = new System.Drawing.Point(538, 204);
            this.LblDataPaiN.Name = "LblDataPaiN";
            this.LblDataPaiN.Size = new System.Drawing.Size(155, 18);
            this.LblDataPaiN.TabIndex = 15;
            this.LblDataPaiN.Text = "Data de Nascimento:";
            // 
            // LblDataMaeN
            // 
            this.LblDataMaeN.AutoSize = true;
            this.LblDataMaeN.Font = new System.Drawing.Font("Arial", 12F);
            this.LblDataMaeN.Location = new System.Drawing.Point(538, 159);
            this.LblDataMaeN.Name = "LblDataMaeN";
            this.LblDataMaeN.Size = new System.Drawing.Size(155, 18);
            this.LblDataMaeN.TabIndex = 16;
            this.LblDataMaeN.Text = "Data de Nascimento:";
            // 
            // LblCPFMaeN
            // 
            this.LblCPFMaeN.AutoSize = true;
            this.LblCPFMaeN.Font = new System.Drawing.Font("Arial", 12F);
            this.LblCPFMaeN.Location = new System.Drawing.Point(778, 160);
            this.LblCPFMaeN.Name = "LblCPFMaeN";
            this.LblCPFMaeN.Size = new System.Drawing.Size(45, 18);
            this.LblCPFMaeN.TabIndex = 17;
            this.LblCPFMaeN.Text = "CPF:";
            // 
            // MtxtCPFMaeN
            // 
            this.MtxtCPFMaeN.Location = new System.Drawing.Point(829, 159);
            this.MtxtCPFMaeN.Mask = "000.000.000-00";
            this.MtxtCPFMaeN.Name = "MtxtCPFMaeN";
            this.MtxtCPFMaeN.Size = new System.Drawing.Size(98, 20);
            this.MtxtCPFMaeN.TabIndex = 18;
            this.MtxtCPFMaeN.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MtxtCPFMaeN.Leave += new System.EventHandler(this.MtxtCPFMaeN_Leave);
            // 
            // MtxtCPFPaiN
            // 
            this.MtxtCPFPaiN.Location = new System.Drawing.Point(829, 204);
            this.MtxtCPFPaiN.Mask = "000.000.000-00";
            this.MtxtCPFPaiN.Name = "MtxtCPFPaiN";
            this.MtxtCPFPaiN.Size = new System.Drawing.Size(98, 20);
            this.MtxtCPFPaiN.TabIndex = 19;
            this.MtxtCPFPaiN.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MtxtCPFPaiN.Leave += new System.EventHandler(this.MtxtCPFPaiN_Leave);
            // 
            // LblCPFPaiN
            // 
            this.LblCPFPaiN.AutoSize = true;
            this.LblCPFPaiN.Font = new System.Drawing.Font("Arial", 12F);
            this.LblCPFPaiN.Location = new System.Drawing.Point(778, 206);
            this.LblCPFPaiN.Name = "LblCPFPaiN";
            this.LblCPFPaiN.Size = new System.Drawing.Size(45, 18);
            this.LblCPFPaiN.TabIndex = 20;
            this.LblCPFPaiN.Text = "CPF:";
            // 
            // MtxtDataRegistroN
            // 
            this.MtxtDataRegistroN.Location = new System.Drawing.Point(151, 67);
            this.MtxtDataRegistroN.Mask = "00/00/0000";
            this.MtxtDataRegistroN.Name = "MtxtDataRegistroN";
            this.MtxtDataRegistroN.Size = new System.Drawing.Size(71, 20);
            this.MtxtDataRegistroN.TabIndex = 21;
            this.MtxtDataRegistroN.ValidatingType = typeof(System.DateTime);
            // 
            // LblDataRegistroN
            // 
            this.LblDataRegistroN.AutoSize = true;
            this.LblDataRegistroN.Font = new System.Drawing.Font("Arial", 12F);
            this.LblDataRegistroN.Location = new System.Drawing.Point(12, 69);
            this.LblDataRegistroN.Name = "LblDataRegistroN";
            this.LblDataRegistroN.Size = new System.Drawing.Size(131, 18);
            this.LblDataRegistroN.TabIndex = 22;
            this.LblDataRegistroN.Text = "Data do Registro:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 242);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Arial", 12F);
            this.BtnSalvar.Location = new System.Drawing.Point(477, 508);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(130, 45);
            this.BtnSalvar.TabIndex = 24;
            this.BtnSalvar.Text = "SALVAR";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtCPFInvalido
            // 
            this.TxtCPFInvalido.AutoSize = true;
            this.TxtCPFInvalido.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCPFInvalido.ForeColor = System.Drawing.Color.Red;
            this.TxtCPFInvalido.Location = new System.Drawing.Point(718, 21);
            this.TxtCPFInvalido.Name = "TxtCPFInvalido";
            this.TxtCPFInvalido.Size = new System.Drawing.Size(200, 20);
            this.TxtCPFInvalido.TabIndex = 25;
            this.TxtCPFInvalido.Text = "CPF em vermelho está inválido!";
            // 
            // BtnData
            // 
            this.BtnData.Location = new System.Drawing.Point(228, 65);
            this.BtnData.Name = "BtnData";
            this.BtnData.Size = new System.Drawing.Size(81, 23);
            this.BtnData.TabIndex = 26;
            this.BtnData.Text = "Data de hoje";
            this.BtnData.UseVisualStyleBackColor = true;
            this.BtnData.Click += new System.EventHandler(this.BtnData_Click);
            // 
            // Nascimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 605);
            this.Controls.Add(this.BtnData);
            this.Controls.Add(this.TxtCPFInvalido);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblDataRegistroN);
            this.Controls.Add(this.MtxtDataRegistroN);
            this.Controls.Add(this.LblCPFPaiN);
            this.Controls.Add(this.MtxtCPFPaiN);
            this.Controls.Add(this.MtxtCPFMaeN);
            this.Controls.Add(this.LblCPFMaeN);
            this.Controls.Add(this.LblDataMaeN);
            this.Controls.Add(this.LblDataPaiN);
            this.Controls.Add(this.LblDataN);
            this.Controls.Add(this.MtxtDataMaeN);
            this.Controls.Add(this.MtxtDataPaiN);
            this.Controls.Add(this.MtxtDataN);
            this.Controls.Add(this.LblNomePaiN);
            this.Controls.Add(this.LblNomeMaeN);
            this.Controls.Add(this.TxtNomeMaeN);
            this.Controls.Add(this.TxtNomePaiN);
            this.Controls.Add(this.TxtNomeN);
            this.Controls.Add(this.LblNomeN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnIncluirN);
            this.Controls.Add(this.BtnPesquisarN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nascimento";
            this.Text = "Nascimento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPesquisarN;
        private System.Windows.Forms.Button BtnIncluirN;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNomeN;
        private System.Windows.Forms.TextBox TxtNomeN;
        private System.Windows.Forms.TextBox TxtNomePaiN;
        private System.Windows.Forms.TextBox TxtNomeMaeN;
        private System.Windows.Forms.Label LblNomeMaeN;
        private System.Windows.Forms.Label LblNomePaiN;
        private System.Windows.Forms.MaskedTextBox MtxtDataN;
        private System.Windows.Forms.MaskedTextBox MtxtDataPaiN;
        private System.Windows.Forms.MaskedTextBox MtxtDataMaeN;
        private System.Windows.Forms.Label LblDataN;
        private System.Windows.Forms.Label LblDataPaiN;
        private System.Windows.Forms.Label LblDataMaeN;
        private System.Windows.Forms.Label LblCPFMaeN;
        private System.Windows.Forms.MaskedTextBox MtxtCPFMaeN;
        private System.Windows.Forms.MaskedTextBox MtxtCPFPaiN;
        private System.Windows.Forms.Label LblCPFPaiN;
        private System.Windows.Forms.MaskedTextBox MtxtDataRegistroN;
        private System.Windows.Forms.Label LblDataRegistroN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label TxtCPFInvalido;
        private System.Windows.Forms.Button BtnData;
    }
}