using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            HashSet<int> lottóSzámok = new HashSet<int>();
            int számokSzáma = 6;
            int maxSzám = 49;

            while (lottóSzámok.Count < számokSzáma)
            {
                int újSzám = random.Next(1, maxSzám + 1);
                lottóSzámok.Add(újSzám);
            }

            Console.WriteLine("A lottó sorsolás számai:");
            foreach (int szám in lottóSzámok)
            {
                Console.Write(szám + " ");
            }
        }
    }
}
