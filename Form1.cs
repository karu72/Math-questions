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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int diff;

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butDiff1_Click(object sender, EventArgs e)
        {
            diff = 1;
            this.Hide();
            Form2 operators = new Form2();
            operators.Show();
        }

        private void butDiff2_Click(object sender, EventArgs e)
        {
            diff = 2;
            this.Hide();
            Form2 operators = new Form2();
            operators.Show();
        }

        private void butDiff3_Click(object sender, EventArgs e)
        {
            diff = 3;
            this.Hide();
            Form2 operators = new Form2();
            operators.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Form3.answers > 1)
            {
                if (Form3.right_answers == 1)
                {
                    labRes.Text = Form3.right_answers + " no " + Form3.answers + " atbildēm bija pareiza!";
                } else
                {
                    labRes.Text = Form3.right_answers + " no " + Form3.answers + " atbildēm bija pareizas!";
                }
                labRes.Show();
            }
            Form3.answers = 0;
            Form3.right_answers = 0;
        }
    }
}
