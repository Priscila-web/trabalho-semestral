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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeUsu, sexoUsu, ufUsu, favFilm, favMusic;
            int idadeUsu;

            nomeUsu = textBox1.Text;
            idadeUsu = Convert.ToInt32(textBox2.Text);
            sexoUsu = comboBox1.Text;
            ufUsu = comboBox2.Text;
            favFilm = comboBox3.Text;
            favMusic = comboBox4.Text;


            MessageBox.Show("Nome:" + nomeUsu);
            MessageBox.Show("Idade:" + idadeUsu);
            MessageBox.Show("Sexo:" + sexoUsu);
            MessageBox.Show("UF:" + ufUsu);
            MessageBox.Show("Tipo de Filme Favorito:" + favFilm);
            MessageBox.Show("Genero Musical Favorito:" + favMusic);


        }
    }
}
