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
        private double save = 0;
        private double pain = 0;
        private double bill = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void income_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthMath()
        {
            //gives money a value to math with
            Money = double.Parse(income.Text);
            pain = double.Parse(TuitionAmount.Text);
            bill = double.Parse(BillAmount.Text);
            //tuition payment in box
            Money = Money - pain;
            tuition.Text = pain.ToString();
            //bills payment thrown into its box
            Money = Money - bill;
            bills.Text = bill.ToString();

            //check to make sure the user is not prioritizing both
           /* if(priorGrocery.Checked == true && PriorNecess.Checked == true)
            {
                MessageBox.Show("we cannot allow you to prioritize in both categories");
                System.Windows.Forms.Application.Exit();
            }
           */
           

            //apply savings
            save = double.Parse(saving.Text);
            if (save >= 100)
            {
                MessageBox.Show("you cant save more than 100 \n" +
                    "it builds overtime as a safety");
                System.Windows.Forms.Application.Restart();
                //System.Windows.Forms.Application.Exit();
                
            }
            else
            {
              double  saved =  Money - save;
             
            
            }
        
           
            if (Money < 100)
            {
                MessageBox.Show("you should really get a job or something");
                System.Windows.Forms.Application.Exit();
            }

            


            //free spend
             double free = Money * 0.15;
            
             free = Math.Round(free, 2);
            freespend.Text = free.ToString();
            
            //MessageBox.Show(Money.ToString());
                Money =  Money - free;

            //groceries
            double gros = 0;
            if (priorGrocery.Checked == false)
            {
                gros = Money * 0.50;
            }
            else
            {
                //placeholder
                gros = Money * 0.60 ;
            }
            gros = Math.Round(gros, 2);
            grocery.Text = gros.ToString();


            //necessities
            Money = Money - gros;
            double nec = 0;
            if(PriorNecess.Checked == false)
            {
               nec = Money * 0.25;
            }
            else
            {
                nec = Money * 0.35;
            }
            
            nec = Math.Round(nec, 2);
            necessities.Text = nec.ToString();

            //limited money
            Money = Money - nec;
           
             double lim = Money * 0.20;

            lim = Math.Round(lim, 2);
            Limit.Text = lim.ToString();

            //total value
            Money =  Money - lim;
            totalSavings.Text = Money.ToString();

            income.ReadOnly = true;
            saving.ReadOnly = true;
            TuitionAmount.ReadOnly = true;
            BillAmount.ReadOnly = true;
            DBSchema.Visible = true;
            DBSchema.Enabled = true;
            button1.Enabled = false;
            //confirmBtn.Enabled = false;
            
        }
        private void weekMath()
        {
            //set money values 
            Money = double.Parse(income.Text);
            save = double.Parse(saving.Text);

            if (save >= 50)
            {
                MessageBox.Show("you cant save more than 50 per week \n" +
                    "its more efficient to pick this over month that weekly");
                System.Windows.Forms.Application.Restart();

            }
            else
            {
                double saved = Money - save;


            }
            //groceries
            double gros = 0;
            if (priorGrocery.Checked == false)
            {
                gros = Money * 0.15;
            }
            else
            {
                //placeholder
                gros = Money * 0.20;
            }
            gros = Math.Round(gros, 2);
            grocery.Text = gros.ToString();
            Money = Money - gros;

            //necessities
            double nec = 0;
            if (PriorNecess.Checked == false)
            {
                nec = Money * 0.06;
            }
            else
            {
                nec = Money * 0.10;
            }

            nec = Math.Round(nec, 2);
            necessities.Text = nec.ToString();
            Money = Money - nec;

            //total

            totalSavings.Text = Money.ToString();

            //after math values 
            income.ReadOnly = true;
            saving.ReadOnly = true;
            DBSchema.Visible = true;
            DBSchema.Enabled = true;
            button1.Enabled = false;
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
            //string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True";
            string test = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Philip Smith\source\repos\PhilipSmith-Capstone-moneySave\PhilipSmith-Capstone-moneySave\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(test);
            SqlCommand cmd = new SqlCommand("insert into MoneyData" +
                "(Income, Grocery, necesities, freespend, limit, tuition, bills, totalSavings, Saving)" +
                "values(@Income, @Grocery, @necessities, @freespend, @limit, @tuition, @bills, @totalSavings, @Saving)", conn);

            conn.Open();
            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Income", income.Text);
            cmd.Parameters.AddWithValue("@Grocery", grocery.Text);
            cmd.Parameters.AddWithValue("@necessities", necessities.Text);
            cmd.Parameters.AddWithValue("@freespend", freespend.Text);
            cmd.Parameters.AddWithValue("@limit", Limit.Text);
            cmd.Parameters.AddWithValue("@tuition", tuition.Text);
            cmd.Parameters.AddWithValue("@bills", bills.Text);
            cmd.Parameters.AddWithValue("@totalSavings", totalSavings.Text);
            cmd.Parameters.AddWithValue("@Saving", saving.Text);
            
            int i = cmd.ExecuteNonQuery();
            //conn.Close();
            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
            }
            else
            {
                //pain
                MessageBox.Show("Unable to obtain");
            }
        }

       
        private void TuitionAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                TuitionAmount.Visible = true;
                Lpay.Visible = true;
                label5.Visible = true;
                tuition.Visible = true;
            }
            else
            {
                TuitionAmount.Visible = false;
                Lpay.Visible = false;
                label5.Visible = false;
                tuition.Visible = false;
                TuitionAmount.Text = pain.ToString();
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                BillAmount.Visible = true;
                Bpay.Visible = true;
                label6.Visible = true;
                bills.Visible = true;
            }
            else
            {
                BillAmount.Visible = false;
                Bpay.Visible = false;
                label6.Visible = false;
                bills.Visible = false;

                BillAmount.Text = bill.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            income.ReadOnly = false;
            saving.ReadOnly = false;
            TuitionAmount.ReadOnly = false;
            BillAmount.ReadOnly = false;
            DBSchema.Visible = false;
            DBSchema.Enabled = false;
            button1.Enabled = true;

            income.Text = 0.ToString();
            TuitionAmount.Text = 0.ToString();
            BillAmount.Text = 0.ToString();
            grocery.Text = 0.ToString();
            necessities.Text = 0.ToString();
            freespend.Text = 0.ToString();
            Limit.Text = 0.ToString();
            totalSavings.Text = 0.ToString();
            tuition.Text = 0.ToString();
            bills.Text = 0.ToString();
        }

        private void rbWeek_CheckedChanged(object sender, EventArgs e)
        {
            savingWeek.Visible = true;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            saving.Visible = false;
            freespend.Visible = false;
            label7.Visible = false;
            Limit.Visible = false;
            label9.Visible = false;
        }

        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            savingWeek.Visible = false;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            saving.Visible = true;
        }

        private void priorGrocery_CheckedChanged(object sender, EventArgs e)
        {
           
            if(priorGrocery.Checked == false)
            {
                PriorNecess.Visible = true;
            }
            else
            {
                PriorNecess.Visible = false;
            }
        }

        private void PriorNecess_CheckedChanged(object sender, EventArgs e)
        {
           
            if(PriorNecess.Checked == false)
            {
                priorGrocery.Visible = true;
            }
            else
            {
                priorGrocery.Visible = false;
            }
        }

        private void savingWeek_CheckedChanged(object sender, EventArgs e)
        {
            if(savingWeek.Checked == true)
            {
                saving.Visible = true;
            }
            else
            {
                saving.Visible = false;
            }
        }
    }
}
