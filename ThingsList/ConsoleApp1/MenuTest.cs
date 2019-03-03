using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MenuTest
    {

        private static readonly string[] options = { "Option1", "Option2", "Exit" };

        private static bool closeProgram = false;

        public static void MTest()
        {
            MainMenu(options);
            while (!closeProgram)
            {
                ConsoleKeyInfo userInput;
                while (Console.KeyAvailable)
                {
                    userInput = Console.ReadKey(true);
                    switch (userInput.Key)
                    {
                        case ConsoleKey.UpArrow:
                            MenuChanger(false);
                            break;
                        case ConsoleKey.DownArrow:
                            MenuChanger(true);
                            break;
                        case ConsoleKey.Enter:
                            OptionChosen(Console.CursorTop);
                            break;
                    }
                }
            }
            Console.ReadKey();
        }

        private static void MainMenu(string[] options)
        {
            Console.CursorVisible = false;
            foreach(string tmp in options)
            {
                Console.WriteLine(tmp);
            }
            Console.CursorTop--;
            MenuChanger(true);
        }

        private static void SetColor(bool option)
        {
            if (option)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ResetColor();
            }
        }

        private static void MenuChanger(bool goingDown)
        {
            Console.CursorLeft = 0;
            Console.Write(options[Console.CursorTop]);
            if (goingDown)
            {
                if (Console.CursorTop == options.Length - 1) Console.CursorTop = 0;
                else Console.CursorTop++;
            }
            else
            {
                if (Console.CursorTop == 0) Console.CursorTop = options.Length - 1;
                else Console.CursorTop--;
            }
            Console.CursorLeft = 0;
            SetColor(true);
            Console.Write(options[Console.CursorTop]);
            SetColor(false);
        }

        private static void OptionChosen(int optionValue)
        {
            if (Console.CursorTop == options.Length - 1)
            {
                closeProgram = true;
            }
            else
            {
                Console.Clear();
                Console.Write("Not implemented");
                Console.ReadKey();
                Console.Clear();
                MainMenu(options);
            }
        }
    }
}