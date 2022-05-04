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
            Properties.Settings.Default.FilePath1 = FilePath2.Text;
            Properties.Settings.Default.FilePath1 = FilePath3.Text;
            Properties.Settings.Default.FilePath1 = FilePath4.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void CheckVersion_Click(object sender, EventArgs e)
        {
            string fileName1 = FilePath1.Text;
            string fileName2 = FilePath2.Text;
            try
            {
                
                FileVersionInfo FileVersion = FileVersionInfo.GetVersionInfo(fileName1);
                lbl_Versao1.Text = Convert.ToString(FileVersion.ProductVersion);
                DateTime ModDate = File.GetLastWriteTime(fileName1);
                lbl_DataMod1.Text = Convert.ToString(ModDate);

                FileVersionInfo FileVersion2 = FileVersionInfo.GetVersionInfo(fileName2);
                lbl_Versao2.Text = Convert.ToString(FileVersion2.ProductVersion);
                DateTime ModDate2 = File.GetLastWriteTime(fileName2);
                lbl_DataMod2.Text = Convert.ToString(ModDate2);


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

        private void btn_Folder1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog selectfile = new OpenFileDialog();
            selectfile.ShowDialog();
            FilePath1.Text = selectfile.FileName;
        }

        private void btn_Folder2_Click(object sender, EventArgs e)
        {

            OpenFileDialog selectfile = new OpenFileDialog();
            selectfile.ShowDialog();
            FilePath2.Text = selectfile.FileName;
        }

        private void btn_Folder3_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectfile = new OpenFileDialog();
            selectfile.ShowDialog();
            FilePath3.Text = selectfile.FileName;
        }

        private void btn_Folder4_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectfile = new OpenFileDialog();
            selectfile.ShowDialog();
            FilePath4.Text = selectfile.FileName;
        }
    }
}
