using System;
using System.Numerics;
using System.Threading;
using TextAdventure;

class Program
{
    private static double saved = 5;


    Var variable = new Var();
    public Program(Var variable)
    {
        this.variable = variable;
    }


    void Main()
    {
        variable.Monsterlvl = 1;
        variable.Monsterhp = 5;
        variable.Schwertdmg = 1;

        

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
                variable.Stärke = 0.30;
                variable.Geschwindigkeit = 0.45;
                variable.StärkeAnzeige = 2;
                variable.GeschwindigkeitAnzeige = 3;
                variable.Player = "Lisa";
                Spiel();
            }
            else if (charakter.ToLower() == "thomas")
            {
                variable.Stärke = 0.45;
                variable.Geschwindigkeit = 0.30;
                variable.StärkeAnzeige = 3;
                variable.GeschwindigkeitAnzeige = 2;
                variable.Player = "Thomas";
                Spiel();
            }
            else if (charakter.ToLower() == "mike")
            {
                variable.Stärke = 0.60;
                variable.Geschwindigkeit = 0.15;
                variable.StärkeAnzeige = 4;
                variable.GeschwindigkeitAnzeige = 1;
                variable.Player = "Mike";
                Spiel();
            }
            else
            {
                Console.WriteLine("Wer ist das denn? Den kenne ich garnicht..");
                Thread.Sleep(1000);
            }
        }
    }

    public void Spiel()
    {
        Thread.Sleep(400);
        Console.Clear();
        Console.WriteLine("Du hast " + variable.Player + " gewählt!");
        Thread.Sleep(1000);
        Console.WriteLine("Stärke " + variable.StärkeAnzeige);
        Thread.Sleep(500);
        Console.WriteLine("Geschwindigkeit " + variable.GeschwindigkeitAnzeige);
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
        Farming();
    }

    public void Farming()
    {
        Console.WriteLine("Wildschwein " + variable.Monsterhp + "hp");
        while (variable.Monsterhp > 0)
        {
            double fast2 = 2000 * variable.Geschwindigkeit;
            double fast = 2000 - fast2;
            Thread.Sleep(1000);
            double dmg1 = variable.Schwertdmg * variable.Stärke;
            double dmg = variable.Schwertdmg + dmg1;
            variable.Monsterhp = variable.Monsterhp - dmg;

            Console.WriteLine("Wildschwein: -" + dmg + "hp");
            Console.WriteLine(variable.Monsterhp);
        }

        Console.WriteLine("Wenn du in die Stadt gehen willst, schreibe 'Stadt'.");
        Console.WriteLine("Wenn du nicht in die Stadt gehst, drücke Enter oder gib 'weiter' ein.");
        Console.WriteLine("ACHTUNG! Wenn du weiter eingibst, werden die Monster gefährlicher und variable.Stärker!");

        while (true)
        {
            Switch();
        }
    }

    public void Stay()
    {
        Console.Clear();
        Console.WriteLine("Du bleibst also");
    }

    public void HPRechnung()
    {
        variable.Monsterhp = variable.Save;
        double multiplikator = 1.25;
        variable.Monsterhp *= multiplikator;
        double saved = variable.Monsterhp;
        Weiter();
    }


    public void Weiter()
    {
        Console.Clear();
        Console.WriteLine("Achtung, hier sind die Monster 1 Level höher.");
        Console.WriteLine("Gebe 'kill' ein, um Monster zu töten.");
        while (true)
        {

            Switch();
            
        }
    }

    public void Switch()
    {
        int level = 0;
        level++;
        string input = Console.ReadLine();
        switch (input.ToLower())
        {
            case "kill":
                if (level >= 10)
                {
                    Wildschwein();
                    Thread.Sleep(200);
                }
                else
                {
                    Wildschwein();
                    Thread.Sleep(300);
                }
                break;
            case "weiter":
                variable.Monsterhp = 5;
                HPRechnung();
                break;
            case "stadt":
                Stadt();
                break;
        }
    }

    public void Wildschwein()
    {
        Console.WriteLine("Wildschwein " + variable.Monsterhp + "hp");
        while (variable.Monsterhp > 0)
        {
            double fast2 = 2000 * variable.Geschwindigkeit;
            double fast = 2000 - fast2;
            Thread.Sleep(1000);
            double dmg1 = variable.Schwertdmg * variable.Stärke;
            double dmg = variable.Schwertdmg + dmg1;
            variable.Monsterhp = variable.Monsterhp - dmg;

            Console.WriteLine("Wildschwein: -" + dmg + "hp");
            Console.WriteLine(variable.Monsterhp);
        }
    }

    public void Stadt()
    {
        Console.Clear();
        Console.WriteLine("Willkommen in der Hauptstadt!");
        Console.WriteLine("Hier gibt es einiges zu sehen!");
        Console.WriteLine("Gebe die jeweiligen Nummern ein, was du tun willst");
        Console.WriteLine("1: Waffen & Rüstungsladen");
        Console.WriteLine("2: Bar");
        Console.WriteLine("3: Questtafel");
        Console.WriteLine("4: Stadt verlassen");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Weapon();
                break;
            case "2":
                Bar();
                break;
            case "3":
                Quest();
                break;
            case "4":
                Leave();
                break;
            default:
                Console.WriteLine("Ungültig!");
                break;
        }
    }

    public void Weapon()
    {
        Console.Clear();
        Console.WriteLine("Willkommen in meinem Waffenladen!");
        Console.WriteLine("Wie kann ich dir helfen?");
        Console.WriteLine("Gebe die jeweiligen Nummern ein, was du tun willst");
        Console.WriteLine("1: Waffen kaufen");
        Console.WriteLine("2: Rüstung kaufen");
        Console.WriteLine("3: Laden verlassen");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":

                break;
            case "2":

                break;
            case "3":
                Stadt();
                break;
            default:
                Console.WriteLine("Ungültig!");
                break;
        }
    }

    public void Bar()
    {

    }

    public void Quest()
    {

    }

    public void Leave()
    {

    }
}
