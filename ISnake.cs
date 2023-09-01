using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeGame
{
    //Snake interface. Defines methods that must be implemented.
    internal interface ISnake
    {
        public void EatFood(int points); // Eats food
        public bool Collision(); // Snake runs in to itself
        public bool Collision(Snake secondSnake); // Runs in to a second snake (2 player mode)
        public void ChangeDirection(string dir, bool trueOrfalse); // Changes direction of the snake
        public void Draw(Graphics canvas, int index, Brush color); // Draws the snake
        public void MoveHead(); // Moves the head
        public void ThroughWalls(int width, int height); // Makes snake go through walls
        public void MoveAlong(int index); // Moves body along the head
        public void SnakeDirection(); // Sets direction
    }
}
