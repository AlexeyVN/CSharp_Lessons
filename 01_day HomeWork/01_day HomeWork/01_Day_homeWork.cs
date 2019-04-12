using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Домашняя работа по первому вебинару С#
/// Выполнил Власевский Алексей
/// Задания выполнены в порядке указанном в методичке.
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

            ///<summary>
            ///Задача №1
            ///Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:            ///а) используя склеивание;
            ///б) используя форматированный вывод
            ///в) используя вывод со знаком $.
            ///</summary>

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

            pauseProgramMsg("Нажмите любую клавишу для продолжения");

            // Рассчет индекса массы тела на основе введенных значений из анкеты

            ///<summary>
            ///Задача №2
            ///Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
            ///где m — масса тела в килограммах,
            ///h — рост в метрах.
            ///</summary>

            Console.WriteLine("Из анкеты нам известен ваш рост и вес. На основе этого рассчитаем индекс массы тела");

            //Определяем переменные для рассчета индекса массы тела по условиям задачи
            float m, h, bodyIndex;
            m = userWeight;
            h = userHeight;
            // Расчет индекса массы тела по формуле
            bodyIndex = m / (h * h);
            Console.WriteLine($"Ваш индекс массы тела составляет: ({bodyIndex})");
            pauseProgramMsg("Нажмите любую клавишу для продолжения");

            //Подсчет расстояния между точками

            ///<summary>
            ///Задача №3
            ///а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
            ///Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            ///б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            /// </summary>

        }
    }
}
