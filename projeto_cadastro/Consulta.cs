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

    public partial class frmConsulta : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        String strSQL;
        public frmConsulta()
        {
            InitializeComponent();
        }

            frmHome Home;

        public frmConsulta(frmHome Home)
        {
            this.Home = Home;
            InitializeComponent();
        }


        private void frmConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                //Sintaxe das informações do banco que será conectado.
                conexao = new MySqlConnection("server = localhost; database = projeto; uid = root; pwd =; port = 3306");

                //Comando SQL para inserção dos dados e criando parametros para cada uma das colunas do banco.
                strSQL = "SELECT * FROM PROJETO";

                comando = new MySqlCommand(strSQL, conexao);

                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);
                dgvConsulta.DataSource = dt;

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
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            string codigoCliente;
            codigoCliente = dgvConsulta.CurrentRow.Cells[0].Value.ToString();
            
            conexao = new MySqlConnection("server = localhost; database = projeto; uid = root; pwd =; port = 3306");
            
            dr = null;

            strSQL = "SELECT * FROM PROJETO WHERE cad_id=@ID";
            try
            {                
                conexao.Open();
                comando = new MySqlCommand(strSQL, conexao);
                

                comando.Parameters.AddWithValue("@ID", Convert.ToInt32(codigoCliente));

                dr = comando.ExecuteReader();
                

                if (dr.Read())
                {
                    
                    Home.txtNome.Text = dr["cad_name"].ToString();
                    Home.cbbSex.Text = dr["cad_sex"].ToString();
                    Home.txtIdade.Text = dr["cad_idade"].ToString();
                    Home.cbbUF.Text = dr["cad_UF"].ToString();
                    Home.cbbFilme.Text = dr["cad_filme"].ToString();
                    Home.cbbMusica.Text = dr["cad_musica"].ToString();
                }
                comando.ExecuteNonQuery();
            }
            catch (Exception trataErro)
            {
                MessageBox.Show(trataErro.Message, "Erro na Seleção dos Dados - Cliente");
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
            this.Close();
        }

    }
}

