
namespace PhilipSmith_Capstone_moneySave
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.income = new System.Windows.Forms.TextBox();
            this.saving = new System.Windows.Forms.TextBox();
            this.grocery = new System.Windows.Forms.TextBox();
            this.necessities = new System.Windows.Forms.TextBox();
            this.tuition = new System.Windows.Forms.TextBox();
            this.bills = new System.Windows.Forms.TextBox();
            this.freespend = new System.Windows.Forms.TextBox();
            this.totalSavings = new System.Windows.Forms.TextBox();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.rbWeek = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.moneyTip = new System.Windows.Forms.TextBox();
            this.Limit = new System.Windows.Forms.TextBox();
            this.TuitionAmount = new System.Windows.Forms.TextBox();
            this.BillAmount = new System.Windows.Forms.TextBox();
            this.DBSchema = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lpay = new System.Windows.Forms.Label();
            this.Bpay = new System.Windows.Forms.Label();
            this.priorGrocery = new System.Windows.Forms.CheckBox();
            this.PriorNecess = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // income
            // 
            this.income.Location = new System.Drawing.Point(43, 46);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(116, 22);
            this.income.TabIndex = 0;
            this.income.Text = "0";
            this.income.TextChanged += new System.EventHandler(this.income_TextChanged);
            // 
            // saving
            // 
            this.saving.Location = new System.Drawing.Point(43, 90);
            this.saving.Name = "saving";
            this.saving.Size = new System.Drawing.Size(100, 22);
            this.saving.TabIndex = 1;
            this.saving.Text = "0";
            // 
            // grocery
            // 
            this.grocery.Location = new System.Drawing.Point(43, 159);
            this.grocery.Name = "grocery";
            this.grocery.ReadOnly = true;
            this.grocery.Size = new System.Drawing.Size(116, 22);
            this.grocery.TabIndex = 2;
            this.grocery.Text = "0";
            // 
            // necessities
            // 
            this.necessities.Location = new System.Drawing.Point(203, 159);
            this.necessities.Name = "necessities";
            this.necessities.ReadOnly = true;
            this.necessities.Size = new System.Drawing.Size(100, 22);
            this.necessities.TabIndex = 3;
            this.necessities.Text = "0";
            // 
            // tuition
            // 
            this.tuition.AccessibleDescription = "";
            this.tuition.Location = new System.Drawing.Point(43, 209);
            this.tuition.Name = "tuition";
            this.tuition.ReadOnly = true;
            this.tuition.Size = new System.Drawing.Size(100, 22);
            this.tuition.TabIndex = 4;
            this.tuition.Text = "0";
            this.tuition.Visible = false;
            // 
            // bills
            // 
            this.bills.Location = new System.Drawing.Point(203, 208);
            this.bills.Name = "bills";
            this.bills.ReadOnly = true;
            this.bills.Size = new System.Drawing.Size(100, 22);
            this.bills.TabIndex = 5;
            this.bills.Text = "0";
            this.bills.Visible = false;
            // 
            // freespend
            // 
            this.freespend.Location = new System.Drawing.Point(43, 274);
            this.freespend.Name = "freespend";
            this.freespend.ReadOnly = true;
            this.freespend.Size = new System.Drawing.Size(116, 22);
            this.freespend.TabIndex = 6;
            this.freespend.Text = "0";
            // 
            // totalSavings
            // 
            this.totalSavings.Location = new System.Drawing.Point(203, 274);
            this.totalSavings.Name = "totalSavings";
            this.totalSavings.ReadOnly = true;
            this.totalSavings.Size = new System.Drawing.Size(100, 22);
            this.totalSavings.TabIndex = 7;
            this.totalSavings.Text = "0";
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(474, 44);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(78, 21);
            this.rbMonth.TabIndex = 8;
            this.rbMonth.TabStop = true;
            this.rbMonth.Text = "Monthly";
            this.rbMonth.UseVisualStyleBackColor = true;
            // 
            // rbWeek
            // 
            this.rbWeek.AutoSize = true;
            this.rbWeek.Location = new System.Drawing.Point(474, 74);
            this.rbWeek.Name = "rbWeek";
            this.rbWeek.Size = new System.Drawing.Size(75, 21);
            this.rbWeek.TabIndex = 9;
            this.rbWeek.TabStop = true;
            this.rbWeek.Text = "Weekly";
            this.rbWeek.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(611, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 21);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Tuition";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(611, 76);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 21);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Bills";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Adjust";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // moneyTip
            // 
            this.moneyTip.Location = new System.Drawing.Point(474, 169);
            this.moneyTip.Multiline = true;
            this.moneyTip.Name = "moneyTip";
            this.moneyTip.ReadOnly = true;
            this.moneyTip.Size = new System.Drawing.Size(268, 152);
            this.moneyTip.TabIndex = 14;
            this.moneyTip.Text = "money tip";
            // 
            // Limit
            // 
            this.Limit.Location = new System.Drawing.Point(175, 337);
            this.Limit.Name = "Limit";
            this.Limit.ReadOnly = true;
            this.Limit.Size = new System.Drawing.Size(100, 22);
            this.Limit.TabIndex = 15;
            this.Limit.Text = "0";
            // 
            // TuitionAmount
            // 
            this.TuitionAmount.Location = new System.Drawing.Point(474, 121);
            this.TuitionAmount.Name = "TuitionAmount";
            this.TuitionAmount.Size = new System.Drawing.Size(100, 22);
            this.TuitionAmount.TabIndex = 16;
            this.TuitionAmount.Text = "0";
            this.TuitionAmount.Visible = false;
            this.TuitionAmount.TextChanged += new System.EventHandler(this.TuitionAmount_TextChanged);
            // 
            // BillAmount
            // 
            this.BillAmount.Location = new System.Drawing.Point(611, 120);
            this.BillAmount.Name = "BillAmount";
            this.BillAmount.Size = new System.Drawing.Size(100, 22);
            this.BillAmount.TabIndex = 17;
            this.BillAmount.Text = "0";
            this.BillAmount.Visible = false;
            // 
            // DBSchema
            // 
            this.DBSchema.Enabled = false;
            this.DBSchema.Location = new System.Drawing.Point(203, 415);
            this.DBSchema.Name = "DBSchema";
            this.DBSchema.Size = new System.Drawing.Size(99, 23);
            this.DBSchema.TabIndex = 18;
            this.DBSchema.Text = "Save To DB";
            this.DBSchema.UseVisualStyleBackColor = true;
            this.DBSchema.Visible = false;
            this.DBSchema.Click += new System.EventHandler(this.DBSchema_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Income";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "how much do you want to save?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Grocery";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Necessities";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "tuition";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "bills";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "free spend limit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "total savings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Spend Limit";
            // 
            // Lpay
            // 
            this.Lpay.AutoSize = true;
            this.Lpay.Location = new System.Drawing.Point(471, 101);
            this.Lpay.Name = "Lpay";
            this.Lpay.Size = new System.Drawing.Size(105, 17);
            this.Lpay.TabIndex = 29;
            this.Lpay.Text = "tuition Payment";
            this.Lpay.Visible = false;
            // 
            // Bpay
            // 
            this.Bpay.AutoSize = true;
            this.Bpay.Location = new System.Drawing.Point(608, 101);
            this.Bpay.Name = "Bpay";
            this.Bpay.Size = new System.Drawing.Size(84, 17);
            this.Bpay.TabIndex = 30;
            this.Bpay.Text = "Bill payment";
            this.Bpay.Visible = false;
            // 
            // priorGrocery
            // 
            this.priorGrocery.AutoSize = true;
            this.priorGrocery.Location = new System.Drawing.Point(43, 118);
            this.priorGrocery.Name = "priorGrocery";
            this.priorGrocery.Size = new System.Drawing.Size(84, 21);
            this.priorGrocery.TabIndex = 31;
            this.priorGrocery.Text = "prioritize";
            this.priorGrocery.UseVisualStyleBackColor = true;
            // 
            // PriorNecess
            // 
            this.PriorNecess.AutoSize = true;
            this.PriorNecess.Location = new System.Drawing.Point(203, 122);
            this.PriorNecess.Name = "PriorNecess";
            this.PriorNecess.Size = new System.Drawing.Size(84, 21);
            this.PriorNecess.TabIndex = 32;
            this.PriorNecess.Text = "prioritize";
            this.PriorNecess.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PriorNecess);
            this.Controls.Add(this.priorGrocery);
            this.Controls.Add(this.Bpay);
            this.Controls.Add(this.Lpay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DBSchema);
            this.Controls.Add(this.BillAmount);
            this.Controls.Add(this.TuitionAmount);
            this.Controls.Add(this.Limit);
            this.Controls.Add(this.moneyTip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.rbWeek);
            this.Controls.Add(this.rbMonth);
            this.Controls.Add(this.totalSavings);
            this.Controls.Add(this.freespend);
            this.Controls.Add(this.bills);
            this.Controls.Add(this.tuition);
            this.Controls.Add(this.necessities);
            this.Controls.Add(this.grocery);
            this.Controls.Add(this.saving);
            this.Controls.Add(this.income);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox income;
        private System.Windows.Forms.TextBox saving;
        private System.Windows.Forms.TextBox grocery;
        private System.Windows.Forms.TextBox necessities;
        private System.Windows.Forms.TextBox tuition;
        private System.Windows.Forms.TextBox bills;
        private System.Windows.Forms.TextBox freespend;
        private System.Windows.Forms.TextBox totalSavings;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.RadioButton rbWeek;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox moneyTip;
        private System.Windows.Forms.TextBox Limit;
        private System.Windows.Forms.TextBox TuitionAmount;
        private System.Windows.Forms.TextBox BillAmount;
        private System.Windows.Forms.Button DBSchema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lpay;
        private System.Windows.Forms.Label Bpay;
        private System.Windows.Forms.CheckBox priorGrocery;
        private System.Windows.Forms.CheckBox PriorNecess;
    }
}

