namespace Teste_LG
{
    partial class FormCarro
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
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.labelIDColab = new System.Windows.Forms.Label();
            this.textColabID = new System.Windows.Forms.TextBox();
            this.labelNomeColab = new System.Windows.Forms.Label();
            this.textNomeColab = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridMotAdicionais = new System.Windows.Forms.DataGridView();
            this.labelMotAdicionais = new System.Windows.Forms.Label();
            this.labelPlacaCarro = new System.Windows.Forms.Label();
            this.LabelNomeVeiculo = new System.Windows.Forms.Label();
            this.textModeloCarro = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelVeiculo = new System.Windows.Forms.Label();
            this.maskedPlaca = new System.Windows.Forms.MaskedTextBox();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ColumnIdMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrauParentesco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelIDCarro = new System.Windows.Forms.Label();
            this.textCarroID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMotAdicionais)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPesquisa
            // 
            this.textPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPesquisa.Location = new System.Drawing.Point(501, 13);
            this.textPesquisa.Multiline = true;
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(87, 30);
            this.textPesquisa.TabIndex = 39;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisar.Location = new System.Drawing.Point(594, 13);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(89, 30);
            this.buttonPesquisar.TabIndex = 38;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // labelIDColab
            // 
            this.labelIDColab.AutoSize = true;
            this.labelIDColab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDColab.Location = new System.Drawing.Point(83, 23);
            this.labelIDColab.Name = "labelIDColab";
            this.labelIDColab.Size = new System.Drawing.Size(75, 20);
            this.labelIDColab.TabIndex = 31;
            this.labelIDColab.Text = "ID Colab:";
            // 
            // textColabID
            // 
            this.textColabID.Enabled = false;
            this.textColabID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textColabID.Location = new System.Drawing.Point(164, 13);
            this.textColabID.Multiline = true;
            this.textColabID.Name = "textColabID";
            this.textColabID.Size = new System.Drawing.Size(87, 30);
            this.textColabID.TabIndex = 32;
            // 
            // labelNomeColab
            // 
            this.labelNomeColab.AutoSize = true;
            this.labelNomeColab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeColab.Location = new System.Drawing.Point(103, 69);
            this.labelNomeColab.Name = "labelNomeColab";
            this.labelNomeColab.Size = new System.Drawing.Size(55, 20);
            this.labelNomeColab.TabIndex = 28;
            this.labelNomeColab.Text = "Nome:";
            // 
            // textNomeColab
            // 
            this.textNomeColab.Enabled = false;
            this.textNomeColab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeColab.Location = new System.Drawing.Point(164, 59);
            this.textNomeColab.Multiline = true;
            this.textNomeColab.Name = "textNomeColab";
            this.textNomeColab.Size = new System.Drawing.Size(520, 30);
            this.textNomeColab.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridMotAdicionais);
            this.panel1.Controls.Add(this.labelMotAdicionais);
            this.panel1.Location = new System.Drawing.Point(34, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 247);
            this.panel1.TabIndex = 37;
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
            this.dataGridMotAdicionais.Location = new System.Drawing.Point(18, 30);
            this.dataGridMotAdicionais.Name = "dataGridMotAdicionais";
            this.dataGridMotAdicionais.ReadOnly = true;
            this.dataGridMotAdicionais.Size = new System.Drawing.Size(645, 191);
            this.dataGridMotAdicionais.TabIndex = 28;
            // 
            // labelMotAdicionais
            // 
            this.labelMotAdicionais.AutoSize = true;
            this.labelMotAdicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotAdicionais.Location = new System.Drawing.Point(243, 5);
            this.labelMotAdicionais.Name = "labelMotAdicionais";
            this.labelMotAdicionais.Size = new System.Drawing.Size(151, 20);
            this.labelMotAdicionais.TabIndex = 24;
            this.labelMotAdicionais.Text = "Motorista Adicionais";
            // 
            // labelPlacaCarro
            // 
            this.labelPlacaCarro.AutoSize = true;
            this.labelPlacaCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlacaCarro.Location = new System.Drawing.Point(28, 83);
            this.labelPlacaCarro.Name = "labelPlacaCarro";
            this.labelPlacaCarro.Size = new System.Drawing.Size(95, 20);
            this.labelPlacaCarro.TabIndex = 42;
            this.labelPlacaCarro.Text = "Placa Carro:";
            // 
            // LabelNomeVeiculo
            // 
            this.LabelNomeVeiculo.AutoSize = true;
            this.LabelNomeVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomeVeiculo.Location = new System.Drawing.Point(6, 124);
            this.LabelNomeVeiculo.Name = "LabelNomeVeiculo";
            this.LabelNomeVeiculo.Size = new System.Drawing.Size(121, 20);
            this.LabelNomeVeiculo.TabIndex = 40;
            this.LabelNomeVeiculo.Text = "Modelo Veiculo:";
            // 
            // textModeloCarro
            // 
            this.textModeloCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textModeloCarro.Location = new System.Drawing.Point(129, 114);
            this.textModeloCarro.Multiline = true;
            this.textModeloCarro.Name = "textModeloCarro";
            this.textModeloCarro.Size = new System.Drawing.Size(323, 30);
            this.textModeloCarro.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelIDCarro);
            this.panel2.Controls.Add(this.textCarroID);
            this.panel2.Controls.Add(this.maskedPlaca);
            this.panel2.Controls.Add(this.labelVeiculo);
            this.panel2.Controls.Add(this.labelPlacaCarro);
            this.panel2.Controls.Add(this.LabelNomeVeiculo);
            this.panel2.Controls.Add(this.textModeloCarro);
            this.panel2.Location = new System.Drawing.Point(35, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 156);
            this.panel2.TabIndex = 44;
            // 
            // labelVeiculo
            // 
            this.labelVeiculo.AutoSize = true;
            this.labelVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeiculo.Location = new System.Drawing.Point(243, 7);
            this.labelVeiculo.Name = "labelVeiculo";
            this.labelVeiculo.Size = new System.Drawing.Size(152, 20);
            this.labelVeiculo.TabIndex = 29;
            this.labelVeiculo.Text = "Cadastro de Veículo";
            // 
            // maskedPlaca
            // 
            this.maskedPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedPlaca.Location = new System.Drawing.Point(129, 77);
            this.maskedPlaca.Mask = "AAA-0000";
            this.maskedPlaca.Name = "maskedPlaca";
            this.maskedPlaca.Size = new System.Drawing.Size(87, 26);
            this.maskedPlaca.TabIndex = 43;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovo.Location = new System.Drawing.Point(41, 567);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(129, 33);
            this.buttonNovo.TabIndex = 45;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(549, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 33);
            this.button2.TabIndex = 46;
            this.button2.Text = "Adicionar Motorista";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(176, 567);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(129, 33);
            this.buttonSalvar.TabIndex = 47;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(311, 567);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 33);
            this.button4.TabIndex = 48;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ColumnIdMotorista
            // 
            this.ColumnIdMotorista.HeaderText = "ID Motorista";
            this.ColumnIdMotorista.Name = "ColumnIdMotorista";
            this.ColumnIdMotorista.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
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
            // labelIDCarro
            // 
            this.labelIDCarro.AutoSize = true;
            this.labelIDCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDCarro.Location = new System.Drawing.Point(48, 46);
            this.labelIDCarro.Name = "labelIDCarro";
            this.labelIDCarro.Size = new System.Drawing.Size(73, 20);
            this.labelIDCarro.TabIndex = 44;
            this.labelIDCarro.Text = "ID Carro:";
            // 
            // textCarroID
            // 
            this.textCarroID.Enabled = false;
            this.textCarroID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCarroID.Location = new System.Drawing.Point(129, 36);
            this.textCarroID.Multiline = true;
            this.textCarroID.Name = "textCarroID";
            this.textCarroID.Size = new System.Drawing.Size(87, 30);
            this.textCarroID.TabIndex = 45;
            // 
            // FormCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 622);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textPesquisa);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.labelIDColab);
            this.Controls.Add(this.textColabID);
            this.Controls.Add(this.labelNomeColab);
            this.Controls.Add(this.textNomeColab);
            this.Controls.Add(this.panel1);
            this.Name = "FormCarro";
            this.Text = "FormCarro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMotAdicionais)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Label labelIDColab;
        private System.Windows.Forms.TextBox textColabID;
        private System.Windows.Forms.Label labelNomeColab;
        private System.Windows.Forms.TextBox textNomeColab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridMotAdicionais;
        private System.Windows.Forms.Label labelMotAdicionais;
        private System.Windows.Forms.Label labelPlacaCarro;
        private System.Windows.Forms.Label LabelNomeVeiculo;
        private System.Windows.Forms.TextBox textModeloCarro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelVeiculo;
        private System.Windows.Forms.MaskedTextBox maskedPlaca;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrauParentesco;
        private System.Windows.Forms.Label labelIDCarro;
        private System.Windows.Forms.TextBox textCarroID;
    }
}