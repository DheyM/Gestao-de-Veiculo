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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.labelCarro = new System.Windows.Forms.Label();
            this.labelColaborador = new System.Windows.Forms.Label();
            this.pictureColaborador = new System.Windows.Forms.PictureBox();
            this.pictureCarro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColaborador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCarro
            // 
            this.labelCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarro.Location = new System.Drawing.Point(365, 76);
            this.labelCarro.Name = "labelCarro";
            this.labelCarro.Size = new System.Drawing.Size(135, 43);
            this.labelCarro.TabIndex = 1;
            this.labelCarro.Text = "Gerenciamento de Veiculo";
            this.labelCarro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColaborador
            // 
            this.labelColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColaborador.Location = new System.Drawing.Point(90, 76);
            this.labelColaborador.Name = "labelColaborador";
            this.labelColaborador.Size = new System.Drawing.Size(123, 43);
            this.labelColaborador.TabIndex = 3;
            this.labelColaborador.Text = "Cadastro de Colaborador";
            this.labelColaborador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureColaborador
            // 
            this.pictureColaborador.Image = ((System.Drawing.Image)(resources.GetObject("pictureColaborador.Image")));
            this.pictureColaborador.Location = new System.Drawing.Point(90, 122);
            this.pictureColaborador.Name = "pictureColaborador";
            this.pictureColaborador.Size = new System.Drawing.Size(123, 93);
            this.pictureColaborador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureColaborador.TabIndex = 4;
            this.pictureColaborador.TabStop = false;
            this.pictureColaborador.Click += new System.EventHandler(this.pictureColaborador_Click);
            // 
            // pictureCarro
            // 
            this.pictureCarro.Image = ((System.Drawing.Image)(resources.GetObject("pictureCarro.Image")));
            this.pictureCarro.Location = new System.Drawing.Point(369, 122);
            this.pictureCarro.Name = "pictureCarro";
            this.pictureCarro.Size = new System.Drawing.Size(123, 93);
            this.pictureCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCarro.TabIndex = 5;
            this.pictureCarro.TabStop = false;
            this.pictureCarro.Click += new System.EventHandler(this.pictureCarro_Click);
            // 
            // FormMenu
            // 
            this.ClientSize = new System.Drawing.Size(563, 418);
            this.Controls.Add(this.pictureCarro);
            this.Controls.Add(this.pictureColaborador);
            this.Controls.Add(this.labelColaborador);
            this.Controls.Add(this.labelCarro);
            this.Name = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureColaborador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCarro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelCarro;
        private System.Windows.Forms.Label labelColaborador;
        private System.Windows.Forms.PictureBox pictureColaborador;
        private System.Windows.Forms.PictureBox pictureCarro;
    }
}