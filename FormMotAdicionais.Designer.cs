namespace Teste_LG
{
    partial class FormMotAdicionais
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
            System.Windows.Forms.Panel panelCadColaborador;
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.comboDepartamento = new System.Windows.Forms.ComboBox();
            this.labelIDColab = new System.Windows.Forms.Label();
            this.textColabID = new System.Windows.Forms.TextBox();
            this.labelDepartamento = new System.Windows.Forms.Label();
            this.labelNomeColab = new System.Windows.Forms.Label();
            this.textNomeColab = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridMotAdicionais = new System.Windows.Forms.DataGridView();
            this.ColumnIdMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrauParentesco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTelefone = new System.Windows.Forms.MaskedTextBox();
            this.labelObs = new System.Windows.Forms.Label();
            this.labelRegistros = new System.Windows.Forms.Label();
            this.textNomeMotAdc = new System.Windows.Forms.TextBox();
            this.labelNomeMotAdc = new System.Windows.Forms.Label();
            this.labelTelMotAdc = new System.Windows.Forms.Label();
            this.comboRelacMotAdc = new System.Windows.Forms.ComboBox();
            this.labelRelacMotAdc = new System.Windows.Forms.Label();
            this.labelIDMotAdc = new System.Windows.Forms.Label();
            this.textIDMotAdc = new System.Windows.Forms.TextBox();
            panelCadColaborador = new System.Windows.Forms.Panel();
            panelCadColaborador.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMotAdicionais)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCadColaborador
            // 
            panelCadColaborador.AutoSize = true;
            panelCadColaborador.BackColor = System.Drawing.SystemColors.ButtonFace;
            panelCadColaborador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panelCadColaborador.Controls.Add(this.textPesquisa);
            panelCadColaborador.Controls.Add(this.buttonPesquisar);
            panelCadColaborador.Controls.Add(this.buttonExcluir);
            panelCadColaborador.Controls.Add(this.buttonNovo);
            panelCadColaborador.Controls.Add(this.buttonSalvar);
            panelCadColaborador.Controls.Add(this.comboDepartamento);
            panelCadColaborador.Controls.Add(this.labelIDColab);
            panelCadColaborador.Controls.Add(this.textColabID);
            panelCadColaborador.Controls.Add(this.labelDepartamento);
            panelCadColaborador.Controls.Add(this.labelNomeColab);
            panelCadColaborador.Controls.Add(this.textNomeColab);
            panelCadColaborador.Controls.Add(this.panel1);
            panelCadColaborador.Dock = System.Windows.Forms.DockStyle.Top;
            panelCadColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panelCadColaborador.Location = new System.Drawing.Point(0, 0);
            panelCadColaborador.Name = "panelCadColaborador";
            panelCadColaborador.Size = new System.Drawing.Size(677, 649);
            panelCadColaborador.TabIndex = 3;
            // 
            // textPesquisa
            // 
            this.textPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPesquisa.Location = new System.Drawing.Point(466, 13);
            this.textPesquisa.Multiline = true;
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(87, 30);
            this.textPesquisa.TabIndex = 27;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(559, 13);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(89, 30);
            this.buttonPesquisar.TabIndex = 26;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(414, 599);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(123, 32);
            this.buttonExcluir.TabIndex = 22;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(285, 599);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(123, 32);
            this.buttonNovo.TabIndex = 21;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(163, 599);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(116, 34);
            this.buttonSalvar.TabIndex = 20;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // comboDepartamento
            // 
            this.comboDepartamento.Enabled = false;
            this.comboDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDepartamento.FormattingEnabled = true;
            this.comboDepartamento.Items.AddRange(new object[] {
            "Departamento Pessoal",
            "Logistica",
            "Compras",
            "Juridico"});
            this.comboDepartamento.Location = new System.Drawing.Point(129, 103);
            this.comboDepartamento.Name = "comboDepartamento";
            this.comboDepartamento.Size = new System.Drawing.Size(258, 28);
            this.comboDepartamento.TabIndex = 8;
            // 
            // labelIDColab
            // 
            this.labelIDColab.AutoSize = true;
            this.labelIDColab.Enabled = false;
            this.labelIDColab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDColab.Location = new System.Drawing.Point(48, 23);
            this.labelIDColab.Name = "labelIDColab";
            this.labelIDColab.Size = new System.Drawing.Size(75, 20);
            this.labelIDColab.TabIndex = 6;
            this.labelIDColab.Text = "ID Colab:";
            // 
            // textColabID
            // 
            this.textColabID.Enabled = false;
            this.textColabID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textColabID.Location = new System.Drawing.Point(129, 13);
            this.textColabID.Multiline = true;
            this.textColabID.Name = "textColabID";
            this.textColabID.Size = new System.Drawing.Size(87, 30);
            this.textColabID.TabIndex = 7;
            // 
            // labelDepartamento
            // 
            this.labelDepartamento.AutoSize = true;
            this.labelDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartamento.Location = new System.Drawing.Point(7, 106);
            this.labelDepartamento.Name = "labelDepartamento";
            this.labelDepartamento.Size = new System.Drawing.Size(116, 20);
            this.labelDepartamento.TabIndex = 4;
            this.labelDepartamento.Text = "Departamento:";
            // 
            // labelNomeColab
            // 
            this.labelNomeColab.AutoSize = true;
            this.labelNomeColab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeColab.Location = new System.Drawing.Point(68, 69);
            this.labelNomeColab.Name = "labelNomeColab";
            this.labelNomeColab.Size = new System.Drawing.Size(55, 20);
            this.labelNomeColab.TabIndex = 0;
            this.labelNomeColab.Text = "Nome:";
            // 
            // textNomeColab
            // 
            this.textNomeColab.Enabled = false;
            this.textNomeColab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeColab.Location = new System.Drawing.Point(129, 59);
            this.textNomeColab.Multiline = true;
            this.textNomeColab.Name = "textNomeColab";
            this.textNomeColab.Size = new System.Drawing.Size(520, 30);
            this.textNomeColab.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridMotAdicionais);
            this.panel1.Controls.Add(this.maskedTelefone);
            this.panel1.Controls.Add(this.labelObs);
            this.panel1.Controls.Add(this.labelRegistros);
            this.panel1.Controls.Add(this.textNomeMotAdc);
            this.panel1.Controls.Add(this.labelNomeMotAdc);
            this.panel1.Controls.Add(this.labelTelMotAdc);
            this.panel1.Controls.Add(this.comboRelacMotAdc);
            this.panel1.Controls.Add(this.labelRelacMotAdc);
            this.panel1.Controls.Add(this.labelIDMotAdc);
            this.panel1.Controls.Add(this.textIDMotAdc);
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 505);
            this.panel1.TabIndex = 25;
            // 
            // dataGridMotAdicionais
            // 
            this.dataGridMotAdicionais.AllowUserToAddRows = false;
            this.dataGridMotAdicionais.AllowUserToDeleteRows = false;
            this.dataGridMotAdicionais.AllowUserToResizeColumns = false;
            this.dataGridMotAdicionais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMotAdicionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMotAdicionais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdMotorista,
            this.ColumnNome,
            this.ColumnTelefone,
            this.ColumnGrauParentesco});
            this.dataGridMotAdicionais.Location = new System.Drawing.Point(19, 253);
            this.dataGridMotAdicionais.Name = "dataGridMotAdicionais";
            this.dataGridMotAdicionais.ReadOnly = true;
            this.dataGridMotAdicionais.Size = new System.Drawing.Size(642, 191);
            this.dataGridMotAdicionais.TabIndex = 28;
            this.dataGridMotAdicionais.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMotAdicionais_CellClick);
            // 
            // ColumnIdMotorista
            // 
            this.ColumnIdMotorista.HeaderText = "ID Motorista";
            this.ColumnIdMotorista.Name = "ColumnIdMotorista";
            this.ColumnIdMotorista.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "ColumnNome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Telefone";
            this.ColumnTelefone.Name = "ColumnTelefone";
            this.ColumnTelefone.ReadOnly = true;
            // 
            // ColumnGrauParentesco
            // 
            this.ColumnGrauParentesco.HeaderText = "Grau Parentesco";
            this.ColumnGrauParentesco.Name = "ColumnGrauParentesco";
            this.ColumnGrauParentesco.ReadOnly = true;
            // 
            // maskedTelefone
            // 
            this.maskedTelefone.Location = new System.Drawing.Point(127, 130);
            this.maskedTelefone.Mask = "(00) 00000-9999";
            this.maskedTelefone.Name = "maskedTelefone";
            this.maskedTelefone.Size = new System.Drawing.Size(150, 26);
            this.maskedTelefone.TabIndex = 26;
            // 
            // labelObs
            // 
            this.labelObs.AutoSize = true;
            this.labelObs.Enabled = false;
            this.labelObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObs.Location = new System.Drawing.Point(176, 12);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(314, 15);
            this.labelObs.TabIndex = 25;
            this.labelObs.Text = "Cadastro de Motorista Adicionais para acesso ao veículo";
            // 
            // labelRegistros
            // 
            this.labelRegistros.AutoSize = true;
            this.labelRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistros.Location = new System.Drawing.Point(250, 221);
            this.labelRegistros.Name = "labelRegistros";
            this.labelRegistros.Size = new System.Drawing.Size(170, 20);
            this.labelRegistros.TabIndex = 24;
            this.labelRegistros.Text = "Motorista Cadastrados";
            // 
            // textNomeMotAdc
            // 
            this.textNomeMotAdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeMotAdc.Location = new System.Drawing.Point(126, 76);
            this.textNomeMotAdc.Multiline = true;
            this.textNomeMotAdc.Name = "textNomeMotAdc";
            this.textNomeMotAdc.Size = new System.Drawing.Size(520, 30);
            this.textNomeMotAdc.TabIndex = 13;
            // 
            // labelNomeMotAdc
            // 
            this.labelNomeMotAdc.AutoSize = true;
            this.labelNomeMotAdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeMotAdc.Location = new System.Drawing.Point(0, 86);
            this.labelNomeMotAdc.Name = "labelNomeMotAdc";
            this.labelNomeMotAdc.Size = new System.Drawing.Size(125, 20);
            this.labelNomeMotAdc.TabIndex = 12;
            this.labelNomeMotAdc.Text = "Nome Motorista:";
            // 
            // labelTelMotAdc
            // 
            this.labelTelMotAdc.AutoSize = true;
            this.labelTelMotAdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelMotAdc.Location = new System.Drawing.Point(45, 136);
            this.labelTelMotAdc.Name = "labelTelMotAdc";
            this.labelTelMotAdc.Size = new System.Drawing.Size(75, 20);
            this.labelTelMotAdc.TabIndex = 14;
            this.labelTelMotAdc.Text = "Telefone:";
            // 
            // comboRelacMotAdc
            // 
            this.comboRelacMotAdc.AutoCompleteCustomSource.AddRange(new string[] {
            "MAE",
            "PAI",
            "FILHOS",
            "AMIGOS",
            "OUTROS"});
            this.comboRelacMotAdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRelacMotAdc.FormattingEnabled = true;
            this.comboRelacMotAdc.Items.AddRange(new object[] {
            "Mãe",
            "Irmão",
            "Filho",
            "Outros"});
            this.comboRelacMotAdc.Location = new System.Drawing.Point(126, 177);
            this.comboRelacMotAdc.Name = "comboRelacMotAdc";
            this.comboRelacMotAdc.Size = new System.Drawing.Size(258, 28);
            this.comboRelacMotAdc.TabIndex = 19;
            // 
            // labelRelacMotAdc
            // 
            this.labelRelacMotAdc.AutoSize = true;
            this.labelRelacMotAdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRelacMotAdc.Location = new System.Drawing.Point(4, 180);
            this.labelRelacMotAdc.Name = "labelRelacMotAdc";
            this.labelRelacMotAdc.Size = new System.Drawing.Size(116, 20);
            this.labelRelacMotAdc.TabIndex = 16;
            this.labelRelacMotAdc.Text = "Grau Pantesco";
            // 
            // labelIDMotAdc
            // 
            this.labelIDMotAdc.AutoSize = true;
            this.labelIDMotAdc.Enabled = false;
            this.labelIDMotAdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDMotAdc.Location = new System.Drawing.Point(90, 40);
            this.labelIDMotAdc.Name = "labelIDMotAdc";
            this.labelIDMotAdc.Size = new System.Drawing.Size(30, 20);
            this.labelIDMotAdc.TabIndex = 17;
            this.labelIDMotAdc.Text = "ID:";
            // 
            // textIDMotAdc
            // 
            this.textIDMotAdc.Enabled = false;
            this.textIDMotAdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIDMotAdc.Location = new System.Drawing.Point(126, 30);
            this.textIDMotAdc.Multiline = true;
            this.textIDMotAdc.Name = "textIDMotAdc";
            this.textIDMotAdc.Size = new System.Drawing.Size(87, 30);
            this.textIDMotAdc.TabIndex = 18;
            // 
            // FormMotAdicionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 652);
            this.Controls.Add(panelCadColaborador);
            this.Name = "FormMotAdicionais";
            this.Text = "FormMotAdicionais";
            panelCadColaborador.ResumeLayout(false);
            panelCadColaborador.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMotAdicionais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboDepartamento;
        private System.Windows.Forms.Label labelIDColab;
        private System.Windows.Forms.TextBox textColabID;
        private System.Windows.Forms.Label labelDepartamento;
        private System.Windows.Forms.Label labelNomeColab;
        private System.Windows.Forms.TextBox textNomeColab;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.ComboBox comboRelacMotAdc;
        private System.Windows.Forms.Label labelIDMotAdc;
        private System.Windows.Forms.TextBox textIDMotAdc;
        private System.Windows.Forms.Label labelRelacMotAdc;
        private System.Windows.Forms.Label labelTelMotAdc;
        private System.Windows.Forms.Label labelNomeMotAdc;
        private System.Windows.Forms.TextBox textNomeMotAdc;
        private System.Windows.Forms.Label labelRegistros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelObs;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.MaskedTextBox maskedTelefone;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.DataGridView dataGridMotAdicionais;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrauParentesco;
    }
}