using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29Tanken1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elias Claeys 5ITN 10/12/2020
            /* Opdracht:
             * Ontwerp een toepassing waarmee je het gemiddelde verbruik van een wagen kan berekenen per 100 km.
             * Bij elke tankbeurt noteert de gebruiker hoeveel kilometer hij gereden heeft sinds de vorige tankbeurt en
             * hoeveel liter hij getankt heeft.
             * Wanneer de gebruiker de waarde 0 ingeeft voor het aantal liter dan berekent het programma het gemiddelde
             * verbruik.
             * 
             * Analyse:
             * VRAAG: kilometer
             * VRAAG: litter
             * HERHAAL als litter != 0
             *      BEREKEN: Aantal = Aantal + 1
             *      BEREKEN: Totaal = Totaal + litter       
             *      BEREKEN: Gemiddelde = Totaal / Aantal
             *      VRAAG: kilometer
             *      VRAAG: litter
             * TOON: Gemiddelde
             */

            //Declarations
            int kilometer, litter, aantal, totaal, gemiddelde;

            //Initialisaties 
            aantal = 0;
            totaal = 0;

            //VRAAG: kilometer
            Console.Write("Hoeveel kilometer heb je gereden sinds de vorige tankbeurt ");
            kilometer = int.Parse(Console.ReadLine());

            //VRAAG: litter
            Console.Write("Hoeveel liter heb je toen getankt ");
            litter = int.Parse(Console.ReadLine());

            //HERHAAL als litter != 0
            while (litter != 0)
            {
                //BEREKEN: Aantal = Aantal + 1
                aantal = aantal + 1;

                //BEREKEN: Totaal= Totaal + litter
                totaal = totaal + litter;

                //VRAAG: kilometer
                Console.Write("Hoeveel kilometer heb je gereden sinds de vorige tankbeurt ");
                kilometer = int.Parse(Console.ReadLine());

                //VRAAG: litter
                Console.Write("Hoeveel liter heb je toen getankt ");
                litter = int.Parse(Console.ReadLine());
            }
                
            //BEREKEN gemiddelde
            gemiddelde = totaal / aantal;

            //TOON gemiddelde
            Console.WriteLine($"Het gemiddelde verbruik is {gemiddelde} litter" );

            //Wachten...
            Console.WriteLine();
            Console.Write("Druk op enter om af te sluiten");
            Console.ReadLine();
        }
    }
}
