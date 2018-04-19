//Text Adventure Game
//Astoria Buzek
//April 19th 2018

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

namespace ThirdSummative
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;

        // random number generator
        Random randGen = new Random();

        //Sound player
        SoundPlayer player = new SoundPlayer(Properties.Resources.CatMeow);
        SoundPlayer player2 = new SoundPlayer(Properties.Resources.AngryCat);
        SoundPlayer player3 = new SoundPlayer(Properties.Resources.WeddingBells);
        SoundPlayer player4 = new SoundPlayer(Properties.Resources.Crying);

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
            pictureBox4.BackgroundImage = Properties.Resources.cat;
            outputLabel.Text = "You are walking to work and you come across a cat. Do you pet the cat?";
            redLabel.Text = "Yes";
            blueLabel.Text = "No";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.R)       //red button press
            {
                if (scene == 0)
                {
                    int randomValue = randGen.Next(1, 101);

                    if (randomValue <= 85)
                    {
                        scene = 1;
                    }
                    else
                    {
                        scene = 2;
                    }
                }
                else if (scene == 1)
                {
                    scene = 0;
                }
                else if (scene == 2)
                {
                    scene = 0;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 7;
                }
                else if (scene == 6)
                {
                    scene = 8;
                }
                else if (scene == 7)
                {
                    scene = 0;
                }
                else if (scene == 8)
                {
                    //pictureBox1.BackgroundImage = Properties.Resources.RedButton;
                    scene = 25;

    
                    
                }
                else if (scene == 9)
                {
                    scene = 0;
                }
                else if (scene == 10)
                {
                    scene = 0;
                }
                else if (scene == 11)
                {
                    scene = 0;
                }
                else if (scene == 12)
                {
                    scene = 0;
                }
                else if (scene == 25)
                {
                scene = 13;
                }
                else if (scene == 13)
                {
                    scene = 16;
                }
                else if (scene == 14)
                {
                    scene = 0;
                }
                else if (scene == 15)
                {
                    scene = 0;
                }
                else if (scene == 16)
                {
                    scene = 20;
                }
                else if (scene == 18)
                {
                    scene = 0;
                }
                else if (scene == 19)
                {
                    scene = 0;
                }
                else if (scene == 20)
                {
                    scene = 21;
                }
                else if (scene == 21)
                {
                    scene = 0;
                }
                else if (scene == 22)
                {
                    scene = 0;
                }
                else if (scene == 23)
                {
                    scene = 0;
                }
                else if (scene == 24)
                {
                    scene = 0;
                }
            }
            else if (e.KeyCode == Keys.B)    //Blue button press
            {
                if (scene == 0)
                {
                    scene = 4;
                }
                else if (scene == 1)
                {
                    scene = 26;
                }
                else if (scene == 2)
                {
                    scene = 26;
                }
                else if (scene == 4)
                {
                    scene = 6;
                }
                else if (scene == 5)
                {
                    outputLabel.Text = "Do you leave right away or stay around?";
                    Refresh();
                    if (e.KeyCode == Keys.R)
                    {
                        scene = 9;
                    }
                    else if (e.KeyCode == Keys.B)
                    {
                        scene = 11;
                    }
                }
                else if (scene == 6)
                {
                    scene = 10;
                }
                else if (scene == 7)
                {
                    scene = 26;
                }
                else if (scene == 8)
                {
                    scene = 12;
                }
                else if (scene == 9)
                {
                    scene = 26;
                }
                else if (scene == 10)
                {
                    scene = 26;
                }
                else if (scene == 11)
                {
                    scene = 26;
                }
                else if (scene == 12)
                {
                    scene = 26;
                }
                else if (scene == 25)
                {
                    int randomValue2 = randGen.Next(1, 101);

                    if (randomValue2 <= 50)
                    {
                        scene = 13;
                    }
                    else if (randomValue2 > 50)
                    {
                        scene = 14;
                    }
                }
                else if (scene == 13)
                {
                    scene = 15;
                }
                else if (scene == 14)
                {
                    scene = 26;
                }
                else if (scene == 15)
                {
                    scene = 26;
                }
                else if (scene == 16)
                {
                    scene = 19;
                }
                else if (scene == 17)
                {
                    scene = 26;
                }
                else if (scene == 18)
                {
                    scene = 26;
                }
                else if (scene == 19)
                {
                    scene = 26;
                }
                else if (scene == 20)
                {
                    scene = 22;
                }
                else if (scene == 21)
                {
                    scene = 26;
                }
                else if (scene == 22)
                {
                    scene = 26;
                }
                else if (scene == 23)
                {
                    scene = 26;
                }
                else if (scene == 24)
                {
                    scene = 26;
                }
            }
            else if (e.KeyCode == Keys.G)     //Green button press
            {
                if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 20)
                {
                    outputLabel.Text = "What do you do?";
                    redLabel.Text = "Take the bus home";
                    blueLabel.Text = "Walk home";
                    greenLabel.Text = "";
                    if (e.KeyCode == Keys.R)
                    {
                        scene = 23;
                    }
                    else if (e.KeyCode == Keys.B)
                    {
                        scene = 24;
                    }
                }
            }


            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene
                    pictureBox4.BackgroundImage = Properties.Resources.cat;
                    player.Play();
                    outputLabel.Text = "You are walking to work and you come across a cat. Do you pet the cat?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    player.Stop();
                    break;
                case 1:
                    pictureBox4.BackgroundImage = Properties.Resources.dead;
                    player2.Play();
                    Refresh();
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    outputLabel.Text = "You contracted a deadly disease from the cats and die. Would you like to play again?";
                    player2.Stop();
                    break;
                case 2:
                    pictureBox4.BackgroundImage = Properties.Resources.work;
                    Refresh();
                    outputLabel.Text = "You continue on and reach work succesfully, would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 4:
                    pictureBox4.BackgroundImage = Properties.Resources.CatGroupPng;
                    Refresh();
                    outputLabel.Text = "You continue walking, suddenly a large group of cats appears in front of you";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    outputLabel.Refresh();
                    Thread.Sleep(5000);
                    outputLabel.Text = "What do you do?";
                    redLabel.Text = "Go see the cats";
                    blueLabel.Text = "Run";
                    break;
                case 5:
                    pictureBox4.BackgroundImage = Properties.Resources.kingdom;
                    Refresh();
                    outputLabel.Text = "You go to the cats and they take you to their cat kingdom.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    outputLabel.Refresh();
                    Thread.Sleep(5000);
                    outputLabel.Text = "They ask you to become their leader, what do you decide?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 6:
                    pictureBox4.BackgroundImage = Properties.Resources.bike;
                    Refresh();
                    player2.Play();
                    outputLabel.Text = "The cats begin to chase you, someone rides by on a bike and offers for you to hop on.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    outputLabel.Refresh();
                    Thread.Sleep(6000);
                    outputLabel.Text = "Do you get on the bike?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    player2.Stop();
                    break;
                case 7:
                    pictureBox4.BackgroundImage = Properties.Resources.royalty;
                    Refresh();
                    outputLabel.Text = "You say yes and live with them as their leader. Would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 8:
                    pictureBox4.BackgroundImage = Properties.Resources.person;
                    Refresh();
                    outputLabel.Text = "You ride to safety but have already missed your shift for work.The stranger asks if you want to get something to eat.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    outputLabel.Refresh();
                    Thread.Sleep(8000);
                    outputLabel.Text = "Do you get something to eat?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 9:
                    pictureBox4.BackgroundImage = Properties.Resources.sacrafice;
                    Refresh();
                    outputLabel.Text = "The cats sacrafice you to their gods. Would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 10:
                    pictureBox4.BackgroundImage = Properties.Resources.hostage;
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    outputLabel.Text = "The cats kidnap you and take you hostage. Would you like to play again?";
                    break;
                case 11:
                    pictureBox4.BackgroundImage = Properties.Resources.house;
                    outputLabel.Text = "You return home safely. Would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 12:
                    pictureBox4.BackgroundImage = Properties.Resources.cab;
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    outputLabel.Text = "You politely turn down the offer and get a cab home. Would you like to play again?";
                    break;
                case 13:
                    pictureBox4.BackgroundImage = Properties.Resources.yay;
                    outputLabel.Text = "Your meal goes great!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    outputLabel.Refresh();
                    Thread.Sleep(5000);
                    outputLabel.Text = "What do you do next?";
                    redLabel.Text = "Decide to go skating";
                    blueLabel.Text = "Exchange numbers";
                    break;
                case 14:
                    pictureBox4.BackgroundImage = Properties.Resources.cry;
                    player4.Play();
                    outputLabel.Text = "You spill your pasta all over yourself and run home crying. Would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    player4.Stop();
                    break;
                case 15:
                    pictureBox4.BackgroundImage = Properties.Resources.phone;
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    outputLabel.Text = "You wait to hear from him... but he never calls. Would you like to play again?";
                    break;
                case 16:
                    pictureBox4.BackgroundImage = Properties.Resources.propose;
                    outputLabel.Text = "You spend the evening having a great time and realize you have met your soulmate!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    outputLabel.Refresh();
                    Thread.Sleep(7000);
                    outputLabel.Text = "A few days later they propose!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    outputLabel.Refresh();
                    Thread.Sleep(5000);
                    outputLabel.Text = "What do you say?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "Of course!!!!";
                    break;
                //case 17:
                //    outputLabel.Text = "A few days later the propose!";
                //    redLabel.Text = "";
                //    blueLabel.Text = "";
                //    outputLabel.Refresh();
                //    Thread.Sleep(5000);
                //    outputLabel.Text = "What do you say?";
                //    redLabel.Text = "Yes";
                //    blueLabel.Text = "No";
                //    greenLabel.Text = "Of course!!!!";
                //    break;
                case 18:
                    pictureBox4.BackgroundImage = Properties.Resources.honeymoon;
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    outputLabel.Text = "You elope and have a honeymoon in Mexico! Would you like to play again?";
                    break;
                case 19:
                    pictureBox4.BackgroundImage = Properties.Resources.lonely;
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    outputLabel.Text = "You both die of loneliness. Would you like to play again?";
                    break;
                case 20:
                    pictureBox4.BackgroundImage = Properties.Resources.wedding;
                    player3.Play();
                    outputLabel.Text = "The day of the ceremony comes...";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    outputLabel.Refresh();
                    Thread.Sleep(5000);
                    outputLabel.Text = "Do you follow through?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No, you tell them you are already married.";
                    greenLabel.Text = "Run away";
                    player3.Stop();
                    break;
                case 21:
                    pictureBox4.BackgroundImage = Properties.Resources.wedding;
                    player3.Play();
                    outputLabel.Text = "You both get married and live happily ever after! Would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    player3.Stop();
                    break;
                case 22:
                    pictureBox4.BackgroundImage = Properties.Resources.airplane;
                    outputLabel.Text = "You flee the country and move to Australia. Would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    break;
                case 23:
                    pictureBox4.BackgroundImage = Properties.Resources.cat;
                    player.Play();
                    outputLabel.Text = "You get home safely and live with your own pet cat. Would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    player.Stop();
                    break;
                case 24:
                    pictureBox4.BackgroundImage = Properties.Resources.CatGroupPng;
                    player2.Play();
                    outputLabel.Text = "You get attacked by the same group of cats as before and kidnapped. Would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    player2.Stop();
                    break;
                case 25:
                    pictureBox4.BackgroundImage = Properties.Resources.food;
                    outputLabel.Text = "What do you get to eat?";
                    redLabel.Text = "Salad";
                    blueLabel.Text = "Pasta";
                    break;
                case 26:
                    this.BringToFront();
                    this.BackColor = Color.Black;
                    break;
                 
            }
        }


    }
}



    
