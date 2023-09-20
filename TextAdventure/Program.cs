using Discord;
using Discord.Interactions.Builders;
using System;
using System.Numerics;
using System.Threading;
using TextAdventure;

class Program
{
    private static double saved = 5;

    private Var variable = new Var();

    public Program()
    {
        variable.Saved = 5;
        variable.Monsterlvl = 1;
        variable.Monsterhp = 5;
        variable.Schwertdmg = 1;
    }

    static void Main(string[] args)
    {
        Program program = new Program();

        while (true)
        {
            Console.Clear();
            program.variable.Gold = 200;
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
                program.variable.Stärke = 0.30;
                program.variable.Geschwindigkeit = 0.45;
                program.variable.StärkeAnzeige = 2;
                program.variable.GeschwindigkeitAnzeige = 3;
                program.variable.Player = "Lisa";
                program.Spiel();
            }
            else if (charakter.ToLower() == "thomas")
            {
                program.variable.Stärke = 0.45;
                program.variable.Geschwindigkeit = 0.30;
                program.variable.StärkeAnzeige = 3;
                program.variable.GeschwindigkeitAnzeige = 2;
                program.variable.Player = "Thomas";
                program.Spiel();
            }
            else if (charakter.ToLower() == "mike")
            {
                program.variable.Stärke = 0.60;
                program.variable.Geschwindigkeit = 0.15;
                program.variable.StärkeAnzeige = 4;
                program.variable.GeschwindigkeitAnzeige = 1;
                program.variable.Player = "Mike";
                program.Spiel();
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
        Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
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
        Console.WriteLine("ACHTUNG! Wenn du weiter eingibst, werden die Monster gefährlicher und Stärker!");

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
        variable.Monsterhp = saved; 
        double multiplikator = 1.25;
        variable.Monsterhp *= multiplikator;
        saved = variable.Monsterhp; 
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
        Random zufallsgenerator = new Random();
        int rnd = zufallsgenerator.Next(0, 2);
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
        variable.Gold += rnd;
        Console.WriteLine("Du hast das Wildschwein besiegt!");
        Console.WriteLine("Du erhälst " + rnd + " Goldmünzen!");
        variable.Monsterhp = saved;
        Console.WriteLine(variable.Monsterhp);
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
                Weiter();
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
        Console.Clear();
        Console.WriteLine("Willkommen in meiner Bar. Was kann ich für dich tun?");
        Console.WriteLine("1. Trinken");
        Console.WriteLine("2. Verlassen");
        
        string input = Console.ReadLine();
        if (input == "1")
        {
            Console.Clear();
            Console.WriteLine("Herzlich willkommen, Fremder! Was darf's sein, in unserer ehrwürdigen Taverne?");
            Console.WriteLine("1: Drachenblut Ale");
            Console.WriteLine("2: Feuerschlucker Schnaps");
            Console.WriteLine("3: Eutertrunk");
            string auswahl = Console.ReadLine();
            switch (auswahl)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Ihr habt Geschmack, mein Freund! Dieser Trank wird Euch wohltun, das versprech' ich Euch.");
                    Thread.Sleep(500);
                    Console.WriteLine("Hier ist Euer Ale, mein Freund.");
                    Thread.Sleep(500);
                    Console.WriteLine("Für Euer Ale sind es 2 Goldmünzen. Prost und möge es Euch erfreuen.");
                    variable.Gold -= 2;
                    Thread.Sleep(500);
                    Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                    Console.ReadKey();
                    Bar();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Ah, ein Freund des Feuerschlucker Schnapses! Das macht 3 Goldmünzen");
                    Thread.Sleep(500); 
                    Console.WriteLine("Hier ist Euer Schnaps!");
                    variable.Gold -= 3;
                    Thread.Sleep(500);
                    Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                    Console.ReadKey();
                    Bar();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Ah, die Einfachheit der Milch, eine Wohltat für Leib und Seele. Ihr werdet die Frische dieses Tranks schätzen.");
                    Thread.Sleep(500);
                    Console.WriteLine("Hier ist Deine Milch.");
                    Thread.Sleep(500);
                    Console.WriteLine("Das macht 2 Goldmünzen für Eure Milch. Genießt sie in bester Gesundheit.");
                    variable.Gold -= 2;
                    Thread.Sleep(500);
                    Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                    Console.ReadKey();
                    Bar();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Ein fremdartiger Name für ein Getränk! In unserer Taverne sind wir immer offen für Neues.");
                    Console.ReadKey();
                    Bar();
                    break;
            }
        } 
        else 
        { 
            Console.Clear();
            Stadt();
        }
    }

    public void Quest()
    {

    }

    public void Leave()
    {

    }
}
