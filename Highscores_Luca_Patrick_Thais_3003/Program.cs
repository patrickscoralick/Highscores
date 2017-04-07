using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highscores_Luca_Patrick_Thais_3003
{
    class Jogadores
    {
        public string nome;
        public int points;

        public Jogadores(string Nome, int Points)
        {
            nome = Nome;
            points = Points;
        }

    }

    static class Sorting
    {
        public static Jogadores[] BubbleSort(this Jogadores[] arrayToBeSorted)
        {
            Jogadores auxPlayer;
            for (int i = 0; i < arrayToBeSorted.Length; i++)
            {
                for (int j = 0; j < arrayToBeSorted.Length - 1; j++)
                {
                    if (arrayToBeSorted[j].points > arrayToBeSorted[j + 1].points)
                    {
                        auxPlayer = arrayToBeSorted[j];
                        arrayToBeSorted[j] = arrayToBeSorted[j + 1];
                        arrayToBeSorted[j + 1] = auxPlayer;
                    }
                }
            }
            return arrayToBeSorted;
        }
    }

    class Program
    {
        static string[] nomes = new string[] { "Ester", "Maria", "Pedro", "Paulo", "João", "José", "Isaque", "Daniel", "Jacó", "Rute" };
        static int[] points = new int[] { 0, 5, 67, 980, 41269421, 23, 4, 18, 17, 73};
        static Jogadores[] players = new Jogadores[nomes.Length];
        static void Main(string[] args)
        {
            for(int i = 0; i < nomes.Length; i++)
            {
                players[i] = new Jogadores(nomes[i], points[i]);
            }

            players = players.BubbleSort();

            for(int i = players.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(players.Length - i + " - " + players[i].nome + " | Pontos:" + players[i].points);
            }
            Console.ReadKey();
        }

        
    }
}

