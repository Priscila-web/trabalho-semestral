using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projeto_cadastro
{
    public partial class frmHome : Form
    {
        //Aqui estou "repassando" os comandos MySql para variaveis.
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        String strSQL;

        public frmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //Aqui vou dar o tratamento para os dados vindos do Front
            try
            {
                //Sintaxe das informações do banco que será conectado.
                conexao = new MySqlConnection("server = localhost; database = projeto; uid = root; pwd =; port = 3306");
                
                //Comando SQL para inserção dos dados e criando parametros para cada uma das colunas do banco.
                strSQL = "INSERT INTO PROJETO (cad_name,cad_sex,cad_idade,cad_UF,cad_filme,cad_musica) VALUES(@NOME,@SEXO,@IDADE,@UF,@FILME,@MUSICA)";

                //Criando variaveis para receber os valores do formulario.
                string nomeUsu, sexoUsu, ufUsu, favFilm, favMusic;
                int idadeUsu;

                nomeUsu = txtNome.Text;
                idadeUsu = Convert.ToInt32(txtIdade.Text);
                sexoUsu = cbbSex.Text;
                ufUsu = cbbUF.Text;
                favFilm = cbbFilme.Text;
                favMusic = cbbMusica.Text;

                //referenciando parametros criados a partir das colunas com as variaveis respectivas do formulario.
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOME", nomeUsu);
                comando.Parameters.AddWithValue("@SEXO", sexoUsu);
                comando.Parameters.AddWithValue("@IDADE", idadeUsu);
                comando.Parameters.AddWithValue("@UF", ufUsu);
                comando.Parameters.AddWithValue("@FILME", favFilm);
                comando.Parameters.AddWithValue("@MUSICA", favMusic);

                //Abrindo conexão com o banco, executando o comando INSERT que foi declarado acima e exibindo ao usuario mensagem de Cadastro bem sucedido.
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Pessoa cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
          /*MessageBox.Show("Nome:" + nomeUsu);
            MessageBox.Show("Idade:" + idadeUsu);
            MessageBox.Show("Sexo:" + sexoUsu);
            MessageBox.Show("UF:" + ufUsu);
            MessageBox.Show("Tipo de Filme Favorito:" + favFilm);
            MessageBox.Show("Genero Musical Favorito:" + favMusic);*/


        }
    }
}
