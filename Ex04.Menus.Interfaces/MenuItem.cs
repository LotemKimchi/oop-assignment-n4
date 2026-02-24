using System;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private readonly string r_Title;

        public string Title
        {
            get { return r_Title; }
        }

        public SubMenuItem Parent
        {
            get;
            internal set;
        }

        protected MenuItem(string i_Title)
        {
            if (string.IsNullOrEmpty(i_Title))
            {
                throw new ArgumentException("Title cannot be null or empty.", "i_Title");
            }

            r_Title = i_Title;
        }

        public abstract bool IsLeaf { get; }

        public abstract void OnChosen();
    }
}