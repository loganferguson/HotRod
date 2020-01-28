using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotRod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
            button1.Visible = false;
        }

        // THIS IS THE TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            coins(gamespeed);
            coincollection();
            gameover();
        }

        // THIS IS AN OBJECT OF RANDOM CLASS - USED FOR THE ENEMY CARS
            Random r = new Random();
            int x;

        int collectedcoin = 0;
        private void coincollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoin++;
                coincount.Text = "Coins = " + collectedcoin.ToString();
                x = r.Next(0, 100);
                coin1.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoin++;
                coincount.Text = "Coins = " + collectedcoin.ToString();
                x = r.Next(100, 150);
                coin2.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoin++;
                coincount.Text = "Coins = " + collectedcoin.ToString();
                x = r.Next(150, 200);
                coin3.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoin++;
                coincount.Text = "Coins = " + collectedcoin.ToString();
                x = r.Next(200, 280);
                coin4.Location = new Point(x, 0);
            }
        }
        // COINS
        private void coins(int speed)
        {
        // COIN 1
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 100);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }
        // COIN 2
            if (coin2.Top >= 500)
            {
                x = r.Next(100, 150);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }
        // COIN 3
            if (coin3.Top >= 500)
            {
                x = r.Next(150, 200);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }
        // COIN 4
            if (coin4.Top >= 500)
            {
                x = r.Next(200, 280);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }
        }
        private void enemy(int speed)
        {
        // ENEMY CAR 1 RANDOM LOCATION

            if (enemy1.Top >= 500)
            {
                x = r.Next(0, 100);
                enemy1.Location = new Point(x, 0);
            }
                else
                {
                    enemy1.Top += speed;
                }
        //  ENEMY CAR 2 RANDOM LOCATION

            if (enemy2.Top >= 500)
            {
                x = r.Next(100, 150);
                enemy2.Location = new Point(x, 0);
                
            }
                else
                {
                    enemy2.Top += speed;
                }
        // ENEMY CAR 3 RANDOM LOCATION
            if (enemy3.Top >= 500)
            {
                x = r.Next(150, 250);
                enemy3.Location = new Point(x, 0);

            }
            else
            {
                enemy3.Top += speed;
            }
        }

        // GAMEOVER PARAMETER METHOD
        private void gameover()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                button1.Visible = true;
            }

            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                button1.Visible = true;
            }

            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                button1.Visible = true;
            }
        }

        // THESE ARE THE LINES ON THE ROAD
            private void moveline(int speed)
            {
                if (pictureBox1.Top >= 500)
                {
                    pictureBox1.Top = 0;
                }
                    else
                    {
                        pictureBox1.Top += speed;
                    }
                if (pictureBox2.Top >= 500)
                {
                    pictureBox2.Top = 0;
                }
                    else
                    {
                        pictureBox2.Top += speed;
                    }
                if (pictureBox3.Top >= 500)
                {
                    pictureBox3.Top = 0;
                }
                    else
                    {
                        pictureBox3.Top += speed;
                    }
                if (pictureBox4.Top >= 500)
                {
                    pictureBox4.Top = 0;
                }
                    else
                    {
                        pictureBox4.Top += speed;
                    }
                if (pictureBox7.Top >= 500)
                {
                    pictureBox7.Top = 0;
                }
                    else
                    {
                        pictureBox7.Top += speed;
                    }
   
            }

        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(car.Left > 9)
                {
                    car.Left += -10;
                }
                
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 280)
                {
                    car.Left += 10;
                }
                
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 5)
                {
                    gamespeed--;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
