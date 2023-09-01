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
   public class Snake : Circle, ISnake 
    {
        //Constructor will create a new snake. sets direction as given.
        //initializes a new list of cirlce as snake's body
        public Snake(string direction)
        {
            SnakeBody = new List<Circle>();
            Direction = direction;
        }
        public List<Circle> SnakeBody { get; internal set; }  //Snake's body as a list of circles
        public int SnakeScore { get; internal set; }          //Snake score
        public string Direction { get; internal set; }        //Direction of the snake's movement
        public bool GoLeft { get; internal set; }             //Directions
        public bool GoRight { get; internal set; }
        public bool GoUp { get; internal set; }
        public bool GoDown { get; internal set; }

        //Function will add to snake's score points by the given parameter points
        //if circle needs to be added or removed, it will be from the end of the snake's body list
        //Circles are added and removed in the same (x,y) as the last circle of the body.
        public void EatFood(int points)
        {
            SnakeScore += points;
            if (points == Settings.NormalFoodPoint)
            {
                Circle Body = new Circle
                {
                    //Last circle's (x,y)
                    X = SnakeBody[SnakeBody.Count - 1].X,
                    Y = SnakeBody[SnakeBody.Count - 1].Y
                };
                //Adds a circle to the list
                SnakeBody.Add(Body);
            }

            if (points == Settings.ValuableFoodPoints)
            {
                //Adds the same amount of circles as the valuable food points (5 in default)
                for (int i = 0; i < Settings.ValuableFoodPoints; i++)
                {
                    Circle Body = new Circle
                    {
                        X = SnakeBody[SnakeBody.Count - 1].X,
                        Y = SnakeBody[SnakeBody.Count - 1].Y
                    };

                    SnakeBody.Add(Body);
                }
            }
            //Remove a circle if a diet food was eaten
            if (points == Settings.DietFoodPoints)
            {
                SnakeBody.RemoveAt(SnakeBody.Count - 1);
            }

        }
        //Checks for self collision
        //to do so, function checks each one of snake's body circles position
        //and compares to head's position
        public bool Collision()
        {
            for (int j = 1; j < SnakeBody.Count; j++)
            {
                
                if (SnakeBody[0].X == SnakeBody[j].X && SnakeBody[0].Y == SnakeBody[j].Y) 
                {
                    SnakeBody.Clear(); // Dead
                    return true;
                }
            }
                return false;
        }
        //Checks for collision with other snake
        //function checks each one of other snake's body circles position
        //and compares to this snake head's position.
        //Extra 5 points is awarded to the second snake which is still alive
        public bool Collision(Snake secondSnake)
        {
            if (SnakeBody.Count > 0)
            {
                for (int s = 1; s < secondSnake.SnakeBody.Count; s++) // Other snake
                {
                    if (SnakeBody[0].X == secondSnake.SnakeBody[s].X && SnakeBody[0].Y == secondSnake.SnakeBody[s].Y) // Runs into other snake
                    {
                        SnakeBody.Clear(); // Dead
                        secondSnake.SnakeScore += 5;
                        return true;
                    }
                }
                return false;
            }
            return false;
        }
        //Changes snake's direction
        public void ChangeDirection(string dir, bool trueOrfalse)
        {
            switch (dir)
            {
                case "left":
                    GoLeft = trueOrfalse;
                    break;
                case "right":
                    GoRight = trueOrfalse;
                    break;
                case "up":
                    GoUp = trueOrfalse;
                    break;
                case "down":
                    GoDown = trueOrfalse;
                    break;
            }
        }
        //Draws snake
        public void Draw(Graphics g, int index, Brush color)
        {
            Brush SnakeColor;
            //If snake's head, color is black. otherwise by given color.
            if (index == 0)
                SnakeColor = Brushes.Black;
            else
                SnakeColor = color;

            g.FillEllipse(SnakeColor, new Rectangle
                   (
                   SnakeBody[index].X * Settings.Width,
                   SnakeBody[index].Y * Settings.Height,
                   Settings.Width, Settings.Height));
        }
        //Moves snake's head on grid
        public void MoveHead() 
        {
            switch (Direction) 
            {
                case "left":
                    SnakeBody[0].X--;
                    break;
                case "right":
                    SnakeBody[0].X++;
                    break;
                case "up":
                    SnakeBody[0].Y--;
                    break;
                case "down":
                    SnakeBody[0].Y++;
                    break;
            }
        }
        public void ThroughWalls(int width, int height)
        {
            //if out of bounds from the left, set the snake's head x to value of width (right side)
            if (SnakeBody[0].X < 0) 
            {
                SnakeBody[0].X = width;
            }
            //if out of bounds from the right, set the snake's head x to value 0 (left side)
            if (SnakeBody[0].X > width)
            {
                SnakeBody[0].X = 0;
            }
            //if out of bounds from the bottom, set the snake's head y to value of height (up side)
            if (SnakeBody[0].Y < 0)
            {
                SnakeBody[0].Y = height;
            }
            //if out of bounds from the upper side, set the snake's head y to value of 0 (down side)
            if (SnakeBody[0].Y > height)
            {
                SnakeBody[0].Y = 0;
            }
        }

        //Function will update current circle (by index)
        //to the value of the circle infront of it in the list
        public void MoveAlong(int index) 
        {
            SnakeBody[index].X = SnakeBody[index - 1].X;
            SnakeBody[index].Y = SnakeBody[index - 1].Y;
        }
        //Function will update the class member of direction
        public void SnakeDirection()
        {
            if (GoLeft)
            {
                Direction = "left";
            }
            if (GoRight)
            {
                Direction = "right";
            }
            if (GoDown)
            {
                Direction = "down";
            }
            if (GoUp)
            {
                Direction = "up";
            }
        }
                
    }
}
