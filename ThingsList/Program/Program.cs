using System;
using System.IO;

namespace Program
{
    class Program
    {
        static void Main()
        {
            string[] things = GetListOfThings();
            //Show main menu
            ShowMenu();
        }

        //Method for getting list of things
        static string[] GetListOfThings()
        {
            string path = "C:/ThingsList.txt";
            string[] list = null;
            if (File.Exists(path))
            {
                list = File.ReadAllLines(path);
            }
            else
            {
                File.Create(path);
                AddThing(ref list);
            }
            return list;
        }

        //Method for showing main menu
        static void ShowMenu()
        {
            Console.Clear();
            Console.Write("Things List v0.1\n\n1. Wyświetl listę przedmiotów\n2. Znajdź przedmiot3\n3. Wyjście\n");
            string userOption;
            do
            {
                userOption = Console.ReadLine();
                if (userOption.Equals("1"))
                {
                    //ShowList();
                }
                else if (userOption.Equals("2"))
                {
                    //FindThing();
                }
            }
            while (userOption.Equals("3"));
            Console.Write("\nDo zobaczenia!");
            Console.ReadKey();

        }

        //Method for adding new thing
        static void AddThing(ref string[] list)
        {
            Console.Clear();
            Console.Write("Adding new thing\n\nName: ");
            if (list == null)
            {
                list = new string[1];
            }
            else
            {
                Array.Resize(ref list, list.Length + 1);
                Array.Resize()
            }
            list[list.Length-1] = Console.ReadLine();
        }
    }
}
