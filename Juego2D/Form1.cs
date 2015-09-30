using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego2D
{
    public partial class Form1 : Form
    {

        private Game game;

        public Form1()
        {
            InitializeComponent();
            game = new Game();
        }

        private void buttonExitGame_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.Show();
        }

        private void botonJugar_Click(object sender, EventArgs e)
        {
            GameForm formGameScreen = new GameForm();
            formGameScreen.Show();
        }
    }
}
