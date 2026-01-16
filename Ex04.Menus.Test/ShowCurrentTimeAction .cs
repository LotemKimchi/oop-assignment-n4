using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class ShowCurrentTimeAction : IMenuAction
    {
        public void Execute() 
        {
            Console.WriteLine("Current Time: {0:HH:mm:ss}", DateTime.Now);
        }
    }
}
