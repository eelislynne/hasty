﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasty {
    class Misc {
        public static int UnixTime {
            get {
                int time = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                return time;
            }
        }

        public static string UnixToString(int time = -1) {
            if (time == -1)
                time = UnixTime;

            DateTime dateTime = new DateTime(1970, 1, 1);
            dateTime = dateTime.AddSeconds(time).ToLocalTime();
            return dateTime.ToString("g");
        }


        public static bool ByteCompare(byte[] a1, byte[] b1) {
            int i;
            if (a1.Length == b1.Length) {
                i = 0;
                while (i < a1.Length && (a1[i] == b1[i])) //Earlier it was a1[i]!=b1[i]
                {
                    i++;
                }
                if (i == a1.Length) {
                    return true;
                }
            }

            return false;
        }
    }
}
