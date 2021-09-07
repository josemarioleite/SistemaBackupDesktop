
namespace SistemaBackupDesktop.Screens
{
    partial class ExportBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportBackup));
            this.btrOpenFile = new System.Windows.Forms.Button();
            this.txtNameFile = new System.Windows.Forms.TextBox();
            this.txtPathSave = new System.Windows.Forms.TextBox();
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.secondAlert = new System.Windows.Forms.Label();
            this.firstAlert = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtParaSalvar = new System.Windows.Forms.TextBox();
            this.btnParaSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btrOpenFile
            // 
            this.btrOpenFile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btrOpenFile.FlatAppearance.BorderSize = 0;
            this.btrOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btrOpenFile.ForeColor = System.Drawing.Color.White;
            this.btrOpenFile.Location = new System.Drawing.Point(455, 12);
            this.btrOpenFile.Name = "btrOpenFile";
            this.btrOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btrOpenFile.TabIndex = 0;
            this.btrOpenFile.Text = "Arquivo";
            this.btrOpenFile.UseVisualStyleBackColor = false;
            this.btrOpenFile.Click += new System.EventHandler(this.BtnArquivo);
            // 
            // txtNameFile
            // 
            this.txtNameFile.Location = new System.Drawing.Point(12, 12);
            this.txtNameFile.Name = "txtNameFile";
            this.txtNameFile.Size = new System.Drawing.Size(430, 23);
            this.txtNameFile.TabIndex = 1;
            // 
            // txtPathSave
            // 
            this.txtPathSave.Location = new System.Drawing.Point(12, 84);
            this.txtPathSave.Name = "txtPathSave";
            this.txtPathSave.Size = new System.Drawing.Size(430, 23);
            this.txtPathSave.TabIndex = 3;
            // 
            // btnLocal
            // 
            this.btnLocal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLocal.FlatAppearance.BorderSize = 0;
            this.btnLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocal.ForeColor = System.Drawing.Color.White;
            this.btnLocal.Location = new System.Drawing.Point(455, 84);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(75, 23);
            this.btnLocal.TabIndex = 2;
            this.btnLocal.Text = "Salvar Em";
            this.btnLocal.UseVisualStyleBackColor = false;
            this.btnLocal.Click += new System.EventHandler(this.BtnPath);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.Green;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(214, 292);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(118, 23);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "Executar Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.secondAlert);
            this.panel1.Controls.Add(this.firstAlert);
            this.panel1.Location = new System.Drawing.Point(12, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 164);
            this.panel1.TabIndex = 5;
            // 
            // secondAlert
            // 
            this.secondAlert.AutoSize = true;
            this.secondAlert.Location = new System.Drawing.Point(4, 30);
            this.secondAlert.Name = "secondAlert";
            this.secondAlert.Size = new System.Drawing.Size(0, 15);
            this.secondAlert.TabIndex = 1;
            // 
            // firstAlert
            // 
            this.firstAlert.AutoSize = true;
            this.firstAlert.Location = new System.Drawing.Point(4, 4);
            this.firstAlert.Name = "firstAlert";
            this.firstAlert.Size = new System.Drawing.Size(0, 15);
            this.firstAlert.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.Enabled = false;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(447, 292);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(83, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Visible = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar);
            // 
            // txtParaSalvar
            // 
            this.txtParaSalvar.Location = new System.Drawing.Point(12, 48);
            this.txtParaSalvar.Name = "txtParaSalvar";
            this.txtParaSalvar.Size = new System.Drawing.Size(430, 23);
            this.txtParaSalvar.TabIndex = 8;
            // 
            // btnParaSalvar
            // 
            this.btnParaSalvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnParaSalvar.FlatAppearance.BorderSize = 0;
            this.btnParaSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParaSalvar.ForeColor = System.Drawing.Color.White;
            this.btnParaSalvar.Location = new System.Drawing.Point(455, 48);
            this.btnParaSalvar.Name = "btnParaSalvar";
            this.btnParaSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnParaSalvar.TabIndex = 7;
            this.btnParaSalvar.Text = "Para Salvar";
            this.btnParaSalvar.UseVisualStyleBackColor = false;
            this.btnParaSalvar.Click += new System.EventHandler(this.BtnParaSalvar);
            // 
            // ExportBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 327);
            this.Controls.Add(this.txtParaSalvar);
            this.Controls.Add(this.btnParaSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.txtPathSave);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.txtNameFile);
            this.Controls.Add(this.btrOpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.GetNameFile);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btrOpenFile;
        private System.Windows.Forms.TextBox txtNameFile;
        private System.Windows.Forms.TextBox txtPathSave;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label secondAlert;
        private System.Windows.Forms.Label firstAlert;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox txtParaSalvar;
        private System.Windows.Forms.Button btnParaSalvar;
    }
}

