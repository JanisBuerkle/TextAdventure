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
        int monsterlvl = 1;
        double monsterhp = 5;
        double schwertdmg = 1;

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

        Console.WriteLine("+1 " + schwert);
        Thread.Sleep(2000);
        Console.Clear();

        Console.WriteLine("Wildschwein " + monsterhp + "hp");
        while (monsterhp > 0)
        {
            double fast2 = 2000 * geschwindigkeit;
            double fast = 2000 - fast2;
            Thread.Sleep(1000);
            double dmg1 = schwertdmg * stärke;
            double dmg = schwertdmg + dmg1;
            monsterhp = monsterhp - dmg;

            Console.WriteLine("Wildschwein: -" + dmg + "hp");
            Console.WriteLine(monsterhp);
        }
        monsterhp = 0;
        Console.WriteLine(monsterhp);

        Console.WriteLine("Wenn du in die Stadt gehen willst schreibe 'Stadt' das geht immer!");
        Console.WriteLine("Wenn du nicht in die Stadt gehst drücke enter oder gebe 'weiter' ein.");
        Console.WriteLine("ACHTUNG! Wenn du weiter eingibst werden die Monster gefährlicher und werden Stärker!");

        string eingabe = Console.ReadLine();
        if (eingabe.ToLower() == "stadt")
        {
            Stadt();
        }
        else if (eingabe.ToLower() == "weiter")
        {
            Console.Clear();
            Console.WriteLine("Achtung hier sind die Monster 1 Level höher");
            monsterlvl++;
            monsterhp = monsterhp * 1.25;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Du bleibst also");
        }

        Console.ReadKey();
    }
    public static void Stadt()
    {
        Console.Clear();
        Console.WriteLine("Willkommen in der Hauptstadt!");
        Console.WriteLine("Hier gibt es einiges zu sehen!");
        Console.WriteLine("Gebe die jeweiligen Nummern ein was du tun willst");
        Console.WriteLine("1: Waffen & Rüstungsladen");
        Console.WriteLine("2: Bar");
        Console.WriteLine("3: Questtafel");
        Console.WriteLine("4: Stadt verlassen");
    }

}
