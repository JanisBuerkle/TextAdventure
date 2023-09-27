using System;
using System.Collections.Generic;
using System.Threading;
using TextAdventure;

class Program
{
    private static double saved = 5;

    private Var variable = new Var();



    public static List<Var> swords = new List<Var>()
        {
            new Var() { SwordName = "Anfängerschwert", SwordDamage = 1, Preis = 200 },
            new Var() { SwordName = "Wolfslayer", SwordDamage = 4, Preis = 400 },
            new Var() { SwordName = "Ironsides", SwordDamage = 7, Preis = 600 },
            new Var() { SwordName = "Ravenshadow", SwordDamage = 18, Preis = 900 },
            new Var() { SwordName = "Templar's Oath", SwordDamage = 23, Preis = 1350 },
            new Var() { SwordName = "Bloodletter", SwordDamage = 34, Preis = 2025 },
            new Var() { SwordName = "Grimfang", SwordDamage = 80, Preis = 3038 },
            new Var() { SwordName = "Hawkstrike", SwordDamage = 119, Preis = 4557 },
            new Var() { SwordName = "Kingslayer", SwordDamage = 239, Preis = 6835 },
            new Var() { SwordName = "Dragonsbane", SwordDamage = 308, Preis = 10253 },
            new Var() { SwordName = "Thornblade", SwordDamage = 556, Preis = 15380 },
            new Var() { SwordName = "Wyrmcleaver", SwordDamage = 912, Preis = 18500 },
            new Var() { SwordName = "Valiant Edge", SwordDamage = 1625, Preis = 22000 },
            new Var() { SwordName = "Blackthorn", SwordDamage = 2250, Preis = 28000 },
            new Var() { SwordName = "Ironclad", SwordDamage = 3500, Preis = 35000 },
            new Var() { SwordName = "Stormbringer", SwordDamage = 6000, Preis = 44000 },
            new Var() { SwordName = "Silverthorn", SwordDamage = 15000, Preis = 55000 },
            new Var() { SwordName = "Lionheart", SwordDamage = 25000, Preis = 68000 },
            new Var() { SwordName = "Excalibur", SwordDamage = 40000, Preis = 85000 }
        };

