using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersionAction : IMenuAction
    {
        public void Execute()
        {
            AppActions.ShowVersion();
        }
    }

    public class CountLowercaseAction : IMenuAction
    {
        public void Execute()
        {
            AppActions.CountLowercase();
        }
    }

    public class ShowTimeAction : IMenuAction
    {
        public void Execute()
        {
            AppActions.ShowTime();
        }
    }

    public class ShowDateAction : IMenuAction
    {
        public void Execute()
        {
            AppActions.ShowDate();
        }
    }
}