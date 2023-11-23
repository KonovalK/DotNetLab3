using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionLibrary
{
    public class EncryptionTimeEventArgs : EventArgs
    {

        public int Seconds { get; set; }

        public int Minutes { get;set; }

        public int Hours { get;set ;}

        public EncryptionTimeEventArgs(int hour, int min, int sec)
        {
            Hours = hour;
            Minutes = min;
            Seconds = sec;
        }

        public override string ToString()
        {
            if(Hours == 0 && Minutes != 0)
            {
                return $"0:{Minutes}:{Seconds}";
            }
            else if(Hours == 0 && Minutes == 0)
            {
                return $"0:0:{Seconds}";
            }
            else
            {
                return $"{Hours}:{Minutes}:{Seconds}";
            }
        }
    }
}
