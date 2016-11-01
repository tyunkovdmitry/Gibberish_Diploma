using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Gibberish_diploma
{
    public partial class MainForm : Form
    {
        string[] firstStrR = { "б", "в", "г", "д", "ж", "з", "к", "л", "м", "н", "Б", "В", "Г", "Д", "Ж", "З", "К", "Л", "М", "Н" };
        string[] secondStrR = { "щ", "ш", "ч", "ц", "х", "ф", "т", "с", "р", "п", "Щ", "Ш", "Ч", "Ц", "Х", "Ф", "Т", "С", "Р", "П" };
        string[] threeStrR = { "`щ`", "`ш`", "`ч`", "`ц`", "`х`", "`ф`", "`т`", "`с`", "`р`", "`п`", "`Щ`", "`Ш`", "`Ч`", "`Ц`", "`Х`", "`Ф`", "`Т`", "`С`", "`Р`", "`П`" };
        string[] firstStrE = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "B", "C", "D", "F", "G", "H", "J", "K", "L", "M" };
        string[] secondStrE = { "z", "x", "w", "v", "t", "s", "r", "q", "p", "n", "Z", "X", "W", "V", "T", "S", "R", "Q", "P", "N" };
        string[] threeStrE = { "`z`", "`x`", "`w`", "`v`", "`t`", "`s`", "`r`", "`q`", "`p`", "`n`", "`Z`", "`X`", "`W`", "`V`", "`T`", "`S`", "`R`", "`Q`", "`P`", "`N`" };
        

        public MainForm()
        {
            InitializeComponent();
            comboBoxLanguage.SelectedIndex = 2;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Text files (*.txt)|*.txt";
            openDialog.FilterIndex = 1;
            openDialog.RestoreDirectory = true;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openDialog.FileName;
                textBoxDecrypt.Text = File.ReadAllText(fileName, Encoding.UTF8);
                /*string decryptText = File.ReadAllText(fileName, Encoding.UTF8);
                textBoxDecode.Text = decodeText;*/
            }
        }

        private void buttonCode_Click(object sender, EventArgs e)
        {
            string encryptText = textBoxDecrypt.Text;
            if (comboBoxLanguage.SelectedIndex == 0 || comboBoxLanguage.SelectedIndex == 2)
            {
                for (int i = 0; i < firstStrR.Length; i++)
                {
                    encryptText = encryptText.Replace(secondStrR[i], threeStrR[i]);
                    encryptText = encryptText.Replace(firstStrR[i], secondStrR[i]);
                    encryptText = encryptText.Replace(threeStrR[i], firstStrR[i]);
                }
            }
            if (comboBoxLanguage.SelectedIndex == 1 || comboBoxLanguage.SelectedIndex == 2)
            {
                for (int i = 0; i < firstStrR.Length; i++)
                {
                    encryptText = encryptText.Replace(secondStrE[i], threeStrE[i]);
                    encryptText = encryptText.Replace(firstStrE[i], secondStrE[i]);
                    encryptText = encryptText.Replace(threeStrE[i], firstStrE[i]);
                }
            }
            textBoxEncrypt.Text = encryptText;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text files (*.txt)|*.txt";
            saveDialog.FilterIndex = 1;
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK && saveDialog.FileName.Length > 0)
            {
                File.WriteAllText(saveDialog.FileName, textBoxEncrypt.Text, Encoding.UTF8);
            }
        }
    }
}