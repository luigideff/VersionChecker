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
            FilePath1.Text = Properties.Settings.Default.FilePath1;
            FilePath2.Text = Properties.Settings.Default.FilePath2;
            FilePath3.Text = Properties.Settings.Default.FilePath3;
            FilePath4.Text = Properties.Settings.Default.FilePath4;
            lbl_Cliente1.Text = Properties.Settings.Default.lbl_Cliente1;
            lbl_Cliente2.Text = Properties.Settings.Default.lbl_Cliente2;
            lbl_Cliente3.Text = Properties.Settings.Default.lbl_Cliente3;
            lbl_Cliente4.Text = Properties.Settings.Default.lbl_Cliente4;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.FilePath1 = FilePath1.Text;
            Properties.Settings.Default.FilePath2 = FilePath2.Text;
            Properties.Settings.Default.FilePath3 = FilePath3.Text;
            Properties.Settings.Default.FilePath4 = FilePath4.Text;
            Properties.Settings.Default.lbl_Cliente1 = lbl_Cliente1.Text;
            Properties.Settings.Default.lbl_Cliente2 = lbl_Cliente2.Text;
            Properties.Settings.Default.lbl_Cliente3 = lbl_Cliente3.Text;
            Properties.Settings.Default.lbl_Cliente4 = lbl_Cliente4.Text;
            Properties.Settings.Default.Save();            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetSettings();
            lbl_Versao1.Text = "";
            lbl_DataMod1.Text = "";
            lbl_Versao2.Text = "";
            lbl_DataMod2.Text = "";
            lbl_Versao3.Text = "";
            lbl_DataMod3.Text = "";
            lbl_Versao4.Text = "";
            lbl_DataMod4.Text = "";
            ActiveControl = btn_CheckVersion;     
        }

        public string FolderDialog(string CurrentPath)
        {
            FolderBrowserDialog SelectFolder = new FolderBrowserDialog();
            SelectFolder.ShowDialog();
            string NewPath = SelectFolder.SelectedPath;
            string NewPathPlusFile = NewPath + @"\bin\HBConselhos.dll";
            if (String.IsNullOrEmpty(NewPath) == false)
            {
                return NewPathPlusFile;
            }
            else
            {
                return CurrentPath;
            }            
        }

        public string GetFileVersion(string fileName, string clientName)
        {
            try
            {
                FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(fileName);
                string FileVersion = Convert.ToString(fileVersionInfo.FileVersion);
                return FileVersion;
            }

            catch (IOException ioe)
            {
                MessageBox.Show("O caminho especificado em " + clientName + " não aponta para um arquivo válido.");
                return String.Empty;
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show("Não foi especificado o caminho do arquivo para o " + clientName);
                return String.Empty;
            }
            
        }

        public string GetFileModDate(string fileName, string clientName)
        {
            try
            {               
                string ModDate = Convert.ToString(File.GetLastWriteTime(fileName));
                return ModDate;
            }
            catch (IOException ioe)
            {                
                return String.Empty;
            }
            catch (ArgumentException ae)
            {                
                return String.Empty;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        
        private void CheckVersion_Click(object sender, EventArgs e)
        {
            lbl_Versao1.Text = GetFileVersion(FilePath1.Text, lbl_Cliente1.Text);
            lbl_DataMod1.Text = GetFileModDate(FilePath1.Text, lbl_Cliente1.Text);

            lbl_Versao2.Text = GetFileVersion(FilePath2.Text, lbl_Cliente2.Text);
            lbl_DataMod2.Text = GetFileModDate(FilePath2.Text, lbl_Cliente2.Text);

            lbl_Versao3.Text = GetFileVersion(FilePath3.Text, lbl_Cliente3.Text);
            lbl_DataMod3.Text = GetFileModDate(FilePath3.Text, lbl_Cliente3.Text);

            lbl_Versao4.Text = GetFileVersion(FilePath4.Text, lbl_Cliente4.Text);
            lbl_DataMod4.Text = GetFileModDate(FilePath4.Text, lbl_Cliente4.Text);
        }

        
        public void lbl_Cliente1_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();                     
            form2.ShowDialog();
            lbl_Cliente1.Text = form2.Text;
        }

        public void lbl_Cliente2_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente2.Text = form2.Text;
        }
        public void lbl_Cliente3_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente3.Text = form2.Text;
        }
        public void lbl_Cliente4_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente4.Text = form2.Text;
        }

        public void lbl_Cliente5_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente5.Text = form2.Text;
        }

        public void lbl_Cliente6_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente6.Text = form2.Text;
        }
        public void lbl_Cliente7_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente7.Text = form2.Text;
        }

        public void lbl_Cliente8_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente8.Text = form2.Text;
        }
        public void lbl_Cliente9_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente9.Text = form2.Text;
        }
        public void lbl_Cliente10_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente10.Text = form2.Text;
        }
        public void lbl_Cliente11_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente11.Text = form2.Text;
        }
        public void lbl_Cliente12_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente13.Text = form2.Text;
        }
        public void lbl_Cliente13_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente13.Text = form2.Text;
        }
        public void lbl_Cliente14_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente14.Text = form2.Text;
        }
        public void lbl_Cliente15_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente15.Text = form2.Text;
        }
        public void lbl_Cliente16_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente16.Text = form2.Text;
        }
        public void lbl_Cliente17_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente17.Text = form2.Text;
        }
        public void lbl_Cliente18_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente18.Text = form2.Text;
        }
        public void lbl_Cliente19_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente19.Text = form2.Text;
        }
        public void lbl_Cliente20_Click(object sender, EventArgs e)
        {
            AlteraNomeCliente form2 = new AlteraNomeCliente();
            form2.ShowDialog();
            lbl_Cliente20.Text = form2.Text;
        }

        private void btn_Folder1_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath1.Text;           
            FilePath1.Text = FolderDialog(CurrentPath);
        }

        private void btn_Folder2_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath2.Text;
            FilePath2.Text = FolderDialog(CurrentPath);
        }

        private void btn_Folder3_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath3.Text;
            FilePath3.Text = FolderDialog(CurrentPath);
        }

        private void btn_Folder4_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath4.Text;
            FilePath4.Text = FolderDialog(CurrentPath);
        }
    }
}
