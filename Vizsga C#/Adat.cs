using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizsga
{
    internal class Adat
    {
        //Itt annyi ilyet csinaljatok amennyi adat* van a main fájlban és nevezzétek el úgy ami logikus a fájl-ban lévő adatokhoz és olyan adattípust adjatok meg
        //pl.:  ID → ez egy szám szóval "int" lesz
        //      Név → ez egy karakterlánc (egy szó) szóval "string" lesz
        //Ha olyan szám van ami nem egész szám akkor "float"
        public int ID { get; set; }
        public string Mufaj { get; set; }
        public string Nev { get; set; }
        public int Ar { get; set; }
        public int Db { get; set; }

        //Ide annyi adatot írjatok amennyit a main fájl-ban át adtatok és a nevek kezdődjenek igy → '_Példa'
        public Adat(string _adat1, string _adat2, string _adat3, string _adat4, string _adat5) 
        {
            //Ha fent az elnevezett változóban nem string van mert éppen egy szám az akkor használhátok az int.Parse() -t vagy ha float akkor float.Parse() -t
            ID = int.Parse(_adat1);
            Mufaj = _adat2;
            Nev = _adat3;
            Ar = int.Parse(_adat4);
            Db = int.Parse(_adat5);
        }
    }
}
