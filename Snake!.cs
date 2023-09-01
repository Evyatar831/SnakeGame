using System;//random
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SnakeGame
{
    [Serializable]
    public partial class Snake_ : Form
    {
        //All food (Polymorphism)
        private Food ValuableFood = new ValuableFood();
        private Food NormalFood = new NormalFood();
        private Food DietFood = new DietFood();
        
        //New bomb
        private Bomb ExpldodingBomb = new Bomb();

        //Snake players variables. Default position is up
        private Snake Snake1 = new Snake("up");
        private Snake Snake2 = new Snake("up");

        //Grid bounds
        private int maxWidth;//size of game's window
        private int maxHeight;

        private int AmountOfPlayers;
        
        //Random variable to generate new food positions
        Random rand = new Random();


        //Snake main window construcor.
        //Initialize all components
        public Snake_()
        {
            Menu menu = new Menu();
            menu.Show();                //Show menu window
            this.SendToBack();          //Sets game window behind the menu
            this.KeyPreview = true;     //recieve all keys events
            new Settings();             //new game settings
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;  //sets window to center
            this.FormBorderStyle = FormBorderStyle.FixedSingle;   //Unresizeable
            menu.TopMost = true;        //Sets menu in the front
        }

        //Function will determint wheter one of the movement keys was pressed
        //Function will change the direction of the snake if needed
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.J && Snake1.Direction != "right")  //If snake is not moving right
            {
                Snake1.ChangeDirection("left", true);
            }
            if (e.KeyCode == Keys.L && Snake1.Direction != "left")  //If snake is not moving left
            {
                Snake1.ChangeDirection("right", true);
            }
            if (e.KeyCode == Keys.I && Snake1.Direction != "down")  //If snake is not moving down
            {
                Snake1.ChangeDirection("up", true);
            }
            if (e.KeyCode == Keys.K && Snake1.Direction != "up")   //If the snake is not moving up
            {
                Snake1.ChangeDirection("down", true);
            }

            if (e.KeyCode == Keys.A && Snake2.Direction != "right")
            {
                Snake2.ChangeDirection("left", true);
            }
            if (e.KeyCode == Keys.D && Snake2.Direction != "left")
            {
                Snake2.ChangeDirection("right", true);
            }
            if (e.KeyCode == Keys.W && Snake2.Direction != "down")
            {
                Snake2.ChangeDirection("up", true);
            }
            if (e.KeyCode == Keys.S && Snake2.Direction != "up")
            {
                Snake2.ChangeDirection("down", true);
            }

        }

        //Function will tell if key is up
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.J)
            {
                Snake1.ChangeDirection("left", false);
            }
            if (e.KeyCode == Keys.L)
            {
                Snake1.ChangeDirection("right", false);
            }
            if (e.KeyCode == Keys.I)
            {
                Snake1.ChangeDirection("up", false);
            }
            if (e.KeyCode == Keys.K)
            {
                Snake1.ChangeDirection("down", false);
            }

            if (e.KeyCode == Keys.A)
            {
                Snake2.ChangeDirection("left", false);
            }
            if (e.KeyCode == Keys.D)
            {
                Snake2.ChangeDirection("right", false);
            }
            if (e.KeyCode == Keys.W)
            {
                Snake2.ChangeDirection("up", false);
            }
            if (e.KeyCode == Keys.S)
            {
                Snake2.ChangeDirection("down", false);
            }

        }

        //Function will be called if one player button was clicked
        //Disables players buttons and prepares game with one player
        private void OnePlayer(object sender, EventArgs e)
        {
            button1player.Enabled = false;
            button2player.Enabled = false;
            //Turn off player 2 score to determine real amount of players
            S2Score.Enabled = false;  
            PrepareGame(1);
        }

        //Function will be called if 2 players button was clicked
        //Disables players buttons and prepares game with 2 players
        private void TwoPlayers(object sender, EventArgs e)
        {
            button1player.Enabled = false;
            button2player.Enabled = false;
            PrepareGame(2);
        }

        //This function is called every time game timer ticks (50 ms)
        private void GameTimerEvent(object sender, EventArgs e)
        {
            //checks and updates (if needed) snakes direction 
            Snake1.SnakeDirection();
            //if (AmountOfPlayers == 2)
                Snake2.SnakeDirection();

            for (int i = Snake1.SnakeBody.Count - 1; i >= 0; i--) //Snake1 body loop
            {
                if (i == 0) // if it's Snakes Head
                {
                    Snake1.MoveHead();  //move head in the current diretion

                    Snake1.ThroughWalls(maxWidth, maxHeight);   //check if head is in bounds

                    //Checks for collision with a bomb
                    if (ExpldodingBomb.Exploded(Snake1))
                    {
                        AmountOfPlayers--;    //reduce number of active players
                        Snake1.SnakeBody.Clear();  //DEAD
                        Snake1.SnakeScore -= Settings.BombDamage;  //reduce points (sets to 25)
                        //generate a new bomb in a radmon position
                        ExpldodingBomb = new Bomb { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };  //Bomb exploded
                        break;
                    }

                    if (ValuableFood.Eaten(Snake1)) // Eats ValuableFood and sets new position
                        ValuableFood = new ValuableFood { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

                    if (NormalFood.Eaten(Snake1)) // Eats NormalFood and sets new position 
                        NormalFood = new NormalFood { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };



                    if (DietFood.Eaten(Snake1)) // Eats DietFood and sets new position
                        DietFood = new DietFood { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

                    //If there are 2 players alive, checks for collision with other player
                    if (AmountOfPlayers == 2 && Snake1.Collision(Snake2))
                        AmountOfPlayers--;

                    //Check for self collision
                    if (Snake1.Collision())
                        AmountOfPlayers--;

                    
                }
                else
                {
                    //If it's not the snake's head
                    Snake1.MoveAlong(i);
                }
            }

            for (int i = Snake2.SnakeBody.Count - 1; i >= 0; i--) //Snake2 -||-  
            {
                if (i == 0)
                {
                    Snake2.MoveHead();

                    Snake2.ThroughWalls(maxWidth, maxHeight);

                    if (ExpldodingBomb.Exploded(Snake2))
                    {
                        AmountOfPlayers--;
                        Snake2.SnakeBody.Clear();
                        Snake2.SnakeScore -= Settings.BombDamage;
                        ExpldodingBomb = new Bomb { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };  //Bomb exploded
                        break;
                    }

                    if (ValuableFood.Eaten(Snake2))
                        ValuableFood = new ValuableFood { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

                    if (NormalFood.Eaten(Snake2))
                        NormalFood = new NormalFood { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };


                    if (DietFood.Eaten(Snake2))
                        DietFood = new DietFood { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };


                    if (AmountOfPlayers == 2 && Snake2.Collision(Snake1))
                        AmountOfPlayers--;

                    if (Snake2.Collision())
                        AmountOfPlayers--;

                }
                else
                {
                    Snake2.MoveAlong(i);
                }
            }

            //After 2 loops ended, checks if there are any players alive to end the game
            if (AmountOfPlayers == 0)
            {
                GameOver();
            }

            //Redraw the entire surface
            PicCanvas.Invalidate();
        }

        //Function is called whenever canvas needs to be redraw 
        private void UpdateGrapichs(object sender, PaintEventArgs e)
        { 
            //object used to paint
            Graphics canvas = e.Graphics;

            //snake's main color
            Brush Snake1Color = Brushes.Green;
            Brush Snake2Color = Brushes.Yellow;

            //Draws the snakes by number of circles they have in their body
            for (int i = 0; i < Snake1.SnakeBody.Count; i++)
                Snake1.Draw(canvas, i, Snake1Color);

            for (int i = 0; i < Snake2.SnakeBody.Count; i++)
                Snake2.Draw(canvas, i, Snake2Color);

            //Draw food and bombs
            NormalFood.Draw(e.Graphics);
            ValuableFood.Draw(e.Graphics);
            DietFood.Draw(e.Graphics);
            ExpldodingBomb.Draw(e.Graphics); 

            //Sets current snake's score
            S1Score.Text = "Score: " + Snake1.SnakeScore;
            S2Score.Text = "Score: " + Snake2.SnakeScore;

        }

        //Function will prepare a new game with requested amount op players
        private void PrepareGame(int amountOfPlayers)
        {
            AmountOfPlayers = amountOfPlayers;

            //game grid boundries
            maxWidth = PicCanvas.Width / Settings.Width - 1 ;
            maxHeight = PicCanvas.Height / Settings.Height - 1;

            //Clear snakes body list
            Snake1.SnakeBody.Clear();
            Snake2.SnakeBody.Clear();

            //Sets score to 0 to start a new count
            Snake1.SnakeScore = 0;
            Snake2.SnakeScore = 0;

            //Sets default position of snakes
            Snake1.Direction = "up";
            Snake2.Direction = "down";

            //Disables player 2 score label if game starts with one player only 
            if (amountOfPlayers == 1)
            {
                S1Score.Text = "Score: " + Snake1.SnakeScore;
                S2Score.Text = "";

            }
            if (amountOfPlayers == 2)
            {
                S1Score.Text = "Score: " + Snake1.SnakeScore;
                S2Score.Text = "Score:" + Snake2.SnakeScore;

            }
            //Snakes starting point positions
            Circle head1 = new Circle { X = 5, Y = 20 };
            Circle head2 = new Circle { X = 30, Y = 20 };

            //Adds head to list
            Snake1.SnakeBody.Add(head1);
            if (amountOfPlayers > 1)
                Snake2.SnakeBody.Add(head2);

            //Adds a default amount of body circle to the list (9 circles)
            for (int i = 0; i < 9; i++)
            {
                Circle body1 = new Circle();
                Circle body2 = new Circle();

                Snake1.SnakeBody.Add(body1);
                if (amountOfPlayers > 1)
                    Snake2.SnakeBody.Add(body2);
            }
            //Generate a random starting point for food and bomb
            NormalFood = new NormalFood() { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            ValuableFood = new ValuableFood() { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            DietFood = new DietFood() { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            ExpldodingBomb = new Bomb() { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            //Starts game timer
            GameTimer.Start();
        }
        private void GameOver()
        {
            GameTimer.Stop();  //to don't update screen anymore
            int realAmountOfPlyaers = 2;
            if (S2Score.Enabled == false)   //if game was only played with one player s2score is disabled
                realAmountOfPlyaers = 1;
            button1player.Enabled = true;   //buttons turn on to allow new game
            button2player.Enabled = true;
            GameOverScreen endScreen;
            if (realAmountOfPlyaers == 2)   //if there was a competition between 2 players
            {
                if (Snake1.SnakeScore > Snake2.SnakeScore)   //snake 1 won
                {
                    endScreen = new GameOverScreen(1, Snake1.SnakeScore);
                    endScreen.Show();
                }
                else if (Snake1.SnakeScore < Snake2.SnakeScore) //snake 2 won
                {
                    endScreen = new GameOverScreen(2, Snake2.SnakeScore);  
                    endScreen.Show();
                }
                else if (Snake1.SnakeScore == Snake2.SnakeScore) //tie
                {
                    endScreen = new GameOverScreen(3, Snake1.SnakeScore);
                    endScreen.Show();
                }
                
            }
            else   // only one player played
            {
                endScreen = new GameOverScreen(0,Snake1.SnakeScore);
                endScreen.Show();
            }
            

        }

        //Function will be called when load button is pressed
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();  //Opens files window
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory(); //Sets to project directory
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*"; //file types filter
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Create an instance of the BinaryFormatter
                BinaryFormatter formatter = new BinaryFormatter();

                using (Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open))
                {
                    try
                    {
                        // Deserialize the GameState instance
                        GameState savedState = (GameState)formatter.Deserialize(stream);

                        // Restore the previous state
                        this.Snake1 = savedState.Snake1;
                        this.Snake2 = savedState.Snake2;
                        this.AmountOfPlayers = savedState.AmountOfPlayers;
                        this.maxWidth = savedState.MaxWidth;
                        this.maxHeight = savedState.MaxHeight;
                        this.DietFood = savedState.Diet;
                        this.NormalFood = savedState.Normal;
                        this.ExpldodingBomb = savedState.ExplodingBomb;
                        this.ValuableFood = savedState.Valuable;
                        // Restore other necessary properties and fields

                        // Update the UI or perform any other necessary actions
                        PicCanvas.Invalidate();

                        // Resume the game
                        GameTimer.Start();
                    }
                    catch (SerializationException ex)
                    {
                        // Handle deserialization error
                        Console.WriteLine("Failed to deserialize: " + ex.Message);
                    }
                }
            }
        }

        //This function is called when save button was pressed
        private void button1_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();   //Stops UI when trying to save the game
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Create an instance of the BinaryFormatter
                BinaryFormatter formatter = new BinaryFormatter();

                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                {
                    try
                    {
                        // Create a new GameState instance and populate it with the current state
                        GameState currentState = new GameState();
                        currentState.Snake1 = Snake1;
                        currentState.Snake2 = Snake2;
                        currentState.AmountOfPlayers = AmountOfPlayers;
                        currentState.MaxWidth = maxWidth;
                        currentState.MaxHeight = maxHeight;
                        currentState.Diet = (DietFood)DietFood;
                        currentState.ExplodingBomb = ExpldodingBomb;
                        currentState.Valuable = (ValuableFood)ValuableFood;
                        currentState.Normal = (NormalFood)NormalFood;

                        // Serialize the GameState instance
                        formatter.Serialize(stream, currentState);
                    }
                    catch (SerializationException ex)
                    {
                        // Handle serialization error
                        Console.WriteLine("Failed to serialize: " + ex.Message);
                    }
                }
            }
            //Resumes game after saving
            GameTimer.Start();
        }
    }
}
