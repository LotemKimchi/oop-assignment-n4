using Ex04.Menus.Interfaces;

using EventsMainMenu = Ex04.Menus.Events.MainMenu;
using EventsSubMenuItem = Ex04.Menus.Events.SubMenuItem;
using EventsActionMenuItem = Ex04.Menus.Events.ActionMenuItem;

namespace Ex04.Menus.Test
{
    public static class MenusBuilder
    {
        public static MainMenu BuildInterfacesMenu()
        {
            MainMenu mainMenu = new MainMenu("Interfaces Main Menu");
            SubMenuItem versionAndLowercaseSubMenu = new SubMenuItem("Version and Lowercase");
            versionAndLowercaseSubMenu.AddChild(new ActionMenuItem("Show Version", new ShowVersionAction()));
            versionAndLowercaseSubMenu.AddChild(new ActionMenuItem("Count Lowercase", new CountLowercaseAction()));
            SubMenuItem currentTimeDateSubMenu = new SubMenuItem("Show Current Date/Time");
            currentTimeDateSubMenu.AddChild(new ActionMenuItem("Show Current Time", new ShowTimeAction()));
            currentTimeDateSubMenu.AddChild(new ActionMenuItem("Show Current Date", new ShowDateAction()));
            mainMenu.Root.AddChild(versionAndLowercaseSubMenu);
            mainMenu.Root.AddChild(currentTimeDateSubMenu);

            return mainMenu;
        }

        public static EventsMainMenu BuildDelegatesMenu()
        {
            EventsMainMenu mainMenu = new EventsMainMenu("Delegates Main Menu");
            EventsSubMenuItem versionAndLowercaseSubMenu = new EventsSubMenuItem("Version and Lowercase");
            EventsActionMenuItem showVersionItem = new EventsActionMenuItem("Show Version");
            showVersionItem.ItemChosenDelegates += AppActions.ShowVersion;
            EventsActionMenuItem countLowercaseItem = new EventsActionMenuItem("Count Lowercase");
            countLowercaseItem.ItemChosenDelegates += AppActions.CountLowercase;
            versionAndLowercaseSubMenu.AddChild(showVersionItem);
            versionAndLowercaseSubMenu.AddChild(countLowercaseItem);
            EventsSubMenuItem currentTimeDateSubMenu = new EventsSubMenuItem("Show Current Date/Time");
            EventsActionMenuItem showTimeItem = new EventsActionMenuItem("Show Current Time");
            showTimeItem.ItemChosenDelegates += AppActions.ShowTime;
            EventsActionMenuItem showDateItem = new EventsActionMenuItem("Show Current Date");
            showDateItem.ItemChosenDelegates += AppActions.ShowDate;
            currentTimeDateSubMenu.AddChild(showTimeItem);
            currentTimeDateSubMenu.AddChild(showDateItem);
            mainMenu.Root.AddChild(versionAndLowercaseSubMenu);
            mainMenu.Root.AddChild(currentTimeDateSubMenu);

            return mainMenu;
        }
    }
}
