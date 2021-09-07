using SistemaBackupDesktop.Services;
using System;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SistemaBackupDesktop.Screens
{
    public partial class ExportBackup : Form
    {
        private static string nameFile;
        private string pathSave;
        private List<string> readFile;
        public ExportBackup()
        {
            InitializeComponent();
        }
        private void BtnArquivo(object sender, EventArgs e)
        {
            ReturnPathOrFile(true);
        }
        private void ReturnPathOrFile(bool file)
        {
            if (file == true)
            {
                using (OpenFileDialog dialog = new())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        nameFile = dialog.FileName;
                    }
                }
            } else
            {
                using (FolderBrowserDialog dialog = new())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        pathSave = dialog.SelectedPath;
                    }
                }
            }         
        }
        private void GetNameFile(object sender, EventArgs e)
        {
            FileText file = new FileText();
            file.VerifyFileExists();
            readFile = file.ReadFile();
            if (file.VerifyFileExists().FileExists == true)
            {
                nameFile = file.VerifyFileExists().FileConfig;
                txtNameFile.Text = nameFile;
                txtPathSave.Text = readFile[1].Replace("salvar em: ", "");
                txtParaSalvar.Text = readFile[0].Replace("para salvar: ", "");
            }
        }
        private void BtnPath(object sender, EventArgs e)
        {
            ReturnPathOrFile(false);
            txtPathSave.Text = pathSave;
        }
        public static string TextVerify(string text)
        {
            string textNotNull = "";
            if (!string.IsNullOrEmpty(text) || !string.IsNullOrWhiteSpace(text))
            {
                textNotNull = text;
            }
            return textNotNull;
        }
        private void BtnBackup(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPathSave.Text))
            {
                pathSave = txtPathSave.Text;
            }
            if (!string.IsNullOrEmpty(pathSave) || !string.IsNullOrWhiteSpace(pathSave))
            {
                string nameFile = $"bkp{DateTime.Now.ToString("dd-MM-yyyy")}_{DateTime.Now.ToString("HH")}-{DateTime.Now.ToString("mm")}" + ".zip";
                string zipFILE = Path.Combine(pathSave.Replace("salvar em: ", ""), nameFile);
                try
                {
                    if (File.Exists(zipFILE))
                    {
                        File.Delete(zipFILE);
                    }
                    DatabaseBackup dt = new(readFile[0].Replace("para salvar: ", ""));
                    string msgBackup = "Executando Backup do Banco: ...";
                    string msgBackupAll = "Executando Backup Geral: ...";
                    string returnExecuteBackupDatabase = "";
                    firstAlert.Text = msgBackup;
                    Task.Run(() => returnExecuteBackupDatabase = dt.ExecuteBackup()).Wait(TimeSpan.FromSeconds(10));
                    firstAlert.Text = msgBackup.Replace(" ...", " ") + returnExecuteBackupDatabase;
                    secondAlert.Text = msgBackupAll;
                    if (!string.IsNullOrEmpty(txtParaSalvar.Text))
                    {
                        Task.Run(() => ZipFile.CreateFromDirectory(Path.Combine(txtParaSalvar.Text, ""), zipFILE)).Wait(TimeSpan.FromSeconds(10));
                    } else
                    {
                        MessageBox.Show("Selecione a pasta para fazer backup", "Atenção");
                        return;
                    }
                    secondAlert.Text = msgBackupAll.Replace(" ...", " ") + "Backup executado com sucesso";
                    Task.Run(() => MessageBox.Show("Backup executado com sucesso", "Atenção")).Wait(TimeSpan.FromSeconds(15));
                    btnBackup.Enabled = false;
                    btnLocal.Enabled = false;
                    btrOpenFile.Enabled = false;
                    btnParaSalvar.Enabled = false;
                    btnFechar.Enabled = true;
                    btnFechar.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível fazer o Backup \n\n" + ex.Message, "Aviso");
                }
            }
            else
            {
                MessageBox.Show("Escolha uma pasta para fazer o backup", "Aviso");
            }
        }
        private void BtnFechar(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnParaSalvar(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtParaSalvar.Text = dialog.SelectedPath;
                }
            }
        }
    }
}
