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

            bool admin = false;
            Console.WriteLine("Als je een account wil aanmaken, schrijf uw naam, alstublieft.");
            string userInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Typ nu uw wachtwoord in.");
            string userInputPassword = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Voer nu jouw leeftijd in alstublieft.");
            int userInputAge;
            while (!int.TryParse(Console.ReadLine(), out userInputAge))
            {
                Console.WriteLine("\nOngeldige invoer! Voer een nummer in.");
            }

            if (userInput.ToLower() == "yassir")
            {
                admin = true;
            }

            User user1 = new User(userInput, userInputPassword, userInputAge, 710569293, admin);
            user1.Login();

            Getal_Raden test = new Getal_Raden();
            test.Start();

            Dobbelsteen_Simulatie test = new Dobbelsteen_Simulatie();
            test.Start();

            Game_Karakter_met_Constructor test = new Game_Karakter_met_Constructor();
            test.Start();
            
            List<Car> carList = new List<Car>();

            Car car1 = new Car("Klep", "Mercedes", 4);
            carList.Add(car1);

            Car car2 = new Car("Seat", "Ibiza", 2);
            carList.Add(car2);

            foreach(Car car in carList)
            {
                car.PrintCarInfo();
            }
            */

            Item_Constructor_RPG test = new Item_Constructor_RPG();
            test.Start();
        }
    }
}
