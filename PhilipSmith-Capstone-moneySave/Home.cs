using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PhilipSmith_Capstone_moneySave
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Name is Philip Smith and I aspire to learn all that there is to C# and all its components im not good at most languages but this project is a test of feats that can be accomplished from databases to math logic which are my 2 weaknesses right now");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I created this application because I have always had a bad habit of spending too much money before next pay to me and all the 70% of Americans who suffer from bad spending habits I believe if I can show what you should spend in and nothing more things should run smoothly");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
