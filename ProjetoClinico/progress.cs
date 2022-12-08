using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoClinico
{
    public partial class progress : Form
    {
        public bool confirma = false;
        public progress()
        {
            InitializeComponent();
        }

        public void progress_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            for (int i = 0; i <= progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string caminho = @"C:\Users\gabri\source\repos\ProjetoClinico\Relatorios\" + "consultas.pdf";
            System.Diagnostics.Process.Start(caminho);

            this.Close();
        }
    }
}
