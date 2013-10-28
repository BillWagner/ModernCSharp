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
