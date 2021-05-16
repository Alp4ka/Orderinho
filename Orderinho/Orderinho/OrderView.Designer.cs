namespace Orderinho
{
    partial class OrderView
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
            this.idTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerTb = new System.Windows.Forms.TextBox();
            this.contentPanel = new System.Windows.Forms.ListBox();
            this.paymentTb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stateTb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer:";
            // 
            // idTb
            // 
            this.idTb.Enabled = false;
            this.idTb.Location = new System.Drawing.Point(110, 16);
            this.idTb.Name = "idTb";
            this.idTb.ReadOnly = true;
            this.idTb.Size = new System.Drawing.Size(100, 20);
            this.idTb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(72, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // customerTb
            // 
            this.customerTb.Enabled = false;
            this.customerTb.Location = new System.Drawing.Point(110, 42);
            this.customerTb.Name = "customerTb";
            this.customerTb.ReadOnly = true;
            this.customerTb.Size = new System.Drawing.Size(100, 20);
            this.customerTb.TabIndex = 4;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.contentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentPanel.FormattingEnabled = true;
            this.contentPanel.Location = new System.Drawing.Point(16, 77);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(194, 119);
            this.contentPanel.TabIndex = 20;
            // 
            // paymentTb
            // 
            this.paymentTb.FormattingEnabled = true;
            this.paymentTb.Location = new System.Drawing.Point(110, 254);
            this.paymentTb.Name = "paymentTb";
            this.paymentTb.Size = new System.Drawing.Size(100, 21);
            this.paymentTb.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Payment:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(46, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "State:";
            // 
            // stateTb
            // 
            this.stateTb.FormattingEnabled = true;
            this.stateTb.Location = new System.Drawing.Point(110, 283);
            this.stateTb.Name = "stateTb";
            this.stateTb.Size = new System.Drawing.Size(100, 21);
            this.stateTb.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(47, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Price:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.priceLabel.Location = new System.Drawing.Point(106, 208);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(83, 22);
            this.priceLabel.TabIndex = 26;
            this.priceLabel.Text = "123 RUB";
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(12, 325);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(200, 41);
            this.confirmButton.TabIndex = 27;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 373);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stateTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paymentTb);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.customerTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.label1);
            this.Name = "OrderView";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerTb;
        private System.Windows.Forms.ListBox contentPanel;
        private System.Windows.Forms.ComboBox paymentTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox stateTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button confirmButton;
    }
}