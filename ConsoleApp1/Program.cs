using ConsoleApp1;
using System;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What paramaters would you like?");
            //int x = int.Parse(Console.ReadLine()); int y = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Would you like to display, add, remove or clear elements from the table?");
                string choice = Console.ReadLine().ToLower();
                Console.WriteLine(choice);
                if (choice == "display")
                {
                    Console.WriteLine("testing");
                    ContentAssign assign = new ContentAssign();
                    Console.WriteLine("testing");
                    ContentDisplay display = new ContentDisplay();
                    Console.WriteLine("testing");
                    display.DisplayTable(assign.GetArray());
                    Console.WriteLine("testing");
                    Console.ReadKey();
                }
                else if (choice == "add")
                {
                    bool repeat = true;
                    while (repeat)
                    {
                        Console.WriteLine("\rPlease insert the name of the individual you would like to add.");
                        string name = Console.ReadLine();
                        Console.WriteLine("Please insert both subjects.");
                        string subject1 = Console.ReadLine();
                        string subject2 = Console.ReadLine();
                        _ = new ContentAdd(name, subject1, subject2);
                        Console.WriteLine("Successfully added.\nWould you like to add another?");
                        if (Console.ReadKey().KeyChar == 'n') { repeat = false; }
                    }
                }
                else if (choice == "clear")
                {
                    Console.WriteLine("Are you sure you want to clear the table of elements?");
                    switch (Console.ReadKey().KeyChar)
                    {
                        case 'y':
                            _ = new ContentClear();
                            Console.WriteLine("\rElements successfully cleared!");
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 'n':
                            break;
                    }
                }
                else
                {
                    throw new Exception("Invalid error!");
                }
                        //case "remove":
                        //Console.WriteLine("Would you like to remove elements by name or by subject?");
                        //ContentRemove removal = new ContentRemove(Console.ReadLine());
                        //Console.WriteLine("Please enter the name of the individual you would like to remove from the table.");
                        //removal.GetName(assign, Console.ReadLine());
                        //break;
            }

        }

    }
}
