using System;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;

namespace consoleApp1
{

    class Program
    {
        static void Main()
        {
            bool isOpen = true;
            string[,] books =
            {
                { "Александр Пушкин", "Михаил Лермонтов", "Сергей Есенин" },
                {"Роберт Мартин", "Джесси Шелл", "Сергей Тепляков" },
                {"Стивен Кинг", "Говард ЛАвкрафт", "Брем Стокер" }
            };

            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("\nВесь список авторов: \n");

                for (int i = 0; i < books.GetLength(0); i++)
                {
                    for (int j = 0; j < books.GetLength(1); j++)
                    {
                        Console.Write(books[i, j] + "|");
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Библиотека");
                Console.WriteLine("\n 1 - узнать имя автора по индексу книги.\n\n 2 - найти книгу по автору.\n\n3 - выход.\n");
                Console.WriteLine("\nВыберите пункт меню: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int line, column;
                        Console.Write("Введите номер полки: ");
                        line = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("Введите номер столбца: ");
                        column = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Это автор: " + books[line, column]);

                        break;
                    case 2:
                        string author;
                        bool authorIsFound = false;
                        Console.Write("Введите автора: ");
                        author = Console.ReadLine();
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (author.ToLower() == books[i, j].ToLower())
                                {
                                    Console.WriteLine($"Автор {books[i, j]} находится по адресу: полка {i + 1}, место {j + 1}.");
                                    authorIsFound = true;
                                }
                            }
                        }
                        if (authorIsFound == false)
                        {
                            Console.WriteLine("Такого автора не существует");
                        }
                        break;
                    case 3:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Введена неверная команда!");
                        break;
                }

                if (isOpen)
                {
                    Console.WriteLine("Нажмите любую клавишу");
                }

                if (isOpen)
                {
                    Console.ReadKey();
                    Console.Clear();
                }
            }


        }



    }
}


