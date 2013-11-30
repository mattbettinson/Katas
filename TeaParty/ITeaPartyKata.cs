﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaParty
{
    public interface ITeaPartyKata
    {
        /*You are dead – but that doesn’t mean you can’t throw a social event.
         * In heaven you are famous for your extraordinary tea parties.
         * This time the guest list is quite astonishing – 8 famous British people announced their visit.
         * So don’t mess up!
         * Your task is to welcome your guests properly: Some are female and some were knighted by the queen.
         * So greet them correctly – or this will be your last hosting.
         * 
         * For example:
         * -Jane Austen is a women, so say Hello Ms. Austen
         * -George Orwell is a man, so say Hello Mr. Orwell
         * -Isaac Newton was knighted, so say Hello Sir Newton  
         */

        /// <summary>
        /// Welcome a guest
        /// </summary>
        /// <param name="lastName">the last name of the guest</param>
        /// <param name="isWoman"><c>true</c> if the guest is female</param>
        /// <param name="isSir"><c>true</c> if the guest was knighted by the queen</param>
        /// <returns>issues welcome text to the guest</returns>
        string Welcome(string lastName, bool isWoman, bool isSir); 
    }
}
