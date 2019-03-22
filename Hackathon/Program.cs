using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Saksham Saksham --- c0732116
 * Chetan Rahanoo --- c0732135
 * Labhwinder Singh --- c0728432
 * Harmanjot Singh --- c0727172
 * Arshdeep Singh Brar --- c0730228
 * Manpreet singh sidhu --- c0726407
 * Gurkirat singh --- c0732169
 */
namespace Hackathon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = new string[] { "Saksham", "Harman", "Chetan", "Manjot", "Gurpinderpal", "Mani", "Guri", "Reman", "Ramu", "Chotu", "Manpreet", "Lavi", "Kaka", "Shiva", "Pranav", "Tirth" };
            for (int i = 0; i <= Names.Length; i++)

            {
                if (i == 0 || i == 3 || i == 7 || i == 11 || i == 15)
                {


                    Console.WriteLine(Names[i] + " = A");
                }


                else if (i == 1 || i == 4 || i == 8 || i == 12)
                {
                    Console.WriteLine(Names[i] + " = B");
                }


                else if (i == 2 || i == 5 || i == 9 || i == 13)
                {
                    Console.WriteLine(Names[i] + " = C");
                }


                else if (i == 3 || i == 6 || i == 10 || i == 14)
                {
                    Console.WriteLine(Names[i] + " = D");
                }

            }
            checkVowels();
        }

        public static int checkVowels()
        {
            int f = 0;
            string[] vowel = new string[] { "a", "e", "i", "o", "u" };
            Console.WriteLine("Enter a character");
            String s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (vowel[i] == s.ToLower())
                {
                    Console.WriteLine("this character is in the list at" + " position " + (i + 1));
                    f = i;
                    
                    
                }
                else
                {
                    Console.WriteLine("not there");
                    f = -1;
                    
                }
            }
            return f;
        }
    }
}