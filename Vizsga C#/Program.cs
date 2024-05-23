namespace Vizsga
{
    internal class Program
    {
        //a List<*>-nál a * az a class neve legyen amit létrehoztál
        public static List<Adat> adatok = new List<Adat>();
        static void Main(string[] args)
        {
            //Csinalj egy új class-t jobb oldalt jobb klikk a project névre → add → alul class → adj neki egy nevet és hozd létre
            //adat.txt legyen átírva arra a fájl névre amit letöltöttetek. ↓
            using (StreamReader sr = new StreamReader("adat.txt", true))
            {
                while (!sr.EndOfStream) 
                {
                    /*
                        példa:

                            1,mufaj,név,24000,15

                        ↓ itt lent annyi string adat*; legyen amennyire fel tudod bontani a txt-ben lévő adatokat. általában felbontás vagy , vagy ; vel szokott lenni
                     */
                    string adat1;
                    string adat2;
                    string adat3;
                    string adat4;
                    string adat5;

                    //A Split("*") -ba a * hellyére azt a karaktert írd amivel el vannak választva az adatok a txt-fileban
                    string[] line = sr.ReadLine().Trim().Split(",");

                    adat1 = line[0];
                    adat2 = line[1];
                    adat3 = line[2];
                    adat4 = line[3];
                    adat5 = line[4];

                    //itt is az Adat legyen az a név ami a class neve és írátok be ide a () az összes adatot amit fent csináltatok
                    Adat adat = new Adat(adat1, adat2, adat3, adat4, adat5);

                    adatok.Add(adat);
                }
            }

            //itt a Console.WriteLine(); -ba mindig beleyrjátok a feladat számot mint a páldában is ahogy van
            #region FELADATOK

            Console.WriteLine("3.Feladat");
            FajlKiir();

            Console.WriteLine("4. Feladat");
            Szamol();

            Console.WriteLine("5. Feladat");
            KategoriaKeres("Akció");

            Console.WriteLine("6. Feladat");
            KategoriaSzamolas();

            Console.WriteLine("7. Feladat");
            Legolcsobb();
            #endregion
        }

        static void FajlKiir() 
        {
            foreach (Adat item in adatok)
            {
                //Itt végigmentek az item.* -on és a csillag mindig az amit a másik class ben elneveztétek a fájl tetején 
                Console.WriteLine($"{item.ID} {item.Mufaj} {item.Nev} {item.Ar} {item.Db}");
            }
        }

        static void Szamol() 
        {
            int sum = 0;

            foreach (Adat item in adatok)
            {
                sum += item.Db;
            }

            Console.WriteLine("Az össz darabszám: " + sum + " db");
        }

        static void KategoriaKeres(string kategoria)
        {
            foreach (Adat item in adatok)
            {
                if (item.Mufaj.ToLower() == kategoria.ToLower())
                { 
                    Console.WriteLine($"A(z) {kategoria} kategóriában lévő játékok címe és ára: {item.Nev}, {item.Ar}");
                }
            }
        }

        static void KategoriaSzamolas()
        { 
            Dictionary<string, int> kategoriak = new Dictionary<string, int>();

            foreach (Adat item in adatok)
            {
                if (kategoriak.ContainsKey(item.Mufaj))
                {
                    kategoriak[item.Mufaj]++;
                }
                else
                { 
                    kategoriak.Add(item.Mufaj, 1);
                }
            }

            foreach (KeyValuePair<string, int> kvp in kategoriak)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value} termék");
            }
        }

        static void Legolcsobb()
        {
            List<Adat> olcsoAdat = new List<Adat>();
            int min = adatok.Min(Item => Item.Ar);

            foreach (Adat item in adatok)
            {
                if (item.Ar == min)
                {
                    olcsoAdat.Add(item);
                }
            }

            Console.WriteLine("Legolcsobb termék(ek) adatai:");
            foreach (Adat item in olcsoAdat)
            {
                Console.WriteLine($"{item.Mufaj}, {item.Nev}, {item.Ar}");
            }
        }
    }
}
