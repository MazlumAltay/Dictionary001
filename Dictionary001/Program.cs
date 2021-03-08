using System;

namespace Dictionary001
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> meyveler = new MyDictionary<int, string>();
            meyveler.Add(4, "Elma");
            for (int i = 0; i < meyveler.KItems.Length; i++)
            {
                Console.WriteLine(meyveler.KItems[i]);
            }
        }
    }
}
