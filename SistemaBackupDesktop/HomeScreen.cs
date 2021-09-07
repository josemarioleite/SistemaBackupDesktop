using SistemaBackupDesktop.Screens;
using System;
using System.Windows.Forms;

namespace SistemaBackupDesktop
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }
        private void BtnFechar(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnBackup(object sender, EventArgs e)
        {
            new ExportBackup().ShowDialog();
        }
        private void BtnRestore(object sender, EventArgs e)
        {
            new ImportBackup().ShowDialog();
        }
    }
}
