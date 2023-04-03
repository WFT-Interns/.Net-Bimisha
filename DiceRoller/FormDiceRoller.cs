using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class FormDiceRoller : Form
    {
        Random dice = new Random();
        public FormDiceRoller()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            int randomNum1 = dice.Next(1, 6);
            Console.WriteLine(randomNum1);

            switch (randomNum1)
            {
                case 1:
                    picDice.ImageLocation = @"C:\Users\bimuu\Downloads\dice1.png";
                    picDice.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 2:
                    picDice.ImageLocation = @"C:\Users\bimuu\Downloads\dice2.png";
                    picDice.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 3:
                    picDice.ImageLocation = @"C:\Users\bimuu\Downloads\dice3.png";
                    picDice.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 4:
                    picDice.ImageLocation = @"C:\Users\bimuu\Downloads\dice4.png";
                    picDice.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 5:
                    picDice.ImageLocation = @"C:\Users\bimuu\Downloads\dice5.png";
                    picDice.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 6:
                    picDice.ImageLocation = @"C:\Users\bimuu\Downloads\dice6.png";
                    picDice.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                default:
                    break;
            }
        }
    }
}
