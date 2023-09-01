using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SnakeGame
{
    [Serializable]
    public class Circle // Food, SnakeBody, SnakeHead etc are all circles. Makes collisions easier to identify
	{
        //coordinates of circle
        protected internal int X { get; internal set; }
		protected internal int Y { get; internal set; }

		//Default constructor. sets x,y to position 0,0 
		public Circle()
		{
			X = 0;
			Y = 0;
		}
	}
}
