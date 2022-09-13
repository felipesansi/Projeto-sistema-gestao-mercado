using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVendas_Versao3.Dados_temporarios;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaVendas_Versao3.Banco_de_dados
{
    public class LoginDal
    {
        bool login_existente = false;

        DataTable dt = new DataTable();
        Classe_Conexao conexao = new Classe_Conexao();
        public string mensagem = "";
        String SQL;



        public bool Verificar_Banco(DadosLogin L)
        {

        
            try
            {

                 SQL = "SELECT * FROM tb_usuario where usuario = @usuario AND senha = @senha AND usuario_tipo = @usuario_tipo";
                MySqlCommand cmd = new MySqlCommand(SQL, conexao.conectar());
                cmd.Parameters.AddWithValue("@usuario", L.User);
                cmd.Parameters.AddWithValue("@senha", L.Senha);
                cmd.Parameters.AddWithValue("@usuario_tipo", L.User_tipo);

               
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                if (dt.Rows .Count > 0)
                {
                    login_existente = true;

                }
                else
                {
                    login_existente = false;
                    mensagem = "Não existe estes dados no sistema.";
                }
            }
            catch (Exception ex)
            {

                mensagem = "Problemas com Banco de dados";
                MessageBox.Show(mensagem);
            }
            finally
            {
                conexao.desconectar();
            }
            return login_existente;
        }
    }
}
