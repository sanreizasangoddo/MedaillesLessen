using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdracht
{
    internal class Program
    {
        private static string _playerName = "Yassir";
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hallo, wat is jouw naam en leeftijd?");
            string naam = Console.ReadLine();
            string leeftijd = Console.ReadLine();
            Console.WriteLine("Hoi " + naam + ", jij bent " + leeftijd + " jaar oud!");
            
            Kamer_Keuze_Tekst_Game test = new Kamer_Keuze_Tekst_Game();
            test.Start();
                        
            Tips_voor_het_weer test = new Tips_voor_het_weer();
            test.Start();

            Loops test = new Loops();
            test.Start();

            Student stu = new Student("Yassir", 16, "Ouallal", "Deon");
            stu.SayHello();
            stu.Introduction();
            stu.Friend();
            
            Leeftijd_Berekenen test = new Leeftijd_Berekenen();
            test.Start();

            Tafels_Generator test = new Tafels_Generator();
            test.Start();

            Getal_Raden test = new Getal_Raden();
            test.Start();
            */

            bool admin = false;
            Console.WriteLine("Als je een account wil aanmaken, schrijf uw naam, alstublieft.");
            string userInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Typ nu uw wachtwoord in.");
            string userInputPassword = Console.ReadLine();

            if (userInput.ToLower() == "yassir")
            {
                admin = true;
            }

            User user1 = new User(userInput, userInputPassword, 16, 710569293, admin);
            user1.Login();
        }
    }
}
