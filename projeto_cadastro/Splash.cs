using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_cadastro
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Responsavel por fazer a contagem de tempo juntamente com o movimento do ProgressBar.
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                //Quando progressbar for igual a 100 ele cairá para ca, o timer será desabilitado, está janela de carregamento se fechara e a tela Home será aberta
                timer1.Enabled = false;
                this.Visible = false;

                frmHome frm = new frmHome();
                frm.ShowDialog();
            }
        }
    }
}
