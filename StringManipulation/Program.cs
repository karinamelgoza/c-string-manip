using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            int age = 26;
            string name = "Karina";
            string punctuation = ".";

            //1. string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old");

            //2. string formatting
            //string formatting uses index 
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old{2}", name, age, punctuation);

            //3. string interpolation
            // string interpolation uses $ at the start so we can use {variables}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old{punctuation}");

            //4. verbatim strings
            // verbatim strings start with @ and tells compiler to take string literally
            // and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit,
sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea
commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

            // instead of using \\ to write file paths we can use verbatim strings
            // with verbatim strings even valid escape characters won't work
            Console.WriteLine(@"muahaha \n you have no powers here!");
        }
    }
}
