using SistemaBackupDesktop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SistemaBackupDesktop.Services
{
    public class FileText
    {
        FileConfiguration fileConfig = new();
        public FileText()
        {
            fileConfig = new();
        }
        public FileConfiguration VerifyFileExists()
        {
            if (!File.Exists(fileConfig.FileConfig))
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(fileConfig.FileConfig))
                    {
                        sw.WriteLine("");
                    }
                    fileConfig.FileExists = true;
                } catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível criar o arquivo \n\n" + ex.Message, "Erro");
                    fileConfig.FileExists = false;
                }
            } else
            {
                fileConfig.FileExists = true;
            }
            return fileConfig;
        }
        public List<string> ReadFile()
        {
            List<string> txt = new();
            if (fileConfig.FileExists == true)
            {
                using (StreamReader sr = new StreamReader(fileConfig.FileConfig))
                {
                    while (!sr.EndOfStream)
                    {
                        txt.Add(sr.ReadLine());
                    }
                }
            }
            else
            {
                MessageBox.Show("Arquivo Inexistente", "Aviso");
            }
            return txt;
        }
    }
}
