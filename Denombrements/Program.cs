using Microsoft.Win32;
using System;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = "1";
            while (c != "0")
            {
                int saisieN()
                {
                    //saisie des données de calcul n
                    while (true)
                        try
                        {
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            int n = int.Parse(Console.ReadLine());
                            return (n);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Erreur de saisie");
                        }
                }

                int saisieT()
                {
                    //saisie des données de calcul t
                    while (true)
                        try
                        {
                            Console.Write("nombre total d'éléments à gérer = ");
                            int t = int.Parse(Console.ReadLine());
                            return (t);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Erreur de saisie");
                        }
                }

                // choix du menu
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = Console.ReadLine();

                switch (c)
                {
                    default:
                        Console.WriteLine("Choix incorrect");
                        continue;


                    //quitter
                    case "0":
                        Environment.Exit(0);
                        break;

                    // permutation (choix 1)
                    case "1":
                        {
                            //saisiée des données de calcul (remplacement de n par t dans la formule pour avoir la bonne demande)
                           int t = saisieT();
                            // calcul de r
                            long r = 1;
                            for (int k = 1; k <= t; k++)
                                r *= k;
                            Console.WriteLine(t + "! = " + r);
                            break;
                        }

                    // arrangement (choix 2)
                    case "2":
                        {
                            //saisie des données de calcul
                            int t = saisieT();
                            int n = saisieN();
                            // calcul de r
                            long r = 1;
                            for (int k = (t - n + 1); k <= t; k++)
                                r *= k;
                            //Console.WriteLine("résultat = " + (r1 / r2));
                            Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                            break;
                        }

                    // combinaison (choix 3)
                    case "3":
                        {
                            //saisie des données de calcul
                            int t = saisieT();
                            int n = saisieN();
                            // calcul de r1
                            long r1 = 1;
                            for (int k = (t - n + 1); k <= t; k++)
                                r1 *= k;
                            // calcul de r2
                            long r2 = 1;
                            for (int k = 1; k <= n; k++)
                                r2 *= k;
                            // calcul de r3
                            //Console.WriteLine("résultat = " + (r1 / r2));
                            Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                            break;
                        }
                }
            }
            Console.ReadLine();
        }
    }
}
