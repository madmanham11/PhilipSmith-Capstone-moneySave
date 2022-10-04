
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
            this.SuspendLayout();
            // 
            // income
            // 
            this.income.Location = new System.Drawing.Point(43, 46);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(116, 22);
            this.income.TabIndex = 0;
            this.income.Text = "income(monthly)";
            this.income.TextChanged += new System.EventHandler(this.income_TextChanged);
            // 
            // saving
            // 
            this.saving.Location = new System.Drawing.Point(43, 74);
            this.saving.Name = "saving";
            this.saving.Size = new System.Drawing.Size(100, 22);
            this.saving.TabIndex = 1;
            this.saving.Text = "how much save";
            // 
            // grocery
            // 
            this.grocery.Location = new System.Drawing.Point(43, 159);
            this.grocery.Name = "grocery";
            this.grocery.Size = new System.Drawing.Size(116, 22);
            this.grocery.TabIndex = 2;
            this.grocery.Text = "grocery spending";
            // 
            // necessities
            // 
            this.necessities.Location = new System.Drawing.Point(203, 159);
            this.necessities.Name = "necessities";
            this.necessities.Size = new System.Drawing.Size(100, 22);
            this.necessities.TabIndex = 3;
            this.necessities.Text = "Necessities";
            // 
            // tuition
            // 
            this.tuition.AccessibleDescription = "";
            this.tuition.Location = new System.Drawing.Point(43, 209);
            this.tuition.Name = "tuition";
            this.tuition.Size = new System.Drawing.Size(100, 22);
            this.tuition.TabIndex = 4;
            this.tuition.Text = "tuition(optional)";
            // 
            // bills
            // 
            this.bills.Location = new System.Drawing.Point(203, 208);
            this.bills.Name = "bills";
            this.bills.Size = new System.Drawing.Size(100, 22);
            this.bills.TabIndex = 5;
            this.bills.Text = "Bills(optional)";
            // 
            // freespend
            // 
            this.freespend.Location = new System.Drawing.Point(43, 274);
            this.freespend.Name = "freespend";
            this.freespend.Size = new System.Drawing.Size(116, 22);
            this.freespend.TabIndex = 6;
            this.freespend.Text = "FreeSpendLimit";
            // 
            // totalSavings
            // 
            this.totalSavings.Location = new System.Drawing.Point(203, 274);
            this.totalSavings.Name = "totalSavings";
            this.totalSavings.Size = new System.Drawing.Size(100, 22);
            this.totalSavings.TabIndex = 7;
            this.totalSavings.Text = "Total Savings";
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(584, 46);
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
            this.rbWeek.Location = new System.Drawing.Point(584, 74);
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
            this.checkBox1.Location = new System.Drawing.Point(669, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 21);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Tuition";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(666, 74);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 21);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Bills";
            this.checkBox2.UseVisualStyleBackColor = true;
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
            // 
            // moneyTip
            // 
            this.moneyTip.Location = new System.Drawing.Point(474, 169);
            this.moneyTip.Multiline = true;
            this.moneyTip.Name = "moneyTip";
            this.moneyTip.Size = new System.Drawing.Size(268, 152);
            this.moneyTip.TabIndex = 14;
            this.moneyTip.Text = "money tip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

