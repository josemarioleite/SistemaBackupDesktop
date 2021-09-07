
namespace SistemaBackupDesktop.Screens
{
    partial class ImportBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportBackup));
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btrOpenFile = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPreparacao = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(12, 19);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(296, 23);
            this.txtArquivo.TabIndex = 3;
            // 
            // btrOpenFile
            // 
            this.btrOpenFile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btrOpenFile.FlatAppearance.BorderSize = 0;
            this.btrOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btrOpenFile.ForeColor = System.Drawing.Color.White;
            this.btrOpenFile.Location = new System.Drawing.Point(322, 18);
            this.btrOpenFile.Name = "btrOpenFile";
            this.btrOpenFile.Size = new System.Drawing.Size(84, 23);
            this.btrOpenFile.TabIndex = 2;
            this.btrOpenFile.Text = "Arquivo";
            this.btrOpenFile.UseVisualStyleBackColor = false;
            this.btrOpenFile.Click += new System.EventHandler(this.BtnArquivo);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.Enabled = false;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(331, 236);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Visible = false;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.Green;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(150, 236);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(118, 23);
            this.btnBackup.TabIndex = 7;
            this.btnBackup.Text = "Executar Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.BtnRestaurar);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblResposta);
            this.panel1.Controls.Add(this.lblPreparacao);
            this.panel1.Location = new System.Drawing.Point(13, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 164);
            this.panel1.TabIndex = 9;
            // 
            // lblPreparacao
            // 
            this.lblPreparacao.AutoSize = true;
            this.lblPreparacao.Location = new System.Drawing.Point(3, 3);
            this.lblPreparacao.Name = "lblPreparacao";
            this.lblPreparacao.Size = new System.Drawing.Size(135, 15);
            this.lblPreparacao.TabIndex = 0;
            this.lblPreparacao.Text = "Preparando importação:";
            this.lblPreparacao.Visible = false;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(137, 3);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(38, 15);
            this.lblResposta.TabIndex = 1;
            this.lblResposta.Text = "label2";
            this.lblResposta.Visible = false;
            // 
            // ImportBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 268);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.btrOpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Dados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btrOpenFile;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label lblPreparacao;
    }
}