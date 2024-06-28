namespace Teste_LG
{
    partial class FormMenu
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
            this.labelCadColaborador = new System.Windows.Forms.Label();
            this.labelCadMotAdicionais = new System.Windows.Forms.Label();
            this.labelGerenciamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCadColaborador
            // 
            this.labelCadColaborador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCadColaborador.Location = new System.Drawing.Point(21, 41);
            this.labelCadColaborador.Name = "labelCadColaborador";
            this.labelCadColaborador.Size = new System.Drawing.Size(168, 91);
            this.labelCadColaborador.TabIndex = 0;
            // 
            // labelCadMotAdicionais
            // 
            this.labelCadMotAdicionais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCadMotAdicionais.Location = new System.Drawing.Point(243, 41);
            this.labelCadMotAdicionais.Name = "labelCadMotAdicionais";
            this.labelCadMotAdicionais.Size = new System.Drawing.Size(168, 91);
            this.labelCadMotAdicionais.TabIndex = 1;
            // 
            // labelGerenciamento
            // 
            this.labelGerenciamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGerenciamento.Location = new System.Drawing.Point(458, 44);
            this.labelGerenciamento.Name = "labelGerenciamento";
            this.labelGerenciamento.Size = new System.Drawing.Size(168, 88);
            this.labelGerenciamento.TabIndex = 3;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 356);
            this.Controls.Add(this.labelGerenciamento);
            this.Controls.Add(this.labelCadMotAdicionais);
            this.Controls.Add(this.labelCadColaborador);
            this.Name = "FormMenu";
            this.Text = "Menu Geral";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCadColaborador;
        private System.Windows.Forms.Label labelCadMotAdicionais;
        private System.Windows.Forms.Label labelGerenciamento;
    }
}