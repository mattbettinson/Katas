using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaCountdown
{
    public class NasaCountdownKata: INasaCountdownKata
    {
        public int[] Countdown(int start)
        {
            var list = new List<int>();

            do
            {
                if (start < 0)
                    break;

                list.Add(start);
                start--;
            }
            while(start > -1);

            return list.ToArray();
        }
    }
}
