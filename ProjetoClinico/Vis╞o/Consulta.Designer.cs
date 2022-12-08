namespace ProjetoClinico
{
    partial class Consulta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.panelcabecalho = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataatual_LABEL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinica_odontoDataSet5 = new ProjetoClinico.Clinica_odontoDataSet5();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Limparbt = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinica_odontoDataSet6 = new ProjetoClinico.Clinica_odontoDataSet6();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.funcionariosTableAdapter = new ProjetoClinico.Clinica_odontoDataSet5TableAdapters.funcionariosTableAdapter();
            this.pacientesTableAdapter = new ProjetoClinico.Clinica_odontoDataSet6TableAdapters.pacientesTableAdapter();
            this.clinica_odontoDataSet = new ProjetoClinico.Clinica_odontoDataSet();
            this.dENTISTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dENTISTATableAdapter = new ProjetoClinico.Clinica_odontoDataSetTableAdapters.DENTISTATableAdapter();
            this.panelcabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinica_odontoDataSet5)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinica_odontoDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinica_odontoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dENTISTABindingSource)).BeginInit();
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
            this.panelcabecalho.Size = new System.Drawing.Size(1475, 49);
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
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "CONSULTA";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1426, 3);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(49, 46);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 174);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dataatual_LABEL
            // 
            this.dataatual_LABEL.AutoSize = true;
            this.dataatual_LABEL.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataatual_LABEL.Location = new System.Drawing.Point(23, 122);
            this.dataatual_LABEL.Name = "dataatual_LABEL";
            this.dataatual_LABEL.Size = new System.Drawing.Size(108, 34);
            this.dataatual_LABEL.TabIndex = 41;
            this.dataatual_LABEL.Text = "Data atual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 34);
            this.label2.TabIndex = 43;
            this.label2.Text = "Data da consulta";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(29, 310);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker2.TabIndex = 42;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.funcionariosBindingSource;
            this.comboBox1.DisplayMember = "Nome_Func";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(784, 441);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 24);
            this.comboBox1.TabIndex = 44;
            this.comboBox1.ValueMember = "ID_Func";
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.clinica_odontoDataSet5;
            // 
            // clinica_odontoDataSet5
            // 
            this.clinica_odontoDataSet5.DataSetName = "Clinica_odontoDataSet5";
            this.clinica_odontoDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(777, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 34);
            this.label3.TabIndex = 43;
            this.label3.Text = "Funcionario";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Controls.Add(this.Limparbt);
            this.panel9.Controls.Add(this.buttonCadastrar);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 752);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1475, 84);
            this.panel9.TabIndex = 45;
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
            this.Limparbt.Location = new System.Drawing.Point(4, 8);
            this.Limparbt.Margin = new System.Windows.Forms.Padding(4);
            this.Limparbt.Name = "Limparbt";
            this.Limparbt.Size = new System.Drawing.Size(460, 76);
            this.Limparbt.TabIndex = 1;
            this.Limparbt.Text = "          Limpar";
            this.Limparbt.UseVisualStyleBackColor = true;
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
            this.buttonCadastrar.Location = new System.Drawing.Point(959, 6);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(467, 78);
            this.buttonCadastrar.TabIndex = 1;
            this.buttonCadastrar.Text = "          Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.pacientesBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(784, 578);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(265, 24);
            this.comboBox2.TabIndex = 46;
            this.comboBox2.ValueMember = "ID";
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "pacientes";
            this.pacientesBindingSource.DataSource = this.clinica_odontoDataSet6;
            // 
            // clinica_odontoDataSet6
            // 
            this.clinica_odontoDataSet6.DataSetName = "Clinica_odontoDataSet6";
            this.clinica_odontoDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(777, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 34);
            this.label4.TabIndex = 43;
            this.label4.Text = "Paciente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(777, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 34);
            this.label5.TabIndex = 43;
            this.label5.Text = "Dentista";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.dENTISTABindingSource;
            this.comboBox3.DisplayMember = "Nome_Dent";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(784, 306);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(265, 24);
            this.comboBox3.TabIndex = 44;
            this.comboBox3.ValueMember = "ID_Dent";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(29, 459);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(328, 22);
            this.dateTimePicker3.TabIndex = 47;
            this.dateTimePicker3.TabStop = false;
            this.dateTimePicker3.Value = new System.DateTime(2022, 11, 29, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 34);
            this.label6.TabIndex = 41;
            this.label6.Text = "Hora de inicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 34);
            this.label7.TabIndex = 41;
            this.label7.Text = "Hora de termino";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(29, 603);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(328, 22);
            this.dateTimePicker4.TabIndex = 47;
            this.dateTimePicker4.TabStop = false;
            this.dateTimePicker4.Value = new System.DateTime(2022, 11, 29, 0, 0, 0, 0);
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // clinica_odontoDataSet
            // 
            this.clinica_odontoDataSet.DataSetName = "Clinica_odontoDataSet";
            this.clinica_odontoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dENTISTABindingSource
            // 
            this.dENTISTABindingSource.DataMember = "DENTISTA";
            this.dENTISTABindingSource.DataSource = this.clinica_odontoDataSet;
            // 
            // dENTISTATableAdapter
            // 
            this.dENTISTATableAdapter.ClearBeforeFill = true;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1475, 836);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataatual_LABEL);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panelcabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Consulta_Load);
            this.panelcabecalho.ResumeLayout(false);
            this.panelcabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinica_odontoDataSet5)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinica_odontoDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinica_odontoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dENTISTABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelcabecalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dataatual_LABEL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button Limparbt;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private Clinica_odontoDataSet5 clinica_odontoDataSet5;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private Clinica_odontoDataSet5TableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        private Clinica_odontoDataSet6 clinica_odontoDataSet6;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private Clinica_odontoDataSet6TableAdapters.pacientesTableAdapter pacientesTableAdapter;
        private Clinica_odontoDataSet clinica_odontoDataSet;
        private System.Windows.Forms.BindingSource dENTISTABindingSource;
        private Clinica_odontoDataSetTableAdapters.DENTISTATableAdapter dENTISTATableAdapter;
    }
}