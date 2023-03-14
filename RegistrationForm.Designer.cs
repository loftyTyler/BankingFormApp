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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // regUsernameInput
            // 
            this.regUsernameInput.Location = new System.Drawing.Point(155, 101);
            this.regUsernameInput.Name = "regUsernameInput";
            this.regUsernameInput.Size = new System.Drawing.Size(135, 22);
            this.regUsernameInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(155, 171);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(135, 22);
            this.passwordInput.TabIndex = 4;
            // 
            // passwordConfirmInput
            // 
            this.passwordConfirmInput.Location = new System.Drawing.Point(159, 244);
            this.passwordConfirmInput.Name = "passwordConfirmInput";
            this.passwordConfirmInput.Size = new System.Drawing.Size(135, 22);
            this.passwordConfirmInput.TabIndex = 6;
            // 
            // registerNewAccountButton
            // 
            this.registerNewAccountButton.BackColor = System.Drawing.Color.Green;
            this.registerNewAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerNewAccountButton.ForeColor = System.Drawing.Color.White;
            this.registerNewAccountButton.Location = new System.Drawing.Point(170, 421);
            this.registerNewAccountButton.Name = "registerNewAccountButton";
            this.registerNewAccountButton.Size = new System.Drawing.Size(111, 39);
            this.registerNewAccountButton.TabIndex = 7;
            this.registerNewAccountButton.Text = "Register";
            this.registerNewAccountButton.UseVisualStyleBackColor = false;
            this.registerNewAccountButton.Click += new System.EventHandler(this.registerNewAccountButton_Click);
            // 
            // registerHomeLabel
            // 
            this.registerHomeLabel.AutoSize = true;
            this.registerHomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerHomeLabel.ForeColor = System.Drawing.Color.White;
            this.registerHomeLabel.Location = new System.Drawing.Point(94, 13);
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
            this.registerUsernameLabel.Location = new System.Drawing.Point(110, 67);
            this.registerUsernameLabel.Name = "registerUsernameLabel";
            this.registerUsernameLabel.Size = new System.Drawing.Size(224, 25);
            this.registerUsernameLabel.TabIndex = 9;
            this.registerUsernameLabel.Text = "What is your username?";
            // 
            // registrationPasswordLabel
            // 
            this.registrationPasswordLabel.AutoSize = true;
            this.registrationPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationPasswordLabel.Location = new System.Drawing.Point(110, 138);
            this.registrationPasswordLabel.Name = "registrationPasswordLabel";
            this.registrationPasswordLabel.Size = new System.Drawing.Size(221, 25);
            this.registrationPasswordLabel.TabIndex = 10;
            this.registrationPasswordLabel.Text = "What is your password?";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(112, 208);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(217, 25);
            this.confirmPasswordLabel.TabIndex = 11;
            this.confirmPasswordLabel.Text = "Confirm your password.";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLabel.Location = new System.Drawing.Point(116, 276);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(214, 25);
            this.fullNameLabel.TabIndex = 12;
            this.fullNameLabel.Text = "What is your Full Name";
            // 
            // fullNameInput
            // 
            this.fullNameInput.Location = new System.Drawing.Point(159, 309);
            this.fullNameInput.Name = "fullNameInput";
            this.fullNameInput.Size = new System.Drawing.Size(135, 22);
            this.fullNameInput.TabIndex = 13;
            // 
            // whatDepositMoneyLabel
            // 
            this.whatDepositMoneyLabel.AutoSize = true;
            this.whatDepositMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatDepositMoneyLabel.Location = new System.Drawing.Point(45, 348);
            this.whatDepositMoneyLabel.Name = "whatDepositMoneyLabel";
            this.whatDepositMoneyLabel.Size = new System.Drawing.Size(378, 25);
            this.whatDepositMoneyLabel.TabIndex = 14;
            this.whatDepositMoneyLabel.Text = "How much money do you want to deposit?";
            // 
            // moneyDepositInput
            // 
            this.moneyDepositInput.Location = new System.Drawing.Point(159, 390);
            this.moneyDepositInput.Name = "moneyDepositInput";
            this.moneyDepositInput.Size = new System.Drawing.Size(135, 22);
            this.moneyDepositInput.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.registerHomeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 48);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 54);
            this.panel2.TabIndex = 17;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.moneyDepositInput);
            this.Controls.Add(this.whatDepositMoneyLabel);
            this.Controls.Add(this.fullNameInput);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.registrationPasswordLabel);
            this.Controls.Add(this.registerUsernameLabel);
            this.Controls.Add(this.registerNewAccountButton);
            this.Controls.Add(this.passwordConfirmInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.regUsernameInput);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}