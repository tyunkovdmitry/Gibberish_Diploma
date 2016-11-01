namespace Gibberish_diploma
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.textBoxDecrypt = new System.Windows.Forms.TextBox();
            this.textBoxEncrypt = new System.Windows.Forms.TextBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 706);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(100, 23);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEncrypt.Location = new System.Drawing.Point(512, 706);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(121, 23);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Encrypt/Decrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveFile.Location = new System.Drawing.Point(906, 706);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(100, 23);
            this.buttonSaveFile.TabIndex = 3;
            this.buttonSaveFile.Text = "Save File";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // textBoxDecrypt
            // 
            this.textBoxDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxDecrypt.Location = new System.Drawing.Point(12, 12);
            this.textBoxDecrypt.MaxLength = 2147483647;
            this.textBoxDecrypt.Multiline = true;
            this.textBoxDecrypt.Name = "textBoxDecrypt";
            this.textBoxDecrypt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDecrypt.Size = new System.Drawing.Size(493, 688);
            this.textBoxDecrypt.TabIndex = 0;
            // 
            // textBoxEncrypt
            // 
            this.textBoxEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEncrypt.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEncrypt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxEncrypt.Location = new System.Drawing.Point(513, 12);
            this.textBoxEncrypt.MaxLength = 2147483647;
            this.textBoxEncrypt.Multiline = true;
            this.textBoxEncrypt.Name = "textBoxEncrypt";
            this.textBoxEncrypt.ReadOnly = true;
            this.textBoxEncrypt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEncrypt.Size = new System.Drawing.Size(493, 688);
            this.textBoxEncrypt.TabIndex = 4;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "Russian",
            "English",
            "Russian/English"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(385, 706);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLanguage.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 741);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.textBoxEncrypt);
            this.Controls.Add(this.textBoxDecrypt);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonOpenFile);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "MainForm";
            this.Text = "Gibberish diploma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.TextBox textBoxDecrypt;
        private System.Windows.Forms.TextBox textBoxEncrypt;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
    }
}

