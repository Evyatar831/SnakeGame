using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    [Serializable]
    class Settings // Game Settings
    {
        //Width of a game circle
        public static int Width { get; private set; }
        
        //Height of game circle
        public static int Height { get; private set; }

        //Different food points
        public const int NormalFoodPoint = 1;
        public const int ValuableFoodPoints = 5;
        public const int DietFoodPoints = -1;
        public const int IntervalFoodPoints = 0;

        //Bomb influence
        public const int BombDamage = 25;

        //Default constructor. sets size for game circles
        public Settings()
        {
            Width = 16;
            Height = 16;
        }
    }
}
