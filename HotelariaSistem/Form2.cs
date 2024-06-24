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
    public partial class Form2 : Form
    {
        private string[] quartos;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InicializarQuartos();
            MostrarDisponibilidade();
        }

        private void InicializarQuartos()
        {
            quartos = new string[60];
            for (int i = 0;i < quartos.Length; i++)
            {
                quartos[i] = "Disponível";
            
             }
        }

        private void MostrarDisponibilidade()
        {
            int quartosDisponiveisCount = 0;
            foreach (string status in quartos)
            {
                if (status == "Disponível")
                {
                    quartosDisponiveisCount++;
                }
            }

            labelDisponibilidade.Text = "Total de quartos: " + (quartos != null ? quartos.Length.ToString() : "0");
            labelQuartosDisponíveis.Text = "Quartos disponíveis: " + quartosDisponiveisCount + " quartos";
        }

        private void labelDisponibilidade_Click(object sender,EventArgs e)
        {
            MostrarDisponibilidade();
        }

        private void buttonReservar_Click(object sender, EventArgs e)
        {
            int idQuarto = EncontrarQuartoDisponivel();

            if (idQuarto != -1)
            {
                Form3 form3 = new Form3(idQuarto);
                form3.ShowDialog();

                quartos[idQuarto] = "Ocupado";
                MostrarDisponibilidade();
            }
            else
            {
                MessageBox.Show("Não há quartos disponíveis para reserva.");
            }
        }
        private int EncontrarQuartoDisponivel()
        {
            Random random = new Random();
            int idQuartoAleatorio = random.Next(0, 60);

            if (quartos[idQuartoAleatorio] == "Disponível")
            {
                return idQuartoAleatorio;
            }
            else
            {
                return -1;
            }
        }

    }
}
