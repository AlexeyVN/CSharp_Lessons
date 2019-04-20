using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_day_HomeWork
{       /// <summary>
        /// Установка курсора в определенную позицию на экране и вывод сообщения
        /// </summary>
    class CursorPos
    {
        public static void Print(string msg, int posX, int posY)
        {
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine(msg);
        }
    }
}
