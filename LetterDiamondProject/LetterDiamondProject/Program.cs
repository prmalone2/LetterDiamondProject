using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterDiamondProject
{
    class Program
    {
        public static char nextLetter(char letter)
        {
            return (char)((int)letter + 1);
        }

        public static List<char> characterArray(char lastLetter)
        {
            List<char> charList = new List<char>();
            char current = 'A';
            while (current != Char.ToUpper(lastLetter))
            {
                charList.Add(current);
                current = nextLetter(current);
            }
            charList.Add(current);
            return characterArrayPt2(charList);
        }

        public static List<char> characterArrayPt2(List<char> list)
        {
            int size = list.Count;
            for (int i = 2; i <= size; i++)
            {
                list.Add(list[size - i]);
            }
            return list;
        }

        public static void printDiamond(List<char> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0 || i == (list.Count - 1))
                {
                    Console.WriteLine(list[i]);
                }
                else
                {
                    Console.WriteLine(list[i].ToString() + list[i].ToString());
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a letter to form a diamond, or type 'escape' to exit");
            while (true)
            {
                Console.WriteLine("Enter Your Letter:");
                string input = Console.ReadLine();
                char letter;
                if (input.Length > 1)
                {
                    if (input.ToLower() == "escape")
                    {
                        break;
                    }
                    Console.WriteLine("One letter only, please");
                    continue;
                }
                else
                {
                    letter = input.ToCharArray()[0];
                }

                if (Char.IsLetter(letter))
                {
                    printDiamond(characterArray(letter));
                    continue;
                }
                else
                {
                    Console.WriteLine("Your input must be a letter");
                    continue;
                }
            }
        }
    }
}
