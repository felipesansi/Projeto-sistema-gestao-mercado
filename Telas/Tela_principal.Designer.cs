namespace SistemaVendas_Versao3
{
    partial class Tela_principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_principal));
            this.Painel_Pricipal = new System.Windows.Forms.Panel();
            this.Painel_Menu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Usuario = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_Transacoes = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_Caixa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Produto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Categoria = new System.Windows.Forms.Button();
            this.Btn_menu = new System.Windows.Forms.Button();
            this.Painel_cima = new System.Windows.Forms.Panel();
            this.Lbl_data = new System.Windows.Forms.Label();
            this.Lbl_hora = new System.Windows.Forms.Label();
            this.Bnt_Minimizar = new System.Windows.Forms.Button();
            this.Btn_Maximizar = new System.Windows.Forms.Button();
            this.Btn_Encerrar = new System.Windows.Forms.Button();
            this.Timer_Relogio = new System.Windows.Forms.Timer(this.components);
            this.Painel_Pricipal.SuspendLayout();
            this.Painel_Menu.SuspendLayout();
            this.Painel_cima.SuspendLayout();
            this.SuspendLayout();
            // 
            // Painel_Pricipal
            // 
            this.Painel_Pricipal.Controls.Add(this.Painel_Menu);
            this.Painel_Pricipal.Controls.Add(this.Painel_cima);
            this.Painel_Pricipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_Pricipal.Location = new System.Drawing.Point(0, 0);
            this.Painel_Pricipal.Name = "Painel_Pricipal";
            this.Painel_Pricipal.Size = new System.Drawing.Size(964, 542);
            this.Painel_Pricipal.TabIndex = 2;
            this.Painel_Pricipal.Paint += new System.Windows.Forms.PaintEventHandler(this.Painel_Pricipal_Paint);
            // 
            // Painel_Menu
            // 
            this.Painel_Menu.BackColor = System.Drawing.Color.MidnightBlue;
            this.Painel_Menu.Controls.Add(this.panel1);
            this.Painel_Menu.Controls.Add(this.Btn_Usuario);
            this.Painel_Menu.Controls.Add(this.panel4);
            this.Painel_Menu.Controls.Add(this.Btn_Transacoes);
            this.Painel_Menu.Controls.Add(this.panel5);
            this.Painel_Menu.Controls.Add(this.Btn_Caixa);
            this.Painel_Menu.Controls.Add(this.panel3);
            this.Painel_Menu.Controls.Add(this.Btn_Produto);
            this.Painel_Menu.Controls.Add(this.panel2);
            this.Painel_Menu.Controls.Add(this.Btn_Categoria);
            this.Painel_Menu.Controls.Add(this.Btn_menu);
            this.Painel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Painel_Menu.Location = new System.Drawing.Point(0, 41);
            this.Painel_Menu.Name = "Painel_Menu";
            this.Painel_Menu.Size = new System.Drawing.Size(58, 501);
            this.Painel_Menu.TabIndex = 1;
            this.Painel_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Painel_Menu_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Location = new System.Drawing.Point(-9, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 33);
            this.panel1.TabIndex = 11;
            // 
            // Btn_Usuario
            // 
            this.Btn_Usuario.Enabled = false;
            this.Btn_Usuario.FlatAppearance.BorderSize = 0;
            this.Btn_Usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.Btn_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Usuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Usuario.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Usuario.Image")));
            this.Btn_Usuario.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btn_Usuario.Location = new System.Drawing.Point(18, 101);
            this.Btn_Usuario.Name = "Btn_Usuario";
            this.Btn_Usuario.Size = new System.Drawing.Size(242, 33);
            this.Btn_Usuario.TabIndex = 12;
            this.Btn_Usuario.Text = "Cadastro de usuário";
            this.Btn_Usuario.UseVisualStyleBackColor = true;
            this.Btn_Usuario.Click += new System.EventHandler(this.Btn_Usuario_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel4.Location = new System.Drawing.Point(-9, 317);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(29, 33);
            this.panel4.TabIndex = 9;
            // 
            // Btn_Transacoes
            // 
            this.Btn_Transacoes.Enabled = false;
            this.Btn_Transacoes.FlatAppearance.BorderSize = 0;
            this.Btn_Transacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.Btn_Transacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Transacoes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Transacoes.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Transacoes.Location = new System.Drawing.Point(18, 317);
            this.Btn_Transacoes.Name = "Btn_Transacoes";
            this.Btn_Transacoes.Size = new System.Drawing.Size(242, 33);
            this.Btn_Transacoes.TabIndex = 10;
            this.Btn_Transacoes.Text = "Transações";
            this.Btn_Transacoes.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel5.Location = new System.Drawing.Point(-9, 259);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(29, 33);
            this.panel5.TabIndex = 7;
            // 
            // Btn_Caixa
            // 
            this.Btn_Caixa.Enabled = false;
            this.Btn_Caixa.FlatAppearance.BorderSize = 0;
            this.Btn_Caixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.Btn_Caixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Caixa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Caixa.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Caixa.Location = new System.Drawing.Point(18, 259);
            this.Btn_Caixa.Name = "Btn_Caixa";
            this.Btn_Caixa.Size = new System.Drawing.Size(242, 33);
            this.Btn_Caixa.TabIndex = 8;
            this.Btn_Caixa.Text = "Caixa";
            this.Btn_Caixa.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.Location = new System.Drawing.Point(-9, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(29, 33);
            this.panel3.TabIndex = 5;
            // 
            // Btn_Produto
            // 
            this.Btn_Produto.Enabled = false;
            this.Btn_Produto.FlatAppearance.BorderSize = 0;
            this.Btn_Produto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.Btn_Produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Produto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Produto.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Produto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Produto.Image")));
            this.Btn_Produto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Produto.Location = new System.Drawing.Point(18, 205);
            this.Btn_Produto.Name = "Btn_Produto";
            this.Btn_Produto.Size = new System.Drawing.Size(242, 33);
            this.Btn_Produto.TabIndex = 6;
            this.Btn_Produto.Text = "Cadastro de produtos";
            this.Btn_Produto.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Location = new System.Drawing.Point(-9, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 33);
            this.panel2.TabIndex = 3;
            // 
            // Btn_Categoria
            // 
            this.Btn_Categoria.Enabled = false;
            this.Btn_Categoria.FlatAppearance.BorderSize = 0;
            this.Btn_Categoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.Btn_Categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Categoria.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Categoria.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Categoria.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Categoria.Image")));
            this.Btn_Categoria.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_Categoria.Location = new System.Drawing.Point(18, 153);
            this.Btn_Categoria.Name = "Btn_Categoria";
            this.Btn_Categoria.Size = new System.Drawing.Size(242, 33);
            this.Btn_Categoria.TabIndex = 4;
            this.Btn_Categoria.Text = "Cadastro de categoria";
            this.Btn_Categoria.UseVisualStyleBackColor = true;
            this.Btn_Categoria.Click += new System.EventHandler(this.Btn_Categoria_Click);
            // 
            // Btn_menu
            // 
            this.Btn_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("Btn_menu.Image")));
            this.Btn_menu.Location = new System.Drawing.Point(3, 3);
            this.Btn_menu.Name = "Btn_menu";
            this.Btn_menu.Size = new System.Drawing.Size(53, 29);
            this.Btn_menu.TabIndex = 2;
            this.Btn_menu.UseVisualStyleBackColor = true;
            this.Btn_menu.Click += new System.EventHandler(this.Btn_menu_Click);
            // 
            // Painel_cima
            // 
            this.Painel_cima.BackColor = System.Drawing.Color.MidnightBlue;
            this.Painel_cima.Controls.Add(this.Lbl_data);
            this.Painel_cima.Controls.Add(this.Lbl_hora);
            this.Painel_cima.Controls.Add(this.Bnt_Minimizar);
            this.Painel_cima.Controls.Add(this.Btn_Maximizar);
            this.Painel_cima.Controls.Add(this.Btn_Encerrar);
            this.Painel_cima.Dock = System.Windows.Forms.DockStyle.Top;
            this.Painel_cima.Location = new System.Drawing.Point(0, 0);
            this.Painel_cima.Name = "Painel_cima";
            this.Painel_cima.Size = new System.Drawing.Size(964, 41);
            this.Painel_cima.TabIndex = 0;
            this.Painel_cima.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Lbl_data
            // 
            this.Lbl_data.AutoSize = true;
            this.Lbl_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_data.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_data.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_data.Location = new System.Drawing.Point(47, 10);
            this.Lbl_data.Name = "Lbl_data";
            this.Lbl_data.Size = new System.Drawing.Size(0, 13);
            this.Lbl_data.TabIndex = 6;
            // 
            // Lbl_hora
            // 
            this.Lbl_hora.AutoSize = true;
            this.Lbl_hora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_hora.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_hora.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_hora.Location = new System.Drawing.Point(604, 9);
            this.Lbl_hora.Name = "Lbl_hora";
            this.Lbl_hora.Size = new System.Drawing.Size(0, 14);
            this.Lbl_hora.TabIndex = 5;
            // 
            // Bnt_Minimizar
            // 
            this.Bnt_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bnt_Minimizar.FlatAppearance.BorderSize = 0;
            this.Bnt_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bnt_Minimizar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bnt_Minimizar.ForeColor = System.Drawing.SystemColors.Control;
            this.Bnt_Minimizar.Location = new System.Drawing.Point(752, 3);
            this.Bnt_Minimizar.Name = "Bnt_Minimizar";
            this.Bnt_Minimizar.Size = new System.Drawing.Size(40, 33);
            this.Bnt_Minimizar.TabIndex = 2;
            this.Bnt_Minimizar.Text = "-";
            this.Bnt_Minimizar.UseVisualStyleBackColor = true;
            this.Bnt_Minimizar.Click += new System.EventHandler(this.Bnt_Minimizar_Click);
            // 
            // Btn_Maximizar
            // 
            this.Btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Maximizar.FlatAppearance.BorderSize = 0;
            this.Btn_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Maximizar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Maximizar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Maximizar.Location = new System.Drawing.Point(798, 3);
            this.Btn_Maximizar.Name = "Btn_Maximizar";
            this.Btn_Maximizar.Size = new System.Drawing.Size(116, 33);
            this.Btn_Maximizar.TabIndex = 3;
            this.Btn_Maximizar.Text = "Normal";
            this.Btn_Maximizar.UseVisualStyleBackColor = true;
            this.Btn_Maximizar.Click += new System.EventHandler(this.Btn_Maximizar_Click);
            // 
            // Btn_Encerrar
            // 
            this.Btn_Encerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Encerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Encerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn_Encerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Encerrar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Encerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Encerrar.Location = new System.Drawing.Point(921, 3);
            this.Btn_Encerrar.Name = "Btn_Encerrar";
            this.Btn_Encerrar.Size = new System.Drawing.Size(40, 36);
            this.Btn_Encerrar.TabIndex = 4;
            this.Btn_Encerrar.Text = "X";
            this.Btn_Encerrar.UseVisualStyleBackColor = true;
            this.Btn_Encerrar.Click += new System.EventHandler(this.Btn_Encerrar_Click_1);
            // 
            // Timer_Relogio
            // 
            this.Timer_Relogio.Enabled = true;
            this.Timer_Relogio.Tick += new System.EventHandler(this.Timer_Relogio_Tick);
            // 
            // Tela_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 542);
            this.Controls.Add(this.Painel_Pricipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Painel_Pricipal.ResumeLayout(false);
            this.Painel_Menu.ResumeLayout(false);
            this.Painel_cima.ResumeLayout(false);
            this.Painel_cima.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel Painel_Pricipal;
        private Panel Painel_Menu;
        private Panel Painel_cima;
        private Button Bnt_Minimizar;
        private Button Btn_Maximizar;
        private Button Btn_Encerrar;
        private Button Btn_menu;
        private Panel panel3;
        private Button Btn_Produto;
        private Panel panel2;
        private Button Btn_Categoria;
        private Panel panel4;
        private Button Btn_Transacoes;
        private Panel panel5;
        private Button Btn_Caixa;
        private Label Lbl_hora;
        private System.Windows.Forms.Timer Timer_Relogio;
        private Label Lbl_data;
        private Panel panel1;
        private Button Btn_Usuario;
    }
}