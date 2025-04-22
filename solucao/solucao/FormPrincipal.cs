using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solucao
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void x1_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Você deseja encerrar o programa?",
                "Sair", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menos1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
