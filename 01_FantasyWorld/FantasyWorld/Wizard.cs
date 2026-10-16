namespace FantasyWorld
{
    sealed class Wizard : Character
    {
        public Wizard(string name) : base(name)
        {
            this.Color = ConsoleColor.Blue;
        }

        public override void Move()
        {
            int randomMove = World.random.Next(0, 8);
            int dx = 0;
            int dy = 0;
            switch (randomMove)
            {
                case 0: dx = -1; dy = -1; break;
                case 1: dx = 0; dy = -1; break;
                case 2: dx = 1; dy = -1; break;
                case 3: dx = 1; dy = 0; break;
                case 4: dx = 1; dy = 1; break;
                case 5: dx = 0; dy = 1; break;
                case 6: dx = -1; dy = 1; break;
                case 7: dx = -1; dy = 0; break;
            }
            if (TargetInWorld(Position.X + dx, Position.Y + dy))
            {
                Position.X = Position.X + dx;
                Position.Y = Position.Y + dy;
            }
        }

        public override void Show()
        {
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.ForegroundColor = Color;
            Console.Write(Name);
        }
    }
}
