using lab_windowsforms.classes;
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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal(login usuarioAutenticado)
        {
            // NÃO MEXER NESTA FUNÇÃO PELO AMOR DE DEUS
            InitializeComponent();

            this.strFuncionario.Text = usuarioAutenticado.Nome;
            this.strFuncao.Text = usuarioAutenticado.UserProfile;
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O senhor é o socorro bem presente na hora da angustia");
        }

        private void pessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
