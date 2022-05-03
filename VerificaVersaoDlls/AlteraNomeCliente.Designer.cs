
namespace VerificaVersaoDlls
{
    partial class AlteraNomeCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_InsiraNomeCliente = new System.Windows.Forms.Label();
            this.btn_SalvarNomeCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label_InsiraNomeCliente
            // 
            this.label_InsiraNomeCliente.AutoSize = true;
            this.label_InsiraNomeCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InsiraNomeCliente.Location = new System.Drawing.Point(111, 28);
            this.label_InsiraNomeCliente.Name = "label_InsiraNomeCliente";
            this.label_InsiraNomeCliente.Size = new System.Drawing.Size(187, 17);
            this.label_InsiraNomeCliente.TabIndex = 1;
            this.label_InsiraNomeCliente.Text = "Insira o nome do cliente.";
            // 
            // btn_SalvarNomeCliente
            // 
            this.btn_SalvarNomeCliente.Location = new System.Drawing.Point(145, 102);
            this.btn_SalvarNomeCliente.Name = "btn_SalvarNomeCliente";
            this.btn_SalvarNomeCliente.Size = new System.Drawing.Size(107, 40);
            this.btn_SalvarNomeCliente.TabIndex = 2;
            this.btn_SalvarNomeCliente.Text = "Salvar";
            this.btn_SalvarNomeCliente.UseVisualStyleBackColor = true;
            this.btn_SalvarNomeCliente.Click += new System.EventHandler(this.btn_SalvarNomeCliente_Click);
            // 
            // AlteraNomeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 164);
            this.Controls.Add(this.btn_SalvarNomeCliente);
            this.Controls.Add(this.label_InsiraNomeCliente);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AlteraNomeCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar nome do cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_InsiraNomeCliente;
        public System.Windows.Forms.Button btn_SalvarNomeCliente;
    }
}