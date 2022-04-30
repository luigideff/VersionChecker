
namespace VerificaVersaoDlls
{
    partial class VersionChecker
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
            this.label1 = new System.Windows.Forms.Label();
            this.FilePath1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Versao_Txt = new System.Windows.Forms.Label();
            this.SaveSettings_Btn = new System.Windows.Forms.Button();
            this.CheckVersion_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente 1";
            // 
            // FilePath1
            // 
            this.FilePath1.Location = new System.Drawing.Point(83, 70);
            this.FilePath1.Name = "FilePath1";
            this.FilePath1.Size = new System.Drawing.Size(610, 22);
            this.FilePath1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Versão:";
            // 
            // Versao_Txt
            // 
            this.Versao_Txt.AutoSize = true;
            this.Versao_Txt.Location = new System.Drawing.Point(247, 33);
            this.Versao_Txt.Name = "Versao_Txt";
            this.Versao_Txt.Size = new System.Drawing.Size(0, 17);
            this.Versao_Txt.TabIndex = 0;
            // 
            // SaveSettings_Btn
            // 
            this.SaveSettings_Btn.Location = new System.Drawing.Point(529, 375);
            this.SaveSettings_Btn.Name = "SaveSettings_Btn";
            this.SaveSettings_Btn.Size = new System.Drawing.Size(164, 39);
            this.SaveSettings_Btn.TabIndex = 2;
            this.SaveSettings_Btn.Text = "Salvar Configurações";
            this.SaveSettings_Btn.UseVisualStyleBackColor = true;
            this.SaveSettings_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckVersion_Btn
            // 
            this.CheckVersion_Btn.Location = new System.Drawing.Point(83, 375);
            this.CheckVersion_Btn.Name = "CheckVersion_Btn";
            this.CheckVersion_Btn.Size = new System.Drawing.Size(164, 39);
            this.CheckVersion_Btn.TabIndex = 2;
            this.CheckVersion_Btn.Text = "Verificar Versão";
            this.CheckVersion_Btn.UseVisualStyleBackColor = true;
            this.CheckVersion_Btn.Click += new System.EventHandler(this.CheckVersion_Click);
            // 
            // VersionChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckVersion_Btn);
            this.Controls.Add(this.SaveSettings_Btn);
            this.Controls.Add(this.FilePath1);
            this.Controls.Add(this.Versao_Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VersionChecker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Version Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilePath1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Versao_Txt;
        private System.Windows.Forms.Button SaveSettings_Btn;
        private System.Windows.Forms.Button CheckVersion_Btn;
    }
}

