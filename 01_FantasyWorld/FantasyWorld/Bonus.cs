using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyWorld
{
    abstract class Bonus : IShowable
    {
        public int X { get; protected set; }
        public int Y { get; set; }
        public int Value { get; set; }

        public Bonus()
        {
            X = World.random.Next(0, World.WIDTH);
            Y = World.random.Next(0, World.HEIGHT);
            Value = 1;
        }

        public virtual void Show()
        {
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("B");
        }
    }
}
