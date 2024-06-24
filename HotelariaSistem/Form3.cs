using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelariaSistem
{
    public partial class Form3 : Form
    {
        private int idQuartoSelecionado;
        public Form3(int idQuarto)
        {
            InitializeComponent();
            this.idQuartoSelecionado = idQuarto;

            // Certifique-se de que o evento está associado ao método
            monthCalendarForm3.DateChanged += new DateRangeEventHandler(this.monthCalendarForm3_DateChanged);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Este método é chamado quando o formulário é carregado
            // Você pode adicionar qualquer inicialização adicional aqui, se necessário
        }

        private void monthCalendarForm3_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dataInicio = e.Start;
            DateTime dataTermino = e.End;
            int noites = (dataTermino - dataInicio).Days + 1;

            labelDataInicio.Text = "Data de início: " + dataInicio.ToShortDateString();
            labelDataTermino.Text = "Data de Término: " + dataTermino.ToShortDateString();
            labelNoites.Text = "Quantidade de Noites: " + noites.ToString();
            labelTotal.Text = "Total: " + noites * 80;
        }


        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string nome = textBox1NomeHospede.Text;
            string telefone = textBox2TelefoneHospede.Text;

            {
                MessageBox.Show("Hóspede cadastrado com sucesso!");

                this.Close();
            }

        }

            private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1NomeHospede_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }
    }
}