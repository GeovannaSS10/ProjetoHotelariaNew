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
    public partial class Form1 : Form // a class form1 herda da class form
    {
        public Form1() //construtor, é chamado quando uma instância no formulário é criada
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) // método vazio
        {

        }

        private void Login_Click(object sender, EventArgs e) // Ao clicar no btn login
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e) //carregamento da página
        {

        }
    }
}
