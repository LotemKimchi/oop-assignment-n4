using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesMenu = Ex04.Menus.Interfaces;
using EventsMenu = Ex04.Menus.Events;


namespace Ex04.Menus.Test
{
    internal class Program
    {
        public static void Main()
        {
            /// Creating 2 employies, passing each a reference to this company, as IReportSickListener
            /// first ad Interface - first menu
            InterfacesMenu.MainMenu interfacesMenu = MenusBuilder.BuildInterfacesMenu();
            interfacesMenu.Show();

            EventsMenu.MainMenu eventsMenu = MenusBuilder.BuildEventsMenu();
            eventsMenu.Show();

            /// second as event and delecate action <T>- second menu
            /// 
        }
    }
}
