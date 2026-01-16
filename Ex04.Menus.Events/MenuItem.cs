using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public abstract class MenuItem
    {
        public string Title { get; }

        protected MenuItem(string i_Title) 
        {
            Title = i_Title;
        }

        internal abstract void OnSelected();
    }

    public class SubMenu : MenuItem
    {
        private readonly List<MenuItem> r_Items = new List<MenuItem>();

        public SubMenu(string i_Title) : base(i_Title) { }

        public void AddItem(MenuItem i_Item)
        {
            if (i_Item == null)
            {
                throw new ArgumentNullException(nameof(i_Item));
            }

            r_Items.Add(i_Item);
        }

        public void Show(bool i_IsMainMenu = false)
        {
            bool keepRunning = true;

            while(keepRunning)
            {
                Console.Clear();

                printMenu(i_IsMainMenu);

                int choice = readChoice(0, r_Items.Count);

                if(choice == 0)
                {
                    keepRunning = false;
                }
                else
                {
                    MenuItem selected = r_Items[choice - 1];
                    selected.OnSelected();

                    if (selected is ActionItem)
                    {
                        Console.WriteLine();
                        Console.ReadLine();
                    }
                }
            }
        }

        internal override void OnSelected()
        {
            Show(false);
        }

        private void printMenu(bool i_IsMainMenu)
        {
            Console.WriteLine("** {0} **", Title);
            Console.WriteLine("-------------------------");

            for (int i = 0; i < r_Items.Count; i++)
            {
                Console.WriteLine("{0}. {1}: ", i + 1, r_Items[i].Title);
            }

            string printForFinish = i_IsMainMenu ? "Exit" : "Back";
            
            Console.WriteLine("0. {0}", printForFinish);
            Console.WriteLine("Please enter your choice: ");
        }

        private int readChoice(int i_Min, int i_Max)
        {
            while (true)
            {
                string input = Console.ReadLine();
                int value;

                if (int.TryParse(input, out value) && value >= i_Min && value <= i_Max)
                {
                    return value;
                }

                Console.WriteLine("Invalid input. Enter a number between {0} - {1}: ", i_Min, i_Max);
            }
        }
    }

    public class ActionItem : MenuItem
    {
        public event Action Selected;

        public ActionItem(string i_Title) :base(i_Title) { }

        internal override void OnSelected()
        {
            if (Selected != null)
            {
                Selected.Invoke();
            }
        }
    }

    public class MainMenu
    {
        private readonly SubMenu r_RootMenu;

        public MainMenu(string i_Title)
        {
            r_RootMenu = new SubMenu(i_Title);
        }

        public void AddItem(MenuItem i_Item)
        {
            r_RootMenu.AddItem(i_Item);
        }

        public void Show()
        {
            r_RootMenu.Show(true);
        }
    }
}
