using System;
using InterfacesMenu = Ex04.Menus.Interfaces;
using EventsMenu = Ex04.Menus.Events;

namespace Ex04.Menus.Test
{
    internal static class MenusBuilder
    {
        private const string k_InterfaceMainTitle = "Interfaces Main Menu";
        private const string k_EventsMainTitle = "Events Main Menu";

        private const string k_VersionAndLowercaseTitle = "Version and Lowercase";
        private const string k_ShowDateTimeTitle = "Show Current Date/Time";

        public static InterfacesMenu.MainMenu BuildInterfacesMenu()
        {
            InterfacesMenu.MainMenu mainMenu = new InterfacesMenu.MainMenu(k_InterfaceMainTitle);

            // SubMenu: Version and Lowercase
            InterfacesMenu.SubMenu versionAndLowercase = new InterfacesMenu.SubMenu(k_VersionAndLowercaseTitle);
            versionAndLowercase.AddItem(
                new InterfacesMenu.ActionItem("Show Version", new ShowVersionAction()));
            versionAndLowercase.AddItem(
                new InterfacesMenu.ActionItem("Count Lowercase", new CountLowercaseAction()));

            // SubMenu: Date/Time
            InterfacesMenu.SubMenu dateTimeMenu = new InterfacesMenu.SubMenu(k_ShowDateTimeTitle);
            dateTimeMenu.AddItem(
                new InterfacesMenu.ActionItem("Show Current Time", new ShowCurrentTimeAction()));
            dateTimeMenu.AddItem(
                new InterfacesMenu.ActionItem("Show Current Date", new ShowCurrentDateAction()));

            // Root
            mainMenu.AddItem(versionAndLowercase);
            mainMenu.AddItem(dateTimeMenu);

            return mainMenu;
        }

        public static EventsMenu.MainMenu BuildEventsMenu()
        {
            EventsMenu.MainMenu mainMenu = new EventsMenu.MainMenu(k_EventsMainTitle);

            // SubMenu: Version and Lowercase
            EventsMenu.SubMenu versionAndLowercase = new EventsMenu.SubMenu(k_VersionAndLowercaseTitle);

            EventsMenu.ActionItem showVersion = new EventsMenu.ActionItem("Show Version");
            showVersion.Selected += onShowVersion;

            EventsMenu.ActionItem countLowercase = new EventsMenu.ActionItem("Count Lowercase");
            countLowercase.Selected += onCountLowercase;

            versionAndLowercase.AddItem(showVersion);
            versionAndLowercase.AddItem(countLowercase);

            // SubMenu: Date/Time
            EventsMenu.SubMenu dateTimeMenu = new EventsMenu.SubMenu(k_ShowDateTimeTitle);

            EventsMenu.ActionItem showTime = new EventsMenu.ActionItem("Show Current Time");
            showTime.Selected += onShowCurrentTime;

            EventsMenu.ActionItem showDate = new EventsMenu.ActionItem("Show Current Date");
            showDate.Selected += onShowCurrentDate;

            dateTimeMenu.AddItem(showTime);
            dateTimeMenu.AddItem(showDate);

            // Root
            mainMenu.AddItem(versionAndLowercase);
            mainMenu.AddItem(dateTimeMenu);

            return mainMenu;
        }

        // ===== Events callbacks =====

        private static void onShowVersion()
        {
            Console.WriteLine("App Version: 26.1.4.5940");
        }

        private static void onCountLowercase()
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine() ?? string.Empty;

            int count = 0;
            foreach (char c in input)
            {
                if (char.IsLetter(c) && char.IsLower(c))
                {
                    count++;
                }
            }

            Console.WriteLine("There are {0} lowercase letters in your text", count);
        }

        private static void onShowCurrentTime()
        {
            Console.WriteLine("Current Time: {0:HH:mm:ss}", DateTime.Now);
        }

        private static void onShowCurrentDate()
        {
            Console.WriteLine("Current Date: {0:yyyy-MM-dd}", DateTime.Now);
        }
    }
}
