using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            //	Create a constant string with 8 colors separated by a comma
            const string MY_COLORS = "Blue,Red,Orange,Yellow,Green,Purple,Violet,Brown";
            string tempword = MY_COLORS;
            int find = MY_COLORS.IndexOf(",");
            int i = 1;
            while (i < num)
            {
                find = tempword.IndexOf(",");
                tempword = tempword.Substring(find + 1, tempword.Length-find -1);
                //test
                //Console.WriteLine(tempword);
                i++;
            }
            tempword = tempword.Substring(0, tempword.IndexOf(","));
            Console.WriteLine(tempword);
        }
    }
}
