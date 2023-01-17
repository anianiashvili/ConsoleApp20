using System;

namespace UdemyMasterClass.TicTacToe
{
    internal class GuessWord
    {
        public static object Arrays { get; private set; }

        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            GetInitialMessage();

            char[] mainArray = InitializeArray(GetWord().ToCharArray());

            CheckLetterWord(mainArray);
        }

        static void GetInitialMessage()
        {
            Console.Write("Please enter a fruit name: ");
        }

        static string GetWord()
        {
            return Console.ReadLine();
        }

        static char[] InitializeArray(char[] word)
        {
            return word;
        }

        static string GetLetter()
        {
            Console.Write("Please guess the word or enter a letter: ");

            return Console.ReadLine();
        }

        static void CheckLetterWord(char[] mainArray)
        {
            char[] tempArray = new char[mainArray.Length];
            int counter = 0;

            string enteredWord;
            string mainWord;

            bool noMathces;

            for (int index = 0; index < tempArray.Length; index++)
            {
                tempArray[index] = '*';
            }

            do
            {
                enteredWord = GetLetter().ToString();
                mainWord = new string(mainArray);

                noMathces = true;

                char symbol = enteredWord[0];

                for (int index = 0; index < mainArray.Length; index++)
                {
                    if (mainArray[index].Equals(symbol) && tempArray[index] == '*')
                    {
                        tempArray[index] = mainArray[index];
                        counter++;
                        noMathces = false;
                    }
                }

                if (noMathces)
                {
                    Console.WriteLine("There is no such letter...\n");
                }

                if (mainWord.Equals(enteredWord))
                {
                    Victory();
                    DrawArray(enteredWord.ToCharArray());
                    return;
                }

                if (counter == mainArray.Length)
                {
                    Victory();
                    DrawArray(mainWord.ToCharArray());
                    return;
                }

                Console.WriteLine();

                DrawArray(tempArray);

            } while (counter < mainArray.Length);
        }

        static void DrawArray(char[] mainArray)
        {
            Console.Write("The word is: ");
            for (int index = 0; index < mainArray.Length; index++)
            {
                Console.Write(mainArray[index]);
            }
            Console.WriteLine("\n");
        }

        static void Victory()
        {
            Console.WriteLine();
            Console.WriteLine("YOU WON!");
        }
    }
}