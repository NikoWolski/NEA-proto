using System;

namespace ConsoleApp1
{
    public class ContentDisplay
    {
        private int tableWidth = 76;
        private void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        private void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";
            for (int i = 0; i < columns.Length; i++)
            {
                string column = columns[i];
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        private string AlignCentre(string text, int width)
        {
            try
            {
                text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;
                if (string.IsNullOrEmpty(text))
                {
                    return new string(' ', width);
                }
                else
                {
                    return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
                }
            }
            catch (NullReferenceException)
            {
                text = "";
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }

        public void DisplayTable(string[,] setarray)
        {
            PrintLine();
            PrintRow("Teachers", "1st Subject", "2nd Subject");
            PrintLine();
            for (int i = 0; i < setarray.GetLength(0); i++)
            {
                for (int j = 0; j < setarray.GetLength(1); j++)
                {
                    PrintRow(setarray[i, j++], setarray[i, j++], setarray[i, j++]);
                }
            }
            PrintLine();
        }

    }
}
