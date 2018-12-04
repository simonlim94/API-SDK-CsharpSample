namespace WindowsFormsApp1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAuthCode = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRefundAmount = new System.Windows.Forms.TextBox();
            this.tbTransactionID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbReverseOrderID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbStoreID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Refresh Token And Access Token";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(568, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(360, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Refresh Token";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(568, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(360, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Quick Pay";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(568, 472);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(360, 44);
            this.button4.TabIndex = 6;
            this.button4.Text = "Refund";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(585, 679);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(360, 44);
            this.button5.TabIndex = 7;
            this.button5.Text = "Reverse";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Step 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Step 2 Refresh Token is used to get new access token when its expired";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(504, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Step 3 Perform Quick Pay Transaction (Order ID cannot be duplicated)";
            // 
            // tbAuthCode
            // 
            this.tbAuthCode.Location = new System.Drawing.Point(156, 250);
            this.tbAuthCode.Name = "tbAuthCode";
            this.tbAuthCode.Size = new System.Drawing.Size(256, 26);
            this.tbAuthCode.TabIndex = 11;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(156, 294);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(256, 26);
            this.tbAmount.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "RM";
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(156, 337);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.Size = new System.Drawing.Size(260, 26);
            this.tbOrderID.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Auth Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Order ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Transaction ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 534);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "RM";
            // 
            // tbRefundAmount
            // 
            this.tbRefundAmount.Location = new System.Drawing.Point(156, 534);
            this.tbRefundAmount.Name = "tbRefundAmount";
            this.tbRefundAmount.Size = new System.Drawing.Size(256, 26);
            this.tbRefundAmount.TabIndex = 19;
            // 
            // tbTransactionID
            // 
            this.tbTransactionID.Location = new System.Drawing.Point(156, 490);
            this.tbTransactionID.Name = "tbTransactionID";
            this.tbTransactionID.Size = new System.Drawing.Size(256, 26);
            this.tbTransactionID.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(403, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Step 4 Refund (Key in same amount of that transaction)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 589);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Reason";
            // 
            // tbReason
            // 
            this.tbReason.Location = new System.Drawing.Point(156, 583);
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(260, 26);
            this.tbReason.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 637);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Step 5 Reverse";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 691);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Order Id";
            // 
            // tbReverseOrderID
            // 
            this.tbReverseOrderID.Location = new System.Drawing.Point(152, 685);
            this.tbReverseOrderID.Name = "tbReverseOrderID";
            this.tbReverseOrderID.Size = new System.Drawing.Size(260, 26);
            this.tbReverseOrderID.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 391);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Store ID";
            // 
            // tbStoreID
            // 
            this.tbStoreID.Location = new System.Drawing.Point(156, 385);
            this.tbStoreID.Name = "tbStoreID";
            this.tbStoreID.Size = new System.Drawing.Size(260, 26);
            this.tbStoreID.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 799);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbStoreID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbReverseOrderID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbReason);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbRefundAmount);
            this.Controls.Add(this.tbTransactionID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbOrderID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbAuthCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAuthCode;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRefundAmount;
        private System.Windows.Forms.TextBox tbTransactionID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbReverseOrderID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbStoreID;
    }
}

