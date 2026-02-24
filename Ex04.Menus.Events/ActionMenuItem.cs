using System;

namespace Ex04.Menus.Events
{
    public class ActionMenuItem : MenuItem
    {
        public event Action ItemChosenDelegates;

        public override bool IsLeaf
        {
            get { return true; }
        }

        public ActionMenuItem(string i_Title) : base(i_Title)
        {
        }

        public override void OnChosen()
        {
            Action chosenHandler = ItemChosenDelegates;

            if (chosenHandler != null)
            {
                chosenHandler.Invoke();
            }
        }
    }
}