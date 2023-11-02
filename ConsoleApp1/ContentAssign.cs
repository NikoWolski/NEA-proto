using System.IO;
using System;
namespace ConsoleApp1
{
    public class ContentAssign
    {
        private static int subcount = 0, teachcount = 0, yparam = 0;
        private static int TotalLines()
        {
            using (StreamReader r = new StreamReader("contents2.txt"))
            {
                while (r.ReadLine() != null) { yparam++; }
                yparam /= 3;
                return yparam;
            }
        }
        private string[,] setarray = new string[TotalLines(), 3];
        public ContentAssign()//int customparamx, int customparamy
        {
            //setarray = new string[customparamx, customparamy];
            Setter(setarray);
        }
        private string[,] Setter(string[,] setarray)
        {
            subcount = 0;
            teachcount = 0;
            using (StreamReader sr = new StreamReader("contents2.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (subcount <= 2)
                    {
                        setarray[teachcount, subcount] = line; 
                        subcount++;
                    }
                    if (subcount == 3)
                    {
                        subcount = 0;
                        teachcount++;
                    }
                }
            }
            return setarray;
        }
        public string[,] GetArray()
        {
            return setarray;
        }
    }
}
