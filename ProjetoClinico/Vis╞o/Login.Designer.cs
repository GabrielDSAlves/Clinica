namespace ProjetoClinico
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.buttonLOGIN = new System.Windows.Forms.Button();
            this.LABELUSER = new System.Windows.Forms.Label();
            this.paneluser = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Limpar = new System.Windows.Forms.Label();
            this.sair = new System.Windows.Forms.Label();
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.textBoxsenha = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLOGIN
            // 
            this.buttonLOGIN.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.buttonLOGIN, "buttonLOGIN");
            this.buttonLOGIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLOGIN.ForeColor = System.Drawing.Color.White;
            this.buttonLOGIN.Name = "buttonLOGIN";
            this.buttonLOGIN.UseVisualStyleBackColor = false;
            this.buttonLOGIN.Click += new System.EventHandler(this.buttonCADASTRO_Click);
            // 
            // LABELUSER
            // 
            resources.ApplyResources(this.LABELUSER, "LABELUSER");
            this.LABELUSER.ForeColor = System.Drawing.Color.Black;
            this.LABELUSER.Name = "LABELUSER";
            // 
            // paneluser
            // 
            this.paneluser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.paneluser, "paneluser");
            this.paneluser.Name = "paneluser";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ProjetoClinico.Properties.Resources.lock_padlock_symbol_for_protect_icon_icons_com_56926;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ProjetoClinico.Properties.Resources.round_account_button_with_user_inside_icon_icons_com_72596__1_;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjetoClinico.Properties.Resources.medical_54_icon_icons_com_73904;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Limpar
            // 
            resources.ApplyResources(this.Limpar, "Limpar");
            this.Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Limpar.Name = "Limpar";
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // sair
            // 
            resources.ApplyResources(this.sair, "sair");
            this.sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sair.Name = "sair";
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // textBoxuser
            // 
            this.textBoxuser.BackColor = System.Drawing.Color.White;
            this.textBoxuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxuser, "textBoxuser");
            this.textBoxuser.Name = "textBoxuser";
            // 
            // textBoxsenha
            // 
            this.textBoxsenha.BackColor = System.Drawing.Color.White;
            this.textBoxsenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxsenha, "textBoxsenha");
            this.textBoxsenha.Name = "textBoxsenha";
            this.textBoxsenha.TextChanged += new System.EventHandler(this.textBoxsenha_TextChanged);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Checked = true;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxsenha);
            this.Controls.Add(this.textBoxuser);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneluser);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LABELUSER);
            this.Controls.Add(this.buttonLOGIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLOGIN;
        private System.Windows.Forms.Label LABELUSER;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel paneluser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Limpar;
        private System.Windows.Forms.Label sair;
        private System.Windows.Forms.TextBox textBoxuser;
        private System.Windows.Forms.TextBox textBoxsenha;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

