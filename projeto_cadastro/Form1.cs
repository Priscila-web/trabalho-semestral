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
        String strSQL;

        public frmHome()
        {
            InitializeComponent();
        }           

        private void button1_Click(object sender, EventArgs e)
        {
            //Criando variaveis para receber os valores do formulario.
            string nomeUsu, sexoUsu, ufUsu, favFilm, favMusic;
            int idadeUsu;

            nomeUsu = txtNome.Text;
            idadeUsu = Convert.ToInt32(txtIdade.Text);
            sexoUsu = cbbSex.Text;
            ufUsu = cbbUF.Text;
            favFilm = cbbFilme.Text;
            favMusic = cbbMusica.Text;

            //O programa vai verificar se existe algum campo em branco, caso sim o mesmo vai retornar uma mensagem avisando e não irá adicionar o registro no banco.
            if (string.IsNullOrEmpty(nomeUsu) || string.IsNullOrEmpty(sexoUsu) || string.IsNullOrEmpty(ufUsu) || string.IsNullOrEmpty(favFilm) || string.IsNullOrEmpty(favMusic))
            {
                MessageBox.Show("Um dos campos para inclusão está vazio", "Inclusão de Dados - Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Aqui vou dar o tratamento para os dados vindos do Front
            try
            {
                //Sintaxe das informações do banco que será conectado.
                conexao = new MySqlConnection("server = localhost; database = projeto; uid = root; pwd =; port = 3306");

                //Comando SQL para inserção dos dados e criando parametros para cada uma das colunas do banco.
                strSQL = "INSERT INTO PROJETO (cad_name,cad_sex,cad_idade,cad_UF,cad_filme,cad_musica) VALUES(@NOME,@SEXO,@IDADE,@UF,@FILME,@MUSICA)";

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
                //Em caso de erro uma mensagem com o erro será exibido ao Usuario.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Fechando a conexão com o Banco de dados.
                conexao.Close();
                conexao = null;
                comando = null;

                //Os campos serão limpos para o proximo cadastro e o cursor será posicionado no campo Nome.
                txtID.Clear();
                txtNome.Clear();
                txtIdade.Clear();
                cbbFilme.Text = string.Empty;
                cbbMusica.Text = string.Empty;
                cbbSex.Text = string.Empty;
                cbbUF.Text = string.Empty;
                txtNome.Focus();
            }
        }       
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                //Sintaxe das informações do banco que será conectado.
                conexao = new MySqlConnection("server = localhost; database = projeto; uid = root; pwd =; port = 3306");

                //Comando SQL para inserção dos dados e criando parametros para cada uma das colunas do banco.
                strSQL = "UPDATE PROJETO SET cad_name =@NOME,cad_sex=@SEXO,cad_idade=@IDADE,cad_UF=@UF,cad_filme=@FILME,cad_musica=@MUSICA WHERE cad_id=@ID";

                //Criando variaveis para receber os valores do formulario.
                string nomeUsu, sexoUsu, ufUsu, favFilm, favMusic;
                int idadeUsu, idUsu;

                idUsu = Convert.ToInt32(txtID.Text);        
                nomeUsu = txtNome.Text;
                idadeUsu = Convert.ToInt32(txtIdade.Text);
                sexoUsu = cbbSex.Text;
                ufUsu = cbbUF.Text;
                favFilm = cbbFilme.Text;
                favMusic = cbbMusica.Text;


                //referenciando parametros criados a partir das colunas com as variaveis respectivas do formulario.
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", idUsu);
                comando.Parameters.AddWithValue("@NOME", nomeUsu);
                comando.Parameters.AddWithValue("@SEXO", sexoUsu);
                comando.Parameters.AddWithValue("@IDADE", idadeUsu);
                comando.Parameters.AddWithValue("@UF", ufUsu);
                comando.Parameters.AddWithValue("@FILME", favFilm);
                comando.Parameters.AddWithValue("@MUSICA", favMusic);

                //Abrindo conexão com o banco, executando o comando INSERT que foi declarado acima e exibindo ao usuario mensagem de Cadastro bem sucedido.
                conexao.Open();
                comando.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                //Em caso de falha na operação é exibido uma janela com o erro para o usuario
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Fecha a conexão com o banco
                conexao.Close();
                conexao = null;
                comando = null;

                MessageBox.Show("Pessoa alterada!");

                //Após realizado a operação com sucesso ele limpa os campos e reposiciona o cursor para o campo txtNome.
                txtID.Clear();
                txtNome.Clear();
                txtIdade.Clear();
                cbbFilme.Text = string.Empty;
                cbbMusica.Text = string.Empty;
                cbbSex.Text = string.Empty;
                cbbUF.Text = string.Empty;
                txtNome.Focus();
            }
        }
               
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Sintaxe das informações do banco que será conectado.
                conexao = new MySqlConnection("server = localhost; database = projeto; uid = root; pwd =; port = 3306");

                //Comando SQL para e exclusão de registros
                strSQL = "DELETE FROM PROJETO WHERE cad_id=@ID";
                
                //Variavel criada para receber o campo de texto ID criado na parte de Design
                int idUsu;
                idUsu = Convert.ToInt32(txtID.Text);
                
                //Indica ao banco e ao c# por sobre qual parametro deve relizar a operação de exclusão
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", idUsu);

                //Abertura de conexão com o banco e execução do comando SQL declarado
                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Pessoa excluida");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Fecha conexão com banco
                conexao.Close();
                conexao = null;
                comando = null;

                //limpa os campos logo após fazer a exclusão do banco.
                txtID.Clear();
                txtNome.Clear();
                txtIdade.Clear();
                cbbFilme.Text = string.Empty;
                cbbMusica.Text = string.Empty;
                cbbSex.Text = string.Empty;
                cbbUF.Text = string.Empty;
                txtNome.Focus();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtID.Enabled = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void habilitarCampoIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtID.Focus();
        }

        private void maisOpçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {       
            //Habilita botões de exclusão de de alteração, e posiciona o cursor na text box ID 
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            txtID.Enabled = true;
            txtID.Focus();
        }

        private void frmHome_Load(object sender, EventArgs e) 
        {

        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Faz o chamado do form que realizara as consultas dos registros que estão no banco
            frmConsulta frm = new frmConsulta(this);
            frm.ShowDialog();                
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
        
            //Limpa os campos preenchidos
            txtID.Clear();
            txtNome.Clear();
            txtIdade.Clear();
            cbbFilme.Text = string.Empty;
            cbbMusica.Text = string.Empty;
            cbbSex.Text = string.Empty;
            cbbUF.Text = string.Empty;
            txtNome.Focus();
        }
    }
}
