using System.Buffers.Text;
using System.Reflection.Metadata;

    namespace _07.letters
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                //Reads a character(letter, part of the English alphabet) from the console
                //Based on the value of the character, print:
                //If the character is vowel letter print "Vowel"
                //Hint: Vowels letters are: A, a, E, e, I, i, O, o, U, u
                //If the character is consonant letter print "Consonant"

                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "A":
                    case "a":
                    case "O":
                    case "o":
                    case "E":
                    case "e":
                    case "I":
                    case "i":
                    case "U":
                    case "u":
                        Console.WriteLine("Vowel");
                        break;
                    default:
                        Console.WriteLine("Consonant");
                     break;
                }
            }
        }
}