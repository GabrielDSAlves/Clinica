using System;
using System.Windows.Forms;

namespace ProjetoClinico
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'clinica_odontoDataSet.DENTISTA'. Você pode movê-la ou removê-la conforme necessário.
            this.dENTISTATableAdapter.Fill(this.clinica_odontoDataSet.DENTISTA);
            // TODO: esta linha de código carrega dados na tabela 'clinica_odontoDataSet6.pacientes'. Você pode movê-la ou removê-la conforme necessário.
            this.pacientesTableAdapter.Fill(this.clinica_odontoDataSet6.pacientes);
            // TODO: esta linha de código carrega dados na tabela 'clinica_odontoDataSet5.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.clinica_odontoDataSet5.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'clinica_odontoDataSet4.DENTISTA'. Você pode movê-la ou removê-la conforme necessário.
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.ShowUpDown = true;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                Consultar cons = new Consultar(
                dateTimePicker1.Text,
                dateTimePicker2.Text,
                dateTimePicker3.Text,
                dateTimePicker4.Text,
                (int)comboBox1.SelectedValue,
                (int)comboBox2.SelectedValue,
                (int)comboBox3.SelectedValue
                );
                

                ConsultaDAO usuarioInserir = new ConsultaDAO();

                usuarioInserir.Inserir(cons);


                MessageBox.Show("Consulta Marcada!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
