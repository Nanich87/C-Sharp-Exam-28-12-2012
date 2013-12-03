using System;

namespace ExcelColumns
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[] columnLetters = new char[n];
            string columnName = string.Empty;

            for (int i = 0; i < n; i++)
            {
                columnLetters[i] = char.Parse(Console.ReadLine());
            }

            columnName = new string(columnLetters);
            Console.WriteLine(getColumnNumber(columnName).ToString());
        }

        static ulong getColumnNumber(string columnName)
        {
            ulong columnNumber = 0;
            ulong pow = 1;
            for (int i = columnName.Length - 1; i >= 0; i--)
            {
                columnNumber += (ulong)(columnName[i] - 'A' + 1) * pow;
                pow *= 26;
            }
            return columnNumber;
        }
    }
}
