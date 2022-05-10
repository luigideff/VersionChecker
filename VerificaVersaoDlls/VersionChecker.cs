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
            FilePath5.Text = Properties.Settings.Default.FilePath5;
            FilePath6.Text = Properties.Settings.Default.FilePath6;
            FilePath7.Text = Properties.Settings.Default.FilePath7;
            FilePath8.Text = Properties.Settings.Default.FilePath8;
            FilePath9.Text = Properties.Settings.Default.FilePath9;
            FilePath10.Text = Properties.Settings.Default.FilePath10;
            FilePath11.Text = Properties.Settings.Default.FilePath11;
            FilePath12.Text = Properties.Settings.Default.FilePath12;
            FilePath13.Text = Properties.Settings.Default.FilePath13;
            FilePath14.Text = Properties.Settings.Default.FilePath14;
            FilePath15.Text = Properties.Settings.Default.FilePath15;
            FilePath16.Text = Properties.Settings.Default.FilePath16;
            FilePath17.Text = Properties.Settings.Default.FilePath17;
            FilePath18.Text = Properties.Settings.Default.FilePath18;
            FilePath19.Text = Properties.Settings.Default.FilePath19;
            FilePath20.Text = Properties.Settings.Default.FilePath20;
            lbl_Cliente1.Text = Properties.Settings.Default.lbl_Cliente1;
            lbl_Cliente2.Text = Properties.Settings.Default.lbl_Cliente2;
            lbl_Cliente3.Text = Properties.Settings.Default.lbl_Cliente3;
            lbl_Cliente4.Text = Properties.Settings.Default.lbl_Cliente4;
            lbl_Cliente5.Text = Properties.Settings.Default.lbl_Cliente5;
            lbl_Cliente6.Text = Properties.Settings.Default.lbl_Cliente6;
            lbl_Cliente7.Text = Properties.Settings.Default.lbl_Cliente7;
            lbl_Cliente8.Text = Properties.Settings.Default.lbl_Cliente8;
            lbl_Cliente9.Text = Properties.Settings.Default.lbl_Cliente9;
            lbl_Cliente10.Text = Properties.Settings.Default.lbl_Cliente10;
            lbl_Cliente11.Text = Properties.Settings.Default.lbl_Cliente11;
            lbl_Cliente12.Text = Properties.Settings.Default.lbl_Cliente12;
            lbl_Cliente13.Text = Properties.Settings.Default.lbl_Cliente13;
            lbl_Cliente14.Text = Properties.Settings.Default.lbl_Cliente14;
            lbl_Cliente15.Text = Properties.Settings.Default.lbl_Cliente15;
            lbl_Cliente16.Text = Properties.Settings.Default.lbl_Cliente16;
            lbl_Cliente17.Text = Properties.Settings.Default.lbl_Cliente17;
            lbl_Cliente18.Text = Properties.Settings.Default.lbl_Cliente18;
            lbl_Cliente18.Text = Properties.Settings.Default.lbl_Cliente19;
            lbl_Cliente20.Text = Properties.Settings.Default.lbl_Cliente20;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.FilePath1 = FilePath1.Text;
            Properties.Settings.Default.FilePath2 = FilePath2.Text;
            Properties.Settings.Default.FilePath3 = FilePath3.Text;
            Properties.Settings.Default.FilePath4 = FilePath4.Text;
            Properties.Settings.Default.FilePath5 = FilePath5.Text;
            Properties.Settings.Default.FilePath6 = FilePath6.Text;
            Properties.Settings.Default.FilePath7 = FilePath7.Text;
            Properties.Settings.Default.FilePath8 = FilePath8.Text;
            Properties.Settings.Default.FilePath9 = FilePath9.Text;
            Properties.Settings.Default.FilePath10 = FilePath10.Text;
            Properties.Settings.Default.FilePath11 = FilePath11.Text;
            Properties.Settings.Default.FilePath12 = FilePath12.Text;
            Properties.Settings.Default.FilePath13 = FilePath13.Text;
            Properties.Settings.Default.FilePath14 = FilePath14.Text;
            Properties.Settings.Default.FilePath15 = FilePath15.Text;
            Properties.Settings.Default.FilePath16 = FilePath16.Text;
            Properties.Settings.Default.FilePath17 = FilePath17.Text;
            Properties.Settings.Default.FilePath18 = FilePath18.Text;
            Properties.Settings.Default.FilePath19 = FilePath19.Text;
            Properties.Settings.Default.FilePath20 = FilePath20.Text;
            Properties.Settings.Default.lbl_Cliente1 = lbl_Cliente1.Text;
            Properties.Settings.Default.lbl_Cliente2 = lbl_Cliente2.Text;
            Properties.Settings.Default.lbl_Cliente3 = lbl_Cliente3.Text;
            Properties.Settings.Default.lbl_Cliente4 = lbl_Cliente4.Text;
            Properties.Settings.Default.lbl_Cliente5 = lbl_Cliente5.Text;
            Properties.Settings.Default.lbl_Cliente6 = lbl_Cliente6.Text;
            Properties.Settings.Default.lbl_Cliente7 = lbl_Cliente7.Text;
            Properties.Settings.Default.lbl_Cliente8 = lbl_Cliente8.Text;
            Properties.Settings.Default.lbl_Cliente9 = lbl_Cliente9.Text;
            Properties.Settings.Default.lbl_Cliente10 = lbl_Cliente10.Text;
            Properties.Settings.Default.lbl_Cliente11 = lbl_Cliente11.Text;
            Properties.Settings.Default.lbl_Cliente12 = lbl_Cliente12.Text;
            Properties.Settings.Default.lbl_Cliente13 = lbl_Cliente13.Text;
            Properties.Settings.Default.lbl_Cliente14 = lbl_Cliente14.Text;
            Properties.Settings.Default.lbl_Cliente15 = lbl_Cliente15.Text;
            Properties.Settings.Default.lbl_Cliente16 = lbl_Cliente16.Text;
            Properties.Settings.Default.lbl_Cliente17 = lbl_Cliente17.Text;
            Properties.Settings.Default.lbl_Cliente18 = lbl_Cliente18.Text;
            Properties.Settings.Default.lbl_Cliente19 = lbl_Cliente19.Text;
            Properties.Settings.Default.lbl_Cliente20 = lbl_Cliente20.Text;
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
            lbl_Versao5.Text = "";
            lbl_DataMod5.Text = "";
            lbl_Versao6.Text = "";
            lbl_DataMod6.Text = "";
            lbl_Versao7.Text = "";
            lbl_DataMod7.Text = "";
            lbl_Versao8.Text = "";
            lbl_DataMod8.Text = "";
            lbl_Versao9.Text = "";
            lbl_DataMod9.Text = "";
            lbl_Versao10.Text = "";
            lbl_DataMod10.Text = "";
            lbl_Versao11.Text = "";
            lbl_DataMod11.Text = "";
            lbl_Versao12.Text = "";
            lbl_DataMod12.Text = "";
            lbl_Versao13.Text = "";
            lbl_DataMod13.Text = "";
            lbl_Versao14.Text = "";
            lbl_DataMod14.Text = "";
            lbl_Versao15.Text = "";
            lbl_DataMod15.Text = "";
            lbl_Versao16.Text = "";
            lbl_DataMod16.Text = "";
            lbl_Versao17.Text = "";
            lbl_DataMod17.Text = "";
            lbl_Versao18.Text = "";
            lbl_DataMod18.Text = "";
            lbl_Versao19.Text = "";
            lbl_DataMod19.Text = "";
            lbl_Versao20.Text = "";
            lbl_DataMod20.Text = "";
            ActiveControl = btn_CheckVersion;     
        }

        public string FolderDialog(string CurrentPath)
        {
            FolderBrowserDialog SelectFolder = new FolderBrowserDialog();
            SelectFolder.ShowDialog();
            string NewPath = SelectFolder.SelectedPath;
            string NewPathPlusFile = NewPath + @"\bin\HBSIS.Conselho.BLL.Financeiro.dll";
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

            lbl_Versao5.Text = GetFileVersion(FilePath5.Text, lbl_Cliente5.Text);
            lbl_DataMod5.Text = GetFileModDate(FilePath5.Text, lbl_Cliente5.Text);

            lbl_Versao6.Text = GetFileVersion(FilePath6.Text, lbl_Cliente6.Text);
            lbl_DataMod6.Text = GetFileModDate(FilePath6.Text, lbl_Cliente6.Text);

            lbl_Versao7.Text = GetFileVersion(FilePath7.Text, lbl_Cliente7.Text);
            lbl_DataMod7.Text = GetFileModDate(FilePath7.Text, lbl_Cliente7.Text);

            lbl_Versao8.Text = GetFileVersion(FilePath8.Text, lbl_Cliente8.Text);
            lbl_DataMod8.Text = GetFileModDate(FilePath8.Text, lbl_Cliente8.Text);

            lbl_Versao9.Text = GetFileVersion(FilePath9.Text, lbl_Cliente10.Text);
            lbl_DataMod9.Text = GetFileModDate(FilePath9.Text, lbl_Cliente10.Text);

            lbl_Versao11.Text = GetFileVersion(FilePath11.Text, lbl_Cliente11.Text);
            lbl_DataMod11.Text = GetFileModDate(FilePath11.Text, lbl_Cliente11.Text);

            lbl_Versao12.Text = GetFileVersion(FilePath12.Text, lbl_Cliente12.Text);
            lbl_DataMod12.Text = GetFileModDate(FilePath12.Text, lbl_Cliente12.Text);

            lbl_Versao13.Text = GetFileVersion(FilePath13.Text, lbl_Cliente13.Text);
            lbl_DataMod13.Text = GetFileModDate(FilePath13.Text, lbl_Cliente13.Text);

            lbl_Versao14.Text = GetFileVersion(FilePath14.Text, lbl_Cliente14.Text);
            lbl_DataMod14.Text = GetFileModDate(FilePath14.Text, lbl_Cliente14.Text);

            lbl_Versao15.Text = GetFileVersion(FilePath15.Text, lbl_Cliente15.Text);
            lbl_DataMod15.Text = GetFileModDate(FilePath15.Text, lbl_Cliente15.Text);

            lbl_Versao16.Text = GetFileVersion(FilePath16.Text, lbl_Cliente16.Text);
            lbl_DataMod16.Text = GetFileModDate(FilePath16.Text, lbl_Cliente16.Text);

            lbl_Versao17.Text = GetFileVersion(FilePath17.Text, lbl_Cliente17.Text);
            lbl_DataMod17.Text = GetFileModDate(FilePath17.Text, lbl_Cliente17.Text);

            lbl_Versao17.Text = GetFileVersion(FilePath17.Text, lbl_Cliente17.Text);
            lbl_DataMod17.Text = GetFileModDate(FilePath17.Text, lbl_Cliente17.Text);

            lbl_Versao18.Text = GetFileVersion(FilePath18.Text, lbl_Cliente18.Text);
            lbl_DataMod18.Text = GetFileModDate(FilePath18.Text, lbl_Cliente18.Text);

            lbl_Versao19.Text = GetFileVersion(FilePath19.Text, lbl_Cliente19.Text);
            lbl_DataMod19.Text = GetFileModDate(FilePath19.Text, lbl_Cliente19.Text);

            lbl_Versao20.Text = GetFileVersion(FilePath20.Text, lbl_Cliente20.Text);
            lbl_DataMod20.Text = GetFileModDate(FilePath20.Text, lbl_Cliente20.Text);
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
        private void btn_Folder5_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath5.Text;
            FilePath5.Text = FolderDialog(CurrentPath);
        }
        private void btn_Folder6_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath6.Text;
            FilePath6.Text = FolderDialog(CurrentPath);
        }
        private void btn_Folder7_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath7.Text;
            FilePath7.Text = FolderDialog(CurrentPath);
        }
        private void btn_Folder8_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath8.Text;
            FilePath8.Text = FolderDialog(CurrentPath);
        }
        private void btn_Folder9_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath9.Text;
            FilePath9.Text = FolderDialog(CurrentPath);
        }
        private void btn_Folder10_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath10.Text;
            FilePath10.Text = FolderDialog(CurrentPath);
        }
        private void btn_Folder11_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath11.Text;
            FilePath11.Text = FolderDialog(CurrentPath);
        }
        private void btn_Folder12_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath12.Text;
            FilePath12.Text = FolderDialog(CurrentPath);
        }
        private void btn_Folder13_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath13.Text;
            FilePath13.Text = FolderDialog(CurrentPath);
        }
        private void btn_Folder14_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath14.Text;
            FilePath14.Text = FolderDialog(CurrentPath);
        }
        private void btn_Folder15_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath15.Text;
            FilePath15.Text = FolderDialog(CurrentPath);
        }
        private void btn_Folder16_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath16.Text;
            FilePath16.Text = FolderDialog(CurrentPath);
        }
        private void btn_Folder17_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath17.Text;
            FilePath17.Text = FolderDialog(CurrentPath);
        }
        private void btn_Folder18_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath18.Text;
            FilePath18.Text = FolderDialog(CurrentPath);
        }
        private void btn_Folder19_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath19.Text;
            FilePath19.Text = FolderDialog(CurrentPath);
        }
        private void btn_Folder20_Click(object sender, EventArgs e)
        {
            string CurrentPath = FilePath20.Text;
            FilePath20.Text = FolderDialog(CurrentPath);
        }
    }
}
