namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.username = new System.Windows.Forms.Label();
            this.withdraw = new System.Windows.Forms.Button();
            this.deposit = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.Button();
            this.transfer = new System.Windows.Forms.Button();
            this.wtdamt = new System.Windows.Forms.ListBox();
            this.depamt = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(278, 9);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(60, 24);
            this.username.TabIndex = 0;
            this.username.Text = "label1";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // withdraw
            // 
            this.withdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.withdraw.Enabled = false;
            this.withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.withdraw.Location = new System.Drawing.Point(281, 58);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(133, 35);
            this.withdraw.TabIndex = 1;
            this.withdraw.Text = "Withdraw";
            this.withdraw.UseVisualStyleBackColor = false;
            this.withdraw.Click += new System.EventHandler(this.button1_Click);
            // 
            // deposit
            // 
            this.deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deposit.Enabled = false;
            this.deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit.Location = new System.Drawing.Point(282, 115);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(132, 35);
            this.deposit.TabIndex = 2;
            this.deposit.Text = "Deposit";
            this.deposit.UseVisualStyleBackColor = false;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // balance
            // 
            this.balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(282, 177);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(133, 37);
            this.balance.TabIndex = 3;
            this.balance.Text = "Check Balance";
            this.balance.UseVisualStyleBackColor = false;
            this.balance.Click += new System.EventHandler(this.balance_Click);
            // 
            // transfer
            // 
            this.transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transfer.Location = new System.Drawing.Point(281, 238);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(134, 39);
            this.transfer.TabIndex = 4;
            this.transfer.Text = "Transfer";
            this.transfer.UseVisualStyleBackColor = false;
            this.transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // wtdamt
            // 
            this.wtdamt.FormattingEnabled = true;
            this.wtdamt.Items.AddRange(new object[] {
            "500",
            "1000",
            "1500",
            "3000",
            "5000",
            "10000"});
            this.wtdamt.Location = new System.Drawing.Point(479, 58);
            this.wtdamt.Name = "wtdamt";
            this.wtdamt.Size = new System.Drawing.Size(120, 30);
            this.wtdamt.TabIndex = 5;
            this.wtdamt.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // depamt
            // 
            this.depamt.FormattingEnabled = true;
            this.depamt.Items.AddRange(new object[] {
            "500",
            "1000",
            "1500",
            "3000",
            "5000",
            "10000"});
            this.depamt.Location = new System.Drawing.Point(479, 120);
            this.depamt.Name = "depamt";
            this.depamt.Size = new System.Drawing.Size(120, 30);
            this.depamt.TabIndex = 6;
            this.depamt.SelectedIndexChanged += new System.EventHandler(this.depamt_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(669, 289);
            this.Controls.Add(this.depamt);
            this.Controls.Add(this.wtdamt);
            this.Controls.Add(this.transfer);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.username);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.Text = "Atm  Aplication";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button balance;
        private System.Windows.Forms.Button transfer;
        private System.Windows.Forms.ListBox wtdamt;
        private System.Windows.Forms.ListBox depamt;
    }
}