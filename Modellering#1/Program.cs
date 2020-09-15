using System;

namespace Modellering_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   
                Tower Defense
             * Towers/Torn
                * direktion
                * Fire Rate/"eldhastighet"
                * Kill Counter/Slaktar Räknare
             * Hp/Liv
             * Enemies/Fiender
                * mängd
                * 
             * Pengar?
            */ 
            Towers t = new Towers();
            Enemies E = new Enemies();

            t.name1 = "firetower";

            E.Alive = 3;

            Console.WriteLine(t);

            Console.ReadLine();
        }
    }
}
