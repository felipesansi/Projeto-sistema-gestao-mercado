using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVendas_Versao3.Banco_de_dados;
using SistemaVendas_Versao3.Dados_temporarios;
namespace SistemaVendas_Versao3.Telas
{
    public partial class Tela_Entrar : Form
    {
        public Tela_Entrar()
        {
            InitializeComponent();
            Btn_login.BackColor = SystemColors.ActiveCaption;
            Thread t1;
            
          
            
        }
        LoginDal loginDal = new LoginDal();

        DadosLogin dadosLogin = new DadosLogin();
       

        private void Btn_login_Click(object sender, EventArgs e)
        {

        }

        private void Btn_fechar_tela_entrar_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            if (Txb_senha_entrar.Text == String.Empty || Tbx_usuario_Entrar.Text == String.Empty || Cbx_entrar.Text == String.Empty)
            {
                label2.Text = "Preencha todos os Campos";
            }
            else
            {
                dadosLogin.User = Tbx_usuario_Entrar.Text.Trim();
                dadosLogin.Senha = Txb_senha_entrar.Text.Trim();
               dadosLogin.User_tipo = Cbx_entrar.Text.Trim();
                DadaosUsuariosSistema usuariosSistema = new DadaosUsuariosSistema();
                bool Autenticado = loginDal.Verificar_Banco(dadosLogin);

                if (Autenticado)
                {




                    switch (dadosLogin.User_tipo)
                    {
                        case "Adiministrador":
                            MessageBox.Show("Seja-Bem vindo adiminstrador(a)", "Oi do Sistema...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Tela_principal tela_Principal = new Tela_principal();
                            tela_Principal.Show();
                            this.Hide();

                            break;


                        case "Funcionario(a)":
                            MessageBox.Show("Seja-Bem vindo funcionario(a)", "Oi do Sistema...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Tela_principal_funcionarios _Principal_Funcionarios = new Tela_principal_funcionarios();
                            _Principal_Funcionarios.Show();
                            this.Hide();
                            break;


                        default:
                            label2.Text = "Login ou Senha incorretos";
                            break;
                    }

                }
                else
                { 
                    label2.Text = loginDal.mensagem;
                }
            }
            


        }

        private void Btn_Mostrar_senha_Click(object sender, EventArgs e)
        {
            if (Txb_senha_entrar.UseSystemPasswordChar)
            {
                Txb_senha_entrar.UseSystemPasswordChar = false;
                Txb_senha_entrar.Focus();
            }
            else
            {

                Txb_senha_entrar.UseSystemPasswordChar = true;
                Txb_senha_entrar.Focus();
            }
        }
    }
}
