using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaCountdown
{
    public interface INasaCountdownKata
    {   
        /*The NASA wants to shoot yet another rocket to the orbit.
         * As this is your first day as a wannabe scientist at the ground control, you are very excited.
         * So excited that when the guy responsible for the countdown asks you to bring him some coffee,
         * you accidentally spill it all over his lap and the computer
         * – both are not capable of doing their job now.
         * 
         * But the liftoff is only seconds away. 
         * Somebody has to do the countdown – or the rocket can’t start and millions of dollars are lost!
         * In a moment of great bravery you remember you learnt how to count (a long time ago in High School).
         * So you take the chance!
         * 
         * The ground control chief will tell you where to start – then count to 0.
         * (example for ’11’: 11 10 9 8 7 6 5 4 3 2 1 0)
         */

        /// <summary>
        /// Issue the NASA countdown
        /// </summary>
        /// <param name="start">number to start with</param>
        /// <returns>array with numbers from 'start' to 0</returns>
        int[] Countdown(int start);
    }
}
