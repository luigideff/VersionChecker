using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificaVersaoDlls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void GetSettings()
        {
            textBox1.Text = Properties.Settings.Default.DllPath1;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.DllPath1 = textBox1.Text;
            Properties.Settings.Default.Save();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetSettings();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }
    }
}
