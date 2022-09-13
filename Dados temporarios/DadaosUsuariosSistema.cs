using MySql.Data.MySqlClient;
using SistemaVendas_Versao3.Banco_de_dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas_Versao3.Banco_de_dados
{
    public class DadaosUsuariosSistema
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string s_nome { get; set; }
        public string email { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string contato { get; set; }
        public string rua_av { get; set; }
        public string bairro { get; set; }
        public string numero_casa { get; set; }
        public string sexo { get; set; }
        public string usuario_tipo { get; set; }
        public DateTime add_data { get; set; }
        public int add_por { get; set; }
    }
    

    }

