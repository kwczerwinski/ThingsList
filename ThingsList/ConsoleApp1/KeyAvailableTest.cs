using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class KeyAvailableTest
    {
        public static void KATest()
        {
            Console.SetWindowSize(44, 44);
            Console.SetBufferSize(44, 44);
            Console.Write("Press \"esc\" to exit");
            Console.CursorSize = 100;
            Console.SetCursorPosition(1, 1);
            while (true)
            {
                ConsoleKeyInfo userInput;
                while (Console.KeyAvailable)
                {
                    userInput = Console.ReadKey(true);
                    switch (userInput.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (Console.CursorTop > 1) Console.CursorTop--;
                            break;
                        case ConsoleKey.DownArrow:
                            if (Console.CursorTop < Console.BufferHeight - 2) Console.CursorTop++;
                            break;
                        case ConsoleKey.LeftArrow:
                            if (Console.CursorLeft > 1) Console.CursorLeft--;
                            break;
                        case ConsoleKey.RightArrow:
                            if (Console.CursorLeft < Console.BufferWidth - 2) Console.CursorLeft++;
                            break;
                        case ConsoleKey.Escape:
                            return;
                        default:
                            if (!Char.IsControl(userInput.KeyChar))
                            {
                                Console.Write(userInput.KeyChar);
                                if (Console.CursorLeft == 0)
                                {
                                    Console.CursorTop--;
                                    Console.CursorLeft = Console.BufferWidth - 2;
                                }
                                else
                                {
                                    Console.CursorLeft--;
                                }
                            }
                            break;
                    }
                } 
            }
        }
    }
}