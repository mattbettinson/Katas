﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public interface IFizzBuzzKata
    {
        /*
         * It’s the summer of 1923. You and a few friends are on holiday in Goeteborg, Sweden.
         * After one round of starköl in the Nobel Bar you start to feel funny.
         * So you make fun of people around you – loudly.
         * As you spot someone who has that distinct Einstein-haircut you tell him that 
         * "only two things are infinite, the universe and your stupidity, and I’m not sure about the former".
         * As it turns out this man is indeed Einstein celebrating after his nobel price acceptance speech
         * – and now he is mad at you. 
         * To settle this issue like civilized gentlemen he proposes a little drinking game called "fizz-buzz".
         * In order to leave the table without a serious alcohol poisoning but some of your pride left you
         * decide to do what every person would do: Cheat!
         *
         * Rules
         * Any number divisible by three is replaced by the word fizz and any divisible by five by the word buzz.
         * Numbers divisible by both become fizzbuzz. A player who makes a mistake has to take a drink.
         * Einstein will choose a random number to start with
         * – for example: 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizzbuzz…
         */
        
        /// <summary>
        /// Give an answer to the current game
        /// </summary>
        /// <param name="number">current number in the game sequence</param>
        /// <returns>appropriate answer to the current number</returns>
        string Answer(int number);
    }
}
