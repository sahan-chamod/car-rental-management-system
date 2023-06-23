namespace AYUBODRIVE
{
    partial class Driver
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControlDrivers = new System.Windows.Forms.TabControl();
            this.tabPageDriverList = new System.Windows.Forms.TabPage();
            this.guna2GradientButtonDeleteList = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButtonEditAT = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButtonADDNEW = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2DataGridViewDrivers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabPageAddDriver = new System.Windows.Forms.TabPage();
            this.cmbDriverID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbRelevantID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnADD = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cmbTripType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDriverName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.tabControlDrivers.SuspendLayout();
            this.tabPageDriverList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewDrivers)).BeginInit();
            this.tabPageAddDriver.SuspendLayout();
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
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drivers";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(38)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.IdCard;
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
            // tabControlDrivers
            // 
            this.tabControlDrivers.Controls.Add(this.tabPageDriverList);
            this.tabControlDrivers.Controls.Add(this.tabPageAddDriver);
            this.tabControlDrivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDrivers.Location = new System.Drawing.Point(0, 84);
            this.tabControlDrivers.Name = "tabControlDrivers";
            this.tabControlDrivers.SelectedIndex = 0;
            this.tabControlDrivers.Size = new System.Drawing.Size(1221, 799);
            this.tabControlDrivers.TabIndex = 6;
            // 
            // tabPageDriverList
            // 
            this.tabPageDriverList.Controls.Add(this.guna2GradientButtonDeleteList);
            this.tabPageDriverList.Controls.Add(this.guna2GradientButtonEditAT);
            this.tabPageDriverList.Controls.Add(this.guna2GradientButtonADDNEW);
            this.tabPageDriverList.Controls.Add(this.guna2DataGridViewDrivers);
            this.tabPageDriverList.Location = new System.Drawing.Point(4, 22);
            this.tabPageDriverList.Name = "tabPageDriverList";
            this.tabPageDriverList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDriverList.Size = new System.Drawing.Size(1213, 773);
            this.tabPageDriverList.TabIndex = 0;
            this.tabPageDriverList.Text = "DRIVER LIST";
            this.tabPageDriverList.UseVisualStyleBackColor = true;
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
            // guna2DataGridViewDrivers
            // 
            this.guna2DataGridViewDrivers.AllowUserToAddRows = false;
            this.guna2DataGridViewDrivers.AllowUserToDeleteRows = false;
            this.guna2DataGridViewDrivers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridViewDrivers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridViewDrivers.ColumnHeadersHeight = 24;
            this.guna2DataGridViewDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewDrivers.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridViewDrivers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewDrivers.Location = new System.Drawing.Point(10, 48);
            this.guna2DataGridViewDrivers.Name = "guna2DataGridViewDrivers";
            this.guna2DataGridViewDrivers.ReadOnly = true;
            this.guna2DataGridViewDrivers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewDrivers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridViewDrivers.RowHeadersVisible = false;
            this.guna2DataGridViewDrivers.Size = new System.Drawing.Size(1085, 702);
            this.guna2DataGridViewDrivers.TabIndex = 0;
            this.guna2DataGridViewDrivers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewDrivers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridViewDrivers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewDrivers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewDrivers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewDrivers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewDrivers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewDrivers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewDrivers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewDrivers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewDrivers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewDrivers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewDrivers.ThemeStyle.HeaderStyle.Height = 24;
            this.guna2DataGridViewDrivers.ThemeStyle.ReadOnly = true;
            this.guna2DataGridViewDrivers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewDrivers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewDrivers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewDrivers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewDrivers.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridViewDrivers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewDrivers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewDrivers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridViewDrivers_CellContentClick);
            // 
            // tabPageAddDriver
            // 
            this.tabPageAddDriver.Controls.Add(this.cmbDriverID);
            this.tabPageAddDriver.Controls.Add(this.cmbRelevantID);
            this.tabPageAddDriver.Controls.Add(this.label8);
            this.tabPageAddDriver.Controls.Add(this.btnDelete);
            this.tabPageAddDriver.Controls.Add(this.btnClear);
            this.tabPageAddDriver.Controls.Add(this.btnADD);
            this.tabPageAddDriver.Controls.Add(this.btnEdit);
            this.tabPageAddDriver.Controls.Add(this.cmbTripType);
            this.tabPageAddDriver.Controls.Add(this.label7);
            this.tabPageAddDriver.Controls.Add(this.label6);
            this.tabPageAddDriver.Controls.Add(this.textBoxDriverName);
            this.tabPageAddDriver.Controls.Add(this.label4);
            this.tabPageAddDriver.Controls.Add(this.label2);
            this.tabPageAddDriver.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddDriver.Name = "tabPageAddDriver";
            this.tabPageAddDriver.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddDriver.Size = new System.Drawing.Size(1213, 773);
            this.tabPageAddDriver.TabIndex = 1;
            this.tabPageAddDriver.Text = "ADD DRIVER";
            this.tabPageAddDriver.UseVisualStyleBackColor = true;
            // 
            // cmbDriverID
            // 
            this.cmbDriverID.BackColor = System.Drawing.Color.Transparent;
            this.cmbDriverID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.cmbDriverID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDriverID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDriverID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDriverID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDriverID.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.cmbDriverID.ForeColor = System.Drawing.Color.Black;
            this.cmbDriverID.ItemHeight = 30;
            this.cmbDriverID.Location = new System.Drawing.Point(10, 42);
            this.cmbDriverID.Name = "cmbDriverID";
            this.cmbDriverID.Size = new System.Drawing.Size(262, 36);
            this.cmbDriverID.TabIndex = 39;
            // 
            // cmbRelevantID
            // 
            this.cmbRelevantID.BackColor = System.Drawing.Color.Transparent;
            this.cmbRelevantID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.cmbRelevantID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRelevantID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelevantID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRelevantID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRelevantID.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.cmbRelevantID.ForeColor = System.Drawing.Color.Black;
            this.cmbRelevantID.ItemHeight = 30;
            this.cmbRelevantID.Location = new System.Drawing.Point(590, 129);
            this.cmbRelevantID.Name = "cmbRelevantID";
            this.cmbRelevantID.Size = new System.Drawing.Size(237, 36);
            this.cmbRelevantID.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(586, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 22);
            this.label8.TabIndex = 37;
            this.label8.Text = "Relevant ID";
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
            this.btnDelete.Location = new System.Drawing.Point(310, 230);
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
            this.btnClear.Location = new System.Drawing.Point(458, 230);
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
            this.btnADD.Location = new System.Drawing.Point(14, 230);
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
            this.btnEdit.Location = new System.Drawing.Point(162, 230);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 36);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "SAVE";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbTripType
            // 
            this.cmbTripType.BackColor = System.Drawing.Color.Transparent;
            this.cmbTripType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.cmbTripType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTripType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTripType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTripType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTripType.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.cmbTripType.ForeColor = System.Drawing.Color.Black;
            this.cmbTripType.ItemHeight = 30;
            this.cmbTripType.Items.AddRange(new object[] {
            "Rental",
            "Day Tour",
            "Long Tour"});
            this.cmbTripType.Location = new System.Drawing.Point(311, 129);
            this.cmbTripType.Name = "cmbTripType";
            this.cmbTripType.Size = new System.Drawing.Size(237, 36);
            this.cmbTripType.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(307, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Travel Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Driver Name";
            // 
            // textBoxDriverName
            // 
            this.textBoxDriverName.Animated = true;
            this.textBoxDriverName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.textBoxDriverName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDriverName.DefaultText = "";
            this.textBoxDriverName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxDriverName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxDriverName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDriverName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDriverName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDriverName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDriverName.ForeColor = System.Drawing.Color.Black;
            this.textBoxDriverName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDriverName.Location = new System.Drawing.Point(12, 129);
            this.textBoxDriverName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDriverName.Name = "textBoxDriverName";
            this.textBoxDriverName.PasswordChar = '\0';
            this.textBoxDriverName.PlaceholderText = "";
            this.textBoxDriverName.SelectedText = "";
            this.textBoxDriverName.Size = new System.Drawing.Size(260, 36);
            this.textBoxDriverName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(605, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Driver ID";
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 883);
            this.Controls.Add(this.tabControlDrivers);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Driver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver";
            this.Load += new System.EventHandler(this.Driver_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.tabControlDrivers.ResumeLayout(false);
            this.tabPageDriverList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewDrivers)).EndInit();
            this.tabPageAddDriver.ResumeLayout(false);
            this.tabPageAddDriver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControlDrivers;
        private System.Windows.Forms.TabPage tabPageDriverList;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButtonDeleteList;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButtonEditAT;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButtonADDNEW;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewDrivers;
        private System.Windows.Forms.TabPage tabPageAddDriver;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRelevantID;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private Guna.UI2.WinForms.Guna2GradientButton btnClear;
        private Guna.UI2.WinForms.Guna2GradientButton btnADD;
        private Guna.UI2.WinForms.Guna2GradientButton btnEdit;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTripType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDriverName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDriverID;
    }
}