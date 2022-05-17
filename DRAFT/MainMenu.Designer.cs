
namespace DRAFT
{
    partial class MainMenu
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
            this.balanceinquiry = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.deposit = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.accountnumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // balanceinquiry
            // 
            this.balanceinquiry.Location = new System.Drawing.Point(217, 167);
            this.balanceinquiry.Name = "balanceinquiry";
            this.balanceinquiry.Size = new System.Drawing.Size(133, 56);
            this.balanceinquiry.TabIndex = 0;
            this.balanceinquiry.Text = "Balance Inquiry";
            this.balanceinquiry.UseVisualStyleBackColor = true;
            this.balanceinquiry.Click += new System.EventHandler(this.balanceinquiry_Click);
            // 
            // withdraw
            // 
            this.withdraw.Location = new System.Drawing.Point(217, 252);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(133, 56);
            this.withdraw.TabIndex = 1;
            this.withdraw.Text = "Withdraw";
            this.withdraw.UseVisualStyleBackColor = true;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // deposit
            // 
            this.deposit.Location = new System.Drawing.Point(427, 252);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(133, 56);
            this.deposit.TabIndex = 2;
            this.deposit.Text = "Deposit";
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(427, 167);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(133, 56);
            this.history.TabIndex = 3;
            this.history.Text = "Transaction History";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select a Transaction";
            // 
            // accountnumber
            // 
            this.accountnumber.AutoSize = true;
            this.accountnumber.Location = new System.Drawing.Point(351, 72);
            this.accountnumber.Name = "accountnumber";
            this.accountnumber.Size = new System.Drawing.Size(40, 17);
            this.accountnumber.TabIndex = 6;
            this.accountnumber.Text = "2021";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Account Number:";
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(345, 335);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(90, 34);
            this.logout.TabIndex = 8;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accountnumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.history);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.balanceinquiry);
            this.Name = "MainMenu";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button balanceinquiry;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accountnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logout;
    }
}