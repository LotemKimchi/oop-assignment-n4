using System;

namespace Ex04.Menus.Interfaces
{
    public class ActionMenuItem : MenuItem
    {
        private readonly IMenuAction r_Action;

        public override bool IsLeaf
        {
            get { return true; }
        }

        public ActionMenuItem(string i_Title, IMenuAction i_Action) : base(i_Title)
        {
            if (i_Action == null)
            {
                throw new ArgumentNullException("i_Action");
            }

            r_Action = i_Action;
        }

        public override void OnChosen()
        {
            r_Action.Execute();
        }
    }
}