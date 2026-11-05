using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_windowsforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sortColor();

            MessageBox.Show("Olá, Mundo \n Para de corrigir o professor, Yvan");           

        }

        private void sortColor()
        {
            Color[] colors = {
                Color.Red,
                Color.AliceBlue,
                Color.Green,
                Color.Blue,
                Color.Magenta,
                Color.Yellow,
                Color.Orange,
                Color.Orchid,
                Color.Purple
            };

            Random sorteio = new Random();

            int indice = sorteio.Next(colors.Length);

            this.BackColor = colors[indice];

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] nomes = {"Raphael", "Wallacy", "Amanda", "Pedro" };

            Random sorteio = new Random();
            int indice = sorteio.Next(nomes.Length);

            this.label1.Text = nomes[indice];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
