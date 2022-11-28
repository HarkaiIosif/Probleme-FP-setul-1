using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Probleme_FP_setul_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool daca = true;
            while (daca)
            {
                Console.WriteLine("Introduceti problema pe care doriti sa o rezolvati");
                int s = int.Parse(Console.ReadLine());
                if (s == 1)
                {
                    S1();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 2)
                {
                    S2();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 3)
                {
                    S3();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 4)
                {
                    S4();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 5)
                {
                    S5();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 6)
                {
                    S6();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 7)
                {
                    S7();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 8)
                {
                    S8();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 9)
                {
                    S9();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 10)
                {
                    S10();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 11)
                {
                    S11();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 12)
                {
                    S12();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 13)
                {
                    S13();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 14)
                {
                    S14();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 15)
                {
                    S15();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 16)
                {
                    S16();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 17)
                {
                    S17();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 18)
                {
                    S18();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 19)
                {
                    S19();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 20)
                {
                    S20();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 21)
                {
                    S21();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }

            }

        }
        /// <summary>
        /// Stabilirea rădăcinii ecuației de grad 1 cu o necunoscută 
        /// </summary>
        private static void S1()
        {
            Console.WriteLine("Introduceti valorile a si b");
            int  b;
            double a;
            string line = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] t = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            a = double.Parse(t[0]);
            b = int.Parse(t[1]);
            double d=-b/a;

            Console.WriteLine($"Radacina este {d}");
            Console.ReadKey();
        }
        /// <summary>
        /// Stabilirea  rădăcinilor ecuației de gradul 2 cu o necunoscută
        /// </summary>
        private static void S2()
        {
            Console.WriteLine("Introduceti valorile a,b si c");
            int a, b, c;
            double d, x1, x2;
            string line = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] t = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            c = int.Parse(t[2]);
            d = (b * b) - (4 * a * c);

            if (d > 0)
            {
                d = Math.Sqrt(d);
                x1 = ((-1 * b) + d) / (2 * a);
                x2 = ((-1 * b) - d) / (2 * a);
                Console.WriteLine($"Radacinile sunt {x1} si {x2}");
            }
            else if (d == 0)
            {
                x1 = (-1 * b) / (2 * a);
                Console.WriteLine($"Radacinile au aceeasi valoare si sunt egale cu {x1}");
            }
            else
            {
                d = Math.Abs(d);
                d = Math.Sqrt(d);
                Console.WriteLine($"Radacinile sunt egale cu {-1 * b}+{d}i/{2 * a} si {-1 * b}-{d}i/{2 * a}");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Stabilirea daca un număr n se divide cu k
        /// </summary>
        private static void S3()
        {
            Console.WriteLine("Introduceti numerele n si k");
            int n, k;
            string line = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] t = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            n = int.Parse(t[0]);
            k = int.Parse(t[1]);
            if (n % k == 0) Console.WriteLine($"{n} se divide cu {k}");
            else Console.WriteLine($"{n} nu se divide cu {k}");
            Console.ReadKey();
        }
        /// <summary>
        /// Stabilirea dacă un an este bisect
        /// </summary>
        private static void S4()
        {
            Console.WriteLine("Introduceti numarul y ");
            int y = int.Parse(Console.ReadLine());
            if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0) Console.WriteLine($"Anul {y} este bisect");
            else Console.WriteLine($"Anul {y} nu este bisect");
            Console.ReadKey();

        }
        /// <summary>
        /// Afișare a a k cifră a unui număr
        /// </summary>
        private static void S5()
        {
            Console.WriteLine("Introduceti numarul n si cifra k");
            int n, k, c;
            string line = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] t = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            n = int.Parse(t[0]);
            k = int.Parse(t[1]);
            int aux = n;
            for (int i = 1; i < k; i++) n = n / 10;
            c = n % 10;
            Console.WriteLine($"A {k} cifra a numarului {aux} este {c}");
            Console.ReadKey();

        }
        /// <summary>
        /// Stabilirea dacă trei numere naturale pot fi lungimile unui triunghi
        /// </summary>
        private static void S6()
        {
            int a, b, c;
            Console.WriteLine("Introduceti numerele a,b si c");
            string line = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] t = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            c = int.Parse(t[2]);
            if (a + b > c && a + c > b && b + c > a) Console.WriteLine($"Numerele {a},{b} si {c} pot fi laturile unui triunghi");
            else Console.WriteLine($"Numerele {a},{b} si {c} nu pot fi laturile unui triunghi");
            Console.ReadKey();

        }
        /// <summary>
        /// Inversarea a două valori
        /// </summary>
        private static void S7()
        {
            int a, b, aux;
            Console.WriteLine("Introduceti valorile a si b");
            string line = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] t = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine(a + " " + b);
            Console.ReadKey();
        }
        /// <summary>
        /// Inversarea a două valori fără a folosi variablie auxiliare
        /// </summary>
        private static void S8()
        {
            int a, b;
            Console.WriteLine("Introduceti valorile a si b");
            string line = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] t = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a + " " + b);
            Console.ReadKey();
        }
        /// <summary>
        /// Afișarea divizorilor unui număr
        /// </summary>
        private static void S9()
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"Dovizorii numarului {n} sunt :");
            for (int d = 1; d <= n / 2; d++) if (n % d == 0) Console.Write(d + " ");
            Console.Write(n+" ");
            Console.WriteLine();
            Console.ReadKey();
        }
        /// <summary>
        /// Stabilirea daca un numar este prim
        /// </summary>
        private static void S10()
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            bool prim = true;
            if (n < 0) prim = false;
            if (n == 2) prim = false;
            if (n % 2 == 0) prim = false;
            for (int i = 2; i * i <= n; i++) if (n % i == 0) prim = false;
            if (prim) Console.WriteLine($"Numarul {n} este prim");
            else Console.WriteLine($"Numarul {n} nu este prim");
            Console.ReadKey();
        }
        /// <summary>
        /// Afisarea in ordine inversa a cifrelor unui numar
        /// </summary>
        private static void S11()
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                Console.Write(n % 10);
                n = n / 10;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        /// <summary>
        /// Numarul de numere divizibile cu n aflate in intervalul [a,b]
        /// </summary>
        private static void S12()
        {
            Console.WriteLine("Introduceti numerele a,b si n");
            int a, b, n, nr = 0;
            string line = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] t = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            n = int.Parse(t[2]);
            for (int i = a; i <= b; i++) if (i % n == 0) nr = nr + 1;
            Console.WriteLine($"In intervalul [{a},{b}] sunt {nr} numere divizibile cu {n}");
            Console.ReadKey();
        }
        /// <summary>
        /// Numarul de ani bisecti intre y1 si y2
        /// </summary>
        private static void S13()
        {
            int y1, y2, nr = 0;
            Console.WriteLine("Introduceti numerele y1 si y2");
            string line = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] t = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            y1 = int.Parse(t[0]);
            y2 = int.Parse(t[1]);
            if (y1 > y2)
            {
                y1 = y1 + y2;
                y2 = y1 - y2;
                y1 = y1 - y2;
            }
            for (int i = y1; i <= y2; i++) if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0) nr = nr + 1;
            Console.WriteLine($"Intre anii {y1} si {y2} sunt {nr} ani bisecti");
            Console.ReadKey();
        }
        /// <summary>
        /// Stabilirea daca un numar este palindrom
        /// </summary>
        private static void S14()
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            int aux = n, o = 0;
            while (n > 0)
            {
                o = (o * 10) + (n % 10);
                n = n / 10;
            }
            if (o == aux) Console.WriteLine($"Numarul {aux} este palindrom");
            else Console.WriteLine($"Numarul {aux} nu este palindrom");
            Console.ReadKey();
        }
        /// <summary>
        /// Afiseaza 3 numere in ordine crescatoare
        /// </summary>
        private static void S15()
        {
            Console.WriteLine("Screti numerele a,b si c");
            int a, b, c, aux;
            string line = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] t = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            c = int.Parse(t[2]);
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (a > c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            Console.WriteLine(a + " " + b + " " + c);
            Console.ReadKey();
        }
        /// <summary>
        /// Afiseaza 5 numere in ordine crescatoare
        /// </summary>
        private static void S16()
        {
            Console.WriteLine("Screti numerele a,b,c,d si e");
            int a, b, c, d, e, aux;
            string line = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] t = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            c = int.Parse(t[2]);
            d = int.Parse(t[3]);
            e = int.Parse(t[4]);
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (a > c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if (a > d)
            {
                aux = a;
                a = d;
                d = aux;
            }
            if (a > e)
            {
                aux = a;
                a = e;
                e = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if (b > d)
            {
                aux = b;
                b = d;
                d = aux;
            }
            if (b > e)
            {
                aux = b;
                b = e;
                e = aux;
            }
            if (c > d)
            {
                aux = c;
                c = d;
                d = aux;
            }
            if (c > e)
            {
                aux = c;
                c = e;
                e = aux;
            }
            if (d > e)
            {
                aux = d;
                d = e;
                e = aux;
            }

            Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e);
            Console.ReadKey();
        }
        /// <summary>
        ///  Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 
        /// </summary>
        private static void S17()
        {
            Console.WriteLine("Introduceti numerele a si b");
            int a, b, aux1, aux2, r, cmmdc = 0, cmmmc = 0;
            string line = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] t = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            if (a == 0 || b == 0) Console.WriteLine("Unul dintre numerele a si b este 0");
            else
            {
                aux1 = a;
                aux2 = b;
                while (b != 0)
                {
                    r = a % b;
                    a = b;
                    b = r;
                }
                cmmdc = a;
                a = aux1;
                b = aux2;
                while (aux1 != aux2)
                {
                    if (aux1 < aux2) aux1 = aux1 + a;
                    else aux2 = aux2 + b;
                }
                cmmmc = aux2;
                Console.WriteLine($"Numerele {a} si {b} au cmmdc-ul {cmmdc} iar cmmmc-ul {cmmmc}");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. 
        /// </summary>
        private static void S18()
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            int d = 2, p;
            while (n > 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    p++;
                    n = n / d;
                }
                if (p != 0) Console.Write(d + "^" + p + "x");
                d++;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        /// <summary>
        /// Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 
        /// </summary>
        private static void S19()
        {
            Console.WriteLine("Scrieti numarul n");
            int n = int.Parse(Console.ReadLine());
            int c1, c2, c, nr = 0;
            c = n;
            bool ok = true;
            while (n > 0)
            {
                nr++;
                n = n / 10;
            }
            n = c;
            c1 = n % 10;
            c2 = (n / 10) % 10;
            if (c1 == c2)
            {
                for (int i = 1; i <= nr; i++)
                {
                    c2 = (n / Convert.ToInt32(Math.Pow(10, i))) % 10;
                    if (c1 != c2) break;
                }
            }
            while (n != 0)
            {
            if (n % 10 != c1 && n % 10 != c2) ok = false;
            n = n / 10;
            }
            if (ok) Console.WriteLine($"Numarul {c} este format din 2 cifre care se repeta");
            else Console.WriteLine($"Numarul {c} nu este format din 2 cifre care se repeta");
            Console.ReadKey();   
        }
        /// <summary>
        /// Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul).
        /// </summary>
        private static void S20()
        {
            Console.WriteLine("Introduceti numerele m si n");
            int m, n, intreg, fractionar,cifra,rest; 
            double d;
            string line = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] t = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            m = int.Parse(t[0]);
            n = int.Parse(t[1]);
            intreg = m / n;
            fractionar = m % n;
            Console.Write(intreg);
            Console.Write(".");
            List<int> cifre = new List<int>();
            List<int> resturi = new List<int>();
            resturi.Add(intreg);
            bool periodic = false;
            do
            {
                cifra = (fractionar * 10) / n;
                cifre.Add(cifra);
                rest = (fractionar * 10) % n;
                if (!resturi.Contains(rest)) resturi.Add(rest);
                else
                {
                    periodic = true;
                    break;
                }
                fractionar = rest;

            } while (rest != 0);
            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 
        /// </summary>
        private static void S21()
        { Random rng =new Random();
            int d=rng.Next(1,1024);
            bool gasit = false;
            do
            {
                Console.WriteLine("Numarul este mai mare sau egal decat ?");
                int n = int.Parse(Console.ReadLine());
                if (n < d) Console.WriteLine($"Numarul este mai mare decat {n}");
                else if (n > d) Console.WriteLine($"Numarul este mai mic decat {n}");    
                    else if (n==d) { gasit = true;
                    Console.WriteLine($"Ati gasit numarul , acesta este egal cu {d}");
                }
                

            } while (gasit == false);
            Console.ReadKey();
        }
    }
}
