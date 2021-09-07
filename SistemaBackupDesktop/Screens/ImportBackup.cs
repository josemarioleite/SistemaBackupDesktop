using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaBackupDesktop.Screens
{
    public partial class ImportBackup : Form
    {
        public ImportBackup()
        {
            InitializeComponent();
        }
        private void BtnArquivo(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtArquivo.Text = dialog.FileName;
                }
            }
        }
        private bool RestoreDatabase()
        {
            string connString = ConfigurationManager.ConnectionStrings["conectRestore"].ConnectionString;
            string file = txtArquivo.Text;
            bool completed = false;
            using (MySqlConnection conn = new(connString))
            {
                using (MySqlCommand cmd = new())
                {
                    using (MySqlBackup bkp = new(cmd))
                    {
                        if (!string.IsNullOrEmpty(file))
                        {
                            if (file.Contains(".sql"))
                            {
                                lblResposta.Visible = true;
                                lblResposta.Text = "restaurando...";
                                try
                                {
                                    cmd.Connection = conn;
                                    conn.Open();
                                    bkp.ImportFromFile(file);
                                    conn.Close();
                                    lblResposta.Text = "";
                                    lblResposta.ForeColor = Color.Green;
                                    lblResposta.Text = "Restauração completada com sucesso!";
                                    MessageBox.Show("O Banco de Dados foi restaurado!", "Sucesso");
                                    completed = true;
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Falha ao fazer restauração do Banco de Dados", "Erro");
                                    completed = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("O arquivo selecionado é um SQL", "Aviso");
                                lblResposta.Text = "";
                                completed = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selecione o arquivo de restauração", "Aviso");
                            completed = false;
                        }
                    }
                }
            }
            return completed;
        }
        private void BtnRestaurar(object sender, EventArgs e)
        {
            lblPreparacao.Visible = true;
            bool restore = RestoreDatabase();
            if (restore == true)
            {
                this.Close();
            } else
            {
                lblPreparacao.Visible = false;
                txtArquivo.Text = "";
                lblResposta.Text = "";
            }
        }
    }
}
