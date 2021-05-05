using System;

namespace Yes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool logLoop = true;
            while (logLoop == true)
            {
                try
                {
                    Console.WriteLine("1) Dodaj książkę");
                    Console.WriteLine("2) Znajdź książki po tytule");
                    Console.WriteLine("3) Znajdź książki po imieniu i nazwisku autora");
                    Console.WriteLine("4) Wyświetl wszystkie książki");
                    Console.WriteLine("5) Wyjdź z aplikacji");

                    int logCase = int.Parse(Console.ReadLine());

                    switch (logCase)
                    {
                        case 1:
                            BookPL Add = new BookPL();
                            Add.AddBook();
                            break;
                        case 2:
                            
                            break;
                        case 3:
                            
                            break;
                        case 4:
                            BookPL ShowAll = new BookPL();
                            ShowAll.GetAllBook();
                            break;
                        case 5:
                            logLoop = false;
                            break;
                        default:
                            Console.WriteLine("Wprowadź poprawną wartość...");
                            break;
                    }
                }
                catch (FormatException)
                    {
                        logLoop = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Spróbuj ponownie...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
        }
    }
}
