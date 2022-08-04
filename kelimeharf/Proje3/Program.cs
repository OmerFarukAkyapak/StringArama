using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kelimenizi giriniz : ");
            String x = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict = fonksiyon(x);
            foreach (var dictitem in dict.Keys)
            {
                Console.WriteLine("{0} harfi {1} kez tekrar ediyor", dictitem, dict[dictitem]);
                Console.ReadLine();
            }

        }
        static Dictionary<char, int> fonksiyon(string j)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in j)
                if (!dict.ContainsKey(c))
                    dict.Add(c, 1);
                else
                    dict[c] = dict[c] + 1;
            return dict;
            Console.ReadLine();
        }
    }
}
