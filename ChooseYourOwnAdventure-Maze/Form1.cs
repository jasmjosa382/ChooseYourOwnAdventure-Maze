using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

//Jasmine Josan
//October 2022
//Choose your own adventure halloween maze game

namespace ChooseYourOwnAdventure_Maze
{
    public partial class Form1 : Form
    {
        int page = 1;
        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "You're lost in a maze on Friday the 13th.  Be careful there's dangerous entities around.";
            option1Label.Text = "Go Left";
            option2Label.Text = "Go Right";
            option3Label.Text = "Go Straight";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 7)
            {
                Random randGen = new Random();
                int chance = randGen.Next(1, 101);

                if (chance < 50)
                {
                    page = 12;
                }
                else
                {
                    page = 13;
                }
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 8)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 1)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 1)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 3)
            {
                page = 19;
            }
            else if (page == 19)
            {
                page = 1;
            }


            switch (page)
            {
                case 1:
                    outputLabel.Text = "You're lost in a maze on Friday the 13th.  Be careful there's dangerous entities around.";
                    option1Label.Text = "Go Left";
                    option2Label.Text = "Go Right";
                    option3Label.Text = "Go Straight";
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    imageBox.Image = Properties.Resources.Maze;
                    break;
                case 2:
                    outputLabel.Text = "You've come across a cabin. Do you enter?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    imageBox.Image = Properties.Resources.Cabin;
                    break;
                case 3:
                    outputLabel.Text = "You come across 2 paths one with  a creepy clown and the other with zombies.\r\nWhich path do you choose?";
                    option1Label.Text = "Clown";
                    option2Label.Text = "Zombies";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    //imageBox.Image = Properties.Resources.TwoWayPath;

                    break;
                case 4:
                    outputLabel.Text = "You come across a big pond. The only way to cross is by canoe or jetski. What do you choose?";
                    option1Label.Text = "Jetski";
                    option2Label.Text = "Canoe";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 5:
                    outputLabel.Text = "You're pushed down the stairs by some ghosts while searching for supplies and die. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 6:
                    outputLabel.Text = "A dark figure stands a few feet away from you. Oh no, It's Michael Myers! Do you try to fight him off or run away? ";
                    option1Label.Text = "Run";
                    option2Label.Text = "Fight";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 7:
                    outputLabel.Text = "Your leg cramps and you fall. You feel around for a weapon which one do you grab, number 1 or 2?";
                    option1Label.Text = "1";
                    option2Label.Text = "2";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 8:
                    outputLabel.Text = "You manage to disarm and knock him out! Would you like to switch clothes with him?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 9:
                    outputLabel.Text = "It's an axe! You manage to defend yourself and escape! Congratulations!!! Play Again?;";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 10:
                    outputLabel.Text = "Disguised as Michael you were able to ask his friend Freddy Kruger where the exit was and escaped!Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 11:
                    outputLabel.Text = "Unfortunately Michael's friend Freddy Kruger wasn't far behind and killed you instead. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 12:
                    outputLabel.Text = "It's broken plastic. You die from being stabbed in the back. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 13:
                    outputLabel.Text = "There's hole under some shrubs you crawl underneath before he can catch you.Congratulations you've escaped!! Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 14:
                    outputLabel.Text = "You awoke the Kraken!!! Pulled underwater by its tentacles, you were drowned. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 15:
                    outputLabel.Text = "You quietly crossed the river without problem. Quick! You hear a noise where do you hide?";
                    option1Label.Text = "Treehouse";
                    option2Label.Text = "Shrubs";
                    break;
                case 16:
                    outputLabel.Text = "It was Slender man! He saw you climbing up the ladder and used his \"Slender Sickness\" on you and killed you. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 17:
                    outputLabel.Text = "Slender man walks past. You quietly find your way out of the maze! You've escaped! Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 18:
                    outputLabel.Text = "The clown hands you a squirting flower except instead of water it squirts poison. Your dead. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 19:
                    outputLabel.Text = "You manage to run away but just as you let your guard down a zombie appears out of no where and bites you! You die from infection. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label. Visible = false;
                    break;
                case 20:
                    outputLabel.Text = "Thanks for playing! Have a spooky Halloween!";
                    option1Label.Text = "";
                    option2Label.Text = "";

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }

        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 2)
            {
                page = 6;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 20;
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 20;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                Random randGen = new Random();
                int chance = randGen.Next(1, 101);

                if (chance < 50)
                {
                    page = 12;
                }
                else
                {
                    page = 13;
                }
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 20;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 20;
            }
            else if (page == 12)
            {
                page = 20;
            }
            else if (page == 13)
            {
                page = 20;
            }
            else if (page == 14)
            {
                page = 20;
            }
            else if (page == 4)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 20;
            }
            else if (page == 16)
            {
                page = 20;
            }
            else if (page == 1)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 19;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 3)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 20;
            }




            switch (page)
            {
                case 1:
                    outputLabel.Text = "You're lost in a maze on Friday the 13th.  Be careful there's dangerous entities around.";
                    option1Label.Text = "Go Left";
                    option2Label.Text = "Go Right";
                    option3Label.Text = "Go Straight";
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    imageBox.Image = Properties.Resources.Maze;
                    break;
                case 2:
                    outputLabel.Text = "You've come across a cabin. Do you enter?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    imageBox.Image = Properties.Resources.Cabin;
                    break;
                case 3:
                    outputLabel.Text = "You come across 2 paths one with  a creepy clown and the other with zombies.\r\nWhich path do you choose?";
                    option1Label.Text = "Clown";
                    option2Label.Text = "Zombies";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                   //imageBox.Image = Properties.Resources.TwoWayPath;
                    break;
                case 4:
                    outputLabel.Text = "You come across a big pond. The only way to cross is by canoe or jetski. What do you choose?";
                    option1Label.Text = "Jetski";
                    option2Label.Text = "Canoe";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 5:
                    outputLabel.Text = "You're pushed down the stairs by some ghosts while searching for supplies and die. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 6:
                    outputLabel.Text = "A dark figure stands a few feet away from you. Oh no, It's Michael Myers! Do you try to fight him off or run away? ";
                    option1Label.Text = "Run";
                    option2Label.Text = "Fight";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 7:
                    outputLabel.Text = "Your leg cramps and you fall. You feel around for a weapon which one do you grab, number 1 or 2?";
                    option1Label.Text = "1";
                    option2Label.Text = "2";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 8:
                    outputLabel.Text = "You manage to disarm and knock him out! Would you like to switch clothes with him?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 9:
                    outputLabel.Text = "It's an axe! You manage to defend yourself and escape! Congratulations!!! Play Again?;";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 10:
                    outputLabel.Text = "Disguised as Michael you were able to ask his friend Freddy Kruger where the exit was and escaped!Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 11:
                    outputLabel.Text = "Unfortunately Michael's friend Freddy Kruger wasn't far behind and killed you instead. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 12:
                    outputLabel.Text = "It's broken plastic. You die from being stabbed in the back. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    break;
                case 13:
                    outputLabel.Text = "There's hole under some shrubs you crawl underneath before he can catch you. Congratulations you've escaped!! Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 14:
                    outputLabel.Text = "You awoke the Kraken!!! Pulled underwater by its tentacles, you were drowned. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 15:
                    outputLabel.Text = "You quietly crossed the river without problem. Quick! You hear a noise where do you hide?";
                    option1Label.Text = "Treehouse";
                    option2Label.Text = "Shrubs";
                    break;
                case 16:
                    outputLabel.Text = "It was Slender man! He saw you climbing up the ladder and used his \"Slender Sickness\" on you and killed you. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 17:
                    outputLabel.Text = "Slender man walks past. You quietly find your way out of the maze! You've escaped! Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 18:
                    outputLabel.Text = "The clown hands you a squirting flower except instead of water it squirts poison. Your dead. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 19:
                    outputLabel.Text = "You manage to run away but just as you let your guard down a zombie appears out of no where and bites you! You die from infection. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 20:
                    outputLabel.Text = "Thanks for playing! Have a spooky Halloween!";
                    option1Label.Text = "";
                    option2Label.Text = "";

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 4;
            }

            switch (page)
            {
                case 1:
                    outputLabel.Text = "You're lost in a maze on Friday the 13th.  Be careful there's dangerous entities around.";
                    option1Label.Text = "Go Left";
                    option2Label.Text = "Go Right";
                    option3Label.Text = "Go Straight";
                    imageBox.Image = Properties.Resources.Maze;
                    break;
                case 2:
                    outputLabel.Text = "You've come across a cabin. Do you enter?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.Cabin;
                    break;
                case 3:
                    outputLabel.Text = "You come across 2 paths one with  a creepy clown and the other with zombies.\r\nWhich path do you choose?";
                    option1Label.Text = "Clown";
                    option2Label.Text = "Zombies";
                  //imageBox.Image = Properties.Resources.TwoWayPath;
                    break;
                case 4:
                    outputLabel.Text = "You come across a big pond. The only way to cross is by canoe or jetski. What do you choose?";
                    option1Label.Text = "Jetski";
                    option2Label.Text = "Canoe";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 5:
                    outputLabel.Text = "You're pushed down the stairs by some ghosts while searching for supplies and die. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 6:
                    outputLabel.Text = "A dark figure stands a few feet away from you. Oh no, It's Michael Myers! Do you try to fight him off or run away? ";
                    option1Label.Text = "Run";
                    option2Label.Text = "Fight";
                    break;
                case 7:
                    outputLabel.Text = "Your leg cramps and you fall. You feel around for a weapon which one do you grab, number 1 or 2?";
                    option1Label.Text = "1";
                    option2Label.Text = "2";
                    break;
                case 8:
                    outputLabel.Text = "You manage to disarm and knock him out! Would you like to switch clothes with him?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 9:
                    outputLabel.Text = "It's an axe! You manage to defend yourself and escape! Congratulations!!! Play Again?;";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 10:
                    outputLabel.Text = "Disguised as Michael you were able to ask his friend Freddy Kruger where the exit was and escaped!Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 11:
                    outputLabel.Text = "Unfortunately Michael's friend Freddy Kruger wasn't far behind and killed you instead. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 12:
                    outputLabel.Text = "It's broken plastic. You die from being stabbed in the back. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 13:
                    outputLabel.Text = "There's hole under some shrubs you crawl underneath before he can catch you. Congratulations you've escaped!! Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 14:
                    outputLabel.Text = "You awoke the Kraken!!! Pulled underwater by its tentacles, you were drowned. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 15:
                    outputLabel.Text = "You quietly crossed the river without problem. Quick! You hear a noise where do you hide?";
                    option1Label.Text = "Treehouse";
                    option2Label.Text = "Shrubs";
                    break;
                case 16:
                    outputLabel.Text = "It was Slender man! He saw you climbing up the ladder and used his \"Slender Sickness\" on you and killed you. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 17:
                    outputLabel.Text = "Slender man walks past. You quietly find your way out of the maze! You've escaped! Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 18:
                    outputLabel.Text = "The clown hands you a squirting flower except instead of water it squirts poison. Your dead. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 19:
                    outputLabel.Text = "You manage to run away but just as you let your guard down a zombie appears out of no where and bites you! You die from infection. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 20:
                    outputLabel.Text = "Thanks for playing! Have a spooky Halloween!";
                    option1Label.Text = "";
                    option2Label.Text = "";

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
