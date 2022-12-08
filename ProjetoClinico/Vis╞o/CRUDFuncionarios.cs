using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoClinico
{


    public partial class CRUDFuncionarios : Form
    {

        private int ID = -1;
        public CRUDFuncionarios()
        {
            InitializeComponent();
        }

        public void AtualizarListView()
        {
            FuncionarioDAO usuarioDao = new FuncionarioDAO();
            listviewFunci.Items.Clear();


            List<Funcionario> usuarios = usuarioDao.ListarTodosUsuarios();
            if (usuarios.Count > 0)
            {
                foreach (var user in usuarios)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.Cpf);
                    lv.SubItems.Add(user.Datanascimento);
                    lv.SubItems.Add(user.Cidade);
                    lv.SubItems.Add(user.Endereco);
                    lv.SubItems.Add(user.Numero);
                    lv.SubItems.Add(user.Bairro);
                    lv.SubItems.Add(user.Email);
                    lv.SubItems.Add(user.Telefone);
                    lv.SubItems.Add(user.Cargo);
                    lv.SubItems.Add(user.Senha);
                    listviewFunci.Items.Add(lv);  //Adiciona a linha criada ao listView.
                }
            }
            // Se não houver elementos, mesclar as colunas e exibir apenas um texto para o usuário.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                DialogResult resultado = MessageBox.Show("Deseja excluir?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        new FuncionarioDAO().Excluir(ID);
                    }

                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Aviso de erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    AtualizarListView();
                }
            }
            else
            {
                MessageBox.Show("Erro! nada selecionado...");
            }
        }

        private void LoadView(object sender, EventArgs e)
        {
            try
            {
                AtualizarListView();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Click(object sender, MouseEventArgs e)
        {
            int index;
            index = listviewFunci.FocusedItem.Index;
            ID = int.Parse(listviewFunci.Items[index].SubItems[0].Text);
        }

        private void doubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listviewFunci.FocusedItem.Index;
            ID = int.Parse(listviewFunci.Items[index].SubItems[0].Text);

            try
            {
                Funcionario func = new Funcionario
                (
                    int.Parse(listviewFunci.Items[index].SubItems[0].Text),
                    listviewFunci.Items[index].SubItems[1].Text,
                    listviewFunci.Items[index].SubItems[2].Text,
                    listviewFunci.Items[index].SubItems[3].Text,
                    listviewFunci.Items[index].SubItems[4].Text,
                    listviewFunci.Items[index].SubItems[5].Text,
                    listviewFunci.Items[index].SubItems[6].Text,
                    listviewFunci.Items[index].SubItems[7].Text,
                    listviewFunci.Items[index].SubItems[8].Text,
                    listviewFunci.Items[index].SubItems[9].Text,
                    listviewFunci.Items[index].SubItems[10].Text,
                    listviewFunci.Items[index].SubItems[11].Text
                );

                CadastroFunc cad = new CadastroFunc(func);
                cad.Show();
            }
            catch
            {
                MessageBox.Show("Você precisa selecionar uma linha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AtualizarListView();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str;
            str = textBox1.Text;
            string consulta = $"SELECT * FROM funcionarios WHERE Nome_Func LIKE '%{str}%' or Email_Func LIKE '%{str}%'";

            listviewFunci.Items.Clear();

            FuncionarioDAO FUCDAO = new FuncionarioDAO();

            List<Funcionario> funcionario = FUCDAO.ListarFUC(consulta);
            if (funcionario.Count > 0)
            {
                foreach (var user in funcionario)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.Cpf);
                    lv.SubItems.Add(user.Datanascimento);
                    lv.SubItems.Add(user.Cidade);
                    lv.SubItems.Add(user.Endereco);
                    lv.SubItems.Add(user.Numero);
                    lv.SubItems.Add(user.Bairro);
                    lv.SubItems.Add(user.Email);
                    lv.SubItems.Add(user.Telefone);
                    lv.SubItems.Add(user.Cargo);
                    lv.SubItems.Add(user.Senha);
                    listviewFunci.Items.Add(lv);
                }

            }
        }
    }
}
