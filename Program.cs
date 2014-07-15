using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Ведите предложение: ");
            str = Console.ReadLine();

            var words = str.Split(new[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var groups = words.GroupBy(x => x).Select(x => new { Value = x.Key, Count = x.Count() }).Where(group => group.Count > 1).ToArray();
            foreach (var group in groups)
                Console.WriteLine("Слово ({0}) повторялось {1} раз.", group.Value, group.Count);
            if (!groups.Any())
                Console.WriteLine("Нет одиноковых слов");
            Console.ReadKey();
        }
    }
}
