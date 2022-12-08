using System;
using System.Windows.Forms;
using BCrypt.Net;
using static BCrypt.Net.BCrypt;
namespace ProjetoClinico
{
    public partial class CadastroFunc : Form
    {
        int WorkFactor = 12;
        private int Id;
        private string cargo;
        public CadastroFunc()
        {
            InitializeComponent();
        }

        public void limpar()
        {
            textBox_NOME.Clear();
            textBoxcpf.Clear();
            textBoxbairro.Clear();
            textBoxcidade.Clear();
            textBoxemail.Clear();
            textBoxendereco.Clear();
            textBoxNumero.Clear();
            textBoxtelefone.Clear();
            textBoxSenha.Clear();
            textBox_NOME.Focus();
        }

        public CadastroFunc(Funcionario Func)
        {
            InitializeComponent();
            Id = Func.Id;
            textBox_NOME.Text = Func.Nome;
            textBoxcpf.Text = Func.Cpf;
            textBoxcidade.Text = Func.Cidade;
            textBoxendereco.Text = Func.Endereco;
            DATADENASCIMENTO.Text = Func.Datanascimento;
            textBoxNumero.Text = Func.Numero;
            textBoxbairro.Text = Func.Bairro;
            textBoxemail.Text = Func.Email;
            textBoxtelefone.Text = Func.Telefone;
            textBoxSenha.Text = Func.Senha;
            cargo = Func.Cargo;
            if (Id != 0)
            {
                textBoxSenha.Visible = false;
                label2.Visible = false;
                panel11.Visible = false;
                checkBox1.Visible = false;
            }
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void buttonCadastrar_Click(object sender, EventArgs e)
        {
            CRUDFuncionarios crud = new CRUDFuncionarios();
            string senhacripto;
            if (radioButton1.Checked)
                cargo = radioButton1.Text;
            else if (radioButton2.Checked)
                cargo = radioButton2.Text;

            senhacripto = textBoxSenha.Text;

            senhacripto = HashPassword(senhacripto, WorkFactor);


            try
            {
                Funcionario Func;

                if (Id == 0)
                {
                    Func = new Funcionario(
                    textBox_NOME.Text,
                    textBoxcpf.Text,
                    DATADENASCIMENTO.Text,
                    textBoxcidade.Text,
                    textBoxendereco.Text,
                    textBoxNumero.Text,
                    textBoxbairro.Text,
                    textBoxemail.Text,
                    textBoxtelefone.Text,
                    senhacripto,
                    cargo
                    );
                }
                else
                {
                    Func = new Funcionario(
                    Id,
                    textBox_NOME.Text,
                    textBoxcpf.Text,
                    DATADENASCIMENTO.Text,
                    textBoxcidade.Text,
                    textBoxendereco.Text,
                    textBoxNumero.Text,
                    textBoxbairro.Text,
                    textBoxemail.Text,
                    textBoxtelefone.Text,
                    senhacripto,
                    cargo
                    );
                }
                FuncionarioDAO usuarioInserir = new FuncionarioDAO();

                if (Id == 0)
                    usuarioInserir.Inserir(Func);
                else
                    usuarioInserir.Atualizar(Func);

                MessageBox.Show("Usuário " + Func.Nome + (Id == 0 ? " Inserido!" : " Atualizado!"), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(Id != 1)
                    this.Close();

                limpar();
                crud.AtualizarListView();
                crud.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Limparbt_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void textBoxSenha_TextChanged_1(object sender, EventArgs e)
        {
                textBoxSenha.PasswordChar = '*';

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBoxSenha.PasswordChar = default;
            else
                textBoxSenha.PasswordChar = '*';
        }
    }
}
