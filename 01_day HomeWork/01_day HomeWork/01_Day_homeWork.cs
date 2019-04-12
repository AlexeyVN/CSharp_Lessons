using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Домашняя работа по первому вебинару С#
/// Выполнил Власевский Алексей
/// </summary>
namespace _01_day_HomeWork
{
    class Program
    {
        // Метод ожидания ввода любого символа пользователем в консоли
        static void pauseProgram()
        {
            Console.ReadKey();
        }
        // Метод ожидания ввода любого символа пользователем в консоли c сообщением пользователю c отступом строки
        static void pauseProgramMsg(string msg)
        {
            Console.WriteLine();
            Console.WriteLine(msg);
            Console.WriteLine();
            pauseProgram();
        }

        static void Main(string[] args)
        {
            //Определяем переменные для Анкеты
            string userName, userSername; //Стоковые типы имени и фамилии
            int userAge;// считаем что возраст не дробный
            float userHeight, userWeight;//рост и вес могут содержать значения с плавающей запятой

            // Ввод данных для анкеты
            Console.WriteLine("Анкета");
            Console.Write("Введите ваше имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите вашу фамилю: ");
            userSername = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            userAge = int.Parse(Console.ReadLine());
            Console.Write("Введите ваш рост в сантиметрах: ");
            userHeight = float.Parse(Console.ReadLine());
            Console.Write("Введите ваш вес в килограммах: ");
            userWeight = float.Parse(Console.ReadLine());

            //Вывод данных анкеты используя склеивание
            pauseProgramMsg("Нажмите клавишу для примера вывода с помощью склеивания:");
            Console.WriteLine("Ваша анкета: " + " имя - " + userName + " фамилия - " + userSername + " возраст - " + userAge + " рост - " + userHeight + " вес - " + userWeight);

            pauseProgramMsg("Нажмите клавишу для примера форматированного вывода:");
            Console.WriteLine("Ваша акета: имя - {0}, фамилия - {1}, возраст - {2}, рост - {3:N} и вес - {4:N}", userName, userSername, userAge, userHeight, userWeight);

            pauseProgramMsg("Нажмите клавишу для примера вывода со знаком $:");
            Console.WriteLine($"Ваша акета: имя - ({userName}), фамилия - ({userSername}), возраст - ({userAge}), рост - ({userHeight:N}) и вес - ({userWeight:N})");
        }
    }
}
