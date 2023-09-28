using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] teacherandsubject = new string[6, 3];
            int teachercounter = 0, subjectcounter = 0, testcounter = 0;
            using (StreamReader sr = new StreamReader("contents.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    testcounter++;
                    if (line.Contains("SubjectTest") || line.Contains("NameTest"))
                    {
                        teacherandsubject[teachercounter, subjectcounter] = line;
                        subjectcounter++;
                    }
                    else
                    {
                        teachercounter++;
                        subjectcounter = 0;
                    }
                    Console.Write(testcounter);
                }
            }
            for (int i = 0; i < teacherandsubject.GetLength(0); i++)
            {
                for (int j = 0; j < teacherandsubject.GetLength(1); j++)
                {
                    Console.Write(teacherandsubject[i, j] + '|');
                }
                Console.WriteLine();
            }
            Console.Write("------------------------------------");
            Console.ReadLine();
        }
    }
}
