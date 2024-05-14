 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_Gülistan_Sahin;
namespace Projekt_Gülistan_Sahin
{
    class GottesHaus
    {
        //eine Klase Gotteshaus
        public string Eingabe1 { get; set; }//mit Eigenschaften
        public string BewohnerName { get; set; }
        public GottesHaus(string name)
        {
            BewohnerName = name;
        }

        public void Raum()//und eine Methote 
        {
            Console.WriteLine($" Willkommen im {BewohnerName}!");
        }
     
        
    }
}
