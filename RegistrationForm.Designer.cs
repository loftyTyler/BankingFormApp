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
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.fullNameInput = new System.Windows.Forms.TextBox();
            this.whatDepositMoneyLabel = new System.Windows.Forms.Label();
            this.moneyDepositInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // regUsernameInput
            // 
            this.regUsernameInput.Location = new System.Drawing.Point(296, 229);
            this.regUsernameInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.regUsernameInput.Name = "regUsernameInput";
            this.regUsernameInput.Size = new System.Drawing.Size(266, 38);
            this.regUsernameInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(296, 364);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(266, 38);
            this.passwordInput.TabIndex = 4;
            // 
            // passwordConfirmInput
            // 
            this.passwordConfirmInput.Location = new System.Drawing.Point(305, 505);
            this.passwordConfirmInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordConfirmInput.Name = "passwordConfirmInput";
            this.passwordConfirmInput.Size = new System.Drawing.Size(266, 38);
            this.passwordConfirmInput.TabIndex = 6;
            // 
            // registerNewAccountButton
            // 
            this.registerNewAccountButton.Location = new System.Drawing.Point(356, 878);
            this.registerNewAccountButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.registerNewAccountButton.Name = "registerNewAccountButton";
            this.registerNewAccountButton.Size = new System.Drawing.Size(172, 58);
            this.registerNewAccountButton.TabIndex = 7;
            this.registerNewAccountButton.Text = "Register";
            this.registerNewAccountButton.UseVisualStyleBackColor = true;
            this.registerNewAccountButton.Click += new System.EventHandler(this.registerNewAccountButton_Click);
            // 
            // registerHomeLabel
            // 
            this.registerHomeLabel.AutoSize = true;
            this.registerHomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerHomeLabel.Location = new System.Drawing.Point(158, 84);
            this.registerHomeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.registerHomeLabel.Name = "registerHomeLabel";
            this.registerHomeLabel.Size = new System.Drawing.Size(544, 46);
            this.registerHomeLabel.TabIndex = 8;
            this.registerHomeLabel.Text = "Register with Developer Bank";
            this.registerHomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // registerUsernameLabel
            // 
            this.registerUsernameLabel.AutoSize = true;
            this.registerUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUsernameLabel.Location = new System.Drawing.Point(206, 163);
            this.registerUsernameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.registerUsernameLabel.Name = "registerUsernameLabel";
            this.registerUsernameLabel.Size = new System.Drawing.Size(451, 46);
            this.registerUsernameLabel.TabIndex = 9;
            this.registerUsernameLabel.Text = "What is your username?";
            // 
            // registrationPasswordLabel
            // 
            this.registrationPasswordLabel.AutoSize = true;
            this.registrationPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationPasswordLabel.Location = new System.Drawing.Point(206, 300);
            this.registrationPasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.registrationPasswordLabel.Name = "registrationPasswordLabel";
            this.registrationPasswordLabel.Size = new System.Drawing.Size(446, 46);
            this.registrationPasswordLabel.TabIndex = 10;
            this.registrationPasswordLabel.Text = "What is your password?";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(210, 435);
            this.confirmPasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(442, 46);
            this.confirmPasswordLabel.TabIndex = 11;
            this.confirmPasswordLabel.Text = "Confirm your password.";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLabel.Location = new System.Drawing.Point(218, 568);
            this.fullNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(434, 46);
            this.fullNameLabel.TabIndex = 12;
            this.fullNameLabel.Text = "What is your Full Name";
            // 
            // fullNameInput
            // 
            this.fullNameInput.Location = new System.Drawing.Point(305, 631);
            this.fullNameInput.Margin = new System.Windows.Forms.Padding(6);
            this.fullNameInput.Name = "fullNameInput";
            this.fullNameInput.Size = new System.Drawing.Size(266, 38);
            this.fullNameInput.TabIndex = 13;
            // 
            // whatDepositMoneyLabel
            // 
            this.whatDepositMoneyLabel.AutoSize = true;
            this.whatDepositMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatDepositMoneyLabel.Location = new System.Drawing.Point(77, 708);
            this.whatDepositMoneyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.whatDepositMoneyLabel.Name = "whatDepositMoneyLabel";
            this.whatDepositMoneyLabel.Size = new System.Drawing.Size(775, 46);
            this.whatDepositMoneyLabel.TabIndex = 14;
            this.whatDepositMoneyLabel.Text = "How much money do you want to deposit?";
            // 
            // moneyDepositInput
            // 
            this.moneyDepositInput.Location = new System.Drawing.Point(305, 788);
            this.moneyDepositInput.Margin = new System.Windows.Forms.Padding(6);
            this.moneyDepositInput.Name = "moneyDepositInput";
            this.moneyDepositInput.Size = new System.Drawing.Size(266, 38);
            this.moneyDepositInput.TabIndex = 15;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 1019);
            this.Controls.Add(this.moneyDepositInput);
            this.Controls.Add(this.whatDepositMoneyLabel);
            this.Controls.Add(this.fullNameInput);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.registrationPasswordLabel);
            this.Controls.Add(this.registerUsernameLabel);
            this.Controls.Add(this.registerHomeLabel);
            this.Controls.Add(this.registerNewAccountButton);
            this.Controls.Add(this.passwordConfirmInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.regUsernameInput);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.TextBox fullNameInput;
        private System.Windows.Forms.Label whatDepositMoneyLabel;
        private System.Windows.Forms.TextBox moneyDepositInput;
    }
}