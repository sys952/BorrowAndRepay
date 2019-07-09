namespace BorrowAndRepay
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myNameInput = new System.Windows.Forms.TextBox();
            this.friendNameInput = new System.Windows.Forms.TextBox();
            this.confirmB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.borrowB = new System.Windows.Forms.Button();
            this.repayB = new System.Windows.Forms.Button();
            this.Laybel10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.myNameLabel = new System.Windows.Forms.Label();
            this.myMoneyLabel = new System.Windows.Forms.Label();
            this.friendNameLabel = new System.Windows.Forms.Label();
            this.friendMoneyLabel = new System.Windows.Forms.Label();
            this.moneyInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(103, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "我的名字 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(103, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "朋友的名字 :";
            // 
            // myNameInput
            // 
            this.myNameInput.Font = new System.Drawing.Font("新細明體", 12F);
            this.myNameInput.Location = new System.Drawing.Point(251, 37);
            this.myNameInput.Name = "myNameInput";
            this.myNameInput.Size = new System.Drawing.Size(192, 36);
            this.myNameInput.TabIndex = 2;
            // 
            // friendNameInput
            // 
            this.friendNameInput.Font = new System.Drawing.Font("新細明體", 12F);
            this.friendNameInput.Location = new System.Drawing.Point(251, 96);
            this.friendNameInput.Name = "friendNameInput";
            this.friendNameInput.Size = new System.Drawing.Size(192, 36);
            this.friendNameInput.TabIndex = 3;
            // 
            // confirmB
            // 
            this.confirmB.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.confirmB.Location = new System.Drawing.Point(525, 70);
            this.confirmB.Name = "confirmB";
            this.confirmB.Size = new System.Drawing.Size(185, 83);
            this.confirmB.TabIndex = 4;
            this.confirmB.Text = "Confirm";
            this.confirmB.UseVisualStyleBackColor = true;
            this.confirmB.Click += new System.EventHandler(this.confirmB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(101, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "我的名字";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(389, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "朋友的名字";
            // 
            // borrowB
            // 
            this.borrowB.Enabled = false;
            this.borrowB.Font = new System.Drawing.Font("新細明體", 12F);
            this.borrowB.Location = new System.Drawing.Point(251, 308);
            this.borrowB.Name = "borrowB";
            this.borrowB.Size = new System.Drawing.Size(270, 41);
            this.borrowB.TabIndex = 7;
            this.borrowB.Text = "借錢";
            this.borrowB.UseVisualStyleBackColor = true;
            this.borrowB.Click += new System.EventHandler(this.button2_Click);
            // 
            // repayB
            // 
            this.repayB.Enabled = false;
            this.repayB.Font = new System.Drawing.Font("新細明體", 12F);
            this.repayB.Location = new System.Drawing.Point(251, 391);
            this.repayB.Name = "repayB";
            this.repayB.Size = new System.Drawing.Size(270, 41);
            this.repayB.TabIndex = 8;
            this.repayB.Text = "還錢";
            this.repayB.UseVisualStyleBackColor = true;
            this.repayB.Click += new System.EventHandler(this.repayB_Click);
            // 
            // Laybel10
            // 
            this.Laybel10.AutoSize = true;
            this.Laybel10.Font = new System.Drawing.Font("新細明體", 12F);
            this.Laybel10.Location = new System.Drawing.Point(101, 254);
            this.Laybel10.Name = "Laybel10";
            this.Laybel10.Size = new System.Drawing.Size(69, 24);
            this.Laybel10.TabIndex = 9;
            this.Laybel10.Text = "我的$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F);
            this.label6.Location = new System.Drawing.Point(389, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "朋友的$";
            // 
            // myNameLabel
            // 
            this.myNameLabel.AutoSize = true;
            this.myNameLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.myNameLabel.Location = new System.Drawing.Point(225, 212);
            this.myNameLabel.Name = "myNameLabel";
            this.myNameLabel.Size = new System.Drawing.Size(106, 24);
            this.myNameLabel.TabIndex = 11;
            this.myNameLabel.Text = "我的名字";
            // 
            // myMoneyLabel
            // 
            this.myMoneyLabel.AutoSize = true;
            this.myMoneyLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.myMoneyLabel.Location = new System.Drawing.Point(225, 254);
            this.myMoneyLabel.Name = "myMoneyLabel";
            this.myMoneyLabel.Size = new System.Drawing.Size(69, 24);
            this.myMoneyLabel.TabIndex = 12;
            this.myMoneyLabel.Text = "我的$";
            // 
            // friendNameLabel
            // 
            this.friendNameLabel.AutoSize = true;
            this.friendNameLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.friendNameLabel.Location = new System.Drawing.Point(545, 212);
            this.friendNameLabel.Name = "friendNameLabel";
            this.friendNameLabel.Size = new System.Drawing.Size(130, 24);
            this.friendNameLabel.TabIndex = 13;
            this.friendNameLabel.Text = "朋友的名字";
            // 
            // friendMoneyLabel
            // 
            this.friendMoneyLabel.AutoSize = true;
            this.friendMoneyLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.friendMoneyLabel.Location = new System.Drawing.Point(545, 254);
            this.friendMoneyLabel.Name = "friendMoneyLabel";
            this.friendMoneyLabel.Size = new System.Drawing.Size(93, 24);
            this.friendMoneyLabel.TabIndex = 14;
            this.friendMoneyLabel.Text = "朋友的$";
            // 
            // moneyInput
            // 
            this.moneyInput.Font = new System.Drawing.Font("新細明體", 12F);
            this.moneyInput.Location = new System.Drawing.Point(251, 152);
            this.moneyInput.Name = "moneyInput";
            this.moneyInput.Size = new System.Drawing.Size(192, 36);
            this.moneyInput.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F);
            this.label7.Location = new System.Drawing.Point(103, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "金額 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moneyInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.friendMoneyLabel);
            this.Controls.Add(this.friendNameLabel);
            this.Controls.Add(this.myMoneyLabel);
            this.Controls.Add(this.myNameLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Laybel10);
            this.Controls.Add(this.repayB);
            this.Controls.Add(this.borrowB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmB);
            this.Controls.Add(this.friendNameInput);
            this.Controls.Add(this.myNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox myNameInput;
        private System.Windows.Forms.TextBox friendNameInput;
        private System.Windows.Forms.Button confirmB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button borrowB;
        private System.Windows.Forms.Button repayB;
        private System.Windows.Forms.Label Laybel10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label myNameLabel;
        private System.Windows.Forms.Label myMoneyLabel;
        private System.Windows.Forms.Label friendNameLabel;
        private System.Windows.Forms.Label friendMoneyLabel;
        private System.Windows.Forms.TextBox moneyInput;
        private System.Windows.Forms.Label label7;
    }
}

