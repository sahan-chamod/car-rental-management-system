namespace AYUBODRIVE
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControlUsers = new System.Windows.Forms.TabControl();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.guna2GradientButtonDeleteList = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButtonEditAT = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButtonADDNEW = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2DataGridViewUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabPageAddUser = new System.Windows.Forms.TabPage();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnADD = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxUName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxUID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxUPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.tabControlUsers.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewUsers)).BeginInit();
            this.tabPageAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1221, 84);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Users";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(38)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 55;
            this.iconPictureBox1.Location = new System.Drawing.Point(14, 14);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(55, 56);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 84);
            this.panel3.TabIndex = 0;
            // 
            // tabControlUsers
            // 
            this.tabControlUsers.Controls.Add(this.tabPageUsers);
            this.tabControlUsers.Controls.Add(this.tabPageAddUser);
            this.tabControlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlUsers.Location = new System.Drawing.Point(0, 84);
            this.tabControlUsers.Name = "tabControlUsers";
            this.tabControlUsers.SelectedIndex = 0;
            this.tabControlUsers.Size = new System.Drawing.Size(1221, 799);
            this.tabControlUsers.TabIndex = 5;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.guna2GradientButtonDeleteList);
            this.tabPageUsers.Controls.Add(this.guna2GradientButtonEditAT);
            this.tabPageUsers.Controls.Add(this.guna2GradientButtonADDNEW);
            this.tabPageUsers.Controls.Add(this.guna2DataGridViewUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(1213, 773);
            this.tabPageUsers.TabIndex = 0;
            this.tabPageUsers.Text = "USER LIST";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // guna2GradientButtonDeleteList
            // 
            this.guna2GradientButtonDeleteList.Animated = true;
            this.guna2GradientButtonDeleteList.AutoRoundedCorners = true;
            this.guna2GradientButtonDeleteList.BorderRadius = 17;
            this.guna2GradientButtonDeleteList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButtonDeleteList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButtonDeleteList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButtonDeleteList.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButtonDeleteList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButtonDeleteList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.guna2GradientButtonDeleteList.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.guna2GradientButtonDeleteList.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButtonDeleteList.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButtonDeleteList.Location = new System.Drawing.Point(1101, 132);
            this.guna2GradientButtonDeleteList.Name = "guna2GradientButtonDeleteList";
            this.guna2GradientButtonDeleteList.Size = new System.Drawing.Size(104, 36);
            this.guna2GradientButtonDeleteList.TabIndex = 37;
            this.guna2GradientButtonDeleteList.Text = "DELETE";
            this.guna2GradientButtonDeleteList.Click += new System.EventHandler(this.guna2GradientButtonDeleteList_Click);
            // 
            // guna2GradientButtonEditAT
            // 
            this.guna2GradientButtonEditAT.Animated = true;
            this.guna2GradientButtonEditAT.AutoRoundedCorners = true;
            this.guna2GradientButtonEditAT.BorderRadius = 17;
            this.guna2GradientButtonEditAT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButtonEditAT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButtonEditAT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButtonEditAT.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButtonEditAT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButtonEditAT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.guna2GradientButtonEditAT.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.guna2GradientButtonEditAT.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButtonEditAT.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButtonEditAT.Location = new System.Drawing.Point(1101, 90);
            this.guna2GradientButtonEditAT.Name = "guna2GradientButtonEditAT";
            this.guna2GradientButtonEditAT.Size = new System.Drawing.Size(104, 36);
            this.guna2GradientButtonEditAT.TabIndex = 36;
            this.guna2GradientButtonEditAT.Text = "EDIT";
            this.guna2GradientButtonEditAT.Click += new System.EventHandler(this.guna2GradientButtonEditAT_Click);
            // 
            // guna2GradientButtonADDNEW
            // 
            this.guna2GradientButtonADDNEW.Animated = true;
            this.guna2GradientButtonADDNEW.AutoRoundedCorners = true;
            this.guna2GradientButtonADDNEW.BorderRadius = 17;
            this.guna2GradientButtonADDNEW.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButtonADDNEW.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButtonADDNEW.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButtonADDNEW.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButtonADDNEW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButtonADDNEW.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.guna2GradientButtonADDNEW.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.guna2GradientButtonADDNEW.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButtonADDNEW.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButtonADDNEW.Location = new System.Drawing.Point(1101, 48);
            this.guna2GradientButtonADDNEW.Name = "guna2GradientButtonADDNEW";
            this.guna2GradientButtonADDNEW.Size = new System.Drawing.Size(104, 36);
            this.guna2GradientButtonADDNEW.TabIndex = 35;
            this.guna2GradientButtonADDNEW.Text = "ADD NEW";
            this.guna2GradientButtonADDNEW.Click += new System.EventHandler(this.guna2GradientButtonADDNEW_Click);
            // 
            // guna2DataGridViewUsers
            // 
            this.guna2DataGridViewUsers.AllowUserToAddRows = false;
            this.guna2DataGridViewUsers.AllowUserToDeleteRows = false;
            this.guna2DataGridViewUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridViewUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.guna2DataGridViewUsers.ColumnHeadersHeight = 24;
            this.guna2DataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle23;
            this.guna2DataGridViewUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewUsers.Location = new System.Drawing.Point(10, 48);
            this.guna2DataGridViewUsers.Name = "guna2DataGridViewUsers";
            this.guna2DataGridViewUsers.ReadOnly = true;
            this.guna2DataGridViewUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.guna2DataGridViewUsers.RowHeadersVisible = false;
            this.guna2DataGridViewUsers.Size = new System.Drawing.Size(1085, 702);
            this.guna2DataGridViewUsers.TabIndex = 0;
            this.guna2DataGridViewUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridViewUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewUsers.ThemeStyle.HeaderStyle.Height = 24;
            this.guna2DataGridViewUsers.ThemeStyle.ReadOnly = true;
            this.guna2DataGridViewUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewUsers.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridViewUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridViewUsers_CellContentClick);
            // 
            // tabPageAddUser
            // 
            this.tabPageAddUser.Controls.Add(this.label3);
            this.tabPageAddUser.Controls.Add(this.TextBoxUPassword);
            this.tabPageAddUser.Controls.Add(this.btnDelete);
            this.tabPageAddUser.Controls.Add(this.btnClear);
            this.tabPageAddUser.Controls.Add(this.btnADD);
            this.tabPageAddUser.Controls.Add(this.btnEdit);
            this.tabPageAddUser.Controls.Add(this.label6);
            this.tabPageAddUser.Controls.Add(this.TextBoxUName);
            this.tabPageAddUser.Controls.Add(this.label2);
            this.tabPageAddUser.Controls.Add(this.TextBoxUID);
            this.tabPageAddUser.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddUser.Name = "tabPageAddUser";
            this.tabPageAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddUser.Size = new System.Drawing.Size(1213, 773);
            this.tabPageAddUser.TabIndex = 1;
            this.tabPageAddUser.Text = "ADD USER";
            this.tabPageAddUser.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BorderRadius = 17;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.btnDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.btnDelete.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(801, 644);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 36);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Animated = true;
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.BorderRadius = 17;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.btnClear.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.btnClear.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(949, 644);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 36);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "CLEAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnADD
            // 
            this.btnADD.Animated = true;
            this.btnADD.AutoRoundedCorners = true;
            this.btnADD.BorderRadius = 17;
            this.btnADD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnADD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnADD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnADD.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnADD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnADD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.btnADD.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.btnADD.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Location = new System.Drawing.Point(505, 644);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(142, 36);
            this.btnADD.TabIndex = 34;
            this.btnADD.Text = "ADD";
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.AutoRoundedCorners = true;
            this.btnEdit.BorderRadius = 17;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.btnEdit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.btnEdit.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(653, 644);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 36);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "SAVE";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "User Name";
            // 
            // TextBoxUName
            // 
            this.TextBoxUName.Animated = true;
            this.TextBoxUName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.TextBoxUName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUName.DefaultText = "";
            this.TextBoxUName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxUName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxUName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUName.ForeColor = System.Drawing.Color.Black;
            this.TextBoxUName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUName.Location = new System.Drawing.Point(12, 129);
            this.TextBoxUName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxUName.Name = "TextBoxUName";
            this.TextBoxUName.PasswordChar = '\0';
            this.TextBoxUName.PlaceholderText = "";
            this.TextBoxUName.SelectedText = "";
            this.TextBoxUName.Size = new System.Drawing.Size(260, 36);
            this.TextBoxUName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "User ID";
            // 
            // TextBoxUID
            // 
            this.TextBoxUID.Animated = true;
            this.TextBoxUID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.TextBoxUID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUID.DefaultText = "";
            this.TextBoxUID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxUID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxUID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUID.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUID.ForeColor = System.Drawing.Color.Black;
            this.TextBoxUID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUID.Location = new System.Drawing.Point(10, 43);
            this.TextBoxUID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxUID.Name = "TextBoxUID";
            this.TextBoxUID.PasswordChar = '\0';
            this.TextBoxUID.PlaceholderText = "";
            this.TextBoxUID.SelectedText = "";
            this.TextBoxUID.Size = new System.Drawing.Size(260, 36);
            this.TextBoxUID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(312, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "User Password";
            // 
            // TextBoxUPassword
            // 
            this.TextBoxUPassword.Animated = true;
            this.TextBoxUPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.TextBoxUPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUPassword.DefaultText = "";
            this.TextBoxUPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxUPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxUPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUPassword.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUPassword.ForeColor = System.Drawing.Color.Black;
            this.TextBoxUPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUPassword.Location = new System.Drawing.Point(314, 129);
            this.TextBoxUPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxUPassword.Name = "TextBoxUPassword";
            this.TextBoxUPassword.PasswordChar = '\0';
            this.TextBoxUPassword.PlaceholderText = "";
            this.TextBoxUPassword.SelectedText = "";
            this.TextBoxUPassword.Size = new System.Drawing.Size(260, 36);
            this.TextBoxUPassword.TabIndex = 37;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 883);
            this.Controls.Add(this.tabControlUsers);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.tabControlUsers.ResumeLayout(false);
            this.tabPageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewUsers)).EndInit();
            this.tabPageAddUser.ResumeLayout(false);
            this.tabPageAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControlUsers;
        private System.Windows.Forms.TabPage tabPageUsers;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButtonDeleteList;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButtonEditAT;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButtonADDNEW;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewUsers;
        private System.Windows.Forms.TabPage tabPageAddUser;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private Guna.UI2.WinForms.Guna2GradientButton btnClear;
        private Guna.UI2.WinForms.Guna2GradientButton btnADD;
        private Guna.UI2.WinForms.Guna2GradientButton btnEdit;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUID;
    }
}