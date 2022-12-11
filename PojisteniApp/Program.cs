using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PojisteniApp;


namespace PojisteniApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Database data = new Database();
            bool end = false;
            while (!end)
            {
                Console.SetCursorPosition((Console.WindowWidth) / 2, Console.CursorTop);
                Console.WriteLine("\n\r\n   _______    ______      ___  __      ________  ___________  _______  _____  ___    __              __         _______   _______   \r\n  |   __ \"\\  /    \" \\    |\"  ||\" \\    /\"       )(\"     _   \")/\"     \"|(\\\"   \\|\"  \\  |\" \\            /\"\"\\       |   __ \"\\ |   __ \"\\  \r\n  (. |__) :)// ____  \\   ||  |||  |  (:   \\___/  )__/  \\\\__/(: ______)|.\\\\   \\    | ||  |          /    \\      (. |__) :)(. |__) :) \r\n  |:  ____//  /    ) :)  |:  ||:  |   \\___  \\       \\\\_ /    \\/    |  |: \\.   \\\\  | |:  |         /' /\\  \\     |:  ____/ |:  ____/  \r\n  (|  /   (: (____/ //___|  / |.  |    __/  \\\\      |.  |    // ___)_ |.  \\    \\. | |.  |        //  __'  \\    (|  /     (|  /      \r\n /|__/ \\   \\        //  :|_/ )/\\  |\\  /\" \\   :)     \\:  |   (:      \"||    \\    \\ | /\\  |\\      /   /  \\\\  \\  /|__/ \\   /|__/ \\     \r\n(_______)   \\\"_____/(_______/(__\\_|_)(_______/       \\__|    \\_______) \\___|\\____\\)(__\\_|_)    (___/    \\___)(_______) (_______)    \r\n                                                                                                                                    \r\n\n\n");
                Console.WriteLine();
                Console.WriteLine("Menu\n");
                Console.WriteLine("Zvolte si prosím akci, kterou chcete provést\n");
                Console.WriteLine("Zvolte 1 pro výpis aktuálních klientů");
                Console.WriteLine("Zvolte 2 pro přidání nového klienta");
                Console.WriteLine("Zvolte 3 pro vyhledání klienta z databáze");
                Console.WriteLine("Zvolte 4 pro ukončení aplikace");

                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                switch (choice)
                {
                    case '1':
                        data.ListAllPeople();
                        Console.WriteLine("\nPokračujte libovolnou klávesou..");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case '2':
                        data.AddPerson();
                        Console.WriteLine("\nPokračujte libovolnou klávesou..");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case '3':
                        data.SearchPerson();
                        Console.WriteLine("\nPokračujte libovolnou klávesou..");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case '4':
                        end = true;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Neplatná volba! Stiskněte libovolnou klávesu a zadejte volbu znova");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}

