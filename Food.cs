using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SnakeGame
{
    [Serializable]
    //Base food class.All classes that inherits this interface must implement all abstract methods
    public abstract class Food : Circle , IFood 
    {
        //Abstract methods are like virtual methods
        //but abstract doesn't have to implement a body in declaration, only on inherited classes

        //Draws food
        public abstract void Draw(Graphics g);
        //Check if food was eaten
        public abstract bool Eaten(Snake snake);
    }
}
