using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PianoKeyboard
    {
        public static void Play()
        {
            Console.Title = "Piano Keyboard";
            char userInput;
            
            do
            {
                userInput = Console.ReadKey().KeyChar;
                switch (userInput)
                {
                    case 's':
                        Console.Beep(262, 200);
                        break;
                    case 'e':
                        Console.Beep(277, 200);
                        break;
                    case 'd':
                        Console.Beep(294, 200);
                        break;
                    case 'r':
                        Console.Beep(311, 200);
                        break;
                    case 'f':
                        Console.Beep(330, 200);
                        break;
                    case 'g':
                        Console.Beep(349, 200);
                        break;
                    case 'y':
                        Console.Beep(370, 200);
                        break;
                    case 'h':
                        Console.Beep(392, 200);
                        break;
                    case 'u':
                        Console.Beep(415, 200);
                        break;
                    case 'j':
                        Console.Beep(440, 200);
                        break;
                    case 'i':
                        Console.Beep(466, 200);
                        break;
                    case 'k':
                        Console.Beep(494, 200);
                        break;
                    case 'l':
                        Console.Beep(523, 200);
                        break;
                }
            }
            while (!Char.IsControl(userInput));
            
        }
    }
}
