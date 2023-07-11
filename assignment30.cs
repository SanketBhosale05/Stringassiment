//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace assignment
//{
//    public  class Assignment30
//    // Write a program and make use of all string functions in it
//    {
//        static void Main()

//        {
           


        
            
//        //    {
//        //        string str = "Hello, World!";

//        //        // Length
//        //        int length = str.Length;
//        //        Console.WriteLine("Length: " + length);

//        //        // Substring
//        //        string substring = str.Substring(7, 5);
//        //        Console.WriteLine("Substring: " + substring);

//        //        // IndexOf
//        //        int indexOfComma = str.IndexOf(",");
//        //        Console.WriteLine("Index of ',': " + indexOfComma);

//        //        // Replace
//        //        string replacedString = str.Replace("Hello", "Hi");
//        //        Console.WriteLine("Replaced String: " + replacedString);

//        //        // ToLower
//        //        string lowerCase = str.ToLower();
//        //        Console.WriteLine("Lowercase: " + lowerCase);

//        //        // ToUpper
//        //        string upperCase = str.ToUpper();
//        //        Console.WriteLine("Uppercase: " + upperCase);

//        //        // Concatenation
//        //        string str1 = "Hello";
//        //        string str2 = "World";
//        //        string concatenatedString = string.Concat(str1, ", ", str2);
//        //        Console.WriteLine("Concatenated String: " + concatenatedString);

//        //        // Trim
//        //        string stringWithWhitespace = "   Trim me!   ";
//        //        string trimmedString = stringWithWhitespace.Trim();
//        //        Console.WriteLine("Trimmed String: " + trimmedString);

//        //        // Split
//        //        string sentence = "This is a sentence.";
//        //        string[] words = sentence.Split(' ');
//        //        Console.WriteLine("Words:");
//        //        foreach (string word in words)
//        //        {
//        //            Console.WriteLine(word);
//        //        }

//        //        // Join
//        //        string[] fruits = { "Apple", "Banana", "Orange" };
//        //        string joinedString = string.Join(", ", fruits);
//        //        Console.WriteLine("Joined String: " + joinedString);

//        //        // StartsWith
//        //        bool startsWithHello = str.StartsWith("Hello");
//        //        Console.WriteLine("Starts with 'Hello': " + startsWithHello);

//        //        // EndsWith
//        //        bool endsWithWorld = str.EndsWith("World!");
//        //        Console.WriteLine("Ends with 'World!': " + endsWithWorld);

//        //        // Contains
//        //        bool containsWorld = str.Contains("World");
//        //        Console.WriteLine("Contains 'World': " + containsWorld);

//        //        // Compare
//        //        int compareResult = string.Compare(str1, str2);
//        //        Console.WriteLine("Compare Result: " + compareResult);

//        //        // Format
//        //        int age = 25;
//        //        string name = "John";
//        //        string formattedString = string.Format("My name is {0} and I am {1} years old.", name, age);
//        //        Console.WriteLine("Formatted String: " + formattedString);
//        //    }
//        //}

//        ////Write a program to find first occurrence of a character in a given string.

        


    
//        //static int FindFirstOccurrence(string str, char target)
//        //{
//        //    for (int i = 0; i < str.Length; i++)
//        //    {
//        //        if (str[i] == target)
//        //        {
//        //            return i;
//        //        }
//        //    }

//        //    return -1; // Character not found
//        //}

//        //static void Main()
//        //{
//        //    Console.WriteLine("Enter a string:");
//        //    string inputString = Console.ReadLine();

//        //    Console.WriteLine("Enter the character to find:");
//        //    char targetChar = Console.ReadKey().KeyChar;
//        //    Console.WriteLine();

//        //    int index = FindFirstOccurrence(inputString, targetChar);
//        //    if (index != -1)
//        //    {
//        //        Console.WriteLine($"The character '{targetChar}' was found at index {index} in the string '{inputString}'.");
//        //    }
//        //    else
//        //    {
//        //        Console.WriteLine($"The character '{targetChar}' was not found in the string '{inputString}'.");
//        //    }




//            // Write a program to find first occurrence of a character in a given string.
//            string str = " hello everyone good morning";
//            Console.WriteLine("enter any character");
//                char ch =Convert.ToChar( Console.ReadLine());
//                char[]arr= str.ToCharArray();
//            int a = 1;

//                for (int i = 0;i <arr.Length;i++)
//                {
//                    if(ch == arr[i])
//                    {
//                    a = 1;
                    
//                        Console.WriteLine(i);
//                        break;
//                    }

//                   if (a==0)
//                {
//                    Console.WriteLine("char not found");
//                }
                
                    
                
                    
//                }
            
//        }


//    }







//}


