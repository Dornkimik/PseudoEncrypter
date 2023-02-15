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
        public static Dictionary<char, char> encryptionCharPairs;

        static void Main(string[] args)
        {
            wordLetters = new List<char>();
            encryptionCharPairs = new Dictionary<char, char>();

            InitializeAlphabet();
            CreateEncryptionTable();
            UserInput();
            SeperateWordToChars();
            EncryptCharacters();
            PrintEncryptedWord();

            Console.ReadLine();
        }

        private static void PrintEncryptedWord()
        {
            Console.Write("Encrypted: ");

            for (int i = 0; i < wordLetters.Count; i++)
            {
                Console.Write(wordLetters[i]);
            }
        }

        private static void EncryptCharacters()
        {
            // Changes characters from the unencrypted word to the value of the list that encrypts the character
            for (int i = 0; i < wordLetters.Count; i++)
            {
                if (encryptionCharPairs.ContainsKey(wordLetters[i]))
                {
                    wordLetters[i] = encryptionCharPairs[wordLetters[i]];
                }
            }
        }

        private static void UserInput()
        {
            Console.Write("Unencrypted: ");
            word = Console.ReadLine();
        }

        private static void SeperateWordToChars()
        {
            for (int i = 0; i < word.Length; i++)
            {
                wordLetters.Add(word[i]);
            }
        }

        private static void CreateEncryptionTable()
        {
            Random random = new Random();

            for (int i = 0; i < alphabet.Count; i++)
            {
                int randomNumber = random.Next(0, alphabet.Count);

                // defines a random character to every character in the alphabet
                encryptionCharPairs.Add(alphabet[i], alphabet[randomNumber]);
            }

            foreach (var pair in encryptionCharPairs)
            {
                Console.WriteLine("| {0} -> {1} |", pair.Key, pair.Value);
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
