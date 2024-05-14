
using System.Collections.Generic;
using System;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Xml.Linq;
using Projekt_Gülistan_Sahin;

//Benutzer objekt
Mensch name = new Mensch();
name.NamensAbfrage();
Console.WriteLine("-.-.-.-.-.-.-.-.-.-");
Console.WriteLine(" Zum schluss wird täglich in unserem Heim ein Raum ausgesucht\n wo Sie sich aufhalten möchten.\n Bitte schreiben sie den Wunsch Raum auf ");
GottesHaus haus = new GottesHaus("Wir haben für alle Religionen einen Raum");//Gottes haus Objekt
haus.Raum();
Console.WriteLine("Schreibe bitte deinen Wunschaufenthaltsort auf: \n 1 Kirche\n 2 Mosche \n 3 Synagoge\n 4 Tempel\n 5 Terrasse");
haus.Eingabe1 = Console.ReadLine().ToLower();
switch (haus.Eingabe1)
{
    case "1":
        Console.WriteLine(" Du hast die Kirche gewählt. Hier kannst du beten und singen.\n Vater unser im Himmel,\n geheiligt werde dein Name.\n Dein Reich komme,\n dein Wille geschehe,\n wie im Himmel so auf Erden.\n Tägliches Brot gib uns heute und\n vergib uns unsere Schuld\n wie auch wir vergeben unseren Schuldigern.\n Und führe uns nicht in Versuchung,\n sondern erlöse uns von dem Bösen.\n Denn dein ist das Reich und Die Kraft und die Herrlichkeit,\n in Ewigkeit. Amen");
            Console.BackgroundColor = ConsoleColor.Red;
        break;
    case "2":
        Console.WriteLine("Du hast die Moschee gewählt. Hier kannst du beten und meditieren.\n Al-Hamdu li-illah");
        Console.BackgroundColor = ConsoleColor.Green;
        break;
    case "3":
        Console.WriteLine("Du hast die Synagoge gewählt. Hier kannst du beten und lernen.\n Segnet Gott, den gesegnet werdenden:\n Gesegnet sei Gott,\n der gesegnet werdende,\n in aller Ewigkeit. Gesegnet seist Du,\n Gott unser Gott, König der Welt,\n Bildner des Lichtes und Schöpfer der Finsternis,\n Der Frieden gestaltet und Schafft das All.");
        Console.BackgroundColor = ConsoleColor.Blue;
        break;
    case "4":
        Console.WriteLine("Du hast den Tempel gewählt. Hier kannst du beten und opfern. Mögen meine Lehrer gesund, glücklich und friedvoll sein.Mögen meine Eltern gesund, glücklich und friedvoll sein.Mögen meine Verwandten gesund, glücklich und friedvoll sein.Mögen meine Freunde gesund, glücklich und friedvoll sein.Mögen die gleichgültigen Menschen gesund, glücklich und friedvoll sein.Mögen die unfreundlichen Menschen gesund, glücklich und friedvoll sein.Mögen alle Meditierenden gesund, glücklich und friedvoll sein.Mögen alle Wesen gesund, glücklich und friedvoll sein.");
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        break;
    case "5":
        Console.WriteLine("Du hast die Terrasse gewählt, Heute Abend gibt es hier Ratespiel.");
        RatteSpiel();
        Console.BackgroundColor = ConsoleColor.Magenta;

        break;
    default:
        Console.WriteLine("Das ist keine gültige Eingabe. Bitte wähle eine Zahl zwischen 1 und 5.");
        break;

        void RatteSpiel()
        {
            Random random = new Random();
            int secretNumber = random
            .Next(1, 11);
            int userGuess = 0;
            do
            {
                Console.WriteLine(" Son nun Ratten sie eine Zahl zwischen 1 und 10 ");
                userGuess = int.Parse(Console.ReadLine());
            }
            while (userGuess != secretNumber);
            {
                Console.WriteLine("lolololo");
            }
            Console.WriteLine("das war richtig");
            Console.WriteLine("yoyoyo jetzt hast du Harribos gewonnen! ");
        }
}

Console.WriteLine(" So für Heute ist das alles gewesen bis morgen.");