using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeAndBob
{
    internal class Guy
    {
        public string Name;
        public int Cash;


        /// <summary>
        /// Write my name and the amount of cash I have to the console.
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine($"{Name} has {Cash} in bucks.");
        }

        /// <summary>
        /// Gives some of my cash, removing it from my wallet (or printing
        /// a message to the console if I don't have enough cash).
        /// </summary>
        /// <param name="amount">Amount of cash to give.</param>
        /// <returns>
        /// The amount of cash removed from my wallet, or 0 if I don't
        /// have enough cash (or if the amount is valid).
        /// </returns>
        public int GiveCash(int amount)
        {
            if (amount < 0)
            {
                Console.Write($"{Name} says: {amount} isn't a valid amount");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine($"{Name} says: I don't have enought cash to give you {amount}");
                return 0;
            }
            Cash -= amount;
            return amount;
        }

        /// <summary>
        /// Recive some cash, adding it to my wallet (or printing
        /// a message to the console if the amount is valid.
        /// </summary>
        /// <param name="amount">Amount of cash to give.</param>
        public void RecieveCash(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine($"{Name} say: {amount} isn't an amount I'll take.");
            }
            else
            {
                Cash += amount;
            }
        }
    }
}
