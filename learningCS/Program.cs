using System;

namespace learningCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    /|");
            Console.WriteLine("   / |");
            Console.WriteLine("  /  |");
            Console.WriteLine(" /___|");

            Console.WriteLine("-------------------");

            string characterName = "Silvia ";
            int characterAge = 27;
            Console.WriteLine("there once was a women named " + characterName + ".");
            Console.WriteLine("she was " + characterAge + " yeers old and she really liked programming");
            Console.WriteLine("but she couldn't find a job because of her inexperience");
            Console.WriteLine("But she still has hope because she knows it's the thing she wants most to do in her life");

            Console.WriteLine("-------------------");
            // c# types

            string text = "simple text";
            char grade = '&';
            int age = -27;
            double dollar = 3.4568;
            bool female = true;


            Console.WriteLine("string: " + text);
            Console.WriteLine("char: can hold just one letter or a sign for example " + grade);
            Console.WriteLine("int: can be only whole number positive or negative for example " + age);
            Console.WriteLine("int: can be only whole number positive or negative for example " + age);
            Console.WriteLine("float, double, decimal: all this typs can hold decimal number, the difference between them is the accuracy " + dollar);
            Console.WriteLine("bool: true or false " + female);

            Console.WriteLine("-------------------");
            // string methods

            Console.WriteLine("\n      takes one more line ");
            Console.WriteLine("    \"quotation mark as a string ");
            Console.WriteLine(text.Length);
            Console.WriteLine(text.ToUpper() + " ToUpper or ToLower");
            Console.WriteLine(text.Contains("simple") + " return a boolean ");
            Console.WriteLine(text[4] + " return the requested index of the string");
            Console.WriteLine(text.IndexOf("z") + " return the first index found if not found return -1");
            Console.WriteLine(text.Substring(7, 3) + "  return the string from the index requested ");

            Console.ReadLine();
        }
    }
}
