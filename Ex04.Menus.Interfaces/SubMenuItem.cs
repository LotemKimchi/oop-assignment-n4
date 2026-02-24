using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class SubMenuItem : MenuItem
    {
        private readonly List<MenuItem> r_Children = new List<MenuItem>();

        public IList<MenuItem> Children
        {
            get { return r_Children; }
        }

        public override bool IsLeaf
        {
            get { return false; }
        }

        public SubMenuItem(string i_Title) : base(i_Title)
        {
        }

        public void AddChild(MenuItem i_Child)
        {
            if (i_Child == null)
            {
                throw new ArgumentNullException("i_Child");
            }

            i_Child.Parent = this;
            r_Children.Add(i_Child);
        }

        public override void OnChosen()
        {
        }
    }
}