using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyWorld
{
    class Butterfly : Bonus
    {
        public Butterfly() : base()
        {
            Value = 3;
        }

        public void Move()
        {
            int randomJump = World.random.Next(0, 4);
            int dx = 0;
            int dy = 0;
            switch(randomJump)
            {
                case 0: dx = 2; dy = -2; break;
                case 1: dx = -2; dy = -2; break;
                case 2: dx = -2; dy = 2; break;
                case 3: dx = 2; dy = 2; break;
            }
            X += dx;
            Y += dy;
            if (X >= World.WIDTH) X -= World.WIDTH;
            if (X < 0) X += World.WIDTH;
            if (Y >= World.HEIGHT) Y -= World.HEIGHT;
            if (Y < 0) Y += World.HEIGHT;
        }
    }
}
