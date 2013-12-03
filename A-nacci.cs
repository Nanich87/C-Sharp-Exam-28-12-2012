using System;

namespace A_nacci
{
    class Program
    {
        static char toChar(int letterIndex)
        {
            letterIndex += 64;
            return (char) letterIndex;
        }

        static void Main()
        {
            int firstLetter = char.Parse(Console.ReadLine()) - 64;
            int secondLetter = char.Parse(Console.ReadLine()) - 64;
            int linesCount = int.Parse(Console.ReadLine());
            int lettersCount = 2 * linesCount - 1;
            if (lettersCount == 1)
            {
                lettersCount++;
            }
            int[] lettersList = new int[lettersCount];

            lettersList[0] = firstLetter;
            lettersList[1] = secondLetter;

            for (int i = 2; i < lettersCount; i++)
            {
                int nextLetter = lettersList[i - 1] + lettersList[i - 2];
                if (nextLetter > 26)
                {
                    nextLetter %= 26;
                }
                lettersList[i] = nextLetter;
            }

            int counter = 0;
            for (int i = 0; i < linesCount; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(toChar(lettersList[i]));
                }
                else
                {
                    counter += 2;
                    Console.WriteLine(toChar(lettersList[counter - 1]) + new string(' ', i - 1) + toChar(lettersList[counter]));
                }
            }
        }
    }
}
