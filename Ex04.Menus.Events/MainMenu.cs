using System;

namespace Ex04.Menus.Events
{
    public class MainMenu
    {
        private const string k_SeparatorLine = "------------------------";
        private const string k_InvalidInputMessage = "Invalid input. Please try again.";
        private readonly string r_MainTitle;
        private readonly SubMenuItem r_Root;

        public SubMenuItem Root
        {
            get { return r_Root; }
        }

        public MainMenu(string i_MainTitle)
        {
            if (string.IsNullOrEmpty(i_MainTitle))
            {
                throw new ArgumentException("Main title cannot be null or empty.", "i_MainTitle");
            }

            r_MainTitle = i_MainTitle;
            r_Root = new SubMenuItem(i_MainTitle);
        }

        public void Show()
        {
            bool isExitRequested = false;
            bool shouldClearScreen = true;
            SubMenuItem currentMenu = r_Root;

            while (!isExitRequested)
            {
                if (shouldClearScreen)
                {
                    Console.Clear();
                }

                printMenu(currentMenu, currentMenu == r_Root);
                int userChoice = readChoice(currentMenu.Children.Count, currentMenu == r_Root);

                if (userChoice == 0)
                {
                    if (currentMenu == r_Root)
                    {
                        isExitRequested = true;
                    }
                    else
                    {
                        currentMenu = currentMenu.Parent;
                        shouldClearScreen = true;
                    }
                }
                else
                {
                    MenuItem chosenItem = currentMenu.Children[userChoice - 1];

                    if (chosenItem.IsLeaf)
                    {
                        chosenItem.OnChosen();

                        Console.WriteLine();
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();

                        Console.Clear();
                    }
                    else
                    {
                        currentMenu = (SubMenuItem)chosenItem;
                        Console.Clear();
                    }
                }
            }
        }

        private void printMenu(SubMenuItem i_MenuToPrint, bool i_IsRoot)
        {
            printTitle(string.Format("** {0} **", i_MenuToPrint.Title));
            Console.WriteLine(k_SeparatorLine);

            for (int i = 0; i < i_MenuToPrint.Children.Count; i++)
            {
                Console.WriteLine(string.Format("{0}. {1}", i + 1, i_MenuToPrint.Children[i].Title));
            }

            Console.WriteLine(string.Format("0. {0}", i_IsRoot ? "Exit" : "Back"));
            Console.WriteLine(string.Format(
                "Please enter your choice (1-{0} or 0 to {1}):",
                i_MenuToPrint.Children.Count,
                i_IsRoot ? "exit" : "go back"));

            Console.Write(">> ");
        }

        private void printTitle(string i_Title)
        {
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(i_Title);
            Console.ForegroundColor = previousColor;
        }

        private int readChoice(int i_MaxOption, bool i_IsRoot)
        {
            bool isValidInput = false;
            int chosenNumber = 0;

            while (!isValidInput)
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out chosenNumber))
                {
                    Console.WriteLine(k_InvalidInputMessage);
                }
                else if (chosenNumber < 0 || chosenNumber > i_MaxOption)
                {
                    Console.WriteLine(string.Format("Invalid choice. Please enter a number between 0 and {0}.", i_MaxOption));
                }
                else
                {
                    isValidInput = true;
                }

                if (!isValidInput)
                {
                    Console.WriteLine(string.Format(
                        "Please enter your choice (1-{0} or 0 to {1}):",
                        i_MaxOption, i_IsRoot ? "exit" : "go back"));
                    Console.Write(">> ");
                }
            }

            return chosenNumber;
        }
    }
}
