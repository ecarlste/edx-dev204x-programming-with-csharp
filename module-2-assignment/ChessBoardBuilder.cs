using System;

namespace ModuleTwoAssignment
{
    class ChessBoardBuilder
    {
        static void Main(string[] args)
        {
            int chessBoardDimension = 8;

            for (int row = 0; row < chessBoardDimension; row++)
            {
                /* Even though the lecture notes included a list of operators used in C# which included the ternary
                 * operator '?', there was no example shown. Since I make use of the ternary operator several times
                 * in this code I will include an example for those unfamiliar with it.
                 * 
                 * int number = (otherNumber == 7) ? 1 : -1;
                 * 
                 * The above code is equivalent to the following if else statement:
                 * 
                 * int number;
                 * 
                 * if (otherNumber == 7)
                 * {
                 *     number = 1;
                 * }
                 * else
                 * {
                 *     number = -1;
                 * }
                 * 
                 */

                char characterToPrint = (rowNumberIsEven(row)) ? 'X' : 'O';
                char lastCharacterUsed = characterToPrint;

                Console.Write(characterToPrint);

                for (int column = 1; column < chessBoardDimension; column++)
                {
                    characterToPrint = (lastCharacterUsed == 'X') ? 'O' : 'X';
                    lastCharacterUsed = characterToPrint;

                    Console.Write(characterToPrint);
                }

                Console.WriteLine();
            }
        }

        private static bool rowNumberIsEven(int row)
        {
            int divisionRemainder = row % 2;

            bool rowIsEven = (divisionRemainder == 0) ? true : false;

            return rowIsEven;
        }
    }
}
