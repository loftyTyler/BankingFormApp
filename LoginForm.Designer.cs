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
            this.SuspendLayout();
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
            this.newuserInput.Click += new System.EventHandler(this.newuserInput_Click);
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
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankLabel.Location = new System.Drawing.Point(170, 37);
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
            this.usernameLabel.Location = new System.Drawing.Point(212, 83);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(102, 25);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(212, 143);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(98, 25);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.bankLabel);
            this.Controls.Add(this.signInSubmit);
            this.Controls.Add(this.forgotPasswordInput);
            this.Controls.Add(this.newuserInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
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
    }
}

