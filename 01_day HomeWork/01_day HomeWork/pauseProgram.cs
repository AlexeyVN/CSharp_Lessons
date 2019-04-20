using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_day_HomeWork
{       /// <summary>
        /// Метод ожидающий ввода любого символа с клавиатуры
        /// </summary>
        
    class pauseProgram
    {   
       public static void Pause()
        {
            Console.ReadKey();// Ожидает ввода любого символа пользователем в консоли
        }
    }
}
