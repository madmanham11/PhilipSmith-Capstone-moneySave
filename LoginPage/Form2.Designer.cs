
namespace LoginPage
{
    partial class Form2
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
            this.NewUser = new System.Windows.Forms.TextBox();
            this.NewPass = new System.Windows.Forms.TextBox();
            this.ExistPass = new System.Windows.Forms.TextBox();
            this.ExistUser = new System.Windows.Forms.TextBox();
            this.Security = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SubmitUser = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewUser
            // 
            this.NewUser.Location = new System.Drawing.Point(72, 131);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(100, 22);
            this.NewUser.TabIndex = 0;
            // 
            // NewPass
            // 
            this.NewPass.Location = new System.Drawing.Point(72, 207);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(100, 22);
            this.NewPass.TabIndex = 1;
            // 
            // ExistPass
            // 
            this.ExistPass.Location = new System.Drawing.Point(530, 207);
            this.ExistPass.Name = "ExistPass";
            this.ExistPass.Size = new System.Drawing.Size(100, 22);
            this.ExistPass.TabIndex = 3;
            // 
            // ExistUser
            // 
            this.ExistUser.Location = new System.Drawing.Point(530, 131);
            this.ExistUser.Name = "ExistUser";
            this.ExistUser.Size = new System.Drawing.Size(100, 22);
            this.ExistUser.TabIndex = 2;
            // 
            // Security
            // 
            this.Security.Location = new System.Drawing.Point(72, 286);
            this.Security.Name = "Security";
            this.Security.Size = new System.Drawing.Size(100, 22);
            this.Security.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Security question fav show";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Existing username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Existing Password";
            // 
            // SubmitUser
            // 
            this.SubmitUser.Location = new System.Drawing.Point(75, 367);
            this.SubmitUser.Name = "SubmitUser";
            this.SubmitUser.Size = new System.Drawing.Size(75, 23);
            this.SubmitUser.TabIndex = 10;
            this.SubmitUser.Text = "Register";
            this.SubmitUser.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(530, 367);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 11;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.SubmitUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Security);
            this.Controls.Add(this.ExistPass);
            this.Controls.Add(this.ExistUser);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.NewUser);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewUser;
        private System.Windows.Forms.TextBox NewPass;
        private System.Windows.Forms.TextBox ExistPass;
        private System.Windows.Forms.TextBox ExistUser;
        private System.Windows.Forms.TextBox Security;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SubmitUser;
        private System.Windows.Forms.Button Login;
    }
}

