using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstExample();

            var oddSquares = from n in Enumerable.Range(0, 12)
                             where n % 2 == 1
                             select n * n;
            oddSquares.ForAll(item => Console.WriteLine(item));

        }
        private static void FirstExample()
        {
            var board = from row in Enumerable.Range(1, 8)
                        from index in Enumerable.Range(0, 8)
                        let column = (char)('a' + index)
                        select new { row, column };

            board.ForAll(item => Console.WriteLine(item));
        }
    }
    public static class Extensions
    {
        public static void ForAll<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            foreach (T item in sequence)
                action(item);
        }
    }
}
