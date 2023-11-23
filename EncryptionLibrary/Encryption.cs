using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace EncryptionLibrary
{
    public class Encryption
    {
        public string FilePath { get; set; }
        public string Password { get; set; }

        public event EventHandler<EncryptionProgressEventArgs> ProgressChanged;

        public event EventHandler<EncryptionTimeEventArgs> TimeChanged;
        public Encryption(string filePath, string password)
        {
            FilePath = filePath;
            Password = password;
        }
                
        public double GetFileSize()
        {
            FileInfo file = new FileInfo(this.FilePath);
            return file.Length;
        }

        public void EncryptFile()
        {
            FileStream file = File.OpenRead(FilePath);
            FileStream resFile = File.OpenWrite(FilePath + ".encrd");
            Stopwatch watch = new Stopwatch();
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (o, e) =>
            {
                using (file)
                {
                    using (resFile)
                    {
                        watch.Start();
                        int symb, passwordIndex = 0, count = 1;
                        while ((symb = file.ReadByte()) != -1)
                        {
                            symb = symb ^ Password[passwordIndex++];
                            resFile.WriteByte((byte)symb);
                            if (passwordIndex >= Password.Length)
                            {
                                passwordIndex = 0;
                            }
                            GetProgressPercent((int)((count * 1.0) / file.Length * 100));
                            count++;
                        }
                    }
                }
                watch.Stop();
                GetEcnryptionDuration(watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds);
            };
            worker.RunWorkerAsync();
        }

        public void DecryptFile()
        {
            BackgroundWorker worker = new BackgroundWorker();
            Stopwatch watch = new Stopwatch();
            FileStream file = File.OpenRead(FilePath);
            FilePath = FilePath.Replace(".encrd", "");
            FileStream resFile = File.OpenWrite(FilePath + ".dencrd");
            worker.DoWork += (o, e) =>
            {
                using (file)
                {
                    using (resFile)
                    {
                        watch.Start();
                        int symb;
                        int count = 1;
                        int passwordIndex = 0;
                        while ((symb = file.ReadByte()) != -1)
                        {
                            symb = symb ^ Password[passwordIndex];
                            passwordIndex++;
                            resFile.WriteByte((byte)symb);
                            if (passwordIndex >= Password.Length) passwordIndex = 0;
                            GetProgressPercent((int)((count * 1.0) / file.Length * 100));
                            count++;
                        }
                    }
                }
                watch.Stop();
                GetEcnryptionDuration(watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds);
            };
            worker.RunWorkerAsync();
        }
        private void GetProgressPercent(int percent)
        {
            if (ProgressChanged != null)
            {
                ProgressChanged(this, new EncryptionProgressEventArgs(percent));
            }
        }

        private void GetEcnryptionDuration(int hours, int minutes, int secs)
        {
            if (TimeChanged != null)
            {
                TimeChanged(this, new EncryptionTimeEventArgs(hours, minutes, secs));
            }
        }

    }
}
