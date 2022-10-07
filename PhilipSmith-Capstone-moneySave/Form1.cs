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
