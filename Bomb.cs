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
    public class Bomb : Circle
    {
        //Default constructor. Sets position x,y to 0,0
        public Bomb() {
            X = 0;
            Y = 0;
        }
        
        //Function checks if head of given snake collided with bomb
        //Function will return true if explosion happened, false if not
        public bool Exploded(Snake snake)
        {
            if (snake.SnakeBody[0].X == this.X && snake.SnakeBody[0].Y == this.Y)
            {
                return true;
            }
            else
                return false;
        }

        //Function will draw the bomb
        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Black, new Rectangle 
                (
                this.X * Settings.Width,
                this.Y * Settings.Height,
                Settings.Width, Settings.Height));
        }

    }
}
