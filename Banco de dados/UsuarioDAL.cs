using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SistemaVendas_Versao3.Banco_de_dados
{

    public class UsuarioDAL
    {
       
        


        public DataTable Select()
        {
            Classe_Conexao classe_Conexao = new Classe_Conexao();
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT id_usuario AS ID, nome AS Nome,  s_nome AS Sobrenome, sexo AS Sexo, email AS Email,usuario AS Usuário, senha AS Senha," +
                    "contato AS Contato, rua_av AS Endereço,numero_casa AS NúmeroDaCasa, bairro AS Bairro,usuario_tipo AS AutorizaçãoUsuário, add_data AS Cadastrado,add_por AS Adicionado FROM tb_usuario";
                MySqlCommand cmd = new MySqlCommand(sql, classe_Conexao.conectar());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                classe_Conexao.desconectar();

            }
            return dt;
        }



        public DataTable Pequisar_usuario(string pequisarPa )
        {
            Classe_Conexao classe_Conexao = new Classe_Conexao();
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tb_usuario where id_usuario LIKE '%"+pequisarPa+"%' or nome LIKE '%"+pequisarPa+"%' or s_nome like'%"+pequisarPa+"%'";

                MySqlCommand cmd = new MySqlCommand(sql, classe_Conexao.conectar());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                classe_Conexao.desconectar();

            }
            return dt;
        }



        public bool inserir(DadaosUsuariosSistema u )
          {
              bool autenticado = false;
              Classe_Conexao conexao = new Classe_Conexao();
              try
              {
                  String sql = "insert into tb_usuario(nome, s_nome ,email ,usuario  ,senha ," +
                      "contato ,rua_av ,bairro ,numero_casa,sexo ,usuario_tipo,add_data ,add_por )" +
                      "values(@nome, @s_nome ,@email ,@usuario  ,@senha ,@contato ,@rua_av ,@bairro ,@numero_casa," +
                      " @sexo ,@usuario_tipo, @add_data , @add_por)";
                  MySqlCommand cmd = new MySqlCommand(sql, conexao.conectar());

                  cmd.Parameters.AddWithValue("@nome",u.nome);
                 
                cmd.Parameters.AddWithValue("@s_nome",u.s_nome);
                 
                cmd.Parameters.AddWithValue("@email", u.email);
                 
                cmd.Parameters.AddWithValue("@usuario",u.usuario);
                 
                cmd.Parameters.AddWithValue("@senha",u.senha);
                 
                cmd.Parameters.AddWithValue("@contato",u.contato);
                 
                cmd.Parameters.AddWithValue("@rua_av",u.rua_av);
                 
                cmd.Parameters.AddWithValue("@bairro",u.bairro);
                 
                cmd.Parameters.AddWithValue("@numero_casa",u.numero_casa);
                 
                cmd.Parameters.AddWithValue("@sexo",u.sexo);
                 
                cmd.Parameters.AddWithValue("@usuario_tipo",u.usuario_tipo);
                 
                cmd.Parameters.AddWithValue("@add_data",u.add_data);
                 
                cmd.Parameters.AddWithValue("@add_por",u.add_por);
                
                int rows = cmd.ExecuteNonQuery();

                  if (rows >0)
                  {
                      autenticado = true;

                  }
                  else
                  {
                      autenticado = false;
                  }


              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);

              }finally
              {
                  conexao.desconectar();
              }
              return autenticado; 
          }

         public bool Atualizar(DadaosUsuariosSistema u)
          {
              bool autenticado = false;
              Classe_Conexao conexao = new Classe_Conexao();
              try
              {
                  String sql = "UPDATE tb_usuario SET nome = @nome, s_nome = @s_nome, email = @email, usuario = @usuario, senha = @senha ," +
                "contato = @contato, rua_av = @rua_av, bairro = @bairro, numero_casa = @numero_casa, sexo = @sexo, usuario_tipo =@usuario_tipo, " +
                "add_data = @add_data, add_por = @add_por WHERE id_usuario = @id_usuario ";


                  MySqlCommand cmd = new MySqlCommand(sql, conexao.conectar());
                  cmd.Parameters.AddWithValue("@id_usuario",u.id);
                  cmd.Parameters.AddWithValue("@nome", u.nome);
                  cmd.Parameters.AddWithValue("@s_nome", u.s_nome);
                  cmd.Parameters.AddWithValue("@email", u.email);
                  cmd.Parameters.AddWithValue("@usuario", u.usuario);
                  cmd.Parameters.AddWithValue("@senha", u.senha);
                  cmd.Parameters.AddWithValue("@contato", u.contato);
                  cmd.Parameters.AddWithValue("@rua_av", u.rua_av);
                  cmd.Parameters.AddWithValue("@bairro", u.bairro);
                  cmd.Parameters.AddWithValue("@numero_casa", u.numero_casa);
                  cmd.Parameters.AddWithValue("@sexo", u.sexo);
                  cmd.Parameters.AddWithValue("@usuario_tipo", u.usuario_tipo);
                  cmd.Parameters.AddWithValue("@add_data", u.add_data);
                  cmd.Parameters.AddWithValue("@add_por", u.add_por);
                  int rows = cmd.ExecuteNonQuery();




              }catch (Exception ex)
              {
                MessageBox.Show(ex.Message);
            }
            finally
              {
                conexao.desconectar();
              }
              return autenticado;
          }









        public bool DELETAR(DadaosUsuariosSistema u)
        {
            bool autenticado = false;
            Classe_Conexao conexao = new Classe_Conexao();
            try
            {
                String sql = "DELETE FROM tb_usuario  WHERE id_usuario = @id_usuario ";


                MySqlCommand cmd = new MySqlCommand(sql, conexao.conectar());
                cmd.Parameters.AddWithValue("@id_usuario", u.id);
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@s_nome", u.s_nome);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@usuario", u.usuario);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@contato", u.contato);
                cmd.Parameters.AddWithValue("@rua_av", u.rua_av);
                cmd.Parameters.AddWithValue("@bairro", u.bairro);
                cmd.Parameters.AddWithValue("@numero_casa", u.numero_casa);
                cmd.Parameters.AddWithValue("@sexo", u.sexo);
                cmd.Parameters.AddWithValue("@usuario_tipo", u.usuario_tipo);
                cmd.Parameters.AddWithValue("@add_data", u.add_data);
                cmd.Parameters.AddWithValue("@add_por", u.add_por);
                int rows = cmd.ExecuteNonQuery();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.desconectar();
            }
            return autenticado;
        }




    }
}

