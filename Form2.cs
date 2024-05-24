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
    public partial class Form2 : Form
    {
        public static string op = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            op = "add";
            this.Hide();
            Form3 main = new Form3();
            main.Show();
        }

        private void butSub_Click(object sender, EventArgs e)
        {
            op = "sub";
            this.Hide();
            Form3 main = new Form3();
            main.Show();
        }

        private void butMult_Click(object sender, EventArgs e)
        {
            op = "mult";
            this.Hide();
            Form3 main = new Form3();
            main.Show();
        }

        private void butDiv_Click(object sender, EventArgs e)
        {
            op = "div";
            this.Hide();
            Form3 main = new Form3();
            main.Show();
        }
    }
}
