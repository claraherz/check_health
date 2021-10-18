
namespace check_health
{
    partial class FormCheckHealth
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckHealth));
            this.painelLateral = new System.Windows.Forms.Panel();
            this.painelPaciente = new System.Windows.Forms.Panel();
            this.btnAgendamento = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.painelSobreNos = new System.Windows.Forms.Panel();
            this.btnFaleConosco = new System.Windows.Forms.Button();
            this.btnColaboradores = new System.Windows.Forms.Button();
            this.btnQuemSomos = new System.Windows.Forms.Button();
            this.btnSobreNos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.painelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.painelLateral.SuspendLayout();
            this.painelPaciente.SuspendLayout();
            this.painelSobreNos.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.painelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // painelLateral
            // 
            this.painelLateral.AutoScroll = true;
            this.painelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(156)))), ((int)(((byte)(111)))));
            this.painelLateral.Controls.Add(this.painelPaciente);
            this.painelLateral.Controls.Add(this.btnPaciente);
            this.painelLateral.Controls.Add(this.painelSobreNos);
            this.painelLateral.Controls.Add(this.btnSobreNos);
            this.painelLateral.Controls.Add(this.panelLogo);
            this.painelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelLateral.Location = new System.Drawing.Point(0, 0);
            this.painelLateral.Name = "painelLateral";
            this.painelLateral.Size = new System.Drawing.Size(250, 561);
            this.painelLateral.TabIndex = 0;
            // 
            // painelPaciente
            // 
            this.painelPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(217)))), ((int)(((byte)(138)))));
            this.painelPaciente.Controls.Add(this.btnAgendamento);
            this.painelPaciente.Controls.Add(this.btnConsultas);
            this.painelPaciente.Controls.Add(this.btnCadastro);
            this.painelPaciente.Controls.Add(this.btnLogin);
            this.painelPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelPaciente.Location = new System.Drawing.Point(0, 401);
            this.painelPaciente.Name = "painelPaciente";
            this.painelPaciente.Size = new System.Drawing.Size(233, 191);
            this.painelPaciente.TabIndex = 3;
            // 
            // btnAgendamento
            // 
            this.btnAgendamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgendamento.FlatAppearance.BorderSize = 0;
            this.btnAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamento.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamento.ForeColor = System.Drawing.Color.White;
            this.btnAgendamento.Location = new System.Drawing.Point(0, 144);
            this.btnAgendamento.Name = "btnAgendamento";
            this.btnAgendamento.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgendamento.Size = new System.Drawing.Size(233, 48);
            this.btnAgendamento.TabIndex = 4;
            this.btnAgendamento.Text = "Agendamento";
            this.btnAgendamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendamento.UseVisualStyleBackColor = true;
            this.btnAgendamento.Click += new System.EventHandler(this.btnAgendamento_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.Location = new System.Drawing.Point(0, 96);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultas.Size = new System.Drawing.Size(233, 48);
            this.btnConsultas.TabIndex = 3;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(0, 48);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCadastro.Size = new System.Drawing.Size(233, 48);
            this.btnCadastro.TabIndex = 2;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(0, 0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(233, 48);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.Color.White;
            this.btnPaciente.Location = new System.Drawing.Point(0, 353);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPaciente.Size = new System.Drawing.Size(233, 48);
            this.btnPaciente.TabIndex = 2;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // painelSobreNos
            // 
            this.painelSobreNos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(217)))), ((int)(((byte)(138)))));
            this.painelSobreNos.Controls.Add(this.btnFaleConosco);
            this.painelSobreNos.Controls.Add(this.btnColaboradores);
            this.painelSobreNos.Controls.Add(this.btnQuemSomos);
            this.painelSobreNos.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelSobreNos.Location = new System.Drawing.Point(0, 211);
            this.painelSobreNos.Name = "painelSobreNos";
            this.painelSobreNos.Size = new System.Drawing.Size(233, 142);
            this.painelSobreNos.TabIndex = 1;
            // 
            // btnFaleConosco
            // 
            this.btnFaleConosco.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFaleConosco.FlatAppearance.BorderSize = 0;
            this.btnFaleConosco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaleConosco.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaleConosco.ForeColor = System.Drawing.Color.White;
            this.btnFaleConosco.Location = new System.Drawing.Point(0, 96);
            this.btnFaleConosco.Name = "btnFaleConosco";
            this.btnFaleConosco.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFaleConosco.Size = new System.Drawing.Size(233, 48);
            this.btnFaleConosco.TabIndex = 2;
            this.btnFaleConosco.Text = "Fale conosco";
            this.btnFaleConosco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaleConosco.UseVisualStyleBackColor = true;
            this.btnFaleConosco.Click += new System.EventHandler(this.btnFaleConosco_Click);
            // 
            // btnColaboradores
            // 
            this.btnColaboradores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnColaboradores.FlatAppearance.BorderSize = 0;
            this.btnColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColaboradores.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaboradores.ForeColor = System.Drawing.Color.White;
            this.btnColaboradores.Location = new System.Drawing.Point(0, 48);
            this.btnColaboradores.Name = "btnColaboradores";
            this.btnColaboradores.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnColaboradores.Size = new System.Drawing.Size(233, 48);
            this.btnColaboradores.TabIndex = 1;
            this.btnColaboradores.Text = "Colaboradores";
            this.btnColaboradores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColaboradores.UseVisualStyleBackColor = true;
            this.btnColaboradores.Click += new System.EventHandler(this.btnColaboradores_Click);
            // 
            // btnQuemSomos
            // 
            this.btnQuemSomos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuemSomos.FlatAppearance.BorderSize = 0;
            this.btnQuemSomos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuemSomos.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuemSomos.ForeColor = System.Drawing.Color.White;
            this.btnQuemSomos.Location = new System.Drawing.Point(0, 0);
            this.btnQuemSomos.Name = "btnQuemSomos";
            this.btnQuemSomos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnQuemSomos.Size = new System.Drawing.Size(233, 48);
            this.btnQuemSomos.TabIndex = 0;
            this.btnQuemSomos.Text = "Quem somos?";
            this.btnQuemSomos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuemSomos.UseVisualStyleBackColor = true;
            this.btnQuemSomos.Click += new System.EventHandler(this.btnQuemSomos_Click);
            // 
            // btnSobreNos
            // 
            this.btnSobreNos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSobreNos.FlatAppearance.BorderSize = 0;
            this.btnSobreNos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobreNos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobreNos.ForeColor = System.Drawing.Color.White;
            this.btnSobreNos.Location = new System.Drawing.Point(0, 163);
            this.btnSobreNos.Name = "btnSobreNos";
            this.btnSobreNos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSobreNos.Size = new System.Drawing.Size(233, 48);
            this.btnSobreNos.TabIndex = 1;
            this.btnSobreNos.Text = "Sobre Nós";
            this.btnSobreNos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobreNos.UseVisualStyleBackColor = true;
            this.btnSobreNos.Click += new System.EventHandler(this.btnSobreNos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.picLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 163);
            this.panelLogo.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(233, 163);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // painelChildForm
            // 
            this.painelChildForm.BackColor = System.Drawing.Color.White;
            this.painelChildForm.Controls.Add(this.pictureBox1);
            this.painelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelChildForm.Location = new System.Drawing.Point(250, 0);
            this.painelChildForm.Name = "painelChildForm";
            this.painelChildForm.Size = new System.Drawing.Size(684, 561);
            this.painelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormCheckHealth1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.painelChildForm);
            this.Controls.Add(this.painelLateral);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FormCheckHealth1";
            this.Text = "Check Health";
            this.Load += new System.EventHandler(this.FormCheckHealth_Load);
            this.painelLateral.ResumeLayout(false);
            this.painelPaciente.ResumeLayout(false);
            this.painelSobreNos.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.painelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelLateral;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel painelSobreNos;
        private System.Windows.Forms.Button btnFaleConosco;
        private System.Windows.Forms.Button btnColaboradores;
        private System.Windows.Forms.Button btnQuemSomos;
        private System.Windows.Forms.Button btnSobreNos;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel painelPaciente;
        private System.Windows.Forms.Button btnAgendamento;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Panel painelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

