using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
   
    [Serializable]
    //This class stores all of the needed variables to save and load games. (Serialization)
    public class GameState
    {
        //fields to store the game state
        public Snake Snake1 { get; set; }
        public Snake Snake2 { get; set; }  
        public int AmountOfPlayers { get; set; }
        public int MaxWidth { get; set; }
        public int MaxHeight { get; set; }
        public Bomb ExplodingBomb { get; set; }
        public DietFood Diet { get; set; }
        public NormalFood Normal { get; set; }
        public ValuableFood Valuable { get; set; }

        //Default Constructor. Init all properties to junk values.
        public GameState()
        {
            Snake1 = new Snake("up");
            Snake2 = new Snake("up");
            Diet = new DietFood();
            MaxHeight = Settings.Height;
            MaxWidth = Settings.Width;
            Normal = new NormalFood();
            Valuable = new ValuableFood();
            ExplodingBomb = new Bomb();
        }

     }
    
}
