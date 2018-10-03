using System;
namespace _5
{
    class MainClass
    {
        public static string LetterCapitalize(string str)
        {

            // code goes here  
            /* Note: In C# the return type of a function and the 
               parameter types being passed are defined, so this return 
               call must match the return type of the function.
               You are free to modify the return type. */
            string newSentence = "";
            string[] strArray = str.Split(' ');
            foreach (var i in strArray)
            {
                char firstLetter = char.ToUpper(i[0]);
                newSentence += $"{firstLetter}{i.Substring(1)} ";
            }
            return newSentence;

        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(LetterCapitalize(Console.ReadLine()));
        }

    }
}