    public Program()
    {
        variable.Saved = 5;
        variable.Monsterlvl = 1;
        variable.Monsterhp = 5;
        variable.SwordName = swords[0].SwordName;
        variable.SwordDamage = swords[0].SwordDamage;
        variable.Leben = 1000;
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
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("Du hast " + variable.Player + " gewählt!");
        Thread.Sleep(1500);
        Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
        Thread.Sleep(1500);
        Console.WriteLine("Stärke " + variable.StärkeAnzeige);
        Thread.Sleep(1500);
        Console.WriteLine("Geschwindigkeit " + variable.GeschwindigkeitAnzeige);
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("ACHTUNG! Ein Wildschwein!");
        Thread.Sleep(1500);
        Console.WriteLine("Hier hast du ein Schwert");
        Thread.Sleep(1500);


        Console.WriteLine("+1 " + variable.SwordName);
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
            double dmg1 = variable.SwordDamage * variable.Stärke;
            double dmg = variable.SwordDamage + dmg1;
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
        double multiplikator = 1.2;
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
    //Gut
    public void Wildschwein()
    {
        string formatierteMonsterhp = variable.Monsterhp.ToString("F0");
        Random zufallsgenerator = new Random();
        double rnd = zufallsgenerator.Next(0, 4);
        Console.WriteLine("Wildschwein " + formatierteMonsterhp + "hp");
        while (variable.Monsterhp > 0)
        {
            double fast2 = 2000 * variable.Geschwindigkeit;
            int fast3 = Convert.ToInt32(fast2);
            int fast = 2000 - fast3;
            Thread.Sleep(fast);
            double dmg1 = variable.SwordDamage * variable.Stärke;
            double dmg = variable.SwordDamage + dmg1;
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
                variable.Leben = 100;
                variable.Monsterlvl = 1;
                variable.Saved = 5;
                Thread.Sleep(4000);
                Stadt();
            }
        }

        double rechnung = saved / 4;
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
        variable.Monsterlvl = 1;
        variable.Saved = 5;
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
                Thread.Sleep(1000);
                Stadt();
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
                Console.Clear();
                Console.WriteLine("Wenn du Informationen über die Schwerter haben möchtest gebe die jeweilige Zahl ein:");
                Console.WriteLine("In meiner bescheidenen Schmiede findet Ihr diese edlen Klingen:");
                Console.WriteLine("1: " + swords[0].SwordName);
                Console.WriteLine("2: " + swords[1].SwordName);
                Console.WriteLine("3: " + swords[2].SwordName);
                Console.WriteLine("4: " + swords[3].SwordName);
                Console.WriteLine("5: " + swords[4].SwordName);
                Console.WriteLine("6: " + swords[5].SwordName);
                Console.WriteLine("7: " + swords[6].SwordName);
                Console.WriteLine("8: " + swords[7].SwordName);
                Console.WriteLine("9: " + swords[8].SwordName);
                Console.WriteLine("10: " + swords[9].SwordName);
                Console.WriteLine("11: " + swords[10].SwordName);
                Console.WriteLine("12: " + swords[11].SwordName); 
                Console.WriteLine("13: " + swords[12].SwordName);
                Console.WriteLine("14: " + swords[13].SwordName);
                Console.WriteLine("15: " + swords[14].SwordName);
                Console.WriteLine("16: " + swords[15].SwordName);
                Console.WriteLine("17: " + swords[16].SwordName);
                Console.WriteLine("18: " + swords[17].SwordName);
                Console.WriteLine("19: " + swords[18].SwordName);

                string inputtt = Console.ReadLine();
                switch (inputtt)
                {
                    //variable.SwordName = swords[0].SwordName;
                    //variable.SwordDamage = swords[0].SwordDamage;
                    //Console.WriteLine("Du hast erhalten: " + variable.SwordName);x
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Anfängerschwert:");
                        Console.WriteLine("Ein bescheidenes Schwert für den aufstrebenden Krieger!");
                        Console.WriteLine("Dieses Anfängerschwert ist leicht und handlich, ideal für den Einsteiger.");
                        Console.WriteLine("Es verursacht einen Schaden von 1 Punkt, aber unterschätzt es nicht, denn auch die größten Abenteuer beginnen oft mit kleinen Schritten.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[0].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen = Console.ReadLine();
                        if (kaufen == "1" && variable.Gold >= swords[0].Preis)
                        {
                            variable.SwordName = swords[0].SwordName;
                            variable.SwordDamage = swords[0].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[0].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();

                        }
                        else
                        {
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Wolfslayer:");
                        Console.WriteLine("Das Wolfslayer-Schwert, ein Werk meisterlicher Handwerkskunst!");
                        Console.WriteLine("Dieses Schwert wurde speziell geschmiedet, um die wildesten Bestien zu besiegen.");
                        Console.WriteLine("Mit einem Schaden von 4 Punkten ist es ein zuverlässiger Begleiter für jede Jagd.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[1].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen1 = Console.ReadLine();
                        if (kaufen1 == "1" && variable.Gold >= swords[1].Preis)
                        {
                            variable.SwordName = swords[1].SwordName;
                            variable.SwordDamage = swords[1].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[1].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Ironsides:");
                        Console.WriteLine("Das Schwert der Unverwüstlichkeit!");
                        Console.WriteLine("Ironsides ist für seine Widerstandsfähigkeit und Stärke bekannt.");
                        Console.WriteLine("Es kann mit seinem Schaden von 7 Punkten sowohl Verteidigung als auch Angriff bewältigen und wird Euch in jeder Schlacht treu dienen.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[2].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen2 = Console.ReadLine();
                        if (kaufen2 == "1" && variable.Gold >= swords[2].Preis)
                        {
                            variable.SwordName = swords[2].SwordName;
                            variable.SwordDamage = swords[2].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[2].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Ravenshadow:");
                        Console.WriteLine("Ein Schwert, so dunkel wie die Nacht!");
                        Console.WriteLine("Das Ravenshadow-Schwert ist ein Meisterwerk der Finsternis und Verderbnis.");
                        Console.WriteLine("Mit einem mächtigen Schaden von 18 Punkten wird es die Schatten der Dunkelheit auf Eure Feinde werfen.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[3].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen3 = Console.ReadLine();
                        if (kaufen3 == "1" && variable.Gold >= swords[3].Preis)
                        {
                            variable.SwordName = swords[3].SwordName;
                            variable.SwordDamage = swords[3].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[3].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Templar's Oath:");
                        Console.WriteLine("Das Schwert des Templer-Eides!");
                        Console.WriteLine("Hinter diesem Schwert steht ein heiliger Schwur, und seine 23 Punkte Schaden sind ein Beweis für die Entschlossenheit und das Vertrauen des Templerordens.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[4].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen4 = Console.ReadLine();
                        if (kaufen4 == "1" && variable.Gold >= swords[4].Preis)
                        {
                            variable.SwordName = swords[4].SwordName;
                            variable.SwordDamage = swords[4].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[4].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Bloodletter:");
                        Console.WriteLine("Ein Schwert, das Durst nach Blut hat!");
                        Console.WriteLine("Das Bloodletter-Schwert ist berüchtigt für seine blutige Spur.");
                        Console.WriteLine("Mit einem tödlichen Schaden von 34 Punkten wird es Euch zu einem gefürchteten Krieger machen.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[5].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen5 = Console.ReadLine();
                        if (kaufen5 == "1" && variable.Gold >= swords[5].Preis)
                        {
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[5].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {
                            variable.SwordName = swords[5].SwordName;
                            variable.SwordDamage = swords[5].SwordDamage;
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Grimfang:");
                        Console.WriteLine("Das Schwert des Grimfangs, eine Legende unter den Waffen!");
                        Console.WriteLine("Mit einem erstaunlichen Schaden von 80 Punkten kann es sogar die härtesten Gegner in die Knie zwingen.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[6].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen6 = Console.ReadLine();
                        if (kaufen6 == "1" && variable.Gold >= swords[6].Preis)
                        {
                            variable.SwordName = swords[6].SwordName;
                            variable.SwordDamage = swords[6].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[6].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("Hawkstrike:");
                        Console.WriteLine("Das Schwert des Falkenangriffs!");
                        Console.WriteLine("Hawkstrike, benannt nach der Präzision eines Falken, wird mit seinen 119 Punkten Schaden Eure Feinde aus der Ferne treffen und besiegen.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[7].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen7 = Console.ReadLine();
                        if (kaufen7 == "1" && variable.Gold >= swords[7].Preis)
                        {
                            variable.SwordName = swords[7].SwordName;
                            variable.SwordDamage = swords[7].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[7].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {

                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "9":
                        Console.Clear();
                        Console.WriteLine("Kingslayer:");
                        Console.WriteLine("Ein Schwert, das Könige stürzen kann!");
                        Console.WriteLine("Kingslayer ist ein Symbol der Macht und des Aufruhrs.");
                        Console.WriteLine("Mit seinen beeindruckenden 239 Punkten Schaden kann es sogar Monarchen beeindrucken.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[8].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen8 = Console.ReadLine();
                        if (kaufen8 == "1" && variable.Gold >= swords[8].Preis)
                        {
                            variable.SwordName = swords[8].SwordName;
                            variable.SwordDamage = swords[8].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[8].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "10":
                        Console.Clear();
                        Console.WriteLine("Dragonsbane:");
                        Console.WriteLine("Das Schwert des Drachentöters!");
                        Console.WriteLine("Dieses beeindruckende Schwert mit 308 Punkten Schaden ist das ultimative Werkzeug gegen die mächtigsten Drachen und Ungeheuer.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[9].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen9 = Console.ReadLine();
                        if (kaufen9 == "1" && variable.Gold >= swords[9].Preis)
                        {
                            variable.SwordName = swords[9].SwordName;
                            variable.SwordDamage = swords[9].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[9].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "11":
                        Console.Clear();
                        Console.WriteLine("Thornblade:");
                        Console.WriteLine("Ein Schwert, das von den Dornen der Dunkelheit gewoben wurde!");
                        Console.WriteLine("Mit seinem beeindruckenden Schaden von 556 Punkten wird das Thornblade Eure Feinde in ein Meer aus Schmerz und Verzweiflung stürzen.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[10].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen10 = Console.ReadLine();
                        if (kaufen10 == "1" && variable.Gold >= swords[10].Preis)
                        {
                            variable.SwordName = swords[10].SwordName;
                            variable.SwordDamage = swords[10].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[10].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "12":
                        Console.Clear();
                        Console.WriteLine("Wyrmcleaver:");
                        Console.WriteLine("Das Schwert, das die Schuppen der Drachen spaltet!");
                        Console.WriteLine("Wyrmcleaver ist legendär für seine 912 Punkte Schaden und seine Fähigkeit, selbst die mächtigsten Drachen zur Strecke zu bringen.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[11].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen11 = Console.ReadLine();
                        if (kaufen11 == "1" && variable.Gold >= swords[11].Preis)
                        {
                            variable.SwordName = swords[11].SwordName;
                            variable.SwordDamage = swords[11].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[11].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "13":
                        Console.Clear();
                        Console.WriteLine("Valiant Edge:");
                        Console.WriteLine("Ein Schwert, das die Tapferkeit der Helden widerspiegelt!");
                        Console.WriteLine("Valiant Edge, mit seinen 1.625 Punkten Schaden, wird Euch zu einem unbesiegbaren Champion auf dem Schlachtfeld machen und Euch in die Geschichtsbücher eingravieren.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[12].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen12 = Console.ReadLine();
                        if (kaufen12 == "1" && variable.Gold >= swords[12].Preis)
                        {
                            variable.SwordName = swords[12].SwordName;
                            variable.SwordDamage = swords[12].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[12].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "14":
                        Console.Clear();
                        Console.WriteLine("Blackthorn:");
                        Console.WriteLine("Das finstere Schwert der Schatten!");
                        Console.WriteLine("Blackthorn ist berüchtigt für seine 2.250 Punkte Schaden und seine düstere Aura.");
                        Console.WriteLine("Es wird die Dunkelheit in den Herzen Eurer Feinde entfesseln und ihren Untergang besiegeln.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[13].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen13 = Console.ReadLine();
                        if (kaufen13 == "1" && variable.Gold >= swords[13].Preis)
                        {
                            variable.SwordName = swords[13].SwordName;
                            variable.SwordDamage = swords[13].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[13].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "15":
                        Console.Clear();
                        Console.WriteLine("Ironclad:");
                        Console.WriteLine("Das unbezwingbare Schwert der Legenden!");
                        Console.WriteLine("Mit einem unglaublichen Schaden von 3.500 Punkten ist Ironclad das Symbol der Unverwundbarkeit.");
                        Console.WriteLine("Es wird Euch in die Geschichtsbücher als unsterblicher Krieger eintragen.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[14].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen14 = Console.ReadLine();
                        if (kaufen14 == "1" && variable.Gold >= swords[14].Preis)
                        {
                            variable.SwordName = swords[14].SwordName;
                            variable.SwordDamage = swords[14].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[14].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "16":
                        Console.Clear();
                        Console.WriteLine("Stormbringer:");
                        Console.WriteLine("Das Schwert des Sturmbringers, ein Ruf, der die Welt erzittern lässt!");
                        Console.WriteLine("Dieses Schwert bietet einen verheerenden Schaden von 6.000 Punkten und wird die Himmel selbst zu Euren Verbündeten machen, wenn Ihr es schwingt.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[15].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen15 = Console.ReadLine();
                        if (kaufen15 == "1" && variable.Gold >= swords[15].Preis)
                        {
                            variable.SwordName = swords[15].SwordName;
                            variable.SwordDamage = swords[15].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[15].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "17":
                        Console.Clear();
                        Console.WriteLine("Silverthorn:");
                        Console.WriteLine("Ein Schwert aus reinem Silber, geschmiedet in den Sternen!");
                        Console.WriteLine("Mit einem atemberaubenden Schaden von 15.000 Punkten wird Silverthorn Euch zu einem wahren Helden der Sterne machen und die Dunkelheit vertreiben.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[16].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen16 = Console.ReadLine();
                        if (kaufen16 == "1" && variable.Gold >= swords[16].Preis)
                        {
                            variable.SwordName = swords[16].SwordName;
                            variable.SwordDamage = swords[16].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[16].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "18":
                        Console.Clear();
                        Console.WriteLine("Lionheart:");
                        Console.WriteLine("Das Schwert des Löwenherzens!");
                        Console.WriteLine("Mit einem eindrucksvollen Schaden von 25.000 Punkten spiegelt Lionheart die unerschütterliche Tapferkeit eines wahren Königs wider und wird Euch zu einem Anführer der Legenden machen.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[17].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen17 = Console.ReadLine();
                        if (kaufen17 == "1" && variable.Gold >= swords[17].Preis)
                        {
                            variable.SwordName = swords[17].SwordName;
                            variable.SwordDamage = swords[17].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[17].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                    case "19":
                        Console.Clear();
                        Console.WriteLine("Excalibur:");
                        Console.WriteLine("Das legendäre Schwert Excalibur!");
                        Console.WriteLine("Mit einem beispiellosen Schaden von 40.000 Punkten ist Excalibur ein Symbol für die Macht der Könige.");
                        Console.WriteLine("Es wird Euch zu einem Herrscher über Schlachten und Schicksal erheben.");
                        Console.WriteLine("Gewiss, um dieses glorreiche Schwert Euer Eigen zu nennen, sollt Ihr " + swords[18].Preis + " Goldmünzen entrichten. Ein wahrhaft edles Stück, das den Preis wert ist!");
                        Console.WriteLine("Die Wahl liegt bei Euch, tapferer Krieger. Möchtet Ihr es kaufen?");
                        Console.WriteLine("1: Ja");
                        Console.WriteLine("2: Nein");
                        string kaufen18 = Console.ReadLine();
                        if (kaufen18 == "1" && variable.Gold >= swords[18].Preis)
                        {
                            variable.SwordName = swords[18].SwordName;
                            variable.SwordDamage = swords[18].SwordDamage;
                            Console.WriteLine("Vielen Dank für Euren Kauf! Möge dieses Schwert Euch treu dienen.");
                            Console.WriteLine("Auf Wiedersehen und viel Erfolg auf Euren Reisen!");
                            Console.WriteLine("+1 " + variable.SwordName);
                            variable.Gold -= swords[18].Preis;
                            Console.WriteLine("Du hast " + variable.Gold + " Goldmünzen!");
                            Console.ReadKey();
                            Stadt();
                        }
                        else
                        {
                            Console.WriteLine("Verstehe, edler Gast. Falls sich Eure Meinung ändert, freue ich mich auf Euren Besuch.");
                            Console.WriteLine("Lebet wohl und viel Erfolg auf Euren Wegen!");
                            Thread.Sleep(1000);
                            Stadt();
                        }
                        break;
                }
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
