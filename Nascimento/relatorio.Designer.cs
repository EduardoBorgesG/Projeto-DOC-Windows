namespace DOC_Projeto.Nascimento
{
    partial class relatorio
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
            this.label2 = new System.Windows.Forms.Label();
            this.MtxtDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.MtxtDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGerar = new System.Windows.Forms.Button();
            this.BtnXML = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Período:";
            // 
            // MtxtDataInicial
            // 
            this.MtxtDataInicial.Location = new System.Drawing.Point(82, 12);
            this.MtxtDataInicial.Mask = "00/00/0000";
            this.MtxtDataInicial.Name = "MtxtDataInicial";
            this.MtxtDataInicial.Size = new System.Drawing.Size(68, 20);
            this.MtxtDataInicial.TabIndex = 2;
            this.MtxtDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // MtxtDataFinal
            // 
            this.MtxtDataFinal.Location = new System.Drawing.Point(187, 12);
            this.MtxtDataFinal.Mask = "00/00/0000";
            this.MtxtDataFinal.Name = "MtxtDataFinal";
            this.MtxtDataFinal.Size = new System.Drawing.Size(67, 20);
            this.MtxtDataFinal.TabIndex = 3;
            this.MtxtDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "até";
            // 
            // BtnGerar
            // 
            this.BtnGerar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerar.Location = new System.Drawing.Point(12, 59);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(84, 30);
            this.BtnGerar.TabIndex = 5;
            this.BtnGerar.Text = "GERAR";
            this.BtnGerar.UseVisualStyleBackColor = true;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // BtnXML
            // 
            this.BtnXML.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.BtnXML.Location = new System.Drawing.Point(102, 60);
            this.BtnXML.Name = "BtnXML";
            this.BtnXML.Size = new System.Drawing.Size(84, 30);
            this.BtnXML.TabIndex = 6;
            this.BtnXML.Text = "XML";
            this.BtnXML.UseVisualStyleBackColor = true;
            this.BtnXML.Click += new System.EventHandler(this.BtnXML_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.BtnCancelar.Location = new System.Drawing.Point(192, 63);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(76, 27);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "FECHAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 119);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnXML);
            this.Controls.Add(this.BtnGerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MtxtDataFinal);
            this.Controls.Add(this.MtxtDataInicial);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "relatorio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MtxtDataInicial;
        private System.Windows.Forms.MaskedTextBox MtxtDataFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.Button BtnXML;
        private System.Windows.Forms.Button BtnCancelar;
    }
}