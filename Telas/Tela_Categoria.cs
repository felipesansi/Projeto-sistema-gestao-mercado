using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVendas_Versao3.Dados_temporarios;
using SistemaVendas_Versao3.Banco_de_dados;

namespace SistemaVendas_Versao3.Telas
{
    public partial class Tela_Categoria : Form
    {
        public Tela_Categoria()
        {
            InitializeComponent();
        }

        DadosCategoria dadosCategoria = new DadosCategoria();
        CategoriaDal categoriaDal = new CategoriaDal();
        DataTable dt = new DataTable();
        private void Btn_fechar_tela_categorias_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cadastrar_categoria_Click(object sender, EventArgs e)
        {

            dadosCategoria.Titulo = Tbx_Titulo_categoria.Text;
            dadosCategoria.Descricao = Tbx_Descricao_categoria.Text;
            dadosCategoria.Add_data = DateTime.Now;
            dadosCategoria.Add_por = 1;
            bool sucesso = categoriaDal.Inserir(dadosCategoria);
            if (sucesso)
            {
                MessageBox.Show("Cadastro realizado de Categoria com sucesso", "Messagem de sucesso", MessageBoxButtons.OK,MessageBoxIcon.Information);
              
                dt = categoriaDal.select();
                Dgv_categoria.DataSource = dt;
            }
        }
    }
}
