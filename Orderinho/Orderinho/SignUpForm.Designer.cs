namespace Orderinho
{
    partial class SignUpForm
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
            this.signupButton = new System.Windows.Forms.Button();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.midnameLabel = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.midnameTb = new System.Windows.Forms.TextBox();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.telephoneTb = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signupButton.ForeColor = System.Drawing.Color.White;
            this.signupButton.Location = new System.Drawing.Point(6, 250);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(314, 37);
            this.signupButton.TabIndex = 11;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(104, 177);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(216, 20);
            this.passwordTb.TabIndex = 10;
            this.passwordTb.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(9, 175);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(89, 22);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password";
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(104, 12);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(216, 20);
            this.emailTb.TabIndex = 8;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(44, 10);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(54, 22);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(41, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 22);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(16, 75);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(82, 22);
            this.surnameLabel.TabIndex = 14;
            this.surnameLabel.Text = "Surname";
            // 
            // midnameLabel
            // 
            this.midnameLabel.AutoSize = true;
            this.midnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.midnameLabel.Location = new System.Drawing.Point(16, 110);
            this.midnameLabel.Name = "midnameLabel";
            this.midnameLabel.Size = new System.Drawing.Size(82, 22);
            this.midnameLabel.TabIndex = 15;
            this.midnameLabel.Text = "Midname";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(104, 43);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(216, 20);
            this.nameTb.TabIndex = 16;
            // 
            // surnameTb
            // 
            this.surnameTb.Location = new System.Drawing.Point(104, 77);
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(216, 20);
            this.surnameTb.TabIndex = 17;
            // 
            // midnameTb
            // 
            this.midnameTb.Location = new System.Drawing.Point(104, 110);
            this.midnameTb.Name = "midnameTb";
            this.midnameTb.Size = new System.Drawing.Size(216, 20);
            this.midnameTb.TabIndex = 18;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telephoneLabel.Location = new System.Drawing.Point(2, 144);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(96, 22);
            this.telephoneLabel.TabIndex = 19;
            this.telephoneLabel.Text = "Telephone";
            // 
            // telephoneTb
            // 
            this.telephoneTb.Location = new System.Drawing.Point(104, 146);
            this.telephoneTb.Name = "telephoneTb";
            this.telephoneTb.Size = new System.Drawing.Size(216, 20);
            this.telephoneTb.TabIndex = 20;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(9, 210);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 22);
            this.errorLabel.TabIndex = 21;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 299);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.telephoneTb);
            this.Controls.Add(this.telephoneLabel);
            this.Controls.Add(this.midnameTb);
            this.Controls.Add(this.surnameTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.midnameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.emailLabel);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label midnameLabel;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox surnameTb;
        private System.Windows.Forms.TextBox midnameTb;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.TextBox telephoneTb;
        private System.Windows.Forms.Label errorLabel;
    }
}