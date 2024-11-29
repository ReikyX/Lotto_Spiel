namespace _08Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Theorie();
            //Aufgabe1();
            //Aufgabe2_Lotto();
            Korrektur_Lotto();
        }


        static void Theorie()
        {
            //Arrays speichern mehrere Werte in einer einzelnen Variable. Wir können also einen einzigen Bezeichner nutzen um auf mehrere Werte zugreifen zu können. 
            //Die einzelnen Einträge nennt man auch Felder bzw. Wertfelder.

            //Die Syntax eines Arrays sieht folgendermaßen aus:

            //<datentyp[]> <bezeichner> = [<wert1> , <wert2> , <wert3> usw...]

            //Deklaration eines String-Arrays:

            string[] autos = ["BMW", "Audi", "Opel", "Skoda"];

            //Deklaration eines Integers:

            int[] zahlen = { 1, 2, 3, 4, 5, -1, -2 };

            //Wie schon bei einem String, können wir über den Index Operator gezielt bestimmte Felder ansprechen.
            Console.WriteLine($"Erstes Feld: \t{autos[0]}");
            Console.WriteLine($"Zweites Feld: \t{autos[1]}");

            //Länge eines Arrays kann man mit Lenght ausgeben lassen.

            Console.WriteLine($"In unserer Liste haben wir : {autos.Length} Autos");

            //Bestimmung des letzten Elements

            Console.WriteLine($"Das letzte Auto in der Liste ist der {autos[autos.Length - 1]}");

            //Ausgabe aller Elemente des Arrays

            for (int i = 0; i < autos.Length; i++)
            {
                Console.WriteLine(autos[i]);
            }

            //Ausgabe aller Elemente des Arrays mit der foreach-Schleife

            foreach (string auto in autos)
            {
                Console.WriteLine(auto);
            }

            Console.Clear();

            Console.WriteLine($"Alter Wert des ersten Feldes {autos[0]}");
            //Wertzuweisung
            autos[0] = "Mercedes";
            Console.WriteLine($"Neuer Wert des ersten Feldes {autos[0]}");

            //Suchen nach einem bestimmten Wert, der dann ersetzt werden soll.
            //Wir suchen nach dem Open und dann ersetzten wir ihn durch den Toyota

            for (int i = 0; i < autos.Length; i++)
            {
                if (autos[i] == "Opel")
                {
                    Console.WriteLine($"Ich haben den {autos[i]} gefunden");
                    autos[i] = "Toyota";
                    Console.WriteLine($"Ich habe an Index {i}, also dem {i + 1}ten Feld, den Opel mit einem {autos[i]} ersetzt!");
                }
            }

            //Erstellen eines Arrays ohne direkte Wertzuweisung
            int[] zahlen2 = new int[5]; //int-Array der Länge 5 ohne Werte
            //Initialisierung des ersten Feldes

            zahlen2[0] = 1;

            string[] name = new string[5];
        }
        static void Aufgabe1()
        {
            //Aufgabe:
            //Erstellen Sie ein int[]-Array der Größe 7 und initialisieren Sie die Felder mit beliebigen von Ihnen ausgesuchten Werten.
            //Die Werte müssen nicht zufällig bestimmt werden.  
            //Lassen Sie dann zählen wie oft die Zahl 1 vorkommt. Geben Sie die Anzahl in der Konsole aus.

            Console.ForegroundColor = ConsoleColor.Blue;

            int[] wert = new int[7];
            int anzahlEinsen = 0;

            for (int i = 0; i < wert.Length; i++)
            {
                wert[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < wert.Length; i++)
            {
                if (wert[i] == 1) anzahlEinsen++;

            }
            Console.WriteLine($"Die Zahl 1 kommt {anzahlEinsen} mal vor.");
        }
        static void Aufgabe2_Lotto()
        {


            // Teil1

            //Lottozahlen
            //Erstellen Sie ein int[] lottozahlen mit der Länge 49.
            //Schreiben Sie dann einen Code der dieses Array automatisch mit den Zahlen 1 - 49 befüllt.

            //Teil2

            //Ziehung der Lottozahlen
            //Aus dem Array unserer Lottozahlen sollen nun sechs Zahlen zufällig gezogen werden.
            //Diese sechs Zahlen müssen in einem neuen Array abgelegt werden. 
            //Verwenden Sie auch wieder Random für die Zufällige Ziehung.
            //Bei den gezogenen Zahlen darf es zu keiner Dopplung kommen.

            //Teil3

            //User-Eingabe und Gewinnausgabe
            //Der User soll in der Lage sein, sechs Zahlen einzugeben.
            //Diese werden in einem Array abgelegt.
            //Danach soll überprüft werden, wieviele Zahlen der User im Vergleich zu den gezogenen Lottozahlen richtig getippt hat.
            //Geben Sie in der Konsole aus, wieviele Richtige getippt wurden.

            //Sollten Sie in der vorherigen Aufgabe zu keiner Lösung gekommen sein, schreiben Sie von Hand ein Array mit gezogenen Zahlen.


            //Variablen
            int[] lottozahlen = new int[50];
            int[] gezogeneZahlen = new int[6];
            int[] ausgewaehlteZahl = new int[6];


            Random zahl = new Random();

            int superZahl = zahl.Next(1, 10);
            int richtige = 0;
            bool pruefe = true;

            //Ausgabe
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("- - - - - - - - - - - - - - - - -  LOTTO-JACKPOT  - - - - - - - - - - - - - - - - -");
            Console.WriteLine("- - - - - - - - - - - - - - - - -  20  Millionen  - - - - - - - - - - - - - - - - -");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.ForegroundColor = ConsoleColor.Blue;

            //Lottozahlen werden gezogen
            for (int i = 0; i < gezogeneZahlen.Length; i++)
            {
                gezogeneZahlen[i] = zahl.Next(1, 50);
                for (int x = 0; x < i; x++)
                {
                    if (gezogeneZahlen[i] == gezogeneZahlen[x])
                    {
                        i--;
                    }
                }
            }

            //Lottozahlen Benutzerauswahl
            for (int i = 0; i < ausgewaehlteZahl.Length; i++)
            {
                Console.Write($"\nBitte gebe deine {i + 1}te Zahl ein: ");
                pruefe = int.TryParse(Console.ReadLine(), out ausgewaehlteZahl[i]);
                if (!pruefe || ausgewaehlteZahl[i] < 1 || ausgewaehlteZahl[i] > 49)
                {
                    Console.WriteLine("Ungültige eingabe. Bitte gebe nur Zahlen zwischen 1 und 49 ein!");
                    i--;
                }
                else
                {
                    for (int x = 0; x < i; x++)
                    {
                        if (ausgewaehlteZahl[i] == ausgewaehlteZahl[x])
                        {
                            Console.WriteLine("Ungültig! Zahlen dürfen nicht doppelt eingegeben werden.");
                            i--;
                        }
                    }
                }
            }

            //Superzahl wird eingeben vom Benutzer
            int superTipp = 0;
            bool superOk = true;
            Console.Write("\nBitte geben Sie ihre Superzahl (1 bis 9) ein: ");
            do
            {
                superTipp = Convert.ToInt32(Console.ReadLine());
                if (superTipp < 1 || superTipp > 9)
                {
                    Console.Write("\nUngültige eingabe. Bitte gébe eine Zahl zwischen 1 und 9 ein: ");
                }
                else
                {
                    superOk = false;
                }
            }
            while (superOk);


            //Zahlen werden verglichen
            for (int i = 0; i < 6; i++)
            {
                if (gezogeneZahlen.Contains(ausgewaehlteZahl[i]) == true)
                {
                    richtige++;
                }
            }

            //Zahlen werden nach größe Sortiert
            Array.Sort(gezogeneZahlen);
            Array.Sort(ausgewaehlteZahl);

            //Ausgabe der ausgewählten Zahlen
            Console.Write("\nIhre Lottozahlen:\t");
            foreach (int zahlen in ausgewaehlteZahl)
            {
                Console.Write(zahlen + "  ");
            }

            //Ausgabe der gezogenen Lottozahlen
            Console.Write("\nGezogene Lottozahlen:\t");
            foreach (int zahlen in gezogeneZahlen)
            {
                Console.Write(zahlen + "  ");
            }

            Thread.Sleep(2000);

            //Ausgabe anzahl der richtig getippten Zahlen
            Console.WriteLine($"\n\nRichtige:\t\t{richtige}");

            if (superZahl == superTipp)
            {
                Console.WriteLine($"\nDie Superzahl:\t\t{superZahl}");
                Console.WriteLine("\nZusätzlich ist Ihre Superzahl richtig!");
            }
            else
            {
                Console.WriteLine($"\nDie Superzahl:\t\t{superZahl}");
                Console.WriteLine("\nIhre Superzahl stimmt nicht überein.");
            }

            if (richtige == 6 && superTipp == superZahl)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("**************************************************************************************************");
                Console.WriteLine("************************   JACKPOT - Herzlichen Glückwunsch   ************************************");
                Console.WriteLine("**************************************************************************************************");
            }
            else if (richtige == 6)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("**************************************************************************************************");
                Console.WriteLine("*************************    Herzlichen Glückwunsch - 6 Richtige  ********************************");
                Console.WriteLine("**************************************************************************************************");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadKey();
            Console.WriteLine("\nAnonyme Hotlines wie die der BZgA (Bundeszentrale für gesundheitliche Aufklärung) stehen rund um die Uhr zur Verfügung. Hier können Betroffene und Angehörige Hilfe und Informationen erhalten: Telefonnummer: 0800 1 37 27 00");
            Console.ReadKey();

        }
        static void Korrektur_Lotto()
        {
            //Aufgab1 

            int[] lottozahlen = new int[49];
            for (int i = 0; i < lottozahlen.Length; i++)
            {
                lottozahlen[i] = i + 1;
            }

            //Aufgabe2

            Random zufall = new Random();
            int[] gezogeneZahlen = new int[6];

            for (int i = 0; i < 6; i++)
            {
                int zufallsIndex;
                int gezogeneZahl;
                int bereitsGezogen = -1;

                do
                {
                    zufallsIndex = zufall.Next(0, 49);
                    gezogeneZahl = lottozahlen[zufallsIndex];
                }
                while (gezogeneZahl == bereitsGezogen);

                lottozahlen[zufallsIndex] = bereitsGezogen;
                gezogeneZahlen[i] = gezogeneZahl;


            }

            //Aufgabe3

            int[] tippZahlen = new int[6];

            Console.WriteLine("Hallo User! Bitte gibt nacheinander sechs Zahlen zwischen 1 und 49 ein.\nBitte bestätige jede Eingabe mit Enter.");

            for (int i = 0; i < tippZahlen.Length; i++)
            {
                bool doppelt;
                do
                {
                    doppelt = false;
                    tippZahlen[i] = Convert.ToInt32(Console.ReadLine());

                    for (int j = 0; j < i; j++)
                    {
                        if (tippZahlen[i] == tippZahlen[j])
                        {
                            doppelt = true;
                            Console.WriteLine("Du hast diese Zahl bereits eingegeben!");
                        }
                    }
                }
                while (tippZahlen[i] <= 0 || tippZahlen[i] > 49 || doppelt);
            }

            int anzahlRichtige = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (gezogeneZahlen[i] == tippZahlen[j])
                    {
                        anzahlRichtige++;
                    }
                }
            }
            Console.Clear();

            Console.WriteLine($"Du hast {anzahlRichtige} Richtige!\n Deine angegebenen Zahlen sind: {string.Join(" - ", tippZahlen)}\nDie Lottozahlen von heute sind: {string.Join(" - ", gezogeneZahlen)}");

        }
    }
}
