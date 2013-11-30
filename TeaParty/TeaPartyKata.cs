using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaParty
{
    public class TeaPartyKata: ITeaPartyKata
    {
        public string Welcome(string lastName, bool isWoman, bool isSir)
        {
            return string.Format("Hello {0} {1}", isWoman ? "Ms." : (isSir ? "Sir" : "Mr."), lastName);
        }
    }
}
