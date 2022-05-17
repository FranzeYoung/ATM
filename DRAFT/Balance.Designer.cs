
namespace DRAFT
{
    partial class Balance
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
            this.balance1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.accountnumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.return1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // balance1
            // 
            this.balance1.Location = new System.Drawing.Point(434, 277);
            this.balance1.Name = "balance1";
            this.balance1.Size = new System.Drawing.Size(133, 56);
            this.balance1.TabIndex = 17;
            this.balance1.Text = "Check Balance";
            this.balance1.UseVisualStyleBackColor = true;
            this.balance1.Click += new System.EventHandler(this.balance1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Account Number:";
            // 
            // accountnumber
            // 
            this.accountnumber.AutoSize = true;
            this.accountnumber.Location = new System.Drawing.Point(383, 116);
            this.accountnumber.Name = "accountnumber";
            this.accountnumber.Size = new System.Drawing.Size(40, 17);
            this.accountnumber.TabIndex = 15;
            this.accountnumber.Text = "2021";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Check your account balance.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 146);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 65);
            this.textBox1.TabIndex = 13;
            // 
            // return1
            // 
            this.return1.Location = new System.Drawing.Point(233, 277);
            this.return1.Name = "return1";
            this.return1.Size = new System.Drawing.Size(133, 56);
            this.return1.TabIndex = 18;
            this.return1.Text = "Return";
            this.return1.UseVisualStyleBackColor = true;
            this.return1.Click += new System.EventHandler(this.return1_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.return1);
            this.Controls.Add(this.balance1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accountnumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Balance";
            this.Text = "Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button balance1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label accountnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button return1;
    }
}