namespace AYUBODRIVE
{
    partial class Vehicles
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
            this.tabControlVehicles = new System.Windows.Forms.TabControl();
            this.tabPageVehicles = new System.Windows.Forms.TabPage();
            this.RefreshButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ComboBoxSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GradientButtonDeleteList = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButtonEditAT = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButtonADDNEW = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2DataGridViewVehicles = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabPageAddVehicle = new System.Windows.Forms.TabPage();
            this.cmbVehAvailability = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxVehCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxVehBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxVehType = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnADD = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxVehNumPlate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxVehRegNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.tabControlVehicles.SuspendLayout();
            this.tabPageVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewVehicles)).BeginInit();
            this.tabPageAddVehicle.SuspendLayout();
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
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vehicles";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(38)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Car;
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
            // tabControlVehicles
            // 
            this.tabControlVehicles.Controls.Add(this.tabPageVehicles);
            this.tabControlVehicles.Controls.Add(this.tabPageAddVehicle);
            this.tabControlVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlVehicles.Location = new System.Drawing.Point(0, 84);
            this.tabControlVehicles.Name = "tabControlVehicles";
            this.tabControlVehicles.SelectedIndex = 0;
            this.tabControlVehicles.Size = new System.Drawing.Size(1221, 799);
            this.tabControlVehicles.TabIndex = 9;
            // 
            // tabPageVehicles
            // 
            this.tabPageVehicles.Controls.Add(this.RefreshButton);
            this.tabPageVehicles.Controls.Add(this.ComboBoxSearch);
            this.tabPageVehicles.Controls.Add(this.guna2GradientButtonDeleteList);
            this.tabPageVehicles.Controls.Add(this.guna2GradientButtonEditAT);
            this.tabPageVehicles.Controls.Add(this.guna2GradientButtonADDNEW);
            this.tabPageVehicles.Controls.Add(this.guna2DataGridViewVehicles);
            this.tabPageVehicles.Location = new System.Drawing.Point(4, 22);
            this.tabPageVehicles.Name = "tabPageVehicles";
            this.tabPageVehicles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVehicles.Size = new System.Drawing.Size(1213, 773);
            this.tabPageVehicles.TabIndex = 0;
            this.tabPageVehicles.Text = "VEHICLE LIST";
            this.tabPageVehicles.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Animated = true;
            this.RefreshButton.AutoRoundedCorners = true;
            this.RefreshButton.BorderRadius = 17;
            this.RefreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RefreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RefreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RefreshButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RefreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RefreshButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.RefreshButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.RefreshButton.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.Location = new System.Drawing.Point(253, 24);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(104, 36);
            this.RefreshButton.TabIndex = 47;
            this.RefreshButton.Text = "REFRESH";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ComboBoxSearch
            // 
            this.ComboBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.ComboBoxSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxSearch.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.ComboBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxSearch.ItemHeight = 30;
            this.ComboBoxSearch.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.ComboBoxSearch.Location = new System.Drawing.Point(10, 24);
            this.ComboBoxSearch.Name = "ComboBoxSearch";
            this.ComboBoxSearch.Size = new System.Drawing.Size(237, 36);
            this.ComboBoxSearch.TabIndex = 46;
            this.ComboBoxSearch.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxSearch_SelectionChangeCommitted);
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
            this.guna2GradientButtonDeleteList.Location = new System.Drawing.Point(1101, 165);
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
            this.guna2GradientButtonEditAT.Location = new System.Drawing.Point(1101, 123);
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
            this.guna2GradientButtonADDNEW.Location = new System.Drawing.Point(1101, 81);
            this.guna2GradientButtonADDNEW.Name = "guna2GradientButtonADDNEW";
            this.guna2GradientButtonADDNEW.Size = new System.Drawing.Size(104, 36);
            this.guna2GradientButtonADDNEW.TabIndex = 35;
            this.guna2GradientButtonADDNEW.Text = "ADD NEW";
            this.guna2GradientButtonADDNEW.Click += new System.EventHandler(this.guna2GradientButtonADDNEW_Click);
            // 
            // guna2DataGridViewVehicles
            // 
            this.guna2DataGridViewVehicles.AllowUserToAddRows = false;
            this.guna2DataGridViewVehicles.AllowUserToDeleteRows = false;
            this.guna2DataGridViewVehicles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridViewVehicles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridViewVehicles.ColumnHeadersHeight = 24;
            this.guna2DataGridViewVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewVehicles.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridViewVehicles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewVehicles.Location = new System.Drawing.Point(10, 81);
            this.guna2DataGridViewVehicles.Name = "guna2DataGridViewVehicles";
            this.guna2DataGridViewVehicles.ReadOnly = true;
            this.guna2DataGridViewVehicles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewVehicles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridViewVehicles.RowHeadersVisible = false;
            this.guna2DataGridViewVehicles.Size = new System.Drawing.Size(1085, 669);
            this.guna2DataGridViewVehicles.TabIndex = 0;
            this.guna2DataGridViewVehicles.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewVehicles.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridViewVehicles.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewVehicles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewVehicles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewVehicles.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewVehicles.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewVehicles.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewVehicles.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewVehicles.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewVehicles.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewVehicles.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewVehicles.ThemeStyle.HeaderStyle.Height = 24;
            this.guna2DataGridViewVehicles.ThemeStyle.ReadOnly = true;
            this.guna2DataGridViewVehicles.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewVehicles.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewVehicles.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewVehicles.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewVehicles.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridViewVehicles.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewVehicles.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridViewVehicles_CellContentClick);
            // 
            // tabPageAddVehicle
            // 
            this.tabPageAddVehicle.Controls.Add(this.cmbVehAvailability);
            this.tabPageAddVehicle.Controls.Add(this.label7);
            this.tabPageAddVehicle.Controls.Add(this.label5);
            this.tabPageAddVehicle.Controls.Add(this.TextBoxVehCost);
            this.tabPageAddVehicle.Controls.Add(this.label4);
            this.tabPageAddVehicle.Controls.Add(this.TextBoxVehBrand);
            this.tabPageAddVehicle.Controls.Add(this.label3);
            this.tabPageAddVehicle.Controls.Add(this.TextBoxVehType);
            this.tabPageAddVehicle.Controls.Add(this.btnDelete);
            this.tabPageAddVehicle.Controls.Add(this.btnClear);
            this.tabPageAddVehicle.Controls.Add(this.btnADD);
            this.tabPageAddVehicle.Controls.Add(this.btnEdit);
            this.tabPageAddVehicle.Controls.Add(this.label6);
            this.tabPageAddVehicle.Controls.Add(this.TextBoxVehNumPlate);
            this.tabPageAddVehicle.Controls.Add(this.label2);
            this.tabPageAddVehicle.Controls.Add(this.TextBoxVehRegNum);
            this.tabPageAddVehicle.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddVehicle.Name = "tabPageAddVehicle";
            this.tabPageAddVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddVehicle.Size = new System.Drawing.Size(1213, 773);
            this.tabPageAddVehicle.TabIndex = 1;
            this.tabPageAddVehicle.Text = "ADD VEHICLE";
            this.tabPageAddVehicle.UseVisualStyleBackColor = true;
            // 
            // cmbVehAvailability
            // 
            this.cmbVehAvailability.BackColor = System.Drawing.Color.Transparent;
            this.cmbVehAvailability.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.cmbVehAvailability.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVehAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehAvailability.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbVehAvailability.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbVehAvailability.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.cmbVehAvailability.ForeColor = System.Drawing.Color.Black;
            this.cmbVehAvailability.ItemHeight = 30;
            this.cmbVehAvailability.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmbVehAvailability.Location = new System.Drawing.Point(614, 216);
            this.cmbVehAvailability.Name = "cmbVehAvailability";
            this.cmbVehAvailability.Size = new System.Drawing.Size(237, 36);
            this.cmbVehAvailability.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(610, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 44;
            this.label7.Text = "Availability";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(314, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 22);
            this.label5.TabIndex = 42;
            this.label5.Text = "Cost";
            // 
            // TextBoxVehCost
            // 
            this.TextBoxVehCost.Animated = true;
            this.TextBoxVehCost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.TextBoxVehCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxVehCost.DefaultText = "";
            this.TextBoxVehCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxVehCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxVehCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxVehCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxVehCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxVehCost.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxVehCost.ForeColor = System.Drawing.Color.Black;
            this.TextBoxVehCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxVehCost.Location = new System.Drawing.Point(316, 216);
            this.TextBoxVehCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxVehCost.Name = "TextBoxVehCost";
            this.TextBoxVehCost.PasswordChar = '\0';
            this.TextBoxVehCost.PlaceholderText = "";
            this.TextBoxVehCost.SelectedText = "";
            this.TextBoxVehCost.Size = new System.Drawing.Size(260, 36);
            this.TextBoxVehCost.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "Brand";
            // 
            // TextBoxVehBrand
            // 
            this.TextBoxVehBrand.Animated = true;
            this.TextBoxVehBrand.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.TextBoxVehBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxVehBrand.DefaultText = "";
            this.TextBoxVehBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxVehBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxVehBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxVehBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxVehBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxVehBrand.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxVehBrand.ForeColor = System.Drawing.Color.Black;
            this.TextBoxVehBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxVehBrand.Location = new System.Drawing.Point(12, 216);
            this.TextBoxVehBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxVehBrand.Name = "TextBoxVehBrand";
            this.TextBoxVehBrand.PasswordChar = '\0';
            this.TextBoxVehBrand.PlaceholderText = "";
            this.TextBoxVehBrand.SelectedText = "";
            this.TextBoxVehBrand.Size = new System.Drawing.Size(260, 36);
            this.TextBoxVehBrand.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(312, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "Vehicle Type";
            // 
            // TextBoxVehType
            // 
            this.TextBoxVehType.Animated = true;
            this.TextBoxVehType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.TextBoxVehType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxVehType.DefaultText = "";
            this.TextBoxVehType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxVehType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxVehType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxVehType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxVehType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxVehType.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxVehType.ForeColor = System.Drawing.Color.Black;
            this.TextBoxVehType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxVehType.Location = new System.Drawing.Point(314, 129);
            this.TextBoxVehType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxVehType.Name = "TextBoxVehType";
            this.TextBoxVehType.PasswordChar = '\0';
            this.TextBoxVehType.PlaceholderText = "";
            this.TextBoxVehType.SelectedText = "";
            this.TextBoxVehType.Size = new System.Drawing.Size(260, 36);
            this.TextBoxVehType.TabIndex = 37;
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
            this.label6.Size = new System.Drawing.Size(145, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vehicle NUM Plate";
            // 
            // TextBoxVehNumPlate
            // 
            this.TextBoxVehNumPlate.Animated = true;
            this.TextBoxVehNumPlate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.TextBoxVehNumPlate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxVehNumPlate.DefaultText = "";
            this.TextBoxVehNumPlate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxVehNumPlate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxVehNumPlate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxVehNumPlate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxVehNumPlate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxVehNumPlate.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxVehNumPlate.ForeColor = System.Drawing.Color.Black;
            this.TextBoxVehNumPlate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxVehNumPlate.Location = new System.Drawing.Point(12, 129);
            this.TextBoxVehNumPlate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxVehNumPlate.Name = "TextBoxVehNumPlate";
            this.TextBoxVehNumPlate.PasswordChar = '\0';
            this.TextBoxVehNumPlate.PlaceholderText = "";
            this.TextBoxVehNumPlate.SelectedText = "";
            this.TextBoxVehNumPlate.Size = new System.Drawing.Size(260, 36);
            this.TextBoxVehNumPlate.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehicle REG NUM";
            // 
            // TextBoxVehRegNum
            // 
            this.TextBoxVehRegNum.Animated = true;
            this.TextBoxVehRegNum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.TextBoxVehRegNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxVehRegNum.DefaultText = "";
            this.TextBoxVehRegNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxVehRegNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxVehRegNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxVehRegNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxVehRegNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxVehRegNum.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxVehRegNum.ForeColor = System.Drawing.Color.Black;
            this.TextBoxVehRegNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxVehRegNum.Location = new System.Drawing.Point(10, 43);
            this.TextBoxVehRegNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxVehRegNum.Name = "TextBoxVehRegNum";
            this.TextBoxVehRegNum.PasswordChar = '\0';
            this.TextBoxVehRegNum.PlaceholderText = "";
            this.TextBoxVehRegNum.SelectedText = "";
            this.TextBoxVehRegNum.Size = new System.Drawing.Size(260, 36);
            this.TextBoxVehRegNum.TabIndex = 0;
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 883);
            this.Controls.Add(this.tabControlVehicles);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Vehicles_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.tabControlVehicles.ResumeLayout(false);
            this.tabPageVehicles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewVehicles)).EndInit();
            this.tabPageAddVehicle.ResumeLayout(false);
            this.tabPageAddVehicle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControlVehicles;
        private System.Windows.Forms.TabPage tabPageVehicles;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButtonDeleteList;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButtonEditAT;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButtonADDNEW;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewVehicles;
        private System.Windows.Forms.TabPage tabPageAddVehicle;
        private Guna.UI2.WinForms.Guna2ComboBox cmbVehAvailability;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxVehCost;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxVehBrand;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxVehType;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private Guna.UI2.WinForms.Guna2GradientButton btnClear;
        private Guna.UI2.WinForms.Guna2GradientButton btnADD;
        private Guna.UI2.WinForms.Guna2GradientButton btnEdit;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxVehNumPlate;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxVehRegNum;
        private Guna.UI2.WinForms.Guna2GradientButton RefreshButton;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxSearch;
    }
}