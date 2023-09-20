using Discord;
using Discord.Interactions.Builders;
using System;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms.VisualStyles;
using TextAdventure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

class Program
{
    private static double saved = 5;

    private Var variable = new Var();

    public Program()
    {
        variable.Saved = 5;
        variable.Monsterlvl = 1;
        variable.Monsterhp = 5;
        variable.Schwertdmg = 5;
        variable.Leben = 100;
        variable.Damage = 1;
        
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
        double multiplikator = 1.5;
        variable.Monsterhp *= multiplikator;
        variable.Monsterlvl++;
        saved = variable.Monsterhp; 
        Weiter();
    }


    public void Weiter()
    {
        variable.Monsterhp = saved;
        Console.Clear();
        Console.WriteLine("Achtung, hier sind die Monster auf Level " + variable.Monsterlvl + "!");
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
                Console.Clear();
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
        string formatierteMonsterhp = variable.Monsterhp.ToString("F0");
        Random zufallsgenerator = new Random();
        double rnd = zufallsgenerator.Next(0, 5);
        Console.WriteLine("Wildschwein " + formatierteMonsterhp + "hp");
        while (variable.Monsterhp > 0)
        {
            double fast2 = 2000 * variable.Geschwindigkeit;
            double fast = 2000 - fast2;
            Thread.Sleep(1000);
            double dmg1 = variable.Schwertdmg * variable.Stärke;
            double dmg = variable.Schwertdmg + dmg1;
            variable.Monsterhp = variable.Monsterhp - dmg;

            Console.WriteLine("Wildschwein: -" + dmg + "hp");
            string formatierteMonsterhpp = variable.Monsterhp.ToString("F0");
            Console.WriteLine("Das Wildschwein hat noch " + formatierteMonsterhpp + "HP!");
            Random rndm = new Random();
            double random = rndm.Next(1, 4);
            double mobdmgt = variable.Monsterlvl * 1.7 + random;
            double mobdmg = variable.Damage + mobdmgt;
            variable.Leben -= mobdmg;
            Console.WriteLine("Das Wildschwein hat dir " + mobdmg + " Leben abgezogen!");
            string formatierteLeben = variable.Leben.ToString("F0");
            Console.WriteLine("Du hast noch " + formatierteLeben + " Leben!");
            if (variable.Leben < 0)
            {
                variable.Gold = variable.Gold * 0.25;
                Console.WriteLine("Du wirst in der Stadt neugespawnt und verlierst 25% deines Geldes!");
                Console.WriteLine("Du hast nun noch " + variable.Gold + "Gold");
                Console.WriteLine("Warte 3 Sekunden bis du Spawnst!");
                Thread.Sleep(3000);
                Stadt();
            }
        }

        double rechnung = saved / 10;
        double reward = rnd + rechnung;

        string formatierterReward = reward.ToString("F0");
        string formatiertesLeben = variable.Leben.ToString("F0");
        string formatiertesGold = variable.Gold.ToString("F0");
        int rewardConvert = Convert.ToInt32(reward);
        variable.Gold += rewardConvert;
        variable.Monsterhp = saved;
        Console.Clear();
        Console.WriteLine("Du hast das Wildschwein Level " + variable.Monsterlvl + " besiegt!");
        Console.WriteLine("Das Wilschwein hatte " + formatierteMonsterhp + "HP");
        Console.WriteLine("Du hast noch " + formatiertesLeben + " Leben!");
        Console.WriteLine("Du erhälst " + formatierterReward + " Goldmünzen!");
        Console.WriteLine("Du hast nun insgesamt " + variable.Gold + " Goldmünzen!");
    }

    public void Stadt()
    {
        Console.Clear();
        Console.WriteLine("Willkommen in der Hauptstadt!");
        Console.WriteLine("Hier gibt es einiges zu sehen!");
        Console.WriteLine("Gebe die jeweiligen Nummern ein, was du tun willst");
        Console.WriteLine("1: Schmiede");
        Console.WriteLine("2: Taverne");
        Console.WriteLine("3: Questtafel");
        Console.WriteLine("4: Stadt verlassen");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Schmiede();
                break;
            case "2":
                Taverne();
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

    public void Schmiede()
    {
        Console.Clear();
        Console.WriteLine("Seid gegrüßt, werte Gäste! Herzlich willkommen in meinem bescheidenen Waffenladen.");
        Console.WriteLine("Wie kann ich Euch heute bei der Auswahl von Rüstungen und Schwertern unterstützen?");
        Console.WriteLine("1: Schwerter kaufen");
        Console.WriteLine("2: Rüstung kaufen");
        Console.WriteLine("3: Verlassen");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.WriteLine("In meiner bescheidenen Schmiede findet Ihr diese edlen Klingen:");
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

    public void Taverne()
    {
        Console.Clear();
        Console.WriteLine("Willkommen in meiner Taverne. Was kann ich für dich tun?");
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
                    string formatierterReward = variable.Gold.ToString("F2");
                    Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                    Console.ReadKey();
                    Taverne();
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
                    Taverne();
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
                    Taverne();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Ein fremdartiger Name für ein Getränk! In unserer Taverne sind wir immer offen für Neues.");
                    Console.ReadKey();
                    Taverne();
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
