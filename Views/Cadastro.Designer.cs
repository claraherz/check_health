﻿
namespace check_health.Views
{
    partial class Cadastro
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.textboxEmail = new System.Windows.Forms.TextBox();
            this.textboxSenha = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textboxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(18, 19);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(67, 36);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // textboxEmail
            // 
            this.textboxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxEmail.Location = new System.Drawing.Point(207, 232);
            this.textboxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.Size = new System.Drawing.Size(235, 23);
            this.textboxEmail.TabIndex = 6;
            // 
            // textboxSenha
            // 
            this.textboxSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxSenha.Location = new System.Drawing.Point(207, 309);
            this.textboxSenha.Margin = new System.Windows.Forms.Padding(4);
            this.textboxSenha.Name = "textboxSenha";
            this.textboxSenha.PasswordChar = '*';
            this.textboxSenha.Size = new System.Drawing.Size(235, 23);
            this.textboxSenha.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Location = new System.Drawing.Point(265, 367);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(108, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // textboxNome
            // 
            this.textboxNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxNome.Location = new System.Drawing.Point(207, 150);
            this.textboxNome.Margin = new System.Windows.Forms.Padding(4);
            this.textboxNome.Name = "textboxNome";
            this.textboxNome.Size = new System.Drawing.Size(235, 23);
            this.textboxNome.TabIndex = 8;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(301, 102);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(301, 196);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(301, 270);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 17);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.textboxNome);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.textboxEmail);
            this.Controls.Add(this.textboxSenha);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cadastro";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox textboxEmail;
        private System.Windows.Forms.TextBox textboxSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textboxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
    }
}