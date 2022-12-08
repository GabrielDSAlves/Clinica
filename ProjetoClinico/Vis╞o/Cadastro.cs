using System;
using System.Windows.Forms;

namespace ProjetoClinico
{
    public partial class Cadastro : Form
    {
        private int Id;

        public Cadastro()
        {
            InitializeComponent();
        }

        public Cadastro(Paciente pac)
        {
            InitializeComponent();
            Id = pac.Id;
            textBox_NOME.Text = pac.Nome;
            textBoxcpf.Text = pac.Cpf;
            textBoxcidade.Text = pac.Cidade;
            textBoxendereco.Text = pac.Endereco;
            DATADENASCIMENTO.Text = pac.Datanascimento;
            textBoxNumero.Text = pac.Numero;
            textBoxbairro.Text = pac.Bairro;
            textBoxemail.Text = pac.Email;
            textBoxtelefone.Text = pac.Telefone;
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
            textBox_NOME.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void buttonCadastrar_Click_1(object sender, EventArgs e)
        {
            CRUDpacientes crud = new CRUDpacientes();
            try
            {
                Paciente pac;

                if (Id == 0)
                {
                    pac = new Paciente(
                    textBox_NOME.Text,
                    textBoxcpf.Text,
                    DATADENASCIMENTO.Text,
                    textBoxcidade.Text,
                    textBoxendereco.Text,
                    textBoxNumero.Text,
                    textBoxbairro.Text,
                    textBoxemail.Text,
                    textBoxtelefone.Text
                    );
                }
                else
                {
                    pac = new Paciente(
                    Id,
                    textBox_NOME.Text,
                    textBoxcpf.Text,
                    DATADENASCIMENTO.Text,
                    textBoxcidade.Text,
                    textBoxendereco.Text,
                    textBoxNumero.Text,
                    textBoxbairro.Text,
                    textBoxemail.Text,
                    textBoxtelefone.Text
                    );
                }
                PacienteDAO usuarioInserir = new PacienteDAO();

                if (Id == 0)
                    usuarioInserir.Inserir(pac);
                else
                    usuarioInserir.Atualizar(pac);

                MessageBox.Show("Usuário " + pac.Nome + (Id == 0? " Inserido!" : " Atualizado!"), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Id != 1)
                    this.Close();

                limpar();
                crud.AtualizarListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_limpar(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
