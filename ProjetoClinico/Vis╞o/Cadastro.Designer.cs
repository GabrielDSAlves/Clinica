namespace ProjetoClinico
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.panelcabecalho = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.Limparbt = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBoxcpf = new System.Windows.Forms.MaskedTextBox();
            this.textBox_NOME = new System.Windows.Forms.TextBox();
            this.DATADENASCIMENTO = new System.Windows.Forms.DateTimePicker();
            this.textBoxtelefone = new System.Windows.Forms.MaskedTextBox();
            this.labeldatanasc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NOME_LABEL = new System.Windows.Forms.Label();
            this.textBoxcidade = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxNumero = new System.Windows.Forms.MaskedTextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.textBoxendereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.textBoxbairro = new System.Windows.Forms.TextBox();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelcabecalho.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcabecalho
            // 
            this.panelcabecalho.BackColor = System.Drawing.Color.DimGray;
            this.panelcabecalho.Controls.Add(this.label1);
            this.panelcabecalho.Controls.Add(this.btnFechar);
            this.panelcabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelcabecalho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelcabecalho.Name = "panelcabecalho";
            this.panelcabecalho.Size = new System.Drawing.Size(1401, 49);
            this.panelcabecalho.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "CADASTRO PACIENTES";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1348, 4);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(49, 46);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCadastrar.FlatAppearance.BorderSize = 0;
            this.buttonCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.ForeColor = System.Drawing.Color.Black;
            this.buttonCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCadastrar.Image")));
            this.buttonCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastrar.Location = new System.Drawing.Point(935, 4);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(467, 78);
            this.buttonCadastrar.TabIndex = 1;
            this.buttonCadastrar.Text = "          Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click_1);
            // 
            // Limparbt
            // 
            this.Limparbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Limparbt.FlatAppearance.BorderSize = 0;
            this.Limparbt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Limparbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limparbt.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limparbt.ForeColor = System.Drawing.Color.Black;
            this.Limparbt.Image = ((System.Drawing.Image)(resources.GetObject("Limparbt.Image")));
            this.Limparbt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Limparbt.Location = new System.Drawing.Point(4, 4);
            this.Limparbt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Limparbt.Name = "Limparbt";
            this.Limparbt.Size = new System.Drawing.Size(460, 76);
            this.Limparbt.TabIndex = 1;
            this.Limparbt.Text = "          Limpar";
            this.Limparbt.UseVisualStyleBackColor = true;
            this.Limparbt.Click += new System.EventHandler(this.button_limpar);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Controls.Add(this.Limparbt);
            this.panel9.Controls.Add(this.buttonCadastrar);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 800);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1401, 84);
            this.panel9.TabIndex = 24;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.textBoxcpf);
            this.panel12.Controls.Add(this.textBox_NOME);
            this.panel12.Controls.Add(this.DATADENASCIMENTO);
            this.panel12.Controls.Add(this.textBoxtelefone);
            this.panel12.Controls.Add(this.labeldatanasc);
            this.panel12.Controls.Add(this.panel1);
            this.panel12.Controls.Add(this.labelCidade);
            this.panel12.Controls.Add(this.labelTelefone);
            this.panel12.Controls.Add(this.labelCPF);
            this.panel12.Controls.Add(this.panel4);
            this.panel12.Controls.Add(this.NOME_LABEL);
            this.panel12.Controls.Add(this.textBoxcidade);
            this.panel12.Location = new System.Drawing.Point(13, 55);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(668, 740);
            this.panel12.TabIndex = 58;
            // 
            // textBoxcpf
            // 
            this.textBoxcpf.BackColor = System.Drawing.Color.White;
            this.textBoxcpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxcpf.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcpf.Location = new System.Drawing.Point(11, 217);
            this.textBoxcpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxcpf.Mask = "000,000,000-00";
            this.textBoxcpf.Name = "textBoxcpf";
            this.textBoxcpf.Size = new System.Drawing.Size(259, 42);
            this.textBoxcpf.TabIndex = 27;
            // 
            // textBox_NOME
            // 
            this.textBox_NOME.BackColor = System.Drawing.Color.White;
            this.textBox_NOME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_NOME.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NOME.Location = new System.Drawing.Point(13, 90);
            this.textBox_NOME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_NOME.Name = "textBox_NOME";
            this.textBox_NOME.Size = new System.Drawing.Size(587, 42);
            this.textBox_NOME.TabIndex = 26;
            // 
            // DATADENASCIMENTO
            // 
            this.DATADENASCIMENTO.CalendarFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATADENASCIMENTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATADENASCIMENTO.Location = new System.Drawing.Point(11, 577);
            this.DATADENASCIMENTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DATADENASCIMENTO.Name = "DATADENASCIMENTO";
            this.DATADENASCIMENTO.Size = new System.Drawing.Size(199, 22);
            this.DATADENASCIMENTO.TabIndex = 38;
            // 
            // textBoxtelefone
            // 
            this.textBoxtelefone.BackColor = System.Drawing.Color.White;
            this.textBoxtelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxtelefone.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtelefone.Location = new System.Drawing.Point(13, 334);
            this.textBoxtelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxtelefone.Mask = "(00) 00000-0000";
            this.textBoxtelefone.Name = "textBoxtelefone";
            this.textBoxtelefone.Size = new System.Drawing.Size(213, 42);
            this.textBoxtelefone.TabIndex = 20;
            // 
            // labeldatanasc
            // 
            this.labeldatanasc.AutoSize = true;
            this.labeldatanasc.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldatanasc.Location = new System.Drawing.Point(11, 511);
            this.labeldatanasc.Name = "labeldatanasc";
            this.labeldatanasc.Size = new System.Drawing.Size(199, 34);
            this.labeldatanasc.TabIndex = 33;
            this.labeldatanasc.Text = "Data de nascimento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(16, 134);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 1);
            this.panel1.TabIndex = 51;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidade.Location = new System.Drawing.Point(7, 398);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(77, 34);
            this.labelCidade.TabIndex = 30;
            this.labelCidade.Text = "Cidade";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.Location = new System.Drawing.Point(11, 289);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(92, 34);
            this.labelTelefone.TabIndex = 29;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.Location = new System.Drawing.Point(11, 167);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(49, 34);
            this.labelCPF.TabIndex = 28;
            this.labelCPF.Text = "CPF";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(13, 476);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 1);
            this.panel4.TabIndex = 47;
            // 
            // NOME_LABEL
            // 
            this.NOME_LABEL.AutoSize = true;
            this.NOME_LABEL.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOME_LABEL.Location = new System.Drawing.Point(11, 53);
            this.NOME_LABEL.Name = "NOME_LABEL";
            this.NOME_LABEL.Size = new System.Drawing.Size(67, 34);
            this.NOME_LABEL.TabIndex = 40;
            this.NOME_LABEL.Text = "Nome";
            // 
            // textBoxcidade
            // 
            this.textBoxcidade.BackColor = System.Drawing.Color.White;
            this.textBoxcidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxcidade.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcidade.Location = new System.Drawing.Point(16, 432);
            this.textBoxcidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxcidade.Name = "textBoxcidade";
            this.textBoxcidade.Size = new System.Drawing.Size(347, 42);
            this.textBoxcidade.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1245, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(737, 306);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 1);
            this.panel6.TabIndex = 89;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(736, 409);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 1);
            this.panel5.TabIndex = 88;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(737, 636);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 1);
            this.panel3.TabIndex = 87;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumero.BackColor = System.Drawing.Color.White;
            this.textBoxNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumero.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumero.Location = new System.Drawing.Point(732, 501);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNumero.Mask = "000000";
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(101, 42);
            this.textBoxNumero.TabIndex = 86;
            // 
            // labelEndereco
            // 
            this.labelEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(731, 223);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(102, 34);
            this.labelEndereco.TabIndex = 81;
            this.labelEndereco.Text = "Endereço";
            // 
            // textBoxendereco
            // 
            this.textBoxendereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxendereco.BackColor = System.Drawing.Color.White;
            this.textBoxendereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxendereco.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxendereco.Location = new System.Drawing.Point(736, 258);
            this.textBoxendereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxendereco.Name = "textBoxendereco";
            this.textBoxendereco.Size = new System.Drawing.Size(453, 42);
            this.textBoxendereco.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(729, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 34);
            this.label3.TabIndex = 82;
            this.label3.Text = "Bairro";
            // 
            // labelemail
            // 
            this.labelemail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(729, 560);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(75, 34);
            this.labelemail.TabIndex = 80;
            this.labelemail.Text = "E-Mail";
            // 
            // textBoxbairro
            // 
            this.textBoxbairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxbairro.BackColor = System.Drawing.Color.White;
            this.textBoxbairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxbairro.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxbairro.Location = new System.Drawing.Point(732, 361);
            this.textBoxbairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxbairro.Name = "textBoxbairro";
            this.textBoxbairro.Size = new System.Drawing.Size(457, 42);
            this.textBoxbairro.TabIndex = 83;
            // 
            // textBoxemail
            // 
            this.textBoxemail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxemail.BackColor = System.Drawing.Color.White;
            this.textBoxemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxemail.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxemail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxemail.Location = new System.Drawing.Point(732, 588);
            this.textBoxemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(405, 42);
            this.textBoxemail.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(731, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 34);
            this.label2.TabIndex = 80;
            this.label2.Text = "Nº";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1401, 884);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.textBoxendereco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.textBoxbairro);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panelcabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odontíatros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelcabecalho.ResumeLayout(false);
            this.panelcabecalho.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelcabecalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button Limparbt;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.MaskedTextBox textBoxcpf;
        private System.Windows.Forms.TextBox textBox_NOME;
        private System.Windows.Forms.DateTimePicker DATADENASCIMENTO;
        private System.Windows.Forms.MaskedTextBox textBoxtelefone;
        private System.Windows.Forms.Label labeldatanasc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label NOME_LABEL;
        private System.Windows.Forms.TextBox textBoxcidade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox textBoxNumero;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox textBoxendereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox textBoxbairro;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Label label2;
    }
}