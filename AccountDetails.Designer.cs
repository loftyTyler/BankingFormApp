namespace BankingFormApp
{
    partial class AccountDetails
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.welcomeOutput = new System.Windows.Forms.Label();
            this.checkBalanceButton = new System.Windows.Forms.Button();
            this.whichOfFollowingLabel = new System.Windows.Forms.Label();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(163, 15);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(95, 25);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome";
            // 
            // welcomeOutput
            // 
            this.welcomeOutput.AutoSize = true;
            this.welcomeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeOutput.Location = new System.Drawing.Point(178, 56);
            this.welcomeOutput.Name = "welcomeOutput";
            this.welcomeOutput.Size = new System.Drawing.Size(64, 25);
            this.welcomeOutput.TabIndex = 1;
            this.welcomeOutput.Text = "Name";
            this.welcomeOutput.TextChanged += new System.EventHandler(this.welcomeOutput_TextChanged);
            // 
            // checkBalanceButton
            // 
            this.checkBalanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBalanceButton.Location = new System.Drawing.Point(128, 168);
            this.checkBalanceButton.Name = "checkBalanceButton";
            this.checkBalanceButton.Size = new System.Drawing.Size(166, 32);
            this.checkBalanceButton.TabIndex = 2;
            this.checkBalanceButton.Text = "Check Balance";
            this.checkBalanceButton.UseVisualStyleBackColor = true;
            this.checkBalanceButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // whichOfFollowingLabel
            // 
            this.whichOfFollowingLabel.AutoSize = true;
            this.whichOfFollowingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whichOfFollowingLabel.Location = new System.Drawing.Point(39, 103);
            this.whichOfFollowingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.whichOfFollowingLabel.Name = "whichOfFollowingLabel";
            this.whichOfFollowingLabel.Size = new System.Drawing.Size(370, 25);
            this.whichOfFollowingLabel.TabIndex = 3;
            this.whichOfFollowingLabel.Text = "Which of the following do you want to do?";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawButton.Location = new System.Drawing.Point(128, 220);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(166, 32);
            this.withdrawButton.TabIndex = 4;
            this.withdrawButton.Text = "Withdraw Funds";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.Location = new System.Drawing.Point(128, 277);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(166, 32);
            this.depositButton.TabIndex = 5;
            this.depositButton.Text = "Deposit Funds";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // AccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 342);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.whichOfFollowingLabel);
            this.Controls.Add(this.checkBalanceButton);
            this.Controls.Add(this.welcomeOutput);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "AccountDetails";
            this.Text = "Account Details";
            this.Load += new System.EventHandler(this.AccountDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label welcomeOutput;
        private System.Windows.Forms.Button checkBalanceButton;
        private System.Windows.Forms.Label whichOfFollowingLabel;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
    }
}