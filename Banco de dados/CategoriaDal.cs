using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVendas_Versao3.Dados_temporarios;
using System.Data;
using MySql.Data.MySqlClient;

namespace SistemaVendas_Versao3.Banco_de_dados
{
     public class CategoriaDal
    {
        bool autentcado = false;
        string Sql;
        DataTable dt = new DataTable();
        public DataTable select() 
        { 
            Classe_Conexao _Conexao = new Classe_Conexao();
            try
            {

                Sql = "SELECT id_categoria AS ID, titulo AS Titulo, decricao AS Descrição, add_data AS Datas, add_por AS Adicionado_por FROM tb_categoria ";
               
                MySqlCommand cmd = new MySqlCommand(Sql, _Conexao.conectar());
               
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);   
                
            
               
                adapter.Fill(dt);
               
       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                _Conexao.desconectar();
            }
            return dt;
        }
        public bool Inserir(DadosCategoria dadosCategoria)
        {
            Classe_Conexao _Conexao = new Classe_Conexao();
            try
            {
                Sql = "INSERT INTO tb_categoria (id_categoria,titulo,decricao, add_data,add_por)VALUES(@id_categoria, @titulo, @decricao, @add_data, @add_por)";

                MySqlCommand cmd = new MySqlCommand(Sql, _Conexao.conectar());
                
                cmd.Parameters.AddWithValue("@id_categoria", dadosCategoria.Id);

                cmd.Parameters.AddWithValue("@titulo", dadosCategoria.Titulo);

                cmd.Parameters.AddWithValue("@decricao", dadosCategoria.Descricao);

                cmd.Parameters.AddWithValue("@add_data", dadosCategoria.Add_data);

                cmd.Parameters.AddWithValue("@add_por", dadosCategoria.Add_por);
               
               int linha =  cmd.ExecuteNonQuery();
              
                if (linha > 0)
                {
                    autentcado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return autentcado;
        }

    }
}
