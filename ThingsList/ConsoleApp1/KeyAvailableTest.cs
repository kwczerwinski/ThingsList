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
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(62, 32);
            Console.SetBufferSize(62, 32);
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
                            if (Console.CursorTop < Console.BufferHeight - 1) Console.CursorTop++;
                            break;
                        case ConsoleKey.LeftArrow:
                            if (Console.CursorLeft > 1) Console.CursorLeft--;
                            break;
                        case ConsoleKey.RightArrow:
                            if (Console.CursorLeft < Console.BufferWidth - 1) Console.CursorLeft++;
                            break;
                        default:
                            if (Char.IsControl(userInput.KeyChar))
                            {
                                return;
                            }
                            else if (Console.)
                            {
                                Console.Write(userInput.KeyChar);
                                if(Console.CursorLeft == 0)
                                {
                                    Console.CursorTop--;
                                    Console.CursorLeft = Console.BufferWidth - 1;
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
