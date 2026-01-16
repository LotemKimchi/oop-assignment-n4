using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class CountLowercaseAction : IMenuAction
    {
        public void Execute()
        {
            int count = 0;
            string input =  Console.ReadLine();
            
            if (input == null)
            {
                input = "";
            }

            foreach (char ch in  input)
            {
                if (char.IsLower(ch))
                {
                    count++;
                }
            }

            Console.WriteLine("There are {0} lowercase letters in your text", count);
        }
    }
}
