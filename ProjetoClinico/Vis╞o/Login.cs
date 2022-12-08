using System;
using BCrypt.Net;
using System.Windows.Forms;
using static BCrypt.Net.BCrypt;


namespace ProjetoClinico
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBoxuser.Focus();
        }

        public void buttonCADASTRO_Click(object sender, EventArgs e)
        {
            bool vdd;
            string email = textBoxuser.Text, senha = textBoxsenha.Text, cargo = "";

            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

            if (radioButton1.Checked)
                cargo = radioButton1.Text;
            else if (radioButton2.Checked)
                cargo = radioButton2.Text;
            else
            {
                textBoxuser.Clear();
                textBoxsenha.Clear();
                textBoxuser.Focus();
            }
                

            vdd = funcionarioDAO.Login(email, senha, cargo);

            if (vdd && cargo == "Administrador")
            {
                MessageBox.Show("Logado com sucesso. Seja bem-vindo!");
                new Menu().Show();
                this.Hide();

            }
            else if (vdd && cargo == "Funcionário")
            {
                MessageBox.Show("Logado com sucesso. Seja bem-vindo!");
                new menufunc().Show();
                this.Hide();
            }
            else if (textBoxsenha.Text == string.Empty || textBoxsenha.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos vazios!");
                textBoxuser.Clear();
                textBoxsenha.Clear();
                textBoxuser.Focus();
            }
            else
            {
                MessageBox.Show("Dados incorretos!\nSeu usuário ou senha estão incorretos!");
                textBoxuser.Clear();
                textBoxsenha.Clear();
                textBoxuser.Focus();
            }
        }

        public void Limpar_Click(object sender, EventArgs e)
        {
            textBoxuser.Clear();
            textBoxsenha.Clear();
            textBoxuser.Focus();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxsenha_TextChanged(object sender, EventArgs e)
        {
            textBoxsenha.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
                textBoxsenha.PasswordChar = default;
            else
                textBoxsenha.PasswordChar = '*';
        }

    }
}
