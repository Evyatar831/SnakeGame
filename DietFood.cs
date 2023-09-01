using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace SnakeGame
{
    [Serializable]
    public class DietFood : Food
    {
        //Default constructor. sets food position to 0,0
        public DietFood()
        {
            X = 0;
            Y = 0;
        }

        //function checks if diet food was eaten by checking given snake's head position
        //function will return true if eaten to update points
        public override bool Eaten(Snake snake)
        {
            if (snake.SnakeBody[0].X == this.X && snake.SnakeBody[0].Y == this.Y) //SnakeBody[0] = head
            {
                snake.EatFood(Settings.DietFoodPoints);
                return true;
            }
            return false;
        }
        //Function will draw the food
        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Red, new Rectangle 
                (
                this.X * Settings.Width,
                this.Y * Settings.Height,
                Settings.Width, Settings.Height));
        }
    }
}
