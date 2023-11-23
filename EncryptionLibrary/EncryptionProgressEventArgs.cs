using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionLibrary
{
    public class EncryptionProgressEventArgs :EventArgs
    {
        public int ProgressPercentage { get; set; }
        public EncryptionProgressEventArgs(int progress) => ProgressPercentage = progress;
    }
}
