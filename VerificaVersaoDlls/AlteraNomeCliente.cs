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
    public partial class AlteraNomeCliente : Form
    {
        public AlteraNomeCliente()
        {
            InitializeComponent();
            
        }

        public string Text { get; set; } = "ok";


        public void btn_SalvarNomeCliente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) != true)
            {
                Text = textBox1.Text;
                Close();
            }
            else
            {
                MessageBox.Show("O nome não pode ser vazio.");
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_SalvarNomeCliente_Click(this, new EventArgs());     
            }
        }
    }
}
