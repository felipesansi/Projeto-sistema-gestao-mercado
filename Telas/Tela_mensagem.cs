using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas_Versao3.Telas
{
    public partial class Tela_mensagem : Form
    {
        public Tela_mensagem()
        {
            InitializeComponent();
        }
        Tela_mensagem tela_Mensagem = new Tela_mensagem();

        private void Btn_tela_mensagem_Click(object sender, EventArgs e)
        {

            tela_Mensagem.Hide();
            tela_Mensagem.Close();
        }
    }
}
