
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
            this.lbl_Cliente1 = new System.Windows.Forms.Label();
            this.FilePath1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Versao1 = new System.Windows.Forms.Label();
            this.SaveSettings_Btn = new System.Windows.Forms.Button();
            this.btn_CheckVersion = new System.Windows.Forms.Button();
            this.folder1_btn = new System.Windows.Forms.Button();
            this.lbl_DataMod1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Cliente1
            // 
            this.lbl_Cliente1.AutoSize = true;
            this.lbl_Cliente1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Cliente1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cliente1.Location = new System.Drawing.Point(179, 33);
            this.lbl_Cliente1.Name = "lbl_Cliente1";
            this.lbl_Cliente1.Size = new System.Drawing.Size(72, 17);
            this.lbl_Cliente1.TabIndex = 0;
            this.lbl_Cliente1.Text = "Cliente 1";
            this.lbl_Cliente1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FilePath1
            // 
            this.FilePath1.Location = new System.Drawing.Point(182, 67);
            this.FilePath1.Name = "FilePath1";
            this.FilePath1.Size = new System.Drawing.Size(590, 22);
            this.FilePath1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Versão:";
            // 
            // lbl_Versao1
            // 
            this.lbl_Versao1.AutoSize = true;
            this.lbl_Versao1.Location = new System.Drawing.Point(450, 33);
            this.lbl_Versao1.Name = "lbl_Versao1";
            this.lbl_Versao1.Size = new System.Drawing.Size(37, 17);
            this.lbl_Versao1.TabIndex = 0;
            this.lbl_Versao1.Text = "Num";
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
            // btn_CheckVersion
            // 
            this.btn_CheckVersion.Location = new System.Drawing.Point(83, 375);
            this.btn_CheckVersion.Name = "btn_CheckVersion";
            this.btn_CheckVersion.Size = new System.Drawing.Size(164, 39);
            this.btn_CheckVersion.TabIndex = 2;
            this.btn_CheckVersion.Text = "Verificar Versão";
            this.btn_CheckVersion.UseVisualStyleBackColor = true;
            this.btn_CheckVersion.Click += new System.EventHandler(this.CheckVersion_Click);
            // 
            // folder1_btn
            // 
            this.folder1_btn.Location = new System.Drawing.Point(19, 62);
            this.folder1_btn.Name = "folder1_btn";
            this.folder1_btn.Size = new System.Drawing.Size(144, 33);
            this.folder1_btn.TabIndex = 3;
            this.folder1_btn.Text = "Selecionar Pasta";
            this.folder1_btn.UseVisualStyleBackColor = true;
            this.folder1_btn.Click += new System.EventHandler(this.folder1_btn_Click);
            // 
            // lbl_DataMod1
            // 
            this.lbl_DataMod1.AutoSize = true;
            this.lbl_DataMod1.Location = new System.Drawing.Point(636, 33);
            this.lbl_DataMod1.Name = "lbl_DataMod1";
            this.lbl_DataMod1.Size = new System.Drawing.Size(38, 17);
            this.lbl_DataMod1.TabIndex = 4;
            this.lbl_DataMod1.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Modificação:";
            // 
            // VersionChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_DataMod1);
            this.Controls.Add(this.folder1_btn);
            this.Controls.Add(this.btn_CheckVersion);
            this.Controls.Add(this.SaveSettings_Btn);
            this.Controls.Add(this.FilePath1);
            this.Controls.Add(this.lbl_Versao1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Cliente1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VersionChecker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Version Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FilePath1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Versao1;
        private System.Windows.Forms.Button SaveSettings_Btn;
        private System.Windows.Forms.Button btn_CheckVersion;
        private System.Windows.Forms.Button folder1_btn;
        private System.Windows.Forms.Label lbl_DataMod1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_Cliente1;
    }
}

