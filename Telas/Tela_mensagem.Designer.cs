namespace SistemaVendas_Versao3.Telas
{
    partial class Tela_mensagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_titulo_mensagem = new System.Windows.Forms.Label();
            this.Lbl_tela_mensagem = new System.Windows.Forms.Label();
            this.Btn_tela_mensagem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.Lbl_titulo_mensagem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 43);
            this.panel1.TabIndex = 0;
            // 
            // Lbl_titulo_mensagem
            // 
            this.Lbl_titulo_mensagem.AutoSize = true;
            this.Lbl_titulo_mensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_titulo_mensagem.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_titulo_mensagem.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_titulo_mensagem.Location = new System.Drawing.Point(0, 9);
            this.Lbl_titulo_mensagem.Name = "Lbl_titulo_mensagem";
            this.Lbl_titulo_mensagem.Size = new System.Drawing.Size(113, 26);
            this.Lbl_titulo_mensagem.TabIndex = 1;
            this.Lbl_titulo_mensagem.Text = "Mensagem";
            // 
            // Lbl_tela_mensagem
            // 
            this.Lbl_tela_mensagem.AutoSize = true;
            this.Lbl_tela_mensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_tela_mensagem.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_tela_mensagem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_tela_mensagem.Location = new System.Drawing.Point(0, 73);
            this.Lbl_tela_mensagem.Name = "Lbl_tela_mensagem";
            this.Lbl_tela_mensagem.Size = new System.Drawing.Size(164, 26);
            this.Lbl_tela_mensagem.TabIndex = 2;
            this.Lbl_tela_mensagem.Text = "Mensagem teste";
            // 
            // Btn_tela_mensagem
            // 
            this.Btn_tela_mensagem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_tela_mensagem.FlatAppearance.BorderSize = 2;
            this.Btn_tela_mensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_tela_mensagem.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_tela_mensagem.ForeColor = System.Drawing.Color.Peru;
            this.Btn_tela_mensagem.Location = new System.Drawing.Point(24, 124);
            this.Btn_tela_mensagem.Name = "Btn_tela_mensagem";
            this.Btn_tela_mensagem.Size = new System.Drawing.Size(130, 35);
            this.Btn_tela_mensagem.TabIndex = 3;
            this.Btn_tela_mensagem.Text = "OK";
            this.Btn_tela_mensagem.UseVisualStyleBackColor = true;
            this.Btn_tela_mensagem.Click += new System.EventHandler(this.Btn_tela_mensagem_Click);
            // 
            // Tela_mensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 171);
            this.Controls.Add(this.Btn_tela_mensagem);
            this.Controls.Add(this.Lbl_tela_mensagem);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_mensagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_mensagem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        public Label Lbl_tela_mensagem;
        private Button Btn_tela_mensagem;
        public Label Lbl_titulo_mensagem;
    }
}