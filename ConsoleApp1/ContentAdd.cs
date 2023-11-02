using System.IO;

namespace ConsoleApp1
{
    public class ContentAdd
    {
        public ContentAdd(string name, string sub1, string sub2)
        {
            Adder(name, sub1, sub2);
        }
        private void Adder(string name, string sub1, string sub2)
        {
            using (StreamWriter sw = new StreamWriter("contents2.txt", true))
            {
                sw.WriteLine(name);
                sw.WriteLine(sub1);
                sw.WriteLine(sub2);
            }
        }
    }
}
