namespace BankingFormApp
{
    partial class DepositFunds
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
            this.depositFundsInput = new System.Windows.Forms.TextBox();
            this.depositFundsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "How much do you want to deposit?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // depositFundsInput
            // 
            this.depositFundsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositFundsInput.Location = new System.Drawing.Point(148, 75);
            this.depositFundsInput.Name = "depositFundsInput";
            this.depositFundsInput.Size = new System.Drawing.Size(162, 30);
            this.depositFundsInput.TabIndex = 1;
            // 
            // depositFundsButton
            // 
            this.depositFundsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositFundsButton.Location = new System.Drawing.Point(175, 129);
            this.depositFundsButton.Name = "depositFundsButton";
            this.depositFundsButton.Size = new System.Drawing.Size(95, 37);
            this.depositFundsButton.TabIndex = 2;
            this.depositFundsButton.Text = "Submit";
            this.depositFundsButton.UseVisualStyleBackColor = true;
            this.depositFundsButton.Click += new System.EventHandler(this.depositFundsButton_Click);
            // 
            // DepositFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 198);
            this.Controls.Add(this.depositFundsButton);
            this.Controls.Add(this.depositFundsInput);
            this.Controls.Add(this.label1);
            this.Name = "DepositFunds";
            this.Text = "Deposit Funds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox depositFundsInput;
        private System.Windows.Forms.Button depositFundsButton;
    }
}