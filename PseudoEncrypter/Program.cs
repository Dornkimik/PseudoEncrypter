using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoEncrypter
{
    internal class Program
    {
        public static string word;

        public static List<char> wordLetters;
        public static List<char> alphabet;

        static void Main(string[] args)
        {
            wordLetters = new List<char>();

            word = Console.ReadLine();

            SeperateWordToChars();
            Encrypt();

            Console.ReadKey();
        }

        private static void SeperateWordToChars()
        {
            for (int i = 0; i < word.Length; i++)
            {
                wordLetters.Add(word[i]);
            }
        }

        private static void Encrypt()
        {
            for (int i = 0; i < wordLetters.Count; i++)
            {
                switch (wordLetters[i])
                {
                    case 'a':
                        wordLetters[i] = 'k';
                        break;
                    case 'b':
                        wordLetters[i] = 'u';
                        break;
                    case 'c':
                        wordLetters[i] = 'z';
                        break;
                    case 'd':
                        wordLetters[i] = 'f';
                        break;
                    case 'e':
                        wordLetters[i] = 'r';
                        break;
                    case 'f':
                        wordLetters[i] = 'q';
                        break;
                    case 'g':
                        wordLetters[i] = 'h';
                        break;
                    case 'h':
                        wordLetters[i] = 't';
                        break;
                    case 'i':
                        wordLetters[i] = 'v';
                        break;
                    case 'j':
                        wordLetters[i] = 'm';
                        break;
                    case 'k':
                        wordLetters[i] = 'g';
                        break;
                    case 'l':
                        wordLetters[i] = 'y';
                        break;
                    case 'm':
                        wordLetters[i] = 'x';
                        break;
                }

                Console.Write(wordLetters[i]);
            }
        }

        public static void InitializeAlphabet()
        {
            alphabet = new List<char>();

            for (var i = 'a'; i <= 'z'; i++)
            {
                alphabet.Add((char)i);
            }
        }
    }
}
