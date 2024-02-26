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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tblrec
{
    public partial class tlogin : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        int tentativas = 1;

        public tlogin()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bdrec;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void buttonentrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT usuario, senha FROM tblrec WHERE usuario = '" + textBoxusuario.Text + "' AND senha = '" + textBoxsenha.Text + "';";

                MySqlDataReader resultado = comando.ExecuteReader();


                if (resultado.Read())
                {
                    this.Hide();
                    Form telamenu = new tmenu();
                    telamenu.Closed += (s, args) => this.Close();
                    telamenu.Show();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou Senha incorretos!\n\nVocê usou " + tentativas + "/3 Tentativas" );
                    tentativas++;
                }
                
                if (tentativas > 3)
                {
                    MessageBox.Show("Acesso Negado!");
                    this.Close();
                }


            }
            catch (Exception erro_mysql)
            {
                //MessageBox.Show(erro_mysql.Message);
                MessageBox.Show("Erro de Sistema. Informe o suporte");

            }
            finally
            {
                conexao.Close();
            }
        }

        
    }
}
