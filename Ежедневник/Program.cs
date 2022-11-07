using System.Data;
using Ежедневник;

namespace Ежедневник
{
    internal class Program
    {
        static ConsoleKeyInfo key;
        static int position;
        static DateTime datas2 = new DateTime();
        static void Main(string[] args)
        {
           
            bool k = true;
            datas2 = DateTime.Now;
            while (k != false)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    k = false;
                }
                else
                {
                    zametki();
                }
            }
        }

        static void strelki()
        {


            
                if (key.Key == ConsoleKey.UpArrow && position != 2) //двигаем стелочку вверх-вниз
                {
                    position--;
                }
                if (key.Key == ConsoleKey.DownArrow && position != 4)
                {
                    position++;
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    datas2 = datas2.AddDays(1);
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    datas2 = datas2.AddDays(-1);
                }
        }
        static void menu()
        {
                strelki();
                Console.Clear();
                Console.WriteLine(datas2);
            Console.WriteLine("--------------------");
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

         }

        

     

        static void zametki()
        {
            position = 2;
            while (key.Key != ConsoleKey.Enter)
            {
                
                key = Console.ReadKey();
                menu();
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("1. Сходить на пары");
                Console.SetCursorPosition(2, 3);
                Console.WriteLine("2. Купить продукты");
                if (key.Key == ConsoleKey.RightArrow)
                {
                    zametki2();
                }
            }
            if (position == 2)
            {
                Console.Clear();
                Console.WriteLine("Сходить на пары");
                Console.WriteLine("-------------------");
                Console.WriteLine("Описание:  чтобы зарабатывать деньги в будущем, надо учитьсф");
                DateTime dataw = new DateTime(2022, 9, 23, 8, 54, 34);
                Console.WriteLine(dataw);
                Console.WriteLine("Для выхода из описания заметки, нажмите на cтрелку вверх 2 раза");

            }
            if (position == 3)
            {
                Console.Clear();
                Console.WriteLine("Купить продукты");
                Console.WriteLine("-------------------");
                Console.WriteLine("Описание:  чтобы не умереть от голода, нужно пополнять запасы");
                DateTime dataw = new DateTime(2022, 9, 23, 8, 54, 34);
                Console.WriteLine(dataw);
                Console.WriteLine("Для выхода из описания заметки, нажмите на cтрелку вверх 2 раза");

            }
            key = Console.ReadKey();
            

        }
        static void zametki2()
        {
            position = 2;
            while (key.Key != ConsoleKey.Enter)
            {
                key = Console.ReadKey();
                menu();
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("1. Сделать практическую");
                if (key.Key == ConsoleKey.RightArrow)
                {
                    zametki3();
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    zametki();
                }
            }
            if (position == 2)
            {
                Console.Clear();
                Console.WriteLine("Сделать практическую");
                Console.WriteLine("-------------------");
                Console.WriteLine("Описание: для легкого прохождения зимней сессии, нужно немного потрудиться");
                DateTime dataw = new DateTime(2022, 10, 12, 14, 44, 53);
                Console.WriteLine(dataw);
                Console.WriteLine("Для выхода из описания заметки, нажмите на cтрелку вверх 2 раза");

            }
            key = Console.ReadKey();
        }

        static void zametki3()
        {
            position = 2;
            while (key.Key != ConsoleKey.Enter)
            {
                key = Console.ReadKey();
                menu();
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("1. Написать конспект");
                Console.SetCursorPosition(2, 3);
                Console.WriteLine("2. Поплакать");
                Console.SetCursorPosition(2, 4);
                Console.WriteLine("3. Поиграть с друзьями");
                if (key.Key == ConsoleKey.RightArrow)
                {
                    zametki4();
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    zametki2();
                }
            }


                if (position == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Написать конспект");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Описание: для благоприятного нахождения на парах без волнений нужно немного подготовиться");
                    DateTime dataw = new DateTime(2022, 11, 3, 5, 7, 34);
                    Console.WriteLine(dataw);
                    Console.WriteLine("Для выхода из описания заметки, нажмите на cтрелку вверх 2 раза");

                }

                if (position == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Поплакать");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Описание: чтобы сбросить напряжение нужно пролить слезц и станет легче");
                    DateTime dataw = new DateTime(2022, 11, 10, 6, 4, 34);
                    Console.WriteLine(dataw);
                    Console.WriteLine("Для выхода из описания заметки, нажмите на cтрелку вверх 2 раза");

                }

                if (position == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Поиграть с друзьями");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Описание: для поддержания дружественных отеношений, нужно показать друзьям, что я жива и всё еще ими интересуюсь");
                    DateTime dataw = new DateTime(2022, 9, 23, 8, 54, 34);
                    Console.WriteLine(dataw);
                    Console.WriteLine("Для выхода из описания заметки, нажмите на cтрелку вверх 2 раза");

                }
                key = Console.ReadKey();
               

        }
        static void zametki4()
        {
            position = 2;
            while (key.Key != ConsoleKey.Enter)
            {
                key = Console.ReadKey();
                menu();
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("1. Сходить на пары");
                Console.SetCursorPosition(2, 3);
                Console.WriteLine("2. Вдремнуть");
                if (key.Key == ConsoleKey.RightArrow)
                {
                    zametki5();
                }

                if (key.Key == ConsoleKey.LeftArrow)
                {
                    zametki3();
                }
            }

            if (position == 2)
            {
                Console.Clear();
                Console.WriteLine("Сходить");
                Console.WriteLine("-------------------");
                Console.WriteLine("Описание: чтобы зарабатывать деньги в будущем, надо учитьсф");
                DateTime dataw = new DateTime(2022, 9, 23, 8, 54, 34);
                Console.WriteLine(dataw);
                Console.WriteLine("Для выхода из описания заметки, нажмите на cтрелку вверх 2 раза");

            }
            if (position == 3)
            {
                Console.Clear();
                Console.WriteLine("Взремнуть");
                Console.WriteLine("-------------------");
                Console.WriteLine("Описание: как устала после пар, нужно поспать");
                DateTime dataw = new DateTime(2022, 9, 23, 8, 54, 34);
                Console.WriteLine(dataw);
                Console.WriteLine("Для выхода из описания заметки, нажмите на cтрелку вверх 2 раза");

            }
            key = Console.ReadKey();
        }
        static void zametki5()
        {
            position = 2;
            while (key.Key != ConsoleKey.Enter)
            {
                key = Console.ReadKey();
                menu();
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("1. Поплакать");
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    zametki4();
                }
            }
            
                if (position == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Поплакать");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Описание: чтобы сбросить напряжение, нужно пролить слезц и станет легче");
                    DateTime dataw = new DateTime(2022, 9, 23, 8, 54, 34);
                    Console.WriteLine(dataw);
                Console.WriteLine("Для выхода из описания заметки, нажмите на cтрелку вверх 2 раза");
                
                }
            key = Console.ReadKey();
        }
    }
}
