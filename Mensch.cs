using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Gülistan_Sahin
{
    internal class Mensch
    {
        public string BenutzerName;
        public Mensch()
        {

        }
        public Mensch(string benutzername)
        {
            BenutzerName = benutzername;
        }
        public void NamensAbfrage()
        {
            Console.WriteLine("Guten Morgen Liebe Bewohner Des Heimes GottesHaus bitte Melde dich mit deinen Namen ein:");

            BenutzerName = Console.ReadLine().ToLower();
            Console.WriteLine($"Hallo lieber {BenutzerName} Heute dürfen Sie sich nach dem Frühstück einen Raum zum beschäftigen aussuchen");

        anfang:
            Console.WriteLine($"Hallo, wo befindest du dich? \n Schreibe bitte den Raum auf: \n Musik Raum \n Bastel Raum \n Bad \n Medizin Raum \n Ruhe Raum \n:");
            string eingabe = Console.ReadLine().ToLower();
            BenutzerName = eingabe;

            switch (eingabe)
            {
                case "musik raum":
                    Console.WriteLine("Hier darfst du Musik hören und spielen.");
                    // Wir rufen eine Methode auf, die dem Benutzer erlaubt, ein Musikinstrument auszuwählen und zu spielen
                    MusikRaum();
                    break;
                case "bastel raum":
                    Console.WriteLine("Hallo hallo heute gibt es einiges zu puzzeln.");
                    // Wir rufen eine Methode auf, die dem Benutzer erlaubt, eine Laterne zu basteln und zu dekorieren
                    BastelRaum();
                    break;
                case "bad":
                    Console.WriteLine("Es wird gebadet.");
                    // Wir rufen eine Methode auf, die dem Benutzer erlaubt, ein Bad zu nehmen und sich zu pflegen
                    BadRaum();
                    break;
                case "medizin raum":
                    Console.WriteLine("Tabletten nicht vergessen.");
                    // Wir rufen eine Methode auf, die dem Benutzer erlaubt, seine Medikamente zu nehmen und seinen Gesundheitszustand zu überprüfen
                    MedizinRaum();
                    break;
                case "ruhe raum":
                    Console.WriteLine("Du bist im Ruhe Raum.");
                    // Wir rufen eine Methode auf, die dem Benutzer erlaubt, sich auszuruhen und zu schlafen. Hier sollte ruhige und entspannte Musik sein. 
                    RuheRaum();
                    break;
                default:
                    Console.WriteLine("Das ist kein gültiger Raum. Bitte wähle einen Raum aus der Liste aus.");
                    goto anfang;

            }
        }
        void MusikRaum()
        {
            string[] instrumente = new string[] { $"1 = Klavier", "2=Gitarre", "3=Trommel", "4=Radio " };
            Console.WriteLine("Such dir ein Instrument aus oder schalte den Radio an");

            for (int i = 0; i < instrumente.Length; i++)
            {
                Console.WriteLine($"{i + 1}={instrumente[i]}");
            }
            string eingabe = Console.ReadLine();
            {
                switch (eingabe)
                {
                    case "1":
                        Console.WriteLine("Du hast das Klavier gewählt. Viel Spaß beim Spielen!");
                        break;
                    case "2":
                        Console.WriteLine("Du hast die Gitarre gewählt. Viel Spaß beim Spielen!");
                        break;
                    case "3":
                        Console.WriteLine("Du hast die Trommel gewählt. \nDu kannst in das Isolierte Zimmer rein und so viel Krach machen wie du willst!");
                        break;
                    case "4":
                        Console.WriteLine("Du hast das Radio ausgesucht!");
                        break;
                    default:
                        Console.WriteLine("Das ist keine gültige Zahl. Bitte wähle eine Zahl zwischen 1 und 5.");

                        break;
                }

            }

        }
        void BastelRaum()
        {
            string[] Schnickschnack = new string[] { " 1 = stricken ", " 2 = malen ", " 3 = Puzzeln ", " 4 = karten spielen " };
            Console.WriteLine("Am besten suchst du dir ein Platz aus, da wo nicht so viele sitzen!");

            for (int i = 0; i < Schnickschnack.Length; i++)
            {
                Console.WriteLine($"{i + 1}={Schnickschnack[i]}");
            }
            string eingabe1 = Console.ReadLine();
            switch (eingabe1)
            {
                case "1":
                    Console.WriteLine("Du hast das Stricken gewählt. Viel Spaß beim Socken stricken!");
                    break;
                case "2":
                    Console.WriteLine("Du hast die malen gewählt. Viel Spaß beim Bilder malen!");

                    break;
                case "3":
                    Console.WriteLine("Du hast das Puzzeln gewählt. Viel Spaß beim Puzzeln Spielen!");
                    break;
                case "4":
                    Console.WriteLine("Du hast das Karten spiel ausgesucht!");
                    break;
                default:
                    Console.WriteLine("Das ist keine gültige Zahl. Bitte wähle eine Zahl zwischen 1 und 5.");
                    break;
            }

        }
        void BadRaum()//hinter Methoden kommen kein Semikolon;
        {
            string[] Lavendelseife = new string[] { " 1 = Harre waschen", " 2 = Nägel lackieren", " 3 = Duschen ", " 4 = Kräuterbad " };
            Console.WriteLine("Heute ist sehr viel los im Bad!");

            for (int i = 0; i < Lavendelseife.Length; i++)
            {
                Console.WriteLine($"{i + 1}={Lavendelseife[i]}");
            }
            string eingabe2 = Console.ReadLine();
            switch (eingabe2)
            {
                case "1":
                    Console.WriteLine("Deine Harre werden gewaschen und geföhnt und du bekommst noch lavendel Öl dazu!");
                    break;
                case "2":
                    Console.WriteLine("Deine Nägel werden Rosa lackiert !");
                    break;
                case "3":
                    Console.WriteLine("Heute ist leider die Dusche Voll du kannst die Badewanne nehmen, wenn du willst!");
                    break;
                case "4":
                    Console.WriteLine("Du hast das Kräuterbad ausgesucht jetzt werden wir alle nach Minze riechen hahahahah!");
                    break;
                default:
                    Console.WriteLine("Das ist keine gültige Zahl. Bitte wähle eine Zahl zwischen 1 und 5.");
                    break;
            }

        }
        void MedizinRaum()
        {
            string[] ErsteHilfe = new string[] { " 1 = Medikamente", " 2 = Pfleger ", " 3 = Arzt", " 4 = Seelsorger+" };
            Console.WriteLine("Der Arzt hat heute viel zu tun!");

            for (int i = 0; i < ErsteHilfe.Length; i++)
            {
                Console.WriteLine($"{i + 1}={ErsteHilfe[i]}");
            }
            string eingabe3 = Console.ReadLine();
            switch (eingabe3)
            {
                case "1":
                    Console.WriteLine("Deine Medikamente werden jetzt bestellt natürlich!");
                    break;
                case "2":
                    Console.WriteLine("Du wirst herzlich von einem Pfleger versorgt!");
                    break;
                case "3":
                    Console.WriteLine("Heute hast du gluck der Arzt hat gute Laune dabei und grüne rote Tabletten !");
                    break;
                case "4":
                    Console.WriteLine("Der Seelsorger kommt heute zu dir in dein Zimmer !");
                    break;
                default:
                    Console.WriteLine("Das ist keine gültige Zahl. Bitte wähle eine Zahl zwischen 1 und 5.");
                    break;
            }
        }
        void RuheRaum()
        {
            string[] zeitnehmen = new string[] { " 1 = lesen", " 2 = Aus dem Fenster schauen", " 3 = ein Brief schreiben", " 4 = Hunde streicheln" };
            Console.WriteLine("Wilkommen im Raum der Ruhe!");

            for (int i = 0; i < zeitnehmen.Length; i++)
            {
                Console.WriteLine($"{i + 1}={zeitnehmen[i]}");
            }
            string eingabe4 = Console.ReadLine();

            switch (eingabe4)
            {
                case "1":
                    Console.WriteLine("es ist ein Sonniger kalter Wintertag und du darfst\n mit einer Kuschel decke im Liegestuhl aus dem Fensterschauen!");
                    break;
                case "2":
                    Console.WriteLine("in der Blumen und Pflanzen Ecke hast du ein Plätzchen\n um deiner besten Freundin ein Brief zu schreiben !");
                    break;
                case "3":
                    Console.WriteLine("Der Seelsorger kommt heute zu dir in dein Zimmer \n er wird dir auch helfen ein Brief zu schreiben!");
                    break;
                case "4":
                    Console.WriteLine("Heute sind die Hunde Joshi und Matilhlda\n da du kannst sie Streicheln so lange du willst, Außerdem bekommst du noch ein paar Leckerli für die Hunde \n und für dich kannst du eine Sorte von den\n Kuchen aussuchen: 1=Käsekuchen oder 2= Brownie?!:"); Kuchen();
                    break;

                default:
                    Console.WriteLine("Das ist keine gültige Zahl. Bitte wähle eine Zahl zwischen 1 und 5.");
                    break;

            }

        }

        void Kuchen()
        {
            string[] Leckerbissen = new string[] { "1 = Käsekuchen, 2 = Brownie " };
            Console.WriteLine("Der Seelsorger ist heute da, seine Frau Die nette Lore\n hat 2 Sorten kuchen gemacht\n du kannst dir ein stück aussuchen. 1 Käsekuchen oder 2 Brownie");

            int sorte;
            sorte = Convert.ToInt32(Console.ReadLine());
            bool keins;

            if (sorte == 1)
            {
                Console.WriteLine("Der Käse Kuchen schmeckt so lecker.\n Dazu gibt es noch frische Kaffe.\n Der pflege bringt gleich den Kuchen und den Kaffee zu ihnen zum Zimmer rauf.");
                keins = true;
            }
            if (sorte == 2)
            {
                Console.WriteLine("Die Brownies sind schokoladig und weich\n und es gibt noch Frische Milsch dazu,\n der Pfleger bringt ihnen alles hoch zum Zimmer");
                keins = true;
            }
            else keins = false;
            Console.WriteLine("schade das sie kein Kuchen nehmen´!");
        }
    }
}
