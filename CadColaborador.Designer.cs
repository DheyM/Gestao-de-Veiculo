namespace Teste_LG
{
    partial class FormColaborador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormColaborador));
            this.labelNome = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.panelCadColaborador = new System.Windows.Forms.Panel();
            this.LabelVinculaMot = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.maskedTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.comboDepartamento = new System.Windows.Forms.ComboBox();
            this.labelColabID = new System.Windows.Forms.Label();
            this.textColabID = new System.Windows.Forms.TextBox();
            this.labelDepartamento = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCadColaborador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(78, 124);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(55, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // textNome
            // 
            this.textNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(139, 114);
            this.textNome.Multiline = true;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(520, 30);
            this.textNome.TabIndex = 1;
            // 
            // panelCadColaborador
            // 
            this.panelCadColaborador.AutoSize = true;
            this.panelCadColaborador.Controls.Add(this.pictureBox1);
            this.panelCadColaborador.Controls.Add(this.LabelVinculaMot);
            this.panelCadColaborador.Controls.Add(this.buttonLimpar);
            this.panelCadColaborador.Controls.Add(this.buttonPesquisar);
            this.panelCadColaborador.Controls.Add(this.maskedTelefone);
            this.panelCadColaborador.Controls.Add(this.textPesquisa);
            this.panelCadColaborador.Controls.Add(this.buttonExcluir);
            this.panelCadColaborador.Controls.Add(this.ButtonSalvar);
            this.panelCadColaborador.Controls.Add(this.comboDepartamento);
            this.panelCadColaborador.Controls.Add(this.labelColabID);
            this.panelCadColaborador.Controls.Add(this.textColabID);
            this.panelCadColaborador.Controls.Add(this.labelDepartamento);
            this.panelCadColaborador.Controls.Add(this.labelTelefone);
            this.panelCadColaborador.Controls.Add(this.labelNome);
            this.panelCadColaborador.Controls.Add(this.textNome);
            this.panelCadColaborador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCadColaborador.Location = new System.Drawing.Point(0, 0);
            this.panelCadColaborador.Name = "panelCadColaborador";
            this.panelCadColaborador.Size = new System.Drawing.Size(687, 398);
            this.panelCadColaborador.TabIndex = 2;
            // 
            // LabelVinculaMot
            // 
            this.LabelVinculaMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVinculaMot.Location = new System.Drawing.Point(31, 278);
            this.LabelVinculaMot.Name = "LabelVinculaMot";
            this.LabelVinculaMot.Size = new System.Drawing.Size(150, 41);
            this.LabelVinculaMot.TabIndex = 18;
            this.LabelVinculaMot.Text = "Vincula Motorista Adicional";
            this.LabelVinculaMot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(308, 354);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(116, 31);
            this.buttonLimpar.TabIndex = 16;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(231, 12);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(105, 30);
            this.buttonPesquisar.TabIndex = 15;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // maskedTelefone
            // 
            this.maskedTelefone.Location = new System.Drawing.Point(139, 168);
            this.maskedTelefone.Mask = "(00) 00000-9999";
            this.maskedTelefone.Name = "maskedTelefone";
            this.maskedTelefone.Size = new System.Drawing.Size(145, 26);
            this.maskedTelefone.TabIndex = 14;
            // 
            // textPesquisa
            // 
            this.textPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPesquisa.Location = new System.Drawing.Point(138, 12);
            this.textPesquisa.Multiline = true;
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(87, 30);
            this.textPesquisa.TabIndex = 13;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(552, 354);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(123, 32);
            this.buttonExcluir.TabIndex = 11;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.Location = new System.Drawing.Point(430, 354);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(116, 34);
            this.ButtonSalvar.TabIndex = 9;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.UseVisualStyleBackColor = true;
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // comboDepartamento
            // 
            this.comboDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDepartamento.FormattingEnabled = true;
            this.comboDepartamento.Items.AddRange(new object[] {
            "DEPARTAMENTO PESSOAL",
            "LOGISTICA",
            "COMPRAS",
            "JURIDICO",
            "VENDAS"});
            this.comboDepartamento.Location = new System.Drawing.Point(139, 215);
            this.comboDepartamento.Name = "comboDepartamento";
            this.comboDepartamento.Size = new System.Drawing.Size(258, 28);
            this.comboDepartamento.TabIndex = 8;
            // 
            // labelColabID
            // 
            this.labelColabID.AutoSize = true;
            this.labelColabID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColabID.Location = new System.Drawing.Point(103, 78);
            this.labelColabID.Name = "labelColabID";
            this.labelColabID.Size = new System.Drawing.Size(30, 20);
            this.labelColabID.TabIndex = 6;
            this.labelColabID.Text = "ID:";
            // 
            // textColabID
            // 
            this.textColabID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textColabID.Enabled = false;
            this.textColabID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textColabID.Location = new System.Drawing.Point(139, 68);
            this.textColabID.Multiline = true;
            this.textColabID.Name = "textColabID";
            this.textColabID.Size = new System.Drawing.Size(87, 30);
            this.textColabID.TabIndex = 7;
            // 
            // labelDepartamento
            // 
            this.labelDepartamento.AutoSize = true;
            this.labelDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartamento.Location = new System.Drawing.Point(17, 218);
            this.labelDepartamento.Name = "labelDepartamento";
            this.labelDepartamento.Size = new System.Drawing.Size(116, 20);
            this.labelDepartamento.TabIndex = 4;
            this.labelDepartamento.Text = "Departamento:";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.Location = new System.Drawing.Point(58, 174);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(75, 20);
            this.labelTelefone.TabIndex = 2;
            this.labelTelefone.Text = "Telefone:";
            // 
            // Label
            // 
            this.Label.Location = new System.Drawing.Point(41, 285);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(172, 21);
            this.Label.TabIndex = 18;
            this.Label.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FormColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 398);
            this.Controls.Add(this.panelCadColaborador);
            this.Name = "FormColaborador";
            this.Text = "Cadastro Colaborador";
            this.panelCadColaborador.ResumeLayout(false);
            this.panelCadColaborador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Panel panelCadColaborador;
        private System.Windows.Forms.ComboBox comboDepartamento;
        private System.Windows.Forms.Label labelColabID;
        private System.Windows.Forms.TextBox textColabID;
        private System.Windows.Forms.Label labelDepartamento;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Button ButtonSalvar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.MaskedTextBox maskedTelefone;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Label LabelVinculaMot;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

