using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private double save;
         

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
            save = double.Parse(saving.Text);
            if (save >= Money || save >= 100)
            {
                MessageBox.Show("you cant save more than 100 \n" +
                    "it builds overtime as a safety");
            }
           
            if (Money < 100)
            {
                MessageBox.Show("you should really get a job or something");
            }

            //free spend
            Money = Money * 0.15;
            
             Money = Math.Round(Money, 2);
            freespend.Text = Money.ToString();
            
            //MessageBox.Show(Money.ToString());
                Money = double.Parse(income.Text) - Money;
            
            //groceries
            Money = Money * 0.50;
            Money = Math.Round(Money, 2);
            grocery.Text = Money.ToString();
            
            
            //necessities
            Money = double.Parse(income.Text) - Money;


            Money = Money * 0.25;
            Money = Math.Round(Money, 2);
            necessities.Text = Money.ToString();

            //limited money
            Money = double.Parse(income.Text) - Money;
           
            Money = Money * 0.20;

            Money = Math.Round(Money, 2);
            Limit.Text = Money.ToString();
            
        }

        private void weekMath()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] quotes = new string[] { 
                "Do not save what is left after spending, but spend what is left after saving. – Warren Buffett",
                "The price of anything is the amount of life you exchange for it. – Henry David Thoreau",
                "A budget is telling your money where to go instead of wondering where it went. – John C. Maxwell",
                "You must gain control over your money or the lack of it will forever control you. – Dave Ramsey",
                "Never spend your money before you have it. – Thomas Jefferson",
                "If we command our wealth, we shall be rich and free. If our wealth commands us, we are poor indeed. – Edmund Burke",};
            Random rng = new Random();
            int index = rng.Next(quotes.Length);
            moneyTip.Text = $"{quotes[index]}";
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

        private void DBSchema_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);

            try
            {
                conn.Open();
                MessageBox.Show("Connection passed");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                conn.Close();
            }
        }
    }
}
