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
    public partial class Form3 : Form//Declaração da classe Form3 que herda de Form
    {
        private int idQuartoSelecionado;//armazena o ID
        private string connectionString = "server=localhost;user=root;database=hotelaria;port=3306;password=;";

        public Form3(int idQuarto)// construtor que recebe o Id como parâmetro
        {
            InitializeComponent();
            this.idQuartoSelecionado = idQuarto;

            //associa o evento de alteração de data
            monthCalendarForm3.DateChanged += new DateRangeEventHandler(this.monthCalendarForm3_DateChanged);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Este método é chamado quando o formulário é carregado
            
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

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = "INSERT INTO hospedagem (nome, telefone, quantNoites, idQuarto) VALUES (@nome, @telefone, @quantNoites, @idQuarto)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@quantNoites", labelNoites.Text.Split(':')[1].Trim());
                        cmd.Parameters.AddWithValue("@idQuarto", idQuartoSelecionado);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Hóspede cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar hóspede: " + ex.Message);
                }
            }

            // Após finalizar, mostra o Form4, passando os dados do hóspede como parâmetros
            Form4 form4 = new Form4(nome, idQuartoSelecionado, Convert.ToInt32(labelNoites.Text.Split(':')[1].Trim()));

            form4.Show();

            // Fecha o formulário atual
            this.Close();
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