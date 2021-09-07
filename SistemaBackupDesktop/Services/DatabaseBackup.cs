using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.IO;

namespace SistemaBackupDesktop.Services
{
    public class DatabaseBackup
    {
        private readonly string pathLocation;

        public DatabaseBackup(string path)
        {
            pathLocation = path;
        }

        public string ExecuteBackup()
        {
            string conexion = ConfigurationManager.ConnectionStrings["conectDatabase"].ConnectionString;
            string pathBackup = Path.Combine(pathLocation, "backupDatabase");

            if (!Directory.Exists(pathBackup))
            {
                Directory.CreateDirectory(pathBackup);
            } else
            {
                DirectoryInfo info = new(pathBackup);
                foreach (FileInfo fileInfo in info.GetFiles())
                {
                    if (fileInfo.Exists)
                    {
                        File.Delete(fileInfo.FullName);
                    }
                }
                Directory.Delete(pathBackup);
                Directory.CreateDirectory(pathBackup);
            }
            string file = Path.Combine(pathBackup, $"bkpDatabase{DateTime.Now.ToString("dd-MM-yyyy")}_{DateTime.Now.ToString("HH")}-{DateTime.Now.ToString("mm")}" + ".sql");
            string msg = "";
            using (MySqlConnection conn = new(conexion))
            {
                using (MySqlCommand cmd = new())
                {
                    using (MySqlBackup bkp = new(cmd))
                    {
                        try
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            bkp.ExportToFile(file);
                            conn.Close();
                            msg = "Realizado com sucesso!";
                        } catch (Exception)
                        {
                            msg = "Falha ao fazer Backup do Banco";
                        }
                    }
                }
            }
            return msg;
        }
    }
}
