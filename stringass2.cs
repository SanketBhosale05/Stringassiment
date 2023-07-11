using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public class stringass2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter you sentences");
            string str3 = Console.ReadLine();
            string[] str4 = str3.Split(new[] { " " }, StringSplitOptions.None);
            int count = 0; string word = string.Empty;
            foreach (string str in str4)
            {
                if (str.Length > count)
                {
                    count = str.Length;
                    word = str;
                }
            }
            Console.WriteLine($"logest word is {word}, and lenth = {count}");

        }
    }
}
