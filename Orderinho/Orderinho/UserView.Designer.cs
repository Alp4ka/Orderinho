namespace Orderinho
{
    partial class UserView
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ordersPanel = new System.Windows.Forms.ListBox();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.midnameTb = new System.Windows.Forms.TextBox();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.telephoneTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(8, 384);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(200, 41);
            this.confirmButton.TabIndex = 39;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.priceLabel.Location = new System.Drawing.Point(102, 224);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(83, 22);
            this.priceLabel.TabIndex = 38;
            this.priceLabel.Text = "123 RUB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "Summary:";
            // 
            // nameTb
            // 
            this.nameTb.Enabled = false;
            this.nameTb.Location = new System.Drawing.Point(106, 36);
            this.nameTb.Name = "nameTb";
            this.nameTb.ReadOnly = true;
            this.nameTb.Size = new System.Drawing.Size(100, 20);
            this.nameTb.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(72, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "ID:";
            // 
            // idTb
            // 
            this.idTb.Enabled = false;
            this.idTb.Location = new System.Drawing.Point(106, 10);
            this.idTb.Name = "idTb";
            this.idTb.ReadOnly = true;
            this.idTb.Size = new System.Drawing.Size(100, 20);
            this.idTb.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 40;
            this.label6.Text = "Surname:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(18, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 41;
            this.label7.Text = "Midname:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(46, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 22);
            this.label8.TabIndex = 42;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(4, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 22);
            this.label9.TabIndex = 43;
            this.label9.Text = "Telephone:";
            // 
            // ordersPanel
            // 
            this.ordersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ordersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ordersPanel.FormattingEnabled = true;
            this.ordersPanel.Location = new System.Drawing.Point(8, 259);
            this.ordersPanel.Name = "ordersPanel";
            this.ordersPanel.Size = new System.Drawing.Size(200, 119);
            this.ordersPanel.TabIndex = 44;
            // 
            // surnameTb
            // 
            this.surnameTb.Enabled = false;
            this.surnameTb.Location = new System.Drawing.Point(106, 72);
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.ReadOnly = true;
            this.surnameTb.Size = new System.Drawing.Size(100, 20);
            this.surnameTb.TabIndex = 45;
            // 
            // midnameTb
            // 
            this.midnameTb.Enabled = false;
            this.midnameTb.Location = new System.Drawing.Point(106, 106);
            this.midnameTb.Name = "midnameTb";
            this.midnameTb.ReadOnly = true;
            this.midnameTb.Size = new System.Drawing.Size(100, 20);
            this.midnameTb.TabIndex = 46;
            // 
            // emailTb
            // 
            this.emailTb.Enabled = false;
            this.emailTb.Location = new System.Drawing.Point(106, 140);
            this.emailTb.Name = "emailTb";
            this.emailTb.ReadOnly = true;
            this.emailTb.Size = new System.Drawing.Size(100, 20);
            this.emailTb.TabIndex = 47;
            // 
            // telephoneTb
            // 
            this.telephoneTb.Enabled = false;
            this.telephoneTb.Location = new System.Drawing.Point(106, 173);
            this.telephoneTb.Name = "telephoneTb";
            this.telephoneTb.ReadOnly = true;
            this.telephoneTb.Size = new System.Drawing.Size(100, 20);
            this.telephoneTb.TabIndex = 48;
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 432);
            this.Controls.Add(this.telephoneTb);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.midnameTb);
            this.Controls.Add(this.surnameTb);
            this.Controls.Add(this.ordersPanel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.label1);
            this.Name = "UserView";
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox ordersPanel;
        private System.Windows.Forms.TextBox surnameTb;
        private System.Windows.Forms.TextBox midnameTb;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.TextBox telephoneTb;
    }
}