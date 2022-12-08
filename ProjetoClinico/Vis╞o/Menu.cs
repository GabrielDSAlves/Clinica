using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ProjetoClinico
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Cadastro>();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }

        private void btnpacientes(object sender, EventArgs e)
        {
            AbrirFormNoPanel<CRUDpacientes>();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
           AbrirFormNoPanel<CadastroFunc>();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<CadastroFunc>();
        }

        private void vizualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<CRUDFuncionarios>();
        }

        private void btnconsulta(object sender, EventArgs e)
        {
            AbrirFormNoPanel<CrudConsultas>();
        }

        private void btnMINIMIZAR_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Consulta>();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<progress>();

            CrudConsultas consultas = new CrudConsultas();
            consultas.pdf();

        }
    }
}
