using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HotelariaSistem
{
    public partial class Form2 : Form //class form2 que herda da class form
    {
        private List<int> quartosDisponiveis = new List<int>();//lista de números inteiros q armazena os ids

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)// esse método é chamado quando o form é carregado pela primeira vez
        {
            InicializarQuartos();
            CarregarQuartosOcupados();
            MostrarDisponibilidade();
        }

        private void InicializarQuartos()
        {
            // Adicionar todos os quartos como disponíveis inicialmente, adicionando os Ids de cada um como disponíveis
            for (int i = 1; i <= 60; i++)
            {
                quartosDisponiveis.Add(i);
            }
        }

        private void CarregarQuartosOcupados()//esse método inicia o bd
        {
            string connectionString = "server=localhost;user=root;database=hotelaria;port=3306;password=;";
            string query = "SELECT idQuarto FROM hospedagem";//executa uma consulta

            using (MySqlConnection conn = new MySqlConnection(connectionString))//cria uma nova conexão
            {
                try // try-cath é iniciado
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);//executa a consulta
                    MySqlDataReader reader = cmd.ExecuteReader();// usado para ler as consultas

                    while (reader.Read())// inicia um loop
                    {
                        int idQuarto = reader.GetInt32("idQuarto");//ocupa o quarto
                        quartosDisponiveis.Remove(idQuarto);//remove de quartosDisponíveis
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar quartos ocupados: " + ex.Message);
                }
            }
        }

        private void MostrarDisponibilidade()//esse método atualiza as labels para mostrar o número real
        {
            int quartosDisponiveisCount = quartosDisponiveis.Count;

            labelDisponibilidade.Text = "Total de quartos: 60";
            labelQuartosDisponíveis.Text = "Quartos disponíveis: " + quartosDisponiveisCount + " quartos";
        }

        private void buttonReservar_Click(object sender, EventArgs e)// esse método é chamado quando o btn Reservar é clicado
        {
            if (quartosDisponiveis.Count > 0)
            {
                int idQuarto = quartosDisponiveis.First();// pega o 1º ID da lista

                Form3 form3 = new Form3(idQuarto);//  cria e exibe uma nova instância do form3
                form3.ShowDialog();

                quartosDisponiveis.Remove(idQuarto);// remove de quartosDisponíveis
                MostrarDisponibilidade();// atualiza disponibilidade
            }
            else
            {
                MessageBox.Show("Não há quartos disponíveis para reserva.");
            }
        }
    }
}