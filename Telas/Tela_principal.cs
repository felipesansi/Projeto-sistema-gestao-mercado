
using System;
using SistemaVendas_Versao3.Telas;
namespace SistemaVendas_Versao3

{
    public partial class Tela_principal : Form
    {
        Form janela_filho = new Form();
        public Tela_principal()
        {
            InitializeComponent();
        }

        private void Painel_Pricipal_Paint(object sender, PaintEventArgs e)
        {

        }



        // MÉTODO DE REDIMENSIONAMENTO PARA REDIMENTAR / ALTERAR O TAMANHO PARA FORMATO NO TEMPO DE EXECUÇÃO ----------------------------------- -----------------------

        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        // ---------------- DESENHO RETANGLE / EXCLUIR PAINEL DE CANTO
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.Painel_Pricipal.Region = region;
            this.Invalidate();
        }
        // ---------------- COR E GRIP RETÂNGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(36, 48, 60));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Black, sizeGripRectangle);


        }

        private void Btn_Encerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Encerrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Sair ", "Desligar...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
                Tela_Entrar tela_Entrar = new Tela_Entrar();
                tela_Entrar.Show();
            }

        }




        public void Deativar_botoes()
        {
            Btn_Usuario.Enabled = false;
            Btn_Categoria.Enabled = false;
            Btn_Produto.Enabled = false;
            Btn_Caixa.Enabled = false;
            Btn_Transacoes.Enabled = false;
        }

        public void Ativar_botoes()
        {
            Btn_Usuario.Enabled = true;
            Btn_Categoria.Enabled = true;
            Btn_Produto.Enabled = true;
            Btn_Caixa.Enabled = true;
            Btn_Transacoes.Enabled = true;
        }

        bool Aberta_janela = false;
        public bool aberta = false;
        public bool Janela_Aberta()
        {
            if (Application.OpenForms.OfType<Tela_cadastro_usuarios>().Count() > 0)
            {
                Aberta_janela = true;
                Deativar_botoes();
            }
            else if (Application.OpenForms.OfType<Tela_Categoria>().Count() > 0)
            {
                Aberta_janela = true;
                Deativar_botoes();
            }


            return Aberta_janela;
        }

        private void Bnt_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                Btn_Maximizar.Text = "Maximizar";

            }
            else
            {
                WindowState = FormWindowState.Maximized;
                Btn_Maximizar.Text = "Normal";
            }
        }
        private void expandir_menu()
        {
            Ativar_botoes();
            if (Painel_Menu.Width == 267)
            {
                Deativar_botoes();
                Painel_Menu.Width = 58;

            }
            else
            {
                Painel_Menu.Width = 267;

            }
        }

        private void Btn_menu_Click(object sender, EventArgs e)
        {
            expandir_menu();
        }
        public void Abrirjanela(Form fh)
        {
            janela_filho = fh;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            Painel_Pricipal.Controls.Add(fh);
            Painel_Pricipal.Tag = janela_filho;
            janela_filho.BringToFront();
            janela_filho.Show();
        }

        private void Painel_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer_Relogio_Tick(object sender, EventArgs e)
        {
            Lbl_hora.Text = DateTime.Now.ToString("HH:mm");
            Lbl_data.Text = DateTime.Now.ToString("dd/MM/yy");
        }



        private void Btn_Usuario_Click(object sender, EventArgs e)
        {
            aberta = Janela_Aberta();
            Deativar_botoes();

            if (aberta)
            {
                MessageBox.Show("A janela de usuários está aberta ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                expandir_menu();

                Abrirjanela(new Tela_cadastro_usuarios());

            }

        }

        private void Btn_Categoria_Click(object sender, EventArgs e)
        {

            aberta = Janela_Aberta();
            Deativar_botoes();

            if (aberta)
            {
                MessageBox.Show("A janela de Categoria está aberta ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                expandir_menu();

                Abrirjanela(new Tela_Categoria());

            }
        }
    }
    
}