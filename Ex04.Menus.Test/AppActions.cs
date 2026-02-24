using System;

namespace Ex04.Menus.Test
{
    public static class AppActions
    {
        private const string k_Version = "26.1.4.5940";

        public static void ShowVersion()
        {
            Console.WriteLine(string.Format("App Version: {0}", k_Version));
        }

        public static void CountLowercase()
        {
            Console.WriteLine("Please enter a sentence:");
            Console.Write(">> ");

            string sentence = Console.ReadLine();
            int lowercaseCount = 0;

            if (sentence != null)
            {
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (char.IsLower(sentence[i]))
                    {
                        lowercaseCount++;
                    }
                }
            }

            Console.WriteLine(string.Format("> There are {0} lowercase letters in your text", lowercaseCount));
        }

        public static void ShowTime()
        {
            Console.WriteLine(string.Format("> Current Time is {0}", DateTime.Now.ToLongTimeString()));
        }

        public static void ShowDate()
        {
            Console.WriteLine(string.Format("> Current Date is {0}", DateTime.Now.ToShortDateString()));
        }
    }
}