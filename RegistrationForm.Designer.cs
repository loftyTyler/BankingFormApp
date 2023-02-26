namespace BankingFormApp
{
    partial class RegistrationForm
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
            this.regUsernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.passwordConfirmInput = new System.Windows.Forms.TextBox();
            this.registerNewAccountButton = new System.Windows.Forms.Button();
            this.registerHomeLabel = new System.Windows.Forms.Label();
            this.registerUsernameLabel = new System.Windows.Forms.Label();
            this.registrationPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regUsernameInput
            // 
            this.regUsernameInput.Location = new System.Drawing.Point(148, 171);
            this.regUsernameInput.Name = "regUsernameInput";
            this.regUsernameInput.Size = new System.Drawing.Size(135, 22);
            this.regUsernameInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(148, 254);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(135, 22);
            this.passwordInput.TabIndex = 4;
            // 
            // passwordConfirmInput
            // 
            this.passwordConfirmInput.Location = new System.Drawing.Point(148, 343);
            this.passwordConfirmInput.Name = "passwordConfirmInput";
            this.passwordConfirmInput.Size = new System.Drawing.Size(135, 22);
            this.passwordConfirmInput.TabIndex = 6;
            // 
            // registerNewAccountButton
            // 
            this.registerNewAccountButton.Location = new System.Drawing.Point(180, 393);
            this.registerNewAccountButton.Name = "registerNewAccountButton";
            this.registerNewAccountButton.Size = new System.Drawing.Size(86, 30);
            this.registerNewAccountButton.TabIndex = 7;
            this.registerNewAccountButton.Text = "Register";
            this.registerNewAccountButton.UseVisualStyleBackColor = true;
            this.registerNewAccountButton.Click += new System.EventHandler(this.registerNewAccountButton_Click);
            // 
            // registerHomeLabel
            // 
            this.registerHomeLabel.AutoSize = true;
            this.registerHomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerHomeLabel.Location = new System.Drawing.Point(96, 40);
            this.registerHomeLabel.Name = "registerHomeLabel";
            this.registerHomeLabel.Size = new System.Drawing.Size(266, 25);
            this.registerHomeLabel.TabIndex = 8;
            this.registerHomeLabel.Text = "Register with Developer Bank";
            this.registerHomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // registerUsernameLabel
            // 
            this.registerUsernameLabel.AutoSize = true;
            this.registerUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUsernameLabel.Location = new System.Drawing.Point(103, 122);
            this.registerUsernameLabel.Name = "registerUsernameLabel";
            this.registerUsernameLabel.Size = new System.Drawing.Size(224, 25);
            this.registerUsernameLabel.TabIndex = 9;
            this.registerUsernameLabel.Text = "What is your username?";
            // 
            // registrationPasswordLabel
            // 
            this.registrationPasswordLabel.AutoSize = true;
            this.registrationPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationPasswordLabel.Location = new System.Drawing.Point(103, 213);
            this.registrationPasswordLabel.Name = "registrationPasswordLabel";
            this.registrationPasswordLabel.Size = new System.Drawing.Size(221, 25);
            this.registrationPasswordLabel.TabIndex = 10;
            this.registrationPasswordLabel.Text = "What is your password?";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(107, 299);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(217, 25);
            this.confirmPasswordLabel.TabIndex = 11;
            this.confirmPasswordLabel.Text = "Confirm your password.";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.registrationPasswordLabel);
            this.Controls.Add(this.registerUsernameLabel);
            this.Controls.Add(this.registerHomeLabel);
            this.Controls.Add(this.registerNewAccountButton);
            this.Controls.Add(this.passwordConfirmInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.regUsernameInput);
            this.Name = "RegistrationForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox regUsernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox passwordConfirmInput;
        private System.Windows.Forms.Button registerNewAccountButton;
        private System.Windows.Forms.Label registerHomeLabel;
        private System.Windows.Forms.Label registerUsernameLabel;
        private System.Windows.Forms.Label registrationPasswordLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
    }
}