namespace Orderinho
{
    partial class AdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.allOrdersGridView = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.allOrdersTab = new System.Windows.Forms.TabPage();
            this.ordersEditButton = new System.Windows.Forms.Button();
            this.activeOrdersTab = new System.Windows.Forms.TabPage();
            this.activeEditButton = new System.Windows.Forms.Button();
            this.activeOrdersGridView = new System.Windows.Forms.DataGridView();
            this.usersTab = new System.Windows.Forms.TabPage();
            this.usersEditButton = new System.Windows.Forms.Button();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdminColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allOrdersGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.allOrdersTab.SuspendLayout();
            this.activeOrdersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeOrdersGridView)).BeginInit();
            this.usersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // allOrdersGridView
            // 
            this.allOrdersGridView.AllowUserToAddRows = false;
            this.allOrdersGridView.AllowUserToDeleteRows = false;
            this.allOrdersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allOrdersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allOrdersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.allOrdersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allOrdersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.allOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allOrdersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.customerColumn,
            this.productsColumn,
            this.addressColumn,
            this.paymentColumn,
            this.stateColumn,
            this.priceColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allOrdersGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.allOrdersGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.allOrdersGridView.Location = new System.Drawing.Point(6, 6);
            this.allOrdersGridView.MultiSelect = false;
            this.allOrdersGridView.Name = "allOrdersGridView";
            this.allOrdersGridView.RowHeadersVisible = false;
            this.allOrdersGridView.Size = new System.Drawing.Size(762, 375);
            this.allOrdersGridView.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.allOrdersTab);
            this.tabControl.Controls.Add(this.activeOrdersTab);
            this.tabControl.Controls.Add(this.usersTab);
            this.tabControl.Location = new System.Drawing.Point(12, 40);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(782, 410);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // allOrdersTab
            // 
            this.allOrdersTab.Controls.Add(this.ordersEditButton);
            this.allOrdersTab.Controls.Add(this.allOrdersGridView);
            this.allOrdersTab.Location = new System.Drawing.Point(4, 22);
            this.allOrdersTab.Name = "allOrdersTab";
            this.allOrdersTab.Padding = new System.Windows.Forms.Padding(3);
            this.allOrdersTab.Size = new System.Drawing.Size(774, 384);
            this.allOrdersTab.TabIndex = 0;
            this.allOrdersTab.Text = "Orders";
            this.allOrdersTab.UseVisualStyleBackColor = true;
            // 
            // ordersEditButton
            // 
            this.ordersEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersEditButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.ordersEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersEditButton.ForeColor = System.Drawing.Color.White;
            this.ordersEditButton.Location = new System.Drawing.Point(668, 333);
            this.ordersEditButton.Name = "ordersEditButton";
            this.ordersEditButton.Size = new System.Drawing.Size(86, 33);
            this.ordersEditButton.TabIndex = 4;
            this.ordersEditButton.Text = "Edit";
            this.ordersEditButton.UseVisualStyleBackColor = false;
            this.ordersEditButton.Click += new System.EventHandler(this.ordersEditButton_Click);
            // 
            // activeOrdersTab
            // 
            this.activeOrdersTab.Controls.Add(this.activeEditButton);
            this.activeOrdersTab.Controls.Add(this.activeOrdersGridView);
            this.activeOrdersTab.Location = new System.Drawing.Point(4, 22);
            this.activeOrdersTab.Name = "activeOrdersTab";
            this.activeOrdersTab.Size = new System.Drawing.Size(774, 384);
            this.activeOrdersTab.TabIndex = 2;
            this.activeOrdersTab.Text = "Active";
            this.activeOrdersTab.UseVisualStyleBackColor = true;
            // 
            // activeEditButton
            // 
            this.activeEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.activeEditButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.activeEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activeEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activeEditButton.ForeColor = System.Drawing.Color.White;
            this.activeEditButton.Location = new System.Drawing.Point(668, 333);
            this.activeEditButton.Name = "activeEditButton";
            this.activeEditButton.Size = new System.Drawing.Size(86, 33);
            this.activeEditButton.TabIndex = 3;
            this.activeEditButton.Text = "Edit";
            this.activeEditButton.UseVisualStyleBackColor = false;
            this.activeEditButton.Click += new System.EventHandler(this.activeEditButton_Click);
            // 
            // activeOrdersGridView
            // 
            this.activeOrdersGridView.AllowUserToAddRows = false;
            this.activeOrdersGridView.AllowUserToDeleteRows = false;
            this.activeOrdersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activeOrdersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.activeOrdersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.activeOrdersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activeOrdersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.activeOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activeOrdersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.activeOrdersGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.activeOrdersGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.activeOrdersGridView.Location = new System.Drawing.Point(6, 6);
            this.activeOrdersGridView.MultiSelect = false;
            this.activeOrdersGridView.Name = "activeOrdersGridView";
            this.activeOrdersGridView.RowHeadersVisible = false;
            this.activeOrdersGridView.Size = new System.Drawing.Size(762, 375);
            this.activeOrdersGridView.TabIndex = 1;
            // 
            // usersTab
            // 
            this.usersTab.Controls.Add(this.usersEditButton);
            this.usersTab.Controls.Add(this.usersGridView);
            this.usersTab.Location = new System.Drawing.Point(4, 22);
            this.usersTab.Name = "usersTab";
            this.usersTab.Padding = new System.Windows.Forms.Padding(3);
            this.usersTab.Size = new System.Drawing.Size(774, 384);
            this.usersTab.TabIndex = 1;
            this.usersTab.Text = "Users";
            this.usersTab.UseVisualStyleBackColor = true;
            // 
            // usersEditButton
            // 
            this.usersEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.usersEditButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.usersEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersEditButton.ForeColor = System.Drawing.Color.White;
            this.usersEditButton.Location = new System.Drawing.Point(668, 333);
            this.usersEditButton.Name = "usersEditButton";
            this.usersEditButton.Size = new System.Drawing.Size(86, 33);
            this.usersEditButton.TabIndex = 2;
            this.usersEditButton.Text = "Edit";
            this.usersEditButton.UseVisualStyleBackColor = false;
            this.usersEditButton.Click += new System.EventHandler(this.usersEditButton_Click);
            // 
            // usersGridView
            // 
            this.usersGridView.AllowUserToAddRows = false;
            this.usersGridView.AllowUserToDeleteRows = false;
            this.usersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.usersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.emailColumn,
            this.nameColumn,
            this.surnameColumn,
            this.midnameColumn,
            this.telephoneColumn,
            this.isAdminColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.usersGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.usersGridView.Location = new System.Drawing.Point(6, 6);
            this.usersGridView.MultiSelect = false;
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.RowHeadersVisible = false;
            this.usersGridView.Size = new System.Drawing.Size(762, 372);
            this.usersGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // emailColumn
            // 
            this.emailColumn.HeaderText = "E-Mail";
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // surnameColumn
            // 
            this.surnameColumn.HeaderText = "Surname";
            this.surnameColumn.Name = "surnameColumn";
            this.surnameColumn.ReadOnly = true;
            // 
            // midnameColumn
            // 
            this.midnameColumn.HeaderText = "Midname";
            this.midnameColumn.Name = "midnameColumn";
            this.midnameColumn.ReadOnly = true;
            // 
            // telephoneColumn
            // 
            this.telephoneColumn.HeaderText = "Telephone";
            this.telephoneColumn.Name = "telephoneColumn";
            this.telephoneColumn.ReadOnly = true;
            // 
            // isAdminColumn
            // 
            this.isAdminColumn.HeaderText = "IsAdmin";
            this.isAdminColumn.Name = "isAdminColumn";
            this.isAdminColumn.ReadOnly = true;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // customerColumn
            // 
            this.customerColumn.HeaderText = "Customer";
            this.customerColumn.Name = "customerColumn";
            this.customerColumn.ReadOnly = true;
            // 
            // productsColumn
            // 
            this.productsColumn.HeaderText = "Products";
            this.productsColumn.Name = "productsColumn";
            this.productsColumn.ReadOnly = true;
            // 
            // addressColumn
            // 
            this.addressColumn.HeaderText = "Address";
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.ReadOnly = true;
            // 
            // paymentColumn
            // 
            this.paymentColumn.HeaderText = "Payment";
            this.paymentColumn.Name = "paymentColumn";
            this.paymentColumn.ReadOnly = true;
            // 
            // stateColumn
            // 
            this.stateColumn.HeaderText = "State";
            this.stateColumn.Name = "stateColumn";
            this.stateColumn.ReadOnly = true;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.Name = "priceColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Products";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Payment";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "State";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Price";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.BackColor = System.Drawing.Color.Red;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(686, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(108, 34);
            this.logoutButton.TabIndex = 13;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 462);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminForm";
            this.Text = "Admin Interface";
            ((System.ComponentModel.ISupportInitialize)(this.allOrdersGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.allOrdersTab.ResumeLayout(false);
            this.activeOrdersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activeOrdersGridView)).EndInit();
            this.usersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allOrdersGridView;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage allOrdersTab;
        private System.Windows.Forms.TabPage usersTab;
        private System.Windows.Forms.TabPage activeOrdersTab;
        private System.Windows.Forms.DataGridView activeOrdersGridView;
        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.Button ordersEditButton;
        private System.Windows.Forms.Button activeEditButton;
        private System.Windows.Forms.Button usersEditButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAdminColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button logoutButton;
    }
}