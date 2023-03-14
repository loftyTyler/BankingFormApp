namespace BankingFormApp
{
    partial class LoginForm
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
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.newuserInput = new System.Windows.Forms.Button();
            this.forgotPasswordInput = new System.Windows.Forms.Button();
            this.signInSubmit = new System.Windows.Forms.Button();
            this.bankLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(129, 92);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(262, 22);
            this.usernameInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(129, 152);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(262, 22);
            this.passwordInput.TabIndex = 2;
            // 
            // newuserInput
            // 
            this.newuserInput.BackColor = System.Drawing.Color.Green;
            this.newuserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newuserInput.ForeColor = System.Drawing.Color.White;
            this.newuserInput.Location = new System.Drawing.Point(82, 230);
            this.newuserInput.Name = "newuserInput";
            this.newuserInput.Size = new System.Drawing.Size(121, 39);
            this.newuserInput.TabIndex = 3;
            this.newuserInput.Text = "New User?";
            this.newuserInput.UseVisualStyleBackColor = false;
            this.newuserInput.Click += new System.EventHandler(this.newuserInput_Click);
            // 
            // forgotPasswordInput
            // 
            this.forgotPasswordInput.BackColor = System.Drawing.Color.Green;
            this.forgotPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordInput.ForeColor = System.Drawing.Color.White;
            this.forgotPasswordInput.Location = new System.Drawing.Point(272, 230);
            this.forgotPasswordInput.Name = "forgotPasswordInput";
            this.forgotPasswordInput.Size = new System.Drawing.Size(186, 39);
            this.forgotPasswordInput.TabIndex = 4;
            this.forgotPasswordInput.Text = "Forgot Password?";
            this.forgotPasswordInput.UseVisualStyleBackColor = false;
            // 
            // signInSubmit
            // 
            this.signInSubmit.BackColor = System.Drawing.Color.Green;
            this.signInSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInSubmit.ForeColor = System.Drawing.Color.White;
            this.signInSubmit.Location = new System.Drawing.Point(200, 186);
            this.signInSubmit.Name = "signInSubmit";
            this.signInSubmit.Size = new System.Drawing.Size(113, 38);
            this.signInSubmit.TabIndex = 7;
            this.signInSubmit.Text = "SIGN IN";
            this.signInSubmit.UseVisualStyleBackColor = false;
            this.signInSubmit.Click += new System.EventHandler(this.signInSubmit_Click);
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankLabel.ForeColor = System.Drawing.Color.White;
            this.bankLabel.Location = new System.Drawing.Point(176, 21);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bankLabel.Size = new System.Drawing.Size(187, 25);
            this.bankLabel.TabIndex = 8;
            this.bankLabel.Text = "Bank Of Developers";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(207, 64);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(102, 25);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(211, 124);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(98, 25);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.bankLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 57);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 50);
            this.panel2.TabIndex = 12;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 334);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.signInSubmit);
            this.Controls.Add(this.forgotPasswordInput);
            this.Controls.Add(this.newuserInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button newuserInput;
        private System.Windows.Forms.Button forgotPasswordInput;
        private System.Windows.Forms.Button signInSubmit;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

