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
    public partial class Form1 : Form
    {
        private double Money;

        public Form1()
        {
            InitializeComponent();
        }

        private void income_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthMath()
        {
            Money = double.Parse(income.Text);
            if (Money < 100)
            {
                MessageBox.Show("you should really get a job or something");
            }

            //free spend
            double f = 0;
            f = Money * 0.15;
            Math.Ceiling(f);
            freespend.Text = f.ToString();
            
            //MessageBox.Show(Money.ToString());
                Money = double.Parse(income.Text) - Money;
            
            //groceries
            Money = Money * 0.25;
                grocery.Text = Money.ToString();
            Math.Ceiling(Money);
            //necessities
            Money = double.Parse(income.Text) - Money;


            Money = Money * 0.25;
            necessities.Text = Money.ToString();

            //limited money
            Money = double.Parse(income.Text) - Money;
           
            Money = Money * 0.20;
            
            
            Limit.Text = Money.ToString();
            
        }

        private void weekMath()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rbMonth.Checked){
                monthMath();
            }else if (rbWeek.Checked)
            {
                weekMath();
            }
            else
            {
                MessageBox.Show("we cant do anything without either monthly or weekly spending");
            }
        }
    }
}
