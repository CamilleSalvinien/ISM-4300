namespace CD_Account_Test
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
            this.exitButton = new System.Windows.Forms.Button();
            this.createObjectButton = new System.Windows.Forms.Button();
            this.objectGroupBox = new System.Windows.Forms.GroupBox();
            this.outputMaturityDateLabel = new System.Windows.Forms.Label();
            this.outputBalanceLabel = new System.Windows.Forms.Label();
            this.outoutInterestRateLabel = new System.Windows.Forms.Label();
            this.outputAccountNumberLabel = new System.Windows.Forms.Label();
            this.maturityDateLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.maturityDateTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.inputMaturityDateLabel = new System.Windows.Forms.Label();
            this.inputBalanceLabel = new System.Windows.Forms.Label();
            this.inputInterestRatelLabel = new System.Windows.Forms.Label();
            this.inputAccountNumberLabel = new System.Windows.Forms.Label();
            this.objectGroupBox.SuspendLayout();
            this.inputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(210, 517);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 62);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // createObjectButton
            // 
            this.createObjectButton.Location = new System.Drawing.Point(88, 517);
            this.createObjectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createObjectButton.Name = "createObjectButton";
            this.createObjectButton.Size = new System.Drawing.Size(112, 62);
            this.createObjectButton.TabIndex = 6;
            this.createObjectButton.Text = "Create Object";
            this.createObjectButton.UseVisualStyleBackColor = true;
            this.createObjectButton.Click += new System.EventHandler(this.createObjectButton_Click);
            // 
            // objectGroupBox
            // 
            this.objectGroupBox.Controls.Add(this.outputMaturityDateLabel);
            this.objectGroupBox.Controls.Add(this.outputBalanceLabel);
            this.objectGroupBox.Controls.Add(this.outoutInterestRateLabel);
            this.objectGroupBox.Controls.Add(this.outputAccountNumberLabel);
            this.objectGroupBox.Controls.Add(this.maturityDateLabel);
            this.objectGroupBox.Controls.Add(this.balanceLabel);
            this.objectGroupBox.Controls.Add(this.interestRateLabel);
            this.objectGroupBox.Controls.Add(this.accountNumberLabel);
            this.objectGroupBox.Location = new System.Drawing.Point(36, 266);
            this.objectGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectGroupBox.Name = "objectGroupBox";
            this.objectGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectGroupBox.Size = new System.Drawing.Size(340, 226);
            this.objectGroupBox.TabIndex = 5;
            this.objectGroupBox.TabStop = false;
            this.objectGroupBox.Text = "Object Properties";
            // 
            // outputMaturityDateLabel
            // 
            this.outputMaturityDateLabel.AutoSize = true;
            this.outputMaturityDateLabel.Location = new System.Drawing.Point(39, 166);
            this.outputMaturityDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputMaturityDateLabel.Name = "outputMaturityDateLabel";
            this.outputMaturityDateLabel.Size = new System.Drawing.Size(108, 20);
            this.outputMaturityDateLabel.TabIndex = 18;
            this.outputMaturityDateLabel.Text = "Maturity Date:";
            // 
            // outputBalanceLabel
            // 
            this.outputBalanceLabel.AutoSize = true;
            this.outputBalanceLabel.Location = new System.Drawing.Point(75, 126);
            this.outputBalanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputBalanceLabel.Name = "outputBalanceLabel";
            this.outputBalanceLabel.Size = new System.Drawing.Size(71, 20);
            this.outputBalanceLabel.TabIndex = 17;
            this.outputBalanceLabel.Text = "Balance:";
            // 
            // outoutInterestRateLabel
            // 
            this.outoutInterestRateLabel.AutoSize = true;
            this.outoutInterestRateLabel.Location = new System.Drawing.Point(42, 86);
            this.outoutInterestRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outoutInterestRateLabel.Name = "outoutInterestRateLabel";
            this.outoutInterestRateLabel.Size = new System.Drawing.Size(107, 20);
            this.outoutInterestRateLabel.TabIndex = 16;
            this.outoutInterestRateLabel.Text = "Interest Rate:";
            // 
            // outputAccountNumberLabel
            // 
            this.outputAccountNumberLabel.AutoSize = true;
            this.outputAccountNumberLabel.Location = new System.Drawing.Point(14, 46);
            this.outputAccountNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputAccountNumberLabel.Name = "outputAccountNumberLabel";
            this.outputAccountNumberLabel.Size = new System.Drawing.Size(132, 20);
            this.outputAccountNumberLabel.TabIndex = 15;
            this.outputAccountNumberLabel.Text = "Account Number:";
            // 
            // maturityDateLabel
            // 
            this.maturityDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maturityDateLabel.Location = new System.Drawing.Point(159, 158);
            this.maturityDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maturityDateLabel.Name = "maturityDateLabel";
            this.maturityDateLabel.Size = new System.Drawing.Size(149, 34);
            this.maturityDateLabel.TabIndex = 13;
            this.maturityDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // balanceLabel
            // 
            this.balanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel.Location = new System.Drawing.Point(159, 118);
            this.balanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(149, 34);
            this.balanceLabel.TabIndex = 12;
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.interestRateLabel.Location = new System.Drawing.Point(159, 78);
            this.interestRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(149, 34);
            this.interestRateLabel.TabIndex = 11;
            this.interestRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountNumberLabel.Location = new System.Drawing.Point(159, 38);
            this.accountNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(149, 34);
            this.accountNumberLabel.TabIndex = 10;
            this.accountNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.maturityDateTextBox);
            this.inputGroupBox.Controls.Add(this.balanceTextBox);
            this.inputGroupBox.Controls.Add(this.interestRateTextBox);
            this.inputGroupBox.Controls.Add(this.accountNumberTextBox);
            this.inputGroupBox.Controls.Add(this.inputMaturityDateLabel);
            this.inputGroupBox.Controls.Add(this.inputBalanceLabel);
            this.inputGroupBox.Controls.Add(this.inputInterestRatelLabel);
            this.inputGroupBox.Controls.Add(this.inputAccountNumberLabel);
            this.inputGroupBox.Location = new System.Drawing.Point(36, 28);
            this.inputGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputGroupBox.Size = new System.Drawing.Size(340, 212);
            this.inputGroupBox.TabIndex = 4;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Enter CD Account Data";
            // 
            // maturityDateTextBox
            // 
            this.maturityDateTextBox.Location = new System.Drawing.Point(166, 154);
            this.maturityDateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maturityDateTextBox.Name = "maturityDateTextBox";
            this.maturityDateTextBox.Size = new System.Drawing.Size(148, 26);
            this.maturityDateTextBox.TabIndex = 8;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(168, 114);
            this.balanceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(148, 26);
            this.balanceTextBox.TabIndex = 7;
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(168, 74);
            this.interestRateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(148, 26);
            this.interestRateTextBox.TabIndex = 6;
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(168, 34);
            this.accountNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(148, 26);
            this.accountNumberTextBox.TabIndex = 5;
            // 
            // inputMaturityDateLabel
            // 
            this.inputMaturityDateLabel.AutoSize = true;
            this.inputMaturityDateLabel.Location = new System.Drawing.Point(42, 158);
            this.inputMaturityDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputMaturityDateLabel.Name = "inputMaturityDateLabel";
            this.inputMaturityDateLabel.Size = new System.Drawing.Size(108, 20);
            this.inputMaturityDateLabel.TabIndex = 3;
            this.inputMaturityDateLabel.Text = "Maturity Date:";
            // 
            // inputBalanceLabel
            // 
            this.inputBalanceLabel.AutoSize = true;
            this.inputBalanceLabel.Location = new System.Drawing.Point(78, 118);
            this.inputBalanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputBalanceLabel.Name = "inputBalanceLabel";
            this.inputBalanceLabel.Size = new System.Drawing.Size(71, 20);
            this.inputBalanceLabel.TabIndex = 2;
            this.inputBalanceLabel.Text = "Balance:";
            // 
            // inputInterestRatelLabel
            // 
            this.inputInterestRatelLabel.AutoSize = true;
            this.inputInterestRatelLabel.Location = new System.Drawing.Point(45, 78);
            this.inputInterestRatelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputInterestRatelLabel.Name = "inputInterestRatelLabel";
            this.inputInterestRatelLabel.Size = new System.Drawing.Size(107, 20);
            this.inputInterestRatelLabel.TabIndex = 1;
            this.inputInterestRatelLabel.Text = "Interest Rate:";
            // 
            // inputAccountNumberLabel
            // 
            this.inputAccountNumberLabel.AutoSize = true;
            this.inputAccountNumberLabel.Location = new System.Drawing.Point(16, 38);
            this.inputAccountNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputAccountNumberLabel.Name = "inputAccountNumberLabel";
            this.inputAccountNumberLabel.Size = new System.Drawing.Size(132, 20);
            this.inputAccountNumberLabel.TabIndex = 0;
            this.inputAccountNumberLabel.Text = "Account Number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 606);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createObjectButton);
            this.Controls.Add(this.objectGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "CD Account Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.objectGroupBox.ResumeLayout(false);
            this.objectGroupBox.PerformLayout();
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button createObjectButton;
        private System.Windows.Forms.GroupBox objectGroupBox;
        private System.Windows.Forms.Label outputMaturityDateLabel;
        private System.Windows.Forms.Label outputBalanceLabel;
        private System.Windows.Forms.Label outoutInterestRateLabel;
        private System.Windows.Forms.Label outputAccountNumberLabel;
        private System.Windows.Forms.Label maturityDateLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.TextBox maturityDateTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label inputMaturityDateLabel;
        private System.Windows.Forms.Label inputBalanceLabel;
        private System.Windows.Forms.Label inputInterestRatelLabel;
        private System.Windows.Forms.Label inputAccountNumberLabel;
    }
}

