namespace BankingFormApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.newuserInput = new System.Windows.Forms.Button();
            this.forgotPasswordInput = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.signInSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(162, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Bank of Developers";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(130, 111);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(262, 22);
            this.usernameInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(130, 171);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(262, 22);
            this.passwordInput.TabIndex = 2;
            // 
            // newuserInput
            // 
            this.newuserInput.Location = new System.Drawing.Point(107, 251);
            this.newuserInput.Name = "newuserInput";
            this.newuserInput.Size = new System.Drawing.Size(100, 31);
            this.newuserInput.TabIndex = 3;
            this.newuserInput.Text = "New User?";
            this.newuserInput.UseVisualStyleBackColor = true;
            // 
            // forgotPasswordInput
            // 
            this.forgotPasswordInput.Location = new System.Drawing.Point(302, 251);
            this.forgotPasswordInput.Name = "forgotPasswordInput";
            this.forgotPasswordInput.Size = new System.Drawing.Size(130, 31);
            this.forgotPasswordInput.TabIndex = 4;
            this.forgotPasswordInput.Text = "Forgot Password?";
            this.forgotPasswordInput.UseVisualStyleBackColor = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(217, 92);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(89, 22);
            this.usernameTextBox.TabIndex = 5;
            this.usernameTextBox.Text = "USERNAME";
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(217, 148);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(89, 22);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.Text = "PASSWORD";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signInSubmit
            // 
            this.signInSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.signInSubmit.Location = new System.Drawing.Point(217, 209);
            this.signInSubmit.Name = "signInSubmit";
            this.signInSubmit.Size = new System.Drawing.Size(89, 36);
            this.signInSubmit.TabIndex = 7;
            this.signInSubmit.Text = "SIGN IN";
            this.signInSubmit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.signInSubmit);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.forgotPasswordInput);
            this.Controls.Add(this.newuserInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button newuserInput;
        private System.Windows.Forms.Button forgotPasswordInput;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button signInSubmit;
    }
}

