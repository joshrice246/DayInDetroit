﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayInDetroit
{
    public partial class Form1 : Form
    {
        int page = 1;
        public Form1()
        {

            InitializeComponent();

            outputLabel.Text = "you wake up in an dark and grimy alley.. you hear music do you go towards it or go towards the brightly lit streets";
            option1Label.Text = "streets";
            option2Label.Text = "music";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void option2Button_Click(object sender, EventArgs e)
        { }

        private void option1Button_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (page == 1)
                {
                    page = 2;
                }
                else if (page == 2)
                {
                    page = 4;
                }
                else if (page == 3)
                {
                    page = 5;
                }
                else if (page == 4)
                {
                    page = 99;
                }
                else if (page == 5)
                {
                    page = 99;
                }
                else if (page == 9)
                {
                    page = 10;
                }
                else if (page == 10)
                {
                    page = 99;
                }
                displayPage();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 7;
            }
            else if (page == 3)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 7)
            {
                Random randGen = new Random();
                int randomval = randGen.Next(1, 101);

                if (randomval > 50)
                {
                    page = 8;
                }
                else
                {
                    page = 9;
                }
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 99;
            }
            displayPage();
        }




        public void displayPage()
        {

            switch (page)
            {
                case 1:
                    outputLabel.Text = "you wake up in an dark and grimy alley.. you hear music do you go towards it or go towards the brightly lit streets";
                    option1Label.Text = "streets";
                    option2Label.Text = "music";
                    break;
                case 2:
                    outputLabel.Text = "you see a group of men wearing all black near by a speaker, will you walk away or go and talk to the most likely friendly men";
                    option1Label.Text = "walk";
                    option2Label.Text = "talk";
                    break;
                case 3:
                    outputLabel.Text = "a group of men wearing all black sees you walking towards the streets and presses you for your shoes.";
                    option1Label.Text = "give in";
                    option2Label.Text = "run";
                    break;
                case 4:
                    outputLabel.Text = "you hear loud rattling as you run away, you decide to turn around and you see a large cannon being lit by the group of men ...BANG";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    break;
                case 5:
                    outputLabel.Text = "you step on glass and die";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    break;
                case 6:
                    outputLabel.Text = "you run as fast as possible and trip, they surround you and light a comically large stick of tnt at your feet.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "you walk up to them and ask them where you are, you also notice a large cival war era cannon and wondered what it was for";

                    break;
                case 8:
                    outputLabel.Text = "they take it as an insult and rob you for all your clothes";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "they tell you it doesnt matter where you are...they ask you if you want to join them will you?";
                    option1Label.Text = "yes";
                    option2Label.Text = "no";
                    break;
                case 10:
                    outputLabel.Text = "you rob a bank with the men you just joined and gain a sizable amount of money,freedom";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "you say no and start walking away, you hear them chase after you, you run for your life and barely escape them, as you walk down the brightly lit streets you see a car roll up next to you, its the men from earlier.....you hear a gun being racked back BANG";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    break;
                case 12:
                    outputLabel.Text = "you lose and get stabbed";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    break;
                case 99:
                    outputLabel.Text = "thanks wasting your time";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    break;
                default:
                    break;
            }

        }

        private void option2Label_Click(object sender, EventArgs e)
        {

        }

        private void option1Label_Click(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
               if (page == 12)
            {
                page = 99;
            }
            displayPage();
        }
    }
}


      