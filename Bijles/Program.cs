using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bijles
{
    class Program
    {
        static void Main(string[] args)
        {
            int cijfers , hoofdletters , kleineletters , speciaal = 0;
            
            Console.Write("Hoeveel cijfers wilt u in het wachtwoord? ");
            while(!int.TryParse(Console.ReadLine() , out cijfers))
            {
                ShowError("Hoeveel cijfers wilt u in het wachtwoord? ");
            }

            Console.Write("Hoeveel hoofdletters wilt u in het wachtwoord? ");
            while (!int.TryParse(Console.ReadLine(), out hoofdletters))
            {
                ShowError("Hoeveel hoofdletters wilt u in het wachtwoord? ");
            }

            Console.Write("Hoeveel kleine letters wilt u in het wachtwoord? ");
            while (!int.TryParse(Console.ReadLine(), out kleineletters))
            {
                ShowError("Hoeveel kleine letters wilt u in het wachtwoord? ");
            }

            Console.Write("Hoeveel speciale tekens wilt u in het wachtwoord? ");
            while (!int.TryParse(Console.ReadLine(), out speciaal))
            {
                ShowError("Hoeveel speciale tekens wilt u in het wachtwoord? ");
            }

            Password pw = new Password();
            string randomPassword = pw.CreateRandomPassword(hoofdletters, kleineletters,
                cijfers, speciaal);

            Console.WriteLine("Het gegenereerde wachtwoord is {0}",
                randomPassword);
            Console.ReadKey();
        }

        private static void ShowError(string message)
        {
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;
            ConsoleColor oldForegroundColor = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Onjuiste invoer");
            Console.WriteLine(message);
            Console.BackgroundColor = oldBackgroundColor;
            Console.ForegroundColor = oldForegroundColor;
        }
    }
}
