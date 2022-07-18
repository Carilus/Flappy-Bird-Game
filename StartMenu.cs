using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Game
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game_Screen game_Screen = new Game_Screen();
            this.Hide();
            game_Screen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HelpScreen helpScreen = new HelpScreen();
            helpScreen.Show();
        }

   
    }
}
