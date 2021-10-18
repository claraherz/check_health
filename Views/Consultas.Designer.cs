
namespace check_health.Views
{
    partial class Consultas
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
            this.dgConsultas = new System.Windows.Forms.DataGridView();
            this.ColunaMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgConsultas
            // 
            this.dgConsultas.AllowUserToAddRows = false;
            this.dgConsultas.AllowUserToDeleteRows = false;
            this.dgConsultas.BackgroundColor = System.Drawing.Color.White;
            this.dgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaMedico,
            this.ColunaConsulta,
            this.ColunaData,
            this.ColunaHorario});
            this.dgConsultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgConsultas.Location = new System.Drawing.Point(0, 0);
            this.dgConsultas.Name = "dgConsultas";
            this.dgConsultas.ReadOnly = true;
            this.dgConsultas.RowHeadersWidth = 10;
            this.dgConsultas.RowTemplate.Height = 45;
            this.dgConsultas.Size = new System.Drawing.Size(684, 561);
            this.dgConsultas.TabIndex = 0;
            // 
            // ColunaMedico
            // 
            this.ColunaMedico.HeaderText = "Médico(a)";
            this.ColunaMedico.Name = "ColunaMedico";
            this.ColunaMedico.ReadOnly = true;
            this.ColunaMedico.Width = 244;
            // 
            // ColunaConsulta
            // 
            this.ColunaConsulta.HeaderText = "Consulta";
            this.ColunaConsulta.Name = "ColunaConsulta";
            this.ColunaConsulta.ReadOnly = true;
            this.ColunaConsulta.Width = 190;
            // 
            // ColunaData
            // 
            this.ColunaData.HeaderText = "Data";
            this.ColunaData.Name = "ColunaData";
            this.ColunaData.ReadOnly = true;
            this.ColunaData.Width = 150;
            // 
            // ColunaHorario
            // 
            this.ColunaHorario.HeaderText = "Horario";
            this.ColunaHorario.Name = "ColunaHorario";
            this.ColunaHorario.ReadOnly = true;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.dgConsultas);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Consultas";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaHorario;
    }
}