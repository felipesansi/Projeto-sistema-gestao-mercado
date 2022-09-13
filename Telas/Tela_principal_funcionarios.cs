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
    public partial class Tela_principal_funcionarios : Form
    {
        Form janela_filho_fun = new Form();
        public Tela_principal_funcionarios()
        {
            InitializeComponent();
        }

        private void Timer_relogio_fun_Tick(object sender, EventArgs e)
        {
            Lbl_data_fun.Text = DateTime.Now.ToString("dd/MM/yy");
            Lbl_hora_fun.Text = DateTime.Now.ToString("HH:mm");
        }

        private void Btn_Maximizar_fun_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                Btn_Maximizar_fun.Text = "Maximizar";
            }
            else
            {
                WindowState=FormWindowState.Maximized;
                Btn_Maximizar_fun.Text = "Normal";
            }
        }

        private void Bnt_Minimizar_fun_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void expandir_menu_fun()
        {
           
            if (Painel_Menu_fun.Width == 267)
            {
                Painel_Menu_fun.Width = 58;

            }
            else
            {
                Painel_Menu_fun.Width = 267;

            }
        }
        private void Btn_menu_fun_Click(object sender, EventArgs e)
        {
               expandir_menu_fun();
           
        }
        public void Abrirjanela(Form fh)
        {
            janela_filho_fun = fh;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            Painel_principal_fun.Controls.Add(fh);
            Painel_principal_fun.Tag = janela_filho_fun;
            janela_filho_fun.BringToFront();
            janela_filho_fun.Show();
        }
        }
}
