using System;
using System.Data;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Willkommen im RPG Game :D");
            Console.WriteLine("Wähle deinen Charakter!");
            Console.WriteLine("*********************");
            Console.WriteLine("Lisa");
            Console.WriteLine("Stärke: ||");
            Console.WriteLine("Geschwindigkeit: |||");
            Console.WriteLine("*********************");
            Console.WriteLine("*********************");
            Console.WriteLine("Thomas");
            Console.WriteLine("Stärke: |||");
            Console.WriteLine("Geschwindigkeit: ||");
            Console.WriteLine("*********************");
            Console.WriteLine("*********************");
            Console.WriteLine("Mike");
            Console.WriteLine("Stärke: ||||");
            Console.WriteLine("Geschwindigkeit: |");
            Console.WriteLine("*********************");
            string charakter = Console.ReadLine();

            if (charakter.ToLower() == "lisa")
            {
                double stärke = 0.30;
                double geschwindigkeit = 0.45;
                double stärkeAnzeige = 2;
                double geschwindigkeitAnzeige = 3;
                string player = "Lisa";
                Spiel(stärke, geschwindigkeit, player, stärkeAnzeige, geschwindigkeitAnzeige);
            }
            else if (charakter.ToLower() == "thomas")
            {
                double stärke = 0.45;
                double geschwindigkeit = 0.30;
                double stärkeAnzeige = 3;
                double geschwindigkeitAnzeige = 2;
                string player = "Thomas";
                Spiel(stärke, geschwindigkeit, player, stärkeAnzeige, geschwindigkeitAnzeige);
            }
            else if (charakter.ToLower() == "mike")
            {
                double stärke = 0.60;
                double geschwindigkeit = 0.15;
                double stärkeAnzeige = 4;
                double geschwindigkeitAnzeige = 1;
                string player = "Mike";
                Spiel(stärke, geschwindigkeit, player, stärkeAnzeige, geschwindigkeitAnzeige);

            }
            else
            {
                Console.WriteLine("Wer ist das denn? Den kenne ich garnicht..");
                Thread.Sleep(1000);
            }
        }
    }

    public static void Spiel(double stärke, double geschwindigkeit, string player, double stärkeAnzeige, double geschwindigkeitAnzeige)
    {
        Thread.Sleep(400);
        Console.Clear();
        Console.WriteLine("Du hast " + player + " gewählt!");
        Thread.Sleep(1000);
        Console.WriteLine("Stärke " + stärkeAnzeige);
        Thread.Sleep(500);
        Console.WriteLine("Geschwindigkeit " + geschwindigkeitAnzeige);
        Thread.Sleep(1500);
        Console.Clear();
        Console.WriteLine("ACHTUNG! Ein Wildschwein!");
        Thread.Sleep(1000);
        Console.WriteLine("Hier hast du ein Schwert");
        Thread.Sleep(1000);
        string schwert = "Anfängerschwert";
        double schwertdmg = 1;
        Console.WriteLine("+1 " + schwert);
        Thread.Sleep(2000);
        Console.Clear();
        double hp = 5;
        Console.WriteLine("Wildschwein " + hp + "HP");
        while (hp > 0)
        {
            double fast2 = 2000 * geschwindigkeit;
            double fast = 2000 - fast2;
            Thread.Sleep(1000);
            double dmg1 = schwertdmg * stärke;
            double dmg = schwertdmg + dmg1;
            hp = hp - dmg;

            Console.WriteLine("Wildschwein: -" + dmg + "HP");
            Console.WriteLine(hp);
        }
        hp = 0;
        Console.WriteLine(hp);
        Console.ReadKey();
    }

}
