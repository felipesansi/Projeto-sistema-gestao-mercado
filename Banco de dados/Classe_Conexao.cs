using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas_Versao3.Banco_de_dados
{
    public class Classe_Conexao
    {
      private MySqlConnection cn = new MySqlConnection();

        public Classe_Conexao()
        {
            cn.ConnectionString = "server = Localhost; port =3306; uid = root; database = banco_sistema_vendas";
        }

        public MySqlConnection conectar()
        {
            if (cn.State ==System.Data.ConnectionState.Closed)
            {
                cn.Open();

            }

            return cn;

        }
        public MySqlConnection desconectar()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();

            }

            return cn;



        }
    }
}
