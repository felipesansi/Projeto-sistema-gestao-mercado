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


namespace SistemaVendas_Versao3.Telas
{
    public partial class Tela_cadastro_usuarios : Form
    {
        public Tela_cadastro_usuarios()
        {
            InitializeComponent();
           
        }

        DadaosUsuariosSistema usuariosSistema = new DadaosUsuariosSistema();
        UsuarioDAL UsuarioDAL = new UsuarioDAL();
        DataTable dt = new DataTable();


        private void Tela_cadastro_usuarios_Load(object sender, EventArgs e)
        {
          dt = UsuarioDAL.Select();
            Dgv_usuario.DataSource = dt;
        }

        private void Btn_fechar_tela_usuario_Click(object sender, EventArgs e)
        {
            Tela_principal tela_Principal = new Tela_principal();
            if (MessageBox.Show("Deseja realmente fechar está tela ?", "Fechar tela...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
                tela_Principal.aberta = false;


            }
        }

        private void Btn_Cadastrar_user_Click(object sender, EventArgs e)
        {
         
            if (Tbx_nome.Text == string.Empty||Tbx_S_nome.Text == string.Empty || Tbx_email.Text == string.Empty || Tbx_usuario.Text== string.Empty ||
             Tbx_S_nome.Text == string.Empty || Masc_contato.Text == string.Empty||Tbx_rua_av.Text ==string.Empty|| Tbx_bairro.Text == string.Empty ||
             Tbx_numero_casa.Text == string.Empty||Cbx_sexo.Text == string.Empty ||Cbx_tipo_usuario.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os Campos","Mensagem de Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (Tbx_senha.Text.Length <4)
            {
                MessageBox.Show("O campo Senha deve ter no mínimo 4 caracteres", "Mensagem de Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Tbx_usuario.Text.Length <4 )
            {

                MessageBox.Show("O campo Usuário deve ter no mínimo 4 caracteres", "Mensagem de Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else{
                usuariosSistema.nome = Tbx_nome.Text;

                usuariosSistema.s_nome = Tbx_S_nome.Text;

                usuariosSistema.email = Tbx_email.Text;

                usuariosSistema.usuario = Tbx_usuario.Text;

                usuariosSistema.senha = Tbx_senha.Text;

                usuariosSistema.contato = Masc_contato.Text;

                usuariosSistema.rua_av = Tbx_rua_av.Text;

                usuariosSistema.bairro = Tbx_bairro.Text;

                usuariosSistema.numero_casa = Tbx_numero_casa.Text;

                usuariosSistema.sexo = Cbx_sexo.Text;
                
                usuariosSistema.usuario_tipo = Cbx_tipo_usuario.Text;

                usuariosSistema.add_data = DateTime.Now;

                usuariosSistema.add_por = 1;


                bool sucesso = UsuarioDAL.inserir(usuariosSistema);
                if (sucesso)
                {
                    MessageBox.Show("Cadastro realizado com sucesso", "Mensagem de sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = UsuarioDAL.Select();
                    Dgv_usuario.DataSource = dt;
                }
                else
                {

                    MessageBox.Show("Cadastro não realizado", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private void Dgv_usuario_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int clicado = e.RowIndex;
            
            Tbx_id.Text = Dgv_usuario.Rows[clicado].Cells[0].Value.ToString();
            
            Tbx_nome.Text = Dgv_usuario.Rows[clicado].Cells[1].Value.ToString();
            
            Tbx_S_nome.Text = Dgv_usuario.Rows[clicado].Cells[2].Value.ToString();
           
            Cbx_sexo.Text = Dgv_usuario.Rows[clicado].Cells[3].Value.ToString();

            Tbx_email.Text = Dgv_usuario.Rows[clicado].Cells[4].Value.ToString();


            
           
            Tbx_usuario.Text = Dgv_usuario.Rows[clicado].Cells[5].Value.ToString();
           
            Tbx_senha.Text = Dgv_usuario.Rows[clicado].Cells[6].Value.ToString();
           
            Masc_contato.Text= Dgv_usuario.Rows[clicado].Cells[7].Value.ToString();
          
            Tbx_rua_av.Text = Dgv_usuario.Rows[clicado].Cells[8].Value.ToString();

            Tbx_numero_casa.Text = Dgv_usuario.Rows[clicado].Cells[9].Value.ToString();

            Tbx_bairro.Text = Dgv_usuario.Rows[clicado].Cells[10].Value.ToString();


            Cbx_tipo_usuario.Text = Dgv_usuario.Rows[clicado].Cells[11].Value.ToString();

            
        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
          if (Dgv_usuario.SelectedRows.Count>0)
            {
                usuariosSistema.id = Convert.ToInt32(Tbx_id.Text);

                usuariosSistema.nome = Tbx_nome.Text;
                usuariosSistema.s_nome = Tbx_S_nome.Text;
                usuariosSistema.email = Tbx_email.Text;
                usuariosSistema.usuario = Tbx_usuario.Text;
                usuariosSistema.senha = Tbx_senha.Text;
                usuariosSistema.contato = Masc_contato.Text;
                usuariosSistema.rua_av = Tbx_rua_av.Text;
                usuariosSistema.bairro = Tbx_bairro.Text;
                usuariosSistema.numero_casa = Tbx_numero_casa.Text;
                usuariosSistema.sexo = Cbx_sexo.Text;
                usuariosSistema.usuario_tipo = Cbx_tipo_usuario.Text;
                usuariosSistema.add_data = DateTime.Now;
                usuariosSistema.add_por = 1;

                bool sucesso = false;
                sucesso = UsuarioDAL.Atualizar(usuariosSistema);
                if (sucesso)
                {
                    MessageBox.Show("Cadastro não Atualizado", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    MessageBox.Show("Cadastro Atualizado com sucesso ", "Mensagem de Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = UsuarioDAL.Select();
                    Dgv_usuario.DataSource = dt;

                }
            }
            else
            {
                MessageBox.Show("Escolha a fila de Usuário que deseja Atualizar","Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
            
           
        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            if (Dgv_usuario.SelectedRows.Count>0)
            {
                usuariosSistema.id = Convert.ToInt32(Tbx_id.Text);


                bool sucesso;
                if (MessageBox.Show("Deseja realmente deletar esse usuário ou admistrador?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.No) 
                {
                    return;
                }
                else
                {
                    sucesso = UsuarioDAL.DELETAR(usuariosSistema);
                }
           
                if (sucesso)
                {
                    MessageBox.Show("Cadastro não Atualizado", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    MessageBox.Show("Cadastro Deletado com sucesso " + usuariosSistema.id.ToString(), "Mensagem de Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = UsuarioDAL.Select();
                    Dgv_usuario.DataSource = dt;

                }
            }
            else
            {
                MessageBox.Show("Escolha a fila de Usuário que deseja Deletar", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
           
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            Btn_atualizar.Enabled = true;
            Btn_atualizar.Visible = true;
            Lateral_Btn_atualizar.Visible = true;
            Btn_deletar.Enabled = true;
            Btn_deletar.Visible = true;
            Lateral_Btn_deletar.Visible = true;
            Btn_Cadastrar_user.Enabled = false;
            Btn_editar.Enabled = false;

        }

        private void Tbx_pesquisar_user_TextChanged(object sender, EventArgs e)
        {

            string pequisar =Tbx_pesquisar_user.Text;
            if (pequisar!=null)
            {
                dt = UsuarioDAL.Pequisar_usuario(pequisar);
                Dgv_usuario.DataSource = dt;
            }

        }
    }
    }

