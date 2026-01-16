using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowVersionAction : IMenuAction
    {
        public void Execute()
        {
            Console.WriteLine("App Version: 26.1.4.5940");
        }
    }
}
