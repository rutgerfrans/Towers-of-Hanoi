using System;

namespace PI7TowerOfHanoi
{
    class Program
    {
        public static void Main()
        { 
            int Schijven = 4;

            Hanoi(Schijven, 'S', 'A', 'D');
        }

        static void Hanoi(int Schijven, char Bron, char Bestemming, char Hulp)
        {
            if (Schijven == 1)
            {
                Console.WriteLine("Zet Schijf 1 van Stapel " + Bron + " Naar Stapel " + Bestemming);
                return;
            }
            Hanoi(Schijven - 1, Bron, Hulp, Bestemming);
            Console.WriteLine("Zet Schijf " + Schijven + " Van Stapel " + Bron + " Naar Stapel " + Bestemming);
            Hanoi(Schijven - 1, Hulp, Bestemming, Bron);
        }
    }
}
