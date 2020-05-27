namespace projeto_cadastro
{
    partial class frmHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.cbbSex = new System.Windows.Forms.ComboBox();
            this.cbbUF = new System.Windows.Forms.ComboBox();
            this.cbbFilme = new System.Windows.Forms.ComboBox();
            this.cbbMusica = new System.Windows.Forms.ComboBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "UF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de Filme Favorito:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Genero Musical Favorito:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(98, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(151, 26);
            this.txtNome.TabIndex = 6;
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(98, 96);
            this.txtIdade.MaxLength = 2;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(151, 26);
            this.txtIdade.TabIndex = 7;
            // 
            // cbbSex
            // 
            this.cbbSex.FormattingEnabled = true;
            this.cbbSex.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbbSex.Location = new System.Drawing.Point(63, 12);
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.Size = new System.Drawing.Size(39, 28);
            this.cbbSex.TabIndex = 8;
            // 
            // cbbUF
            // 
            this.cbbUF.FormattingEnabled = true;
            this.cbbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbbUF.Location = new System.Drawing.Point(181, 12);
            this.cbbUF.Name = "cbbUF";
            this.cbbUF.Size = new System.Drawing.Size(40, 28);
            this.cbbUF.TabIndex = 9;
            // 
            // cbbFilme
            // 
            this.cbbFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFilme.FormattingEnabled = true;
            this.cbbFilme.Items.AddRange(new object[] {
            "Ação",
            "",
            "Animação",
            "Aventura",
            "",
            "Cinema de arte",
            "",
            "Comédia",
            "Comédia romântica",
            "",
            "Comédia dramática",
            "",
            "Comédia de ação",
            "",
            "Documentário",
            "",
            "Drama",
            "",
            "Ficção científica",
            "",
            "Musical",
            "",
            "policial",
            "",
            "Romance",
            "Suspense",
            "",
            "Terror"});
            this.cbbFilme.Location = new System.Drawing.Point(43, 224);
            this.cbbFilme.Name = "cbbFilme";
            this.cbbFilme.Size = new System.Drawing.Size(205, 28);
            this.cbbFilme.TabIndex = 10;
            // 
            // cbbMusica
            // 
            this.cbbMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMusica.FormattingEnabled = true;
            this.cbbMusica.Items.AddRange(new object[] {
            "Axé",
            "Blues",
            "Country",
            "Eletrônica",
            "Forró",
            "Funk",
            "Gospel",
            "Hip-Hop",
            "Jazz",
            "MPB",
            "Música clássica",
            "Pagode",
            "Pop",
            "Rap",
            "Reggae",
            "Rock",
            "Metal",
            "Folk",
            "Samba",
            "Sertanejo"});
            this.cbbMusica.Location = new System.Drawing.Point(43, 297);
            this.cbbMusica.Name = "cbbMusica";
            this.cbbMusica.Size = new System.Drawing.Size(205, 28);
            this.cbbMusica.TabIndex = 11;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(83, 337);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(121, 35);
            this.btnCadastro.TabIndex = 12;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbbSex);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbbUF);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(23, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 47);
            this.panel1.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(98, 28);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(151, 26);
            this.txtID.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID:";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 382);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.cbbMusica);
            this.Controls.Add(this.cbbFilme);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHome";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.ComboBox cbbSex;
        private System.Windows.Forms.ComboBox cbbUF;
        private System.Windows.Forms.ComboBox cbbFilme;
        private System.Windows.Forms.ComboBox cbbMusica;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
    }
}

