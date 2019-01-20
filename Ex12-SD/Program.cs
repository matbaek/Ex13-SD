using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book;

namespace Ex12_SD
{
    class Program
    {
        int count = 0;
        static void Main(string[] args)
        {
            bool whileRunning = true;
            Books b = new Books();
            int menuID = 0;
            string book = null;
            while(whileRunning)
            {
                switch(menuID)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("1. Skriv bog title, 2. Få bog, 3. Eksistere bogen");
                        Console.Write("Vælg Menu ID: ");
                        menuID = int.Parse(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("Skriv bog title: ");
                        book = Console.ReadLine();
                        b.AddBook(book);
                        menuID = 0;
                        break;
                    case 2:
                        Console.WriteLine("Få bog: ");
                        int getBook = int.Parse(Console.ReadLine());
                        Console.WriteLine(Print(b.GetBook(getBook)));
                        Console.ReadLine();
                        menuID = 0;
                        break;
                    case 3:
                        Console.WriteLine("Eksistere bogen: ");
                        book = Console.ReadLine();
                        Console.WriteLine(b.ExistBook(book));
                        Console.ReadLine();
                        menuID = 0;
                        break;
                }

            }

        }

        public static string Print(Object b)
        {
            return b.ToString();
        }
    }
}
