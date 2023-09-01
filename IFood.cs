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
    //Food interface. defines a set of methods that a class must implement.
    internal interface IFood
    {
        public void Draw(Graphics g); // Draws food
        public bool Eaten(Snake snake); // Snake ate food
    }
}
