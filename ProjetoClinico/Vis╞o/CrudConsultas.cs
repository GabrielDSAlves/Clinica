using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ProjetoClinico
{
    public partial class CrudConsultas : Form
    {
        private int ID = -1;

        public CrudConsultas()
        {
            InitializeComponent();
        }

        public void pdf()
        {
            ConsultaDAO usuarioDao = new ConsultaDAO();
            List<ConsultaJoin> usuarios = usuarioDao.ListarTodosUsuarios();

            Document doc = new Document(PageSize.A4.Rotate());
            doc.SetMargins(5, 5, 15, 15);
            doc.AddCreationDate();

            string caminho = @"C:\Users\gabri\source\repos\ProjetoClinico\Relatorios\" + "consultas.pdf";

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
            doc.Open();

            string dados = "";

            Font titulo = FontFactory.GetFont(BaseFont.TIMES_BOLD, 26);
            
            Image img = Image.GetInstance("https://cdn.icon-icons.com/icons2/944/PNG/512/medical-54_icon-icons.com_73904.png");
            img.ScaleAbsolute(80, 80);
            img.Alignment = Element.ALIGN_RIGHT;
            doc.Add(img);


            Paragraph paragrafo = new Paragraph(dados, titulo);
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("Consultas da clínica\n\n");
            
            doc.Add(paragrafo);
            PdfPTable table = new PdfPTable(7);

            BaseColor fundo = BaseColor.LIGHT_GRAY;
            BaseColor fundo2 = BaseColor.WHITE;
            Font fonte = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 12);
            Font fonte2 = FontFactory.GetFont(BaseFont.TIMES_BOLD, 16);


            PdfPCell celula = new PdfPCell();

            celula.Phrase = new Phrase("Nome do paciente", fonte2);
            celula.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            celula.BackgroundColor = fundo;
            table.AddCell(celula);

            celula.Phrase = new Phrase("Hora do início", fonte2);
            celula.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            celula.BackgroundColor = fundo;
            table.AddCell(celula);

            celula.Phrase = new Phrase("Hora do fim", fonte2);
            celula.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            celula.BackgroundColor = fundo;
            table.AddCell(celula);

            celula.Phrase = new Phrase("Data da solicitação", fonte2);
            celula.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            celula.BackgroundColor = fundo;
            table.AddCell(celula);

            celula.Phrase = new Phrase("Data marcada", fonte2);
            celula.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            celula.BackgroundColor = fundo;
            table.AddCell(celula);

            celula.Phrase = new Phrase("Nome do dentista", fonte2);
            celula.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            celula.BackgroundColor = fundo;
            table.AddCell(celula);

            celula.Phrase = new Phrase("Nome do funcionário resposável", fonte2);
            celula.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            celula.BackgroundColor = fundo;
            table.AddCell(celula);



            foreach (var user in usuarios)
            {
                celula.Phrase = new Phrase(Convert.ToString(user.NomePac), fonte);
                celula.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED;
                celula.BackgroundColor = fundo2;
                table.AddCell(celula);

                celula.Phrase = new Phrase(Convert.ToString(user.Horainicio), fonte);
                celula.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED;
                table.AddCell(celula);

                celula.Phrase = new Phrase(Convert.ToString(user.HoraFim), fonte);
                celula.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED;
                table.AddCell(celula);

                celula.Phrase = new Phrase(Convert.ToString(user.DataAtual), fonte);
                celula.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED;
                table.AddCell(celula);

                celula.Phrase = new Phrase(Convert.ToString(user.DataMarcada), fonte);
                celula.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED;
                table.AddCell(celula);

                celula.Phrase = new Phrase(Convert.ToString(user.NomeDent), fonte);
                celula.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED;
                table.AddCell(celula);

                celula.Phrase = new Phrase(Convert.ToString(user.NomeFunc), fonte);
                celula.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED;
                table.AddCell(celula);

            }
            
            doc.Add(table);
            doc.Close();
            //System.Diagnostics.Process.Start(caminho);
        }


        private void click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AtualizarListView()
        {
            ConsultaDAO usuarioDao = new ConsultaDAO();
            listView1.Items.Clear();


            List<ConsultaJoin> usuarios = usuarioDao.ListarTodosUsuarios();
            if (usuarios.Count > 0)
            {
                foreach (var user in usuarios)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.DataAtual);
                    lv.SubItems.Add(user.DataMarcada);
                    lv.SubItems.Add(user.Horainicio);
                    lv.SubItems.Add(user.HoraFim);
                    lv.SubItems.Add(user.NomePac);
                    lv.SubItems.Add(user.NomeFunc);
                    lv.SubItems.Add(user.NomeDent);

                    listView1.Items.Add(lv);  //Adiciona a linha criada ao listView.
                }
            }
            // Se não houver elementos, mesclar as colunas e exibir apenas um texto para o usuário.
        }

        private void load(object sender, EventArgs e)
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
                        new ConsultaDAO().Excluir(ID);
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

        private void click(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            ID = int.Parse(listView1.Items[index].SubItems[0].Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
            string str = textBox1.Text;
            
            listView1.Items.Clear();

            ConsultaDAO CONDAO = new ConsultaDAO();

            List<ConsultaJoin> usuarios = CONDAO.ListarCON(str);
            if (usuarios.Count > 0)
            {
                foreach (var user in usuarios)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.DataAtual);
                    lv.SubItems.Add(user.DataMarcada);
                    lv.SubItems.Add(user.Horainicio);
                    lv.SubItems.Add(user.HoraFim);
                    lv.SubItems.Add(user.NomePac);
                    lv.SubItems.Add(user.NomeFunc);
                    lv.SubItems.Add(user.NomeDent);

                    listView1.Items.Add(lv);  //Adiciona a linha criada ao listView.
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AtualizarListView();
        }
    }
}
