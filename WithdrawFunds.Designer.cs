namespace BankingFormApp
{
    partial class WithdrawFunds
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
            this.label1 = new System.Windows.Forms.Label();
            this.withdrawFundsInput = new System.Windows.Forms.TextBox();
            this.withdrawFundsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "How much do you want to withdraw?";
            // 
            // withdrawFundsInput
            // 
            this.withdrawFundsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawFundsInput.Location = new System.Drawing.Point(139, 77);
            this.withdrawFundsInput.Name = "withdrawFundsInput";
            this.withdrawFundsInput.Size = new System.Drawing.Size(142, 30);
            this.withdrawFundsInput.TabIndex = 1;
            // 
            // withdrawFundsButton
            // 
            this.withdrawFundsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawFundsButton.Location = new System.Drawing.Point(153, 121);
            this.withdrawFundsButton.Name = "withdrawFundsButton";
            this.withdrawFundsButton.Size = new System.Drawing.Size(117, 35);
            this.withdrawFundsButton.TabIndex = 2;
            this.withdrawFundsButton.Text = "Submit";
            this.withdrawFundsButton.UseVisualStyleBackColor = true;
            this.withdrawFundsButton.Click += new System.EventHandler(this.withdrawFundsButton_Click);
            // 
            // WithdrawFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 179);
            this.Controls.Add(this.withdrawFundsButton);
            this.Controls.Add(this.withdrawFundsInput);
            this.Controls.Add(this.label1);
            this.Name = "WithdrawFunds";
            this.Text = "Withdraw Funds";
            this.Load += new System.EventHandler(this.WithdrawFunds_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox withdrawFundsInput;
        private System.Windows.Forms.Button withdrawFundsButton;
    }
}