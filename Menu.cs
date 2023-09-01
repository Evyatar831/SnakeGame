using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    //Main menu window
    public partial class Menu : Form
    {
        //Construcor setes window position to center and init all components
        public Menu()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        //Close window to start the game
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
