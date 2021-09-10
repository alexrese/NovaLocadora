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

namespace NovaLocadora
{
    public partial class FormLocadora : Form
    {
        public FormLocadora()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "locadora";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void FormLocadora_Load(object sender, EventArgs e)
        {
            atualizaGrid();
            dgLocadora.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10);
        }

        private void atualizaGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM filme WHERE ativoFilme = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgLocadora.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgLocadora.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//DESCRICAO
                    row.Cells[3].Value = reader.GetString(3);//CATEGORIA
                    row.Cells[4].Value = reader.GetString(4);//ANO
                    dgLocadora.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();

        }

        private void limparCampos()
        {
            tbID.Clear();
            tbAno.Clear();
            tbNome.Clear();
            tbCategoria.Clear();
            tbDescricao.Clear();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
             
                comandoMySql.CommandText = "INSERT INTO filme (nomeFilme,categoriaFilme,descricaoFilme,anoFilme) " +
                    "VALUES('" + tbNome.Text + "', '" + tbCategoria.Text + "','" + tbDescricao.Text + "', " + Convert.ToInt16(tbAno.Text) + ")";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Inserido com sucesso");
                atualizaGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE filme SET nomeFilme = '" + tbNome.Text + "', " +
                    "descricaoFilme = '" + tbDescricao.Text + "', " +
                    "categoriaFilme = '" + tbCategoria.Text + "', " +
                    "anoFilme = " + Convert.ToInt16(tbAno.Text) +
                    " WHERE idFilme = " + tbID.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso"); //Exibo mensagem de aviso
                atualizaGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                // "DELETE FROM filme WHERE idFilme = "+ textBoxId.Text +""
                //comandoMySql.CommandText = "DELETE FROM filme WHERE idFilme = " + tbID.Text + "";
                comandoMySql.CommandText = "UPDATE filme SET ativoFilme = 0 WHERE idFilme = " + tbID.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Deletado com sucesso"); //Exibo mensagem de aviso
                atualizaGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void dgLocadora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgLocadora.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgLocadora.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                tbNome.Text = dgLocadora.Rows[e.RowIndex].Cells["colNome"].FormattedValue.ToString();
                tbCategoria.Text = dgLocadora.Rows[e.RowIndex].Cells["colCategoria"].FormattedValue.ToString();
                tbDescricao.Text = dgLocadora.Rows[e.RowIndex].Cells["colDescricao"].FormattedValue.ToString();
                tbAno.Text = dgLocadora.Rows[e.RowIndex].Cells["colAno"].FormattedValue.ToString();
                tbID.Text = dgLocadora.Rows[e.RowIndex].Cells["colID"].FormattedValue.ToString();
            }
        }
    }
}
