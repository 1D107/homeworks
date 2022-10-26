using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kliknij odpowiedni przycisk aby obliczyć co chcesz");
            Console.WriteLine("Matematyka:");
            Console.WriteLine("----------------------------");
            Console.WriteLine("a - Pole Kwadratu");
            Console.WriteLine("b - Pole Prostokąta");
            Console.WriteLine("c - Przekątna kwadratu");
            Console.WriteLine("d - Obwód protokąta");
            Console.WriteLine("e - Pole trójkąta");
            Console.WriteLine("f - Obwód trójkąta");
            Console.WriteLine("g - Wysokość trójkąta równoramiennego");
            Console.WriteLine("h - Pitagoras");
            Console.WriteLine("i - Pole Koła");
            Console.WriteLine("j - Obwód Koła");
            Console.WriteLine("k - Sinus");
            Console.WriteLine("l - Cosinus");
            Console.WriteLine("m - Tangens");
            Console.WriteLine("n - Cotangens");
            Console.WriteLine("o - Pole Równoległoboka");
            Console.WriteLine("p - Objętość Sześcianu");
            Console.WriteLine("q - Objętość Ostrosłupa");
            Console.WriteLine("r - Objętość Prostopadłościanu");
            Console.WriteLine("s - Objętość Walca");
            Console.WriteLine("t - Objętość Stożka");
            Console.WriteLine("u - Przykładowa Objętość Kuli");
            Console.WriteLine("v - Przykładowe Pole Kuli");
            Console.WriteLine("w - Przykładowa Wartość Bezwzględna");
            Console.WriteLine("x - Przykładowa Średnia Arytmetyczna");
            Console.WriteLine("y - Przykładowa Średnia Harmoniczna");
            Console.WriteLine("z - Przykładowa Średnia Geometryczna");
            Console.WriteLine("a1 - Przykładowa Silnia");
            Console.WriteLine("b1 - Przykładowa Delta");
            Console.WriteLine("Fizyka:");
            Console.WriteLine("----------------------------");
            Console.WriteLine("c1 - Przykładowa prędkość");
            Console.WriteLine("d1 - Przykładowe przyspieszenie");
            Console.WriteLine("e1 - Przykładowa prędkość kątowa");
            Console.WriteLine("f1 - Przykładowe ciśnienie");
            Console.WriteLine("g1 - Przykładowa kinetyczna energia całkowita bryły sztywnej");
            Console.WriteLine("h1 - Przykładowe przyspieszenie kątowe");
            Console.WriteLine("i1 - Przykładowa potencjalna energia obiektu");
            Console.WriteLine("j1 - Przykładowa siła odśrodkowa");
            Console.WriteLine("k1 - Przykładowa siła wyporu");
            Console.WriteLine("l1 - Przykładowy pęd fotonu");
            Console.WriteLine("m1 - Przykładowe obliczenie prawa Ohma");
            Console.WriteLine("n1 - Przykładowa moc");
            Console.WriteLine("o1 - Przykładowa praca");
            string inp = Console.ReadLine();
            if (inp == "a")
            {
                
                Console.WriteLine("Wpisz rozmiar boku");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Twoje pole to:");
                Polekwadratu.Pkwadrat(b);
                Console.ReadKey();
            }
            else if (inp == "b")
            {
                Console.WriteLine("Wpisz oba boki");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Twoje pole to:");
                Poleprostokatu.Pprostokat(a, b);
                Console.ReadKey();
            }
            else if (inp == "c")
            {
                Console.WriteLine("Wpisz bok");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Twoja przekątna to:");
                PrzekatnaKwadratu.PrzKwad(a);
                Console.ReadKey();
            }
            else if (inp == "d")
            {
                Console.WriteLine("Wpisz bok");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Twój obwód to:");
                ObwodProstokata.ObwProst(a);
                Console.ReadKey();
            }
            else if (inp == "e")
            {
                Console.WriteLine("Wpisz podstawe i wysokość");
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine("Twoje pole to:");
                PoleTrojkata.PTroj(a,h);
                Console.ReadKey();
            }
            else if (inp == "f")
            {
                Console.WriteLine("Wpisz boki");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine("Twój obwód to:");
                ObwodTrojkata.ObwTroj(a, b, c);
                Console.ReadKey();
            }
            else if (inp == "g")
            {
                Console.WriteLine("Wpisz podstawe");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Twoja wysokość to:");
                WysokoscTrojkata.WysTroj(a);
                Console.ReadKey();
            }
            else if (inp == "h")
            {
                Console.WriteLine("Wpisz dwie przyprostokątne");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Twoja przeciwprostokątna to:");
                Pitagoras.Pit(a, b);
                Console.ReadKey();
            }
            else if (inp == "i")
            {
                Console.WriteLine("Wpisz promień");
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine("Twoje pole to:");
                PoleKola.PKol(r);
                Console.ReadKey();
            }
            else if (inp == "j")
            {
                Console.WriteLine("Wpisz promień");
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine("Twój obwód to:");
                ObwodKola.ObwKol(r);
                Console.ReadKey();
            }
            else if (inp == "k")
            {
                Console.WriteLine(Sinus.Sin());
                Console.ReadKey();
            }
            else if (inp == "l")
            {
                Console.WriteLine(Cosinus.Cos());
                Console.ReadKey();
            }
            else if (inp == "m")
            {
                Console.WriteLine(Tangens.Tg());
                Console.ReadKey();
            }
            else if (inp == "n")
            {
                Console.WriteLine(Cotangens.Ctg());
                Console.ReadKey();
            }
            else if (inp == "o")
            {
                Console.WriteLine(PoleRownolegloboku.PRown());
                Console.ReadKey();
            }
            else if (inp == "p")
            {
                Console.WriteLine(ObjetoscSzescianu.ObjSze());
                Console.ReadKey();
            }
            else if (inp == "q")
            {
                Console.WriteLine(ObjetoscOstroslupa.ObjOstr());
                Console.ReadKey();
            }
            else if (inp == "r")
            {
                Console.WriteLine(ObjetoscProstopadloscianu.ObjProst());
                Console.ReadKey();
            }
            else if (inp == "s")
            {
                Console.WriteLine(ObjetoscWalca.ObjWal());
                Console.ReadKey();
            }
            else if (inp == "t")
            {
                Console.WriteLine(ObjetoscStozka.ObjStoz());
                Console.ReadKey();
            }
            else if (inp == "u")
            {
                ObjetoscKuli.ObjKul();
                Console.ReadKey();
            }
            else if (inp == "v")
            {
                PoleKuli.PKul();
                Console.ReadKey();
            }
            else if (inp == "w")
            {
                Bezwzgledna.Bezw();
                Console.ReadKey();
            }
            else if (inp == "x")
            {
                SredniaArytmetyczna.Sar();
                Console.ReadKey();
            }
            else if (inp == "y")
            {
                SredniaHarmoniczna.Shar();
                Console.ReadKey();
            }
            else if (inp == "z")
            {
                SredniaGeometryczna.Sgeo();
                Console.ReadKey();
            }
            else if (inp == "a1")
            {
                Silnia.Sil();
                Console.ReadKey();
            }
            else if (inp == "b1")
            {
                Delta.Del();
                Console.ReadKey();
            }
            else if (inp == "c1")
            {
                Predkosc.Pred();
                Console.ReadKey();
            }
            else if (inp == "d1")
            {
                Przyspieszenie.Przys();
                Console.ReadKey();
            }
            else if (inp == "e1")
            {
                PredkoscKatowa.PredKat();
                Console.ReadKey();
            }
            else if (inp == "f1")
            {
                Console.WriteLine(Cisnienie.Cis());
                Console.ReadKey();
            }
            else if (inp == "g1")
            {
                Console.WriteLine(Energia.Ene());
                Console.ReadKey();
            }
            else if (inp == "h1")
            {
                Console.WriteLine(PrzyspieszenieKatowe.PrzysKat());
                Console.ReadKey();
            }
            else if (inp == "i1")
            {
                Console.WriteLine(EnergiaPotencjalna.Enep());
                Console.ReadKey();
            }
            else if (inp == "j1")
            {
                Console.WriteLine(SilaOdsrodkowa.SilaOd());
                Console.ReadKey();
            }
            else if (inp == "k1")
            {
                Console.WriteLine(SilaWyporu.SilaWyp());
                Console.ReadKey();
            }
            else if (inp == "l1")
            {
                Console.WriteLine(PedFotonu.PedFot());
                Console.ReadKey();
            }
            else if (inp == "m1")
            {
                Console.WriteLine(Ohma.Oh());
                Console.ReadKey();
            }
            else if (inp == "n1")
            {
                Console.WriteLine(Moc.moc());
                Console.ReadKey();
            }
            else if (inp == "o1")
            {
                Console.WriteLine(Praca.praca());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nie ma takiej opcji");
                Console.ReadKey();
            }

        }
    }
}
