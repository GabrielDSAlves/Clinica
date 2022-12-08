using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoClinico
{
    public partial class CRUDpacientes : Form
    {
        

        private int ID = -1;
        public CRUDpacientes()
        {
            InitializeComponent();
        }

        public void AtualizarListView()
        {
            PacienteDAO usuarioDao = new PacienteDAO();
            listviewPacientes.Items.Clear();


            List<Paciente> usuarios = usuarioDao.ListarTodosUsuarios();
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

                    listviewPacientes.Items.Add(lv);  //Adiciona a linha criada ao listView.
                }
            }
            // Se não houver elementos, mesclar as colunas e exibir apenas um texto para o usuário.
        }
            

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void listviewPacientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listviewPacientes.FocusedItem.Index;
            ID = int.Parse(listviewPacientes.Items[index].SubItems[0].Text);

            try
            {
                Paciente pac = new Paciente
                (
                    int.Parse(listviewPacientes.Items[index].SubItems[0].Text),
                    listviewPacientes.Items[index].SubItems[1].Text,
                    listviewPacientes.Items[index].SubItems[2].Text,
                    listviewPacientes.Items[index].SubItems[3].Text,
                    listviewPacientes.Items[index].SubItems[4].Text,
                    listviewPacientes.Items[index].SubItems[5].Text,
                    listviewPacientes.Items[index].SubItems[6].Text,
                    listviewPacientes.Items[index].SubItems[7].Text,
                    listviewPacientes.Items[index].SubItems[8].Text,
                    listviewPacientes.Items[index].SubItems[9].Text
                );


                Cadastro cad = new Cadastro(pac);
                this.Close();
                cad.Show();

            }
            catch
            {
                MessageBox.Show("Você precisa selecionar uma linha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void CRUDpacientes_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (ID != -1)
            {
                DialogResult resultado = MessageBox.Show("Deseja excluir?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        new PacienteDAO().Excluir(ID);
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

        private void listviewPacientes_MouseClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listviewPacientes.FocusedItem.Index;
            ID = int.Parse(listviewPacientes.Items[index].SubItems[0].Text);
        }

        private void attButton(object sender, EventArgs e)
        {
            AtualizarListView();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str;
            str = textBox1.Text;
            string consulta = $"SELECT * FROM pacientes WHERE Nome LIKE '%{str}%' or Email LIKE '%{str}%'";

            listviewPacientes.Items.Clear();

            PacienteDAO PACDAO = new PacienteDAO();

            List<Paciente> pacientes = PACDAO.ListarPAC(consulta);
            if(pacientes.Count > 0)
            {
                foreach (var user in pacientes)
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
                    listviewPacientes.Items.Add(lv);
                }
            }
        }
    }
}
