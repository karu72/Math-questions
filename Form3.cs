using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rand_Math_Questions
{
    public partial class Form3 : Form
    {
        Random rnd = new Random();
        private int answer;
        public static int answers;
        public static int right_answers;

        public Form3()
        {
            InitializeComponent();
        }

        bool isPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; (i * i) <= number; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            answer = 0;
            butReroll.Hide();
            butBack.Hide();
            labClick.Hide();
            switch (Form2.op)
            {
                case "add":
                    labOpp.Text = "+";
                    switch (Form1.diff)
                    {
                        case 1:
                            x = rnd.Next(2, 20);
                            y = rnd.Next(2, 20);
                            break;
                        case 2:
                            x = rnd.Next(25, 75);
                            y = rnd.Next(25, 75);
                            break;
                        case 3:
                            x = rnd.Next(75, 200);
                            y = rnd.Next(75, 200);
                            break;
                    }
                    answer = x + y;

                    labX.Text = x.ToString();
                    labY.Text = y.ToString();
                    break;

                case "sub":
                    labOpp.Text = "-";
                    switch (Form1.diff)
                    {
                        case 1:
                            x = rnd.Next(3, 30);
                            do
                            {
                                y = rnd.Next(2, 30);
                            } while (y >= x);
                            break;
                        case 2:
                            x = rnd.Next(50, 100);
                            do
                            {
                                y = rnd.Next(25, 75);
                            } while (y >= x);
                            break;
                        case 3:
                            x = rnd.Next(100, 200);
                            do
                            {
                                y = rnd.Next(50, 100);
                            } while (y >= x);
                            break;
                    }
                    answer = x - y;

                    labX.Text = x.ToString();
                    labY.Text = y.ToString();
                    break;

                case "mult":
                    labOpp.Text = "*";
                    switch (Form1.diff)
                    {
                        case 1:
                            x = rnd.Next(2, 9);
                            y = rnd.Next(2, 9);
                            break;
                        case 2:
                            x = rnd.Next(8, 16);
                            y = rnd.Next(8, 16);
                            break;
                        case 3:
                            x = rnd.Next(12, 24);
                            y = rnd.Next(12, 24);
                            break;
                    }
                    answer = x * y;

                    labX.Text = x.ToString();
                    labY.Text = y.ToString();
                    break;

                case "div":
                    labOpp.Text = "/";
                    switch (Form1.diff)
                    {
                        case 1:
                            do
                            {
                                x = rnd.Next(4, 100);
                            } while (isPrime(x));
                            do
                            {
                                y = rnd.Next(2, 50);
                            } while (y == x || x % y != 0);
                            break;
                        case 2:
                            do
                            {
                                x = rnd.Next(100, 225);
                            } while (isPrime(x));
                            do
                            {
                                y = rnd.Next(2, 40);
                            } while (y == x || x % y != 0);
                            break;
                        case 3:
                            do
                            {
                                x = rnd.Next(196, 392);
                            } while (isPrime(x));
                            do
                            {
                                y = rnd.Next(2, 30);
                            } while (y == x || x % y != 0);
                            break;
                    }
                    answer = x / y;

                    labX.Text = x.ToString();
                    labY.Text = y.ToString();
                    break;
            }


        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 start = new Form1();
            start.Show();
        }

        private void butSubmit_Click(object sender, EventArgs e)
        {
            if (txtAns.Text == answer.ToString())
            {
                answers++;
                right_answers++;

                labAns.Show();
                labAns.Text = txtAns.Text;
                labAns.BackColor = Color.Lime;
                txtAns.Hide();
            }
            else
            {
                answers++;

                labAns.Show();
                labAns.Text = txtAns.Text;
                labAns.BackColor = Color.Red;
                txtAns.Hide();
                labClick.Show();
            }

            txtAns.ReadOnly = true;

            butSubmit.Hide();
            butBack.Show();
            butReroll.Show();
        }

        private void butReroll_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 main = new Form3();
            main.Show();
        }

        private void labAns_Click(object sender, EventArgs e)
        {
            if (labAns.BackColor == Color.Red)
            {
                labAns.Text = answer.ToString();
                labAns.BackColor = Color.Lime;
            }
        }
    }
}
