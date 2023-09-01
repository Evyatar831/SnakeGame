using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SnakeGame
{
    [Serializable]
    public class ValuableFood : Food
    {
        public ValuableFood()
        {
            X = 0;
            Y = 0;
        }
        public override bool Eaten(Snake snake)
        {
           if (snake.SnakeBody[0].X == this.X && snake.SnakeBody[0].Y == this.Y)
           {
                snake.EatFood(Settings.ValuableFoodPoints);
                return true;
           }
           return false;
        }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.HotPink, new Rectangle // ValuableFood
                (
                this.X * Settings.Width,
                this.Y * Settings.Height,
                Settings.Width, Settings.Height));
        }
    }
}
