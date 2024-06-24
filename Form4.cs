using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace HotelariaSistem
{
    public partial class Form4 : Form//Declaração da classe Form4 que herda de Form
    {
        public Form4(string nomeHospede, int numeroQuarto, int numeroNoites)//construtor
        {
            InitializeComponent();

            LabelNomeRegistro.Text = "Nome do hóspede: " + nomeHospede;
            labelQuarto.Text = "Nº do quarto: " + numeroQuarto.ToString();
            labelNoites.Text = "Nº de noites: " + numeroNoites.ToString();
            labelNoites.Text = "Nº de noites: " + numeroNoites.ToString();

            // Calcula o valor total
            int valorNoites = numeroNoites * 80;
            int valorTotal = valorNoites + 10;

            labelValorFinal.Text = "Valor total: " + valorTotal.ToString();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            // Fecha o Form4.cs
            this.Close();

            Form2 form2 = new Form2();

            // Mostra o Form2.cs
            form2.Show();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
