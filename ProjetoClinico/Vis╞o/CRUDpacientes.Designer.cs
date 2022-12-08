namespace ProjetoClinico
{
    partial class CRUDpacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDpacientes));
            this.listviewPacientes = new System.Windows.Forms.ListView();
            this.clhid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhnome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhcpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhdatanas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhEndereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhnumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhbairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhemail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhtelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelcabecalho = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelcabecalho.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listviewPacientes
            // 
            this.listviewPacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhid,
            this.clhnome,
            this.clhcpf,
            this.clhdatanas,
            this.clhCidade,
            this.clhEndereco,
            this.clhnumero,
            this.clhbairro,
            this.clhemail,
            this.clhtelefone});
            this.listviewPacientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listviewPacientes.FullRowSelect = true;
            this.listviewPacientes.HideSelection = false;
            this.listviewPacientes.Location = new System.Drawing.Point(0, 486);
            this.listviewPacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listviewPacientes.Name = "listviewPacientes";
            this.listviewPacientes.Size = new System.Drawing.Size(1220, 394);
            this.listviewPacientes.TabIndex = 0;
            this.listviewPacientes.UseCompatibleStateImageBehavior = false;
            this.listviewPacientes.View = System.Windows.Forms.View.Details;
            this.listviewPacientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listviewPacientes_MouseClick);
            this.listviewPacientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listviewPacientes_MouseDoubleClick);
            // 
            // clhid
            // 
            this.clhid.Text = "ID";
            this.clhid.Width = 40;
            // 
            // clhnome
            // 
            this.clhnome.Text = "Nome";
            this.clhnome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhnome.Width = 150;
            // 
            // clhcpf
            // 
            this.clhcpf.Text = "CPF";
            this.clhcpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhcpf.Width = 150;
            // 
            // clhdatanas
            // 
            this.clhdatanas.Text = "Data de nascimento";
            this.clhdatanas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhdatanas.Width = 150;
            // 
            // clhCidade
            // 
            this.clhCidade.Text = "Cidade";
            this.clhCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhCidade.Width = 150;
            // 
            // clhEndereco
            // 
            this.clhEndereco.Text = "Endereço";
            this.clhEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhEndereco.Width = 150;
            // 
            // clhnumero
            // 
            this.clhnumero.Text = "Numero";
            this.clhnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhnumero.Width = 40;
            // 
            // clhbairro
            // 
            this.clhbairro.Text = "Bairro";
            this.clhbairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhbairro.Width = 150;
            // 
            // clhemail
            // 
            this.clhemail.Text = "E-Mail";
            this.clhemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhemail.Width = 150;
            // 
            // clhtelefone
            // 
            this.clhtelefone.Text = "Telefone";
            this.clhtelefone.Width = 100;
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
            this.panelcabecalho.Size = new System.Drawing.Size(1220, 50);
            this.panelcabecalho.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "PACIENTES";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1167, 4);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(49, 46);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(57, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(621, 42);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(57, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 1);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(754, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 64);
            this.label2.TabIndex = 14;
            this.label2.Text = "      Pesquisar";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::ProjetoClinico.Properties.Resources.refresh_page_option_icon_icons_com_73441__1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1102, 394);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 60);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.attButton);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::ProjetoClinico.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 372);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 82);
            this.button1.TabIndex = 1;
            this.button1.Text = "    Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(57, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 139);
            this.panel2.TabIndex = 15;
            // 
            // CRUDpacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 880);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelcabecalho);
            this.Controls.Add(this.listviewPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CRUDpacientes";
            this.Text = "CRUDpacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CRUDpacientes_Load);
            this.panelcabecalho.ResumeLayout(false);
            this.panelcabecalho.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listviewPacientes;
        private System.Windows.Forms.ColumnHeader clhid;
        private System.Windows.Forms.ColumnHeader clhnome;
        private System.Windows.Forms.ColumnHeader clhcpf;
        private System.Windows.Forms.ColumnHeader clhdatanas;
        private System.Windows.Forms.ColumnHeader clhCidade;
        private System.Windows.Forms.ColumnHeader clhEndereco;
        private System.Windows.Forms.ColumnHeader clhnumero;
        private System.Windows.Forms.ColumnHeader clhbairro;
        private System.Windows.Forms.ColumnHeader clhemail;
        private System.Windows.Forms.ColumnHeader clhtelefone;
        private System.Windows.Forms.Panel panelcabecalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}