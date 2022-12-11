using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojisteniApp
{
    internal class Database
    {
        private List<Person> clients = new List<Person>()
        {
            // Testovací data

            new Person("Karolína", "Nicjsemsenenaučila", 25, "787787787"),
            new Person("Karel", "Pročjetotaktěžký", 30, "715783111"),
            new Person("Kristýna", "Zoufalá", 32, "724785657"),
            new Person("Petr", "Databáze", 29, "711234780")
        };

        // Metoda pro výpis
        public void ListAllPeople()
        {
            Console.WriteLine("\nVyřizuji požadavek...\n", Console.ForegroundColor = ConsoleColor.Blue);

            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(25);
            }
            Console.ResetColor();

            Console.Write("\nHotovo!\n", Console.ForegroundColor = ConsoleColor.Green);
            Console.ResetColor();
            var people = clients.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ThenBy(p => p.Age);
            ListAll(people);
        }
        // Metoda pro přidání
        public void AddPerson()
        {
            string firstName = "";
            while (String.IsNullOrEmpty(firstName))
            {
                Console.Write("Zadejte jméno: ");
                firstName = Console.ReadLine();
            }
            string lastName = "";
            while (String.IsNullOrEmpty(lastName))
            {
                Console.Write("Zadejte příjmení: ");
                lastName = Console.ReadLine();
            }
            int age = 0;
            Console.Write("Zadejte věk: ");
            while (!int.TryParse(Console.ReadLine(), out age))
                Console.WriteLine("Zadejte věk: ");

            string phoneNumber = "";
            while (String.IsNullOrEmpty(phoneNumber))
            {
                Console.WriteLine("Zadejte telefonní číslo: ");
                phoneNumber = Console.ReadLine();
            }

            Console.WriteLine("\nVyřizuji požadavek...\n", Console.ForegroundColor = ConsoleColor.Blue);

            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(25);
            }
            Console.ResetColor();

            Console.Write("\nHotovo!\n", Console.ForegroundColor = ConsoleColor.Green);
            Console.ResetColor();

            clients.Add(new Person(firstName, lastName, age, phoneNumber));
            Console.WriteLine();

            Console.WriteLine("\nKlient byl uložen!\n", Console.ForegroundColor = ConsoleColor.Green);
            Console.ResetColor();
        }
        // Metoda pro vyhledávání
        public void SearchPerson()
        {
            string firstName = "";
            while (String.IsNullOrEmpty(firstName))
            {
                Console.Write("Zadejte jméno klienta: ");
                firstName = Console.ReadLine();
            }
            string lastName = "";
            while (String.IsNullOrEmpty(lastName))
            {
                Console.Write("Zadejte příjmení klienta: ");
                lastName = Console.ReadLine();
            }
            Console.WriteLine("\nVyřizuji požadavek...\n", Console.ForegroundColor = ConsoleColor.Blue);

            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(25);
            }
            Console.ResetColor();
            Console.Write("\nHotovo!\n", Console.ForegroundColor = ConsoleColor.Green);
            Console.ResetColor();

            var people = clients.Where(p => p.FirstName.ToLower() == firstName.ToLower() && p.LastName.ToLower() == lastName.ToLower()).OrderBy(p => p.FirstName).ThenBy(p => p.LastName).ThenByDescending(p => p.Age);
            if (people.Count() > 0)
            {
                Console.WriteLine();
                ListAll(people);
            }
            else
            {
                Console.WriteLine("Klient nebyl nalezen!", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
            }
        }
        // List klientu
        private void ListAll(IEnumerable<Person> people)
        {
            foreach (Person p in people)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
