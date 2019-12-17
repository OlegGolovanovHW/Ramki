using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рамки
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int h = mas[0];
            int w = mas[1];
            int n = mas[2];
            int[] r1 = new int[n];
            int[] r2 = new int[n];
            int[] c1 = new int[n];
            int[] c2 = new int[n];
            for (int i = 0; i<n; i++)
            {
                mas = Console.ReadLine().Split().Select(int.Parse).ToArray();
                r1[i] = mas[0];
                c1[i] = mas[1];
                r2[i] = mas[2];
                c2[i] = mas[3];
            }
            string LatinAlphabet = "abcdefghijklmnopqrstuvwxyz";
            char[,] Field = new char[h, w];
            for (int i = 0; i<h; i++)
            {
                for (int j = 0; j<w; j++)
                {
                    Field[i,j] = '.';
                }
            }
            for (int i = 0; i<n; i++)
            {
                for (int j = r1[i]-1; j<r2[i]; j++)
                {
                    Field[j, c1[i]-1] = LatinAlphabet[i];
                    Field[j, c2[i]-1] = LatinAlphabet[i];
                }
                for (int j = c1[i]-1; j<c2[i]; j++)
                {
                    Field[r1[i]-1, j] = LatinAlphabet[i];
                    Field[r2[i]-1, j] = LatinAlphabet[i];
                }
            }
            for (int i = 0; i<h; i++)
            {
                for (int j = 0; j<w; j++)
                {
                    Console.Write("{0} ",Field[i,j]);
                }
                Console.WriteLine();
            }

        }
    }
}
