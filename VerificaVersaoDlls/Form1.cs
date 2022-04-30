using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace VerificaVersaoDlls
{
    public partial class VersionChecker : Form
    {
        public VersionChecker()
        {
            InitializeComponent();
        }

        public void GetSettings()
        {
            FilePath1.Text = Properties.Settings.Default.DllPath1;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.DllPath1 = FilePath1.Text;
            Properties.Settings.Default.Save();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetSettings();
            
            if (String.IsNullOrEmpty(FilePath1.Text) != true)
            {
                string fileName = FilePath1.Text;
                try
                {

                    FileVersionInfo FileVersion = FileVersionInfo.GetVersionInfo(fileName);
                    Versao_Txt.Text = Convert.ToString(FileVersion.ProductVersion);

                }
                catch (IOException ioe)
                {
                    MessageBox.Show("O caminho especificado não aponta para um arquivo válido.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void CheckVersion_Click(object sender, EventArgs e)
        {
            string fileName = FilePath1.Text;
            try
            {
                
                    FileVersionInfo FileVersion = FileVersionInfo.GetVersionInfo(fileName);
                    Versao_Txt.Text = Convert.ToString(FileVersion.ProductVersion);
               
            }
            catch (IOException ioe)
            {
                MessageBox.Show("O caminho especificado não aponta para um arquivo válido.");
            }
            catch(ArgumentException ae)
            {
                MessageBox.Show("Não foi especificado o caminho do arquivo");
            }
        }
        
    }
}
