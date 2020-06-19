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
        frmHome Home;
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        String strSQL;
        
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
                //Caminho do banco.
                conexao = new MySqlConnection("server = localhost; database = projeto; uid = root; pwd =; port = 3306");

                //Comando SQL para exibir registros.
                strSQL = "SELECT * FROM PROJETO";
                comando = new MySqlCommand(strSQL, conexao);
                da = new MySqlDataAdapter(strSQL, conexao);

                //faz uma cópia dos registros do banco no DataGridView
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvConsulta.DataSource = dt;

                //Deixa as linhas com uma cor sim e outra não
                dgvConsulta.RowsDefaultCellStyle.BackColor = Color.White;
                dgvConsulta.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine;
                dgvConsulta.Columns[0].HeaderCell.Value = "Codigo";
                dgvConsulta.Columns[1].HeaderCell.Value = "Nome";
                dgvConsulta.Columns[2].HeaderCell.Value = "Sexo";
                dgvConsulta.Columns[3].HeaderCell.Value = "Idade";
                dgvConsulta.Columns[4].HeaderCell.Value = "UF";
                dgvConsulta.Columns[5].HeaderCell.Value = "Filme";
                dgvConsulta.Columns[6].HeaderCell.Value = "Musica";

            }
            catch (Exception ex)
            {
                //Em caso de erro uma mensagem será exibida
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Após exibir resultados a conexão com o banco é fechada
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
                    Home.txtID.Text = dr["cad_id"].ToString();
                    Home.txtNome.Text = dr["cad_name"].ToString();
                    Home.cbbSex.Text = dr["cad_sex"].ToString();
                    Home.txtIdade.Text = dr["cad_idade"].ToString();
                    Home.cbbUF.Text = dr["cad_UF"].ToString();
                    Home.cbbFilme.Text = dr["cad_filme"].ToString();
                    Home.cbbMusica.Text = dr["cad_musica"].ToString();
                }
                comando.ExecuteNonQuery();
                dr.Close();
            }
            catch (Exception trataErro)
            {
                MessageBox.Show(trataErro.Message, "Erro na Seleção dos Dados - Cliente");
            }
            finally
            {
               
                conexao.Close();
                conexao = null;
                comando = null;
            
            }            
        }
    }
}

