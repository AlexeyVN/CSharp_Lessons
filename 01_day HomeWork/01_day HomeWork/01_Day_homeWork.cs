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
        static void Main(string[] args)
        {

            ///<summary>
            ///Задача №1
            ///Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
            ///а) используя склеивание;
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
            msgPauseProgram.Msg("Нажмите клавишу для примера вывода с помощью склеивания:");
            Console.WriteLine("Ваша анкета: " + " имя - " + userName + " фамилия - " + userSername + " возраст - " + userAge + " рост - " + userHeight + " вес - " + userWeight);

            msgPauseProgram.Msg("Нажмите клавишу для примера форматированного вывода:");
            Console.WriteLine("Ваша акета: имя - {0}, фамилия - {1}, возраст - {2}, рост - {3:N} и вес - {4:N}", userName, userSername, userAge, userHeight, userWeight);

            msgPauseProgram.Msg("Нажмите клавишу для примера вывода со знаком $:");
            Console.WriteLine($"Ваша акета: имя - {userName}, фамилия - {userSername}, возраст - {userAge}, рост - {userHeight:N} и вес - {userWeight:N}");

            msgPauseProgram.Msg("Нажмите любую клавишу для продолжения");

            // Рассчет индекса массы тела на основе введенных значений из анкеты

            ///<summary>
            ///Задача №2
            ///Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
            ///где m — масса тела в килограммах,
            ///h — рост в метрах.
            ///</summary>

            Console.WriteLine(" Из анкеты нам известен ваш рост и вес. \n На основе этого рассчитаем индекс массы тела");

            //Определяем переменные для рассчета индекса массы тела по условиям задачи
            double m, h, bodyIndex;
            m = userWeight;
            h = userHeight / 100; //Перевод в метры

            // Расчет индекса массы тела по формуле
            bodyIndex = Math.Truncate(m / (h * h));
            Console.WriteLine($"Ваш индекс массы тела составляет: {bodyIndex:G}");
            msgPauseProgram.Msg("Нажмите любую клавишу для продолжения");
            Console.Clear();
            //Подсчет расстояния между точками

            ///<summary>
            ///Задача №3
            ///а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
            ///Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            ///б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            /// </summary>

            Console.WriteLine("Расчитаем расстояние между точками с координатами х1, у1 и х2, у2");
            //Предположим что координаты нам известны
            int x1 = 10, y1 = 10, x2 = 50, y2 = 30;
            //Переменная для нахождения расстояния между точками
            double r;
            //Вычисляем результат
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками равно {r:F2}");
            msgPauseProgram.Msg("Рассчет методом");
            //Реализуем тоже самое в виде метода
            r =  dotDistance.XY(x1, y1, x2, y2);
            Console.WriteLine($"Расстояние между точками равно {r:F2}");
            msgPauseProgram.Msg("Нажмите любую клавишу для продолжения");

            Console.Clear();

           ///<summary>
           ///Задача №4 написать программу обмена занчениями переменных
           ///а) с использованием третьей переменной;
           /// б) *без использования третьей переменной.
           ///</summary>

           Console.WriteLine("Программа обмена значениями 2х переменных. А и B");
            int a = 10, b = 11;
            int tmp;
            Console.WriteLine($"Переменная A равна {a}, переменная B равна {b}");
            tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine($"Поменяли и теперь переменная A равна {a}, переменная B равна {b}");
            msgPauseProgram.Msg("Поменяем без использования третьей переменной. Нажмите любую клавишу");
            a = 10;
            b = 11;
            Console.WriteLine($"Переменная A равна {a}, переменная B равна {b}");
             a = a + b;
            b = b - a;
            b = -b;
            a = a - b;
            Console.WriteLine($"Поменяли и теперь переменная A равна {a}, переменная B равна {b}");
            msgPauseProgram.Msg("Нажмите любую клавишу для продолжения");
            Console.Clear();

            ///<summary>
            ///Задача №5 Программа выводит на экран имя, фамилию и город проживания
            ///а) В центре экрана;
            /// б)С использованием метода.
            ///</summary>

            var cityLive = "Иркутск";

            Console.Write("{0} {1} {2}", userName, userSername, cityLive);
            msgPauseProgram.Msg("Нажмите любую клавишу для вывода информации по центру экрана ");
            Console.Clear();

            int origWidth = Console.WindowWidth; //Получаем ширину окна
            int origHeight = Console.WindowHeight;//Получаем высоту окна

            Console.SetCursorPosition((origWidth / 2) - userName.Length, origHeight / 2); //Отнимаю киличество букв в имени  чтобы поставить ближе к центру

            Console.Write("{0} {1} {2} \n", userName, userSername, cityLive);
            msgPauseProgram.Msg("Нажмите любую клавишу для продолжения. \n \n Вывод с помошью метода");
            Console.Clear();
                       
            string addString = userName + " " + userSername + " " + cityLive;
            CursorPos.Print(addString, (origWidth / 2) - userName.Length, origHeight / 2);
            msgPauseProgram.Msg("Нажмите любую клавишу для продолжения.");
        }
    }
}
