using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicCSharp
{
    public class BoardSpace
    {
        private char column;
        private int row;
        public int Row
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }

        public char Column
        {
            get
            {
                return column;
            }
            set
            {
                column = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("{Row = ");
            builder.Append(row);
            builder.Append(", Column = ");
            builder.Append(column);
            builder.Append("}");
            return builder.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList board = new ArrayList();
            for (int row = 1; row < 9; row++)
                for (char col = 'a'; col < 'k'; col++)
                {
                    BoardSpace b = new BoardSpace();
                    b.Row = row;
                    b.Column = col;
                    board.Add(b);
                }

            foreach (var item in board)
                Console.WriteLine(item);
        }
    }
}
