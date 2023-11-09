using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.Serialization;

namespace ежежедневник
{
    internal class Program
    {
        static void Main()
        {
            ConsoleKeyInfo consoleKeyInfo2 = Console.ReadKey();
            ConsoleKeyInfo consoleKeyInfo1 = consoleKeyInfo2;

            do
            {
                DateTime data = DateTime.Now;

                ConsoleKeyInfo key;

                int pos = 2;

                do
                {

                    if (data.Date == new DateTime(2023, 11, 02))
                    {
                        Console.Clear();
                        Console.WriteLine(data);
                        Console.WriteLine("Расписание на день:");
                        Console.WriteLine("  Отдохнуть");
                        Console.WriteLine("  Поиграть в кс");
                        Console.WriteLine("  Пойти в колледж");

                    }
                    else if (data.Date == new DateTime(2023, 11, 04))
                    {
                        Console.Clear();
                        Console.WriteLine(data);
                        Console.WriteLine("Расписание на день:");
                        Console.WriteLine("  Прогулять пары");
                        Console.WriteLine("  Пойти гулять");
                        Console.WriteLine("  Пойти спать");
                    }
                    else if (data.Date == new DateTime(2023, 11, 05))
                    {   
                        Console.Clear();
                        Console.WriteLine(data);
                        Console.WriteLine("Расписание на день:");
                        Console.WriteLine("  Смотреть тик ток");
                        Console.WriteLine("  Сходить на концерт");
                        Console.WriteLine("  Убраться");
                    }
          
                    else if (data.Date != new DateTime(2023, 11, 04))
                    {
                        Console.Clear();
                        Console.WriteLine(data);
                    }
                    else if (data.Date != new DateTime(2023, 11, 02))
                    {
                        Console.Clear();
                        Console.WriteLine(data);
                    }
                    else if (data.Date != new DateTime(2023, 11, 05))
                    {
                        Console.Clear();
                        Console.WriteLine(data);
                    }

                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    key = Console.ReadKey();
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("  ");
                    if (key.Key == ConsoleKey.DownArrow && pos != 4)
                    {
                        pos++;
                    }
                    else if (key.Key == ConsoleKey.UpArrow && pos != 2)
                    {
                        pos--;
                    }
                    else if (key.Key == ConsoleKey.RightArrow)
                    {
                        data = data.AddDays(1);

                        Console.SetCursorPosition(0, 0);

                        Console.WriteLine(data);
                    }
                    else if (key.Key == ConsoleKey.LeftArrow)
                    {
                        data = data.AddDays(-1);

                        Console.SetCursorPosition(0, 0);

                        Console.WriteLine(data);
                    }

                } while (key.Key != ConsoleKey.Enter);

                if (pos == 2 && data.Date == new DateTime(2023, 11, 02))
                {

                    Console.Clear();
                    Vremy day = new()

                    {
                        deystvie = ("Отдохнуть"),
                        podrobnosty = ("Посмотреть сериал"),
                        data = DateTime.Now
                    };
                    Console.WriteLine(day.deystvie);
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("Описание:" + day.podrobnosty);
                    Console.WriteLine("Выбранная дата и время:  " + data);


                }
                else if (pos == 2 && data.Date == new DateTime(2023, 11, 04))
                {
                    Console.Clear();
                    Vremy day2 = new()
                    {
                        deystvie = ("Прогулять пары"),
                        podrobnosty = ("Прогулять пары и пойти гулять"),
                        data = DateTime.Now
                    };
                    Console.WriteLine(day2.deystvie);
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("Описание:" + day2.podrobnosty);
                    Console.WriteLine("Выбранная дата и время:  " + data);

                }
                else if (pos == 2 && data.Date == new DateTime(2023, 11, 05))
                {
                    Console.Clear();
                    Vremy day2 = new()
                    {
                        deystvie = ("Смотреть тик ток"),
                        data = DateTime.Now,
                        podrobnosty = ("Целый день смотреть видосы")
                    };
                    Console.WriteLine(day2.deystvie);
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("Описание:" + day2.podrobnosty);
                    Console.WriteLine("Выбранная дата и время:  " + data);
                }

                else if (pos == 3 && data.Date == new DateTime(2023, 11, 02))
                {

                    Console.Clear();
                    Vremy day2 = new()
                    {
                        deystvie = ("Поиграть в кс"),
                        podrobnosty = ("Пойти в премьер-режим"),
                        data = DateTime.Now
                    };
                    Console.WriteLine(day2.deystvie);
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("Описание:" + day2.podrobnosty);
                    Console.WriteLine("Выбранная дата и время:  " + data);

                }
                else if (pos == 3 && data.Date == new DateTime(2023, 11, 05))
                {
                    Console.Clear();
                    Vremy day2 = new()
                    {
                        deystvie = ("Сходить на концерт"),
                        podrobnosty = ("Сходить и отдохнуть"),
                        data = DateTime.Now
                    };
                    Console.WriteLine(day2.deystvie);
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("Описание:" + day2.podrobnosty);
                    Console.WriteLine("Выбранная дата и время:  " + data);
                }
                else if (pos == 4 && data.Date == new DateTime(2023, 11, 02))
                {

                    Console.Clear();
                    Vremy day2 = new()
                    {
                        deystvie = ("Пойти в колледж"),
                        podrobnosty = ("Учиться"),
                        data = DateTime.Now
                    };
                    Console.WriteLine(day2.deystvie);
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("Описание:" + day2.podrobnosty);
                    Console.WriteLine("Выбранная дата и время:  " + data);

                }
                else if (pos == 4 && data.Date == new DateTime(2023, 11, 04))
                {
                    Console.Clear();
                    Vremy day2 = new()
                    {
                        deystvie = ("Пойти спать"),
                        podrobnosty = ("Спокойно поспать"),
                        data = DateTime.Now
                    };
                    Console.WriteLine(day2.deystvie);
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("Описание:" + day2.podrobnosty);
                    Console.WriteLine("Выбранная дата и время:  " + data);
                }
                else if (pos == 4 && data.Date == new DateTime(2023, 11, 05))
                {
                    Console.Clear();
                    Vremy day2 = new()
                    {
                        deystvie = ("Убратся"),
                        podrobnosty = ("Убраться в комнате"),
                        data = DateTime.Now
                    };
                    Console.WriteLine(day2.deystvie);
                    Console.WriteLine("---------------------------------------------------------------");   
                    Console.WriteLine("Описание:" + day2.podrobnosty);
                    Console.WriteLine("Выбранная дата и время:  " + data);
                }
                else if (pos == 3 && data.Date == new DateTime(2023, 11, 04))
                {
                    Console.Clear();
                    Vremy day2 = new()
                    {
                        deystvie = ("Прогуляться"),
                        podrobnosty = ("Погулять в парке"),
                        data = DateTime.Now
                    };
                    Console.WriteLine(day2.deystvie);
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("Описание:" + day2.podrobnosty);
                    Console.WriteLine("Выбранная дата и время:  " + data);
                }
                key = Console.ReadKey();

                Console.Clear();

            } while (true);

        }

    }
}