using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncryptionLibrary;

namespace FileEncryptionWinForm
{
    public partial class Form1 : Form
    {
        private bool fl = false;
        private double fileSize;
        private BackgroundWorker bgWorker = new BackgroundWorker();
        public Form1()
        {
            InitializeComponent();
            bgWorker.WorkerReportsProgress = true;
        }

        private void buttonEncryption_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != null && passwordTextBox.Text != "")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = "c:\\";
                ofd.FilterIndex = 0;
                ofd.RestoreDirectory = true;
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    fl = true;
                    string pathFile = ofd.FileName;
                    Encryption encyptor = new Encryption(pathFile, passwordTextBox.Text);
                    encyptor.ProgressChanged += changeProgressBarValue;
                    encyptor.TimeChanged += getTimeOfEncryption;
                    encyptor.EncryptFile();
                    fileSize = (double)encyptor.GetFileSize();
                }
            }
            else
            {
                MessageBox.Show("Введіть пароль!");
            }
        }

        private void changeProgressBarValue(object sender, EncryptionProgressEventArgs e)
        {
            this.Invoke(
                new Action(() =>
                {
                    progressBarEcryption.Visible = true;
                    currentProgressLabel.Visible = true;
                    progressBarEcryption.Value = e.ProgressPercentage;
                    currentProgressLabel.Text = $"{e.ProgressPercentage}%";
                    if (e.ProgressPercentage == 100)
                    {
                        MessageBox.Show("Процес закінчився успішно!");

                        progressBarEcryption.Visible = false;
                        currentProgressLabel.Visible = false;
                    }
                }));
        }

        private void getTimeOfEncryption(object sender,EncryptionTimeEventArgs e)
        {
            this.Invoke(
                new Action(() =>
                {
                    if(fl)
                        EncryptionInfoLabel.Text = $"Час шифрування: {e.ToString()}\nРозмір зашифрованого файлу: {fileSize} байтів";
                    else
                        EncryptionInfoLabel.Text = $"Час дешифрування: {e.ToString()}\nРозмір дешифрованого файлу: {fileSize} байтів";    
                }));
        }
    }
}
