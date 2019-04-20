using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_day_HomeWork
{    /// <summary>
     /// Метод ожидающий ввода любого символа с клавиатуры c сообщением пользователю и c отступом строки
     /// </summary>
    class msgPauseProgram
    {
        // Метод ожидания ввода любого символа пользователем в консоли c сообщением пользователю и c отступом строки
       public static void Msg(string msg)
        {
            Console.WriteLine();
            Console.WriteLine(msg);
            Console.WriteLine();
            pauseProgram.Pause();
        }
    }
}
