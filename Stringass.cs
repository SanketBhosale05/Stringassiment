//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Eventing.Reader;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace assignment
//{
//    public  class Stringass
//    {
//       // Write a program to count occurrences of a character in given string.

//        static void Main(string[] args)
//        {
//            //string str = "good moring ";

//            //Console.WriteLine(" enter any char");
//            //char ch =Convert.ToChar(Console.ReadLine());

//            //char[] array = str.ToCharArray();
//            //int count = 0;


//            //for (int i = 0; i < array.Length; i++)
//            //{
//            //    if (ch == array[i])
//            //    {
//            //        count++;
//            //    }

//            //}
//            //Console.WriteLine(count);



//            // Write a program to trim leading white space characters in a string.

//            //string str ="    hello everyone  ";
//            //str = str.Trim();

//            //Console.WriteLine(str);



//            //
//            //Write a program to count total number of words in a string.

//            //string str = " hello everyone";

//            //char[]arr= str.ToCharArray();
//            //int count = 0;
//            //for (int i = 0; i < arr.Length; i++)
//            //{
//            //    count++;
//            //}
//            //Console.WriteLine(count);

//            // Write a program to check whether given string is palindrome or not.


//            Console.WriteLine(" enter word");
//             string str1 = Console.ReadLine();
//            // string reverse = string.Empty;
//             //string str = str1.Reverse().ToString();

            
//            string str2 = string.Empty;
//            for (int i = str1.Length - 1; i >= 0; i--)
//            {
//                str2 = str2 + str1[i];

//            }
//                if ( str2 == str1)
//                {
//                    Console.WriteLine("given string in palindrome");
//                }
//                else
//                {
//                    Console.WriteLine("not palindrome");


//                }

//            //WAP to find longest word in the given sentence

//            Console.WriteLine("enter you sentences");
//            string str3 = Console.ReadLine();
//            string[] str4 = str1.Split(new[] { " " }, StringSplitOptions.None);
//            int count = 0;  string word = string.Empty;
//            foreach (string str in str4)
//            {
//                if (str.Length> count)
//                {
//                    count= str.Length;
//                    word = str;
//                }
//            }
//            Console.WriteLine($"logest word is {word}, and lenth = { count }");






























//            // if (str1==str )
//            // {
//            //     Console.WriteLine("its palindrome");
//            // }
//            // else
//            // {
//            //     Console.WriteLine("not palindrome");
//            // }












//        }
//    }
//}
