namespace EnterpriseGames.UI.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblEmployee = new MetroFramework.Controls.MetroLabel();
            this.tglShowMenu = new MetroFramework.Controls.MetroToggle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowGames = new MetroFramework.Controls.MetroButton();
            this.btnShowGenres = new MetroFramework.Controls.MetroButton();
            this.btnShowEmployees = new MetroFramework.Controls.MetroButton();
            this.btnShowCustomers = new MetroFramework.Controls.MetroButton();
            this.btnShowOrders = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowHelp = new MetroFramework.Controls.MetroButton();
            this.btnChangeUser = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.flpShowsMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.dtgOrders = new MetroFramework.Controls.MetroGrid();
            this.OderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateClosed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpItems = new System.Windows.Forms.TableLayoutPanel();
            this.lblPositions = new MetroFramework.Controls.MetroLabel();
            this.dtgItems = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblCurrentTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.oderButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.lblCount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnMakeReport = new MetroFramework.Controls.MetroButton();
            this.btnDownloadReport = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flpShowsMenu.SuspendLayout();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrders)).BeginInit();
            this.tlpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItems)).BeginInit();
            this.oderButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEmployee.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmployee.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEmployee.Location = new System.Drawing.Point(873, 60);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(348, 25);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Администратор: Иванов Иван Иванович";
            // 
            // tglShowMenu
            // 
            this.tglShowMenu.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglShowMenu.Checked = true;
            this.tglShowMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tglShowMenu.DisplayStatus = false;
            this.tglShowMenu.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.tglShowMenu.Location = new System.Drawing.Point(94, 97);
            this.tglShowMenu.Name = "tglShowMenu";
            this.tglShowMenu.Size = new System.Drawing.Size(62, 22);
            this.tglShowMenu.TabIndex = 2;
            this.tglShowMenu.Text = "On";
            this.tglShowMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglShowMenu.UseSelectable = true;
            this.tglShowMenu.CheckedChanged += new System.EventHandler(this.tglShowMenu_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "МЕНЮ";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnShowGames);
            this.flowLayoutPanel1.Controls.Add(this.btnShowGenres);
            this.flowLayoutPanel1.Controls.Add(this.btnShowEmployees);
            this.flowLayoutPanel1.Controls.Add(this.btnShowCustomers);
            this.flowLayoutPanel1.Controls.Add(this.btnShowOrders);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(127, 232);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnShowGames
            // 
            this.btnShowGames.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShowGames.Location = new System.Drawing.Point(3, 3);
            this.btnShowGames.Name = "btnShowGames";
            this.btnShowGames.Size = new System.Drawing.Size(119, 40);
            this.btnShowGames.TabIndex = 8;
            this.btnShowGames.Text = "Игры";
            this.btnShowGames.UseSelectable = true;
            this.btnShowGames.Click += new System.EventHandler(this.btnShowGames_Click);
            // 
            // btnShowGenres
            // 
            this.btnShowGenres.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShowGenres.Location = new System.Drawing.Point(3, 49);
            this.btnShowGenres.Name = "btnShowGenres";
            this.btnShowGenres.Size = new System.Drawing.Size(119, 40);
            this.btnShowGenres.TabIndex = 9;
            this.btnShowGenres.Text = "Жанры";
            this.btnShowGenres.UseSelectable = true;
            this.btnShowGenres.Click += new System.EventHandler(this.btnShowGenres_Click);
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShowEmployees.Location = new System.Drawing.Point(3, 95);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.Size = new System.Drawing.Size(119, 40);
            this.btnShowEmployees.TabIndex = 10;
            this.btnShowEmployees.Text = "Сотрудники";
            this.btnShowEmployees.UseSelectable = true;
            this.btnShowEmployees.Click += new System.EventHandler(this.btnShowEmployees_Click);
            // 
            // btnShowCustomers
            // 
            this.btnShowCustomers.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShowCustomers.Location = new System.Drawing.Point(3, 141);
            this.btnShowCustomers.Name = "btnShowCustomers";
            this.btnShowCustomers.Size = new System.Drawing.Size(119, 40);
            this.btnShowCustomers.TabIndex = 12;
            this.btnShowCustomers.Text = "Клиенты";
            this.btnShowCustomers.UseSelectable = true;
            this.btnShowCustomers.Click += new System.EventHandler(this.btnShowCustomers_Click);
            // 
            // btnShowOrders
            // 
            this.btnShowOrders.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShowOrders.Location = new System.Drawing.Point(3, 187);
            this.btnShowOrders.Name = "btnShowOrders";
            this.btnShowOrders.Size = new System.Drawing.Size(119, 40);
            this.btnShowOrders.TabIndex = 11;
            this.btnShowOrders.Text = "Все заказы";
            this.btnShowOrders.UseSelectable = true;
            this.btnShowOrders.Click += new System.EventHandler(this.btnShowOrders_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.btnShowHelp);
            this.flowLayoutPanel2.Controls.Add(this.btnChangeUser);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 258);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(127, 94);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // btnShowHelp
            // 
            this.btnShowHelp.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShowHelp.Location = new System.Drawing.Point(3, 3);
            this.btnShowHelp.Name = "btnShowHelp";
            this.btnShowHelp.Size = new System.Drawing.Size(119, 40);
            this.btnShowHelp.TabIndex = 8;
            this.btnShowHelp.Text = "Справка";
            this.btnShowHelp.UseSelectable = true;
            this.btnShowHelp.Click += new System.EventHandler(this.btnShowHelp_Click);
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnChangeUser.Location = new System.Drawing.Point(3, 49);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(119, 40);
            this.btnChangeUser.TabIndex = 9;
            this.btnChangeUser.Text = "Сменить \r\nпользователя";
            this.btnChangeUser.UseSelectable = true;
            this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.btnExit);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 375);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(127, 48);
            this.flowLayoutPanel3.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 40);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Выход";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // flpShowsMenu
            // 
            this.flpShowsMenu.AutoSize = true;
            this.flpShowsMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpShowsMenu.Controls.Add(this.flowLayoutPanel1);
            this.flpShowsMenu.Controls.Add(this.flowLayoutPanel2);
            this.flpShowsMenu.Controls.Add(this.flowLayoutPanel3);
            this.flpShowsMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpShowsMenu.Location = new System.Drawing.Point(3, 3);
            this.flpShowsMenu.Name = "flpShowsMenu";
            this.tlpMain.SetRowSpan(this.flpShowsMenu, 2);
            this.flpShowsMenu.Size = new System.Drawing.Size(133, 426);
            this.flpShowsMenu.TabIndex = 2;
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.flpShowsMenu, 0, 0);
            this.tlpMain.Controls.Add(this.dtgOrders, 1, 0);
            this.tlpMain.Controls.Add(this.tlpItems, 1, 1);
            this.tlpMain.Location = new System.Drawing.Point(20, 125);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(1201, 433);
            this.tlpMain.TabIndex = 3;
            // 
            // dtgOrders
            // 
            this.dtgOrders.AllowUserToAddRows = false;
            this.dtgOrders.AllowUserToResizeRows = false;
            this.dtgOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OderID,
            this.OrderEmployee,
            this.Customer,
            this.OrderItemsCount,
            this.OrderDate,
            this.DateClosed,
            this.OrderPrice,
            this.OrderState});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgOrders.EnableHeadersVisualStyles = false;
            this.dtgOrders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgOrders.Location = new System.Drawing.Point(169, 3);
            this.dtgOrders.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.dtgOrders.MultiSelect = false;
            this.dtgOrders.Name = "dtgOrders";
            this.dtgOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgOrders.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgOrders.Size = new System.Drawing.Size(1029, 242);
            this.dtgOrders.TabIndex = 3;
            this.dtgOrders.SelectionChanged += new System.EventHandler(this.dtgOrders_SelectionChanged);
            // 
            // OderID
            // 
            this.OderID.Frozen = true;
            this.OderID.HeaderText = "#";
            this.OderID.Name = "OderID";
            this.OderID.ReadOnly = true;
            this.OderID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OderID.Width = 30;
            // 
            // OrderEmployee
            // 
            this.OrderEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderEmployee.HeaderText = "Продавец";
            this.OrderEmployee.Name = "OrderEmployee";
            this.OrderEmployee.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer.HeaderText = "Покупатель";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // OrderItemsCount
            // 
            this.OrderItemsCount.HeaderText = "Кол-во позиций";
            this.OrderItemsCount.Name = "OrderItemsCount";
            this.OrderItemsCount.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Дата создания";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // DateClosed
            // 
            this.DateClosed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateClosed.HeaderText = "Дата закрытия";
            this.DateClosed.Name = "DateClosed";
            this.DateClosed.ReadOnly = true;
            // 
            // OrderPrice
            // 
            this.OrderPrice.HeaderText = "Итог";
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.ReadOnly = true;
            this.OrderPrice.Width = 120;
            // 
            // OrderState
            // 
            this.OrderState.HeaderText = "Состояние";
            this.OrderState.Name = "OrderState";
            this.OrderState.ReadOnly = true;
            this.OrderState.Width = 160;
            // 
            // tlpItems
            // 
            this.tlpItems.ColumnCount = 1;
            this.tlpItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItems.Controls.Add(this.lblPositions, 0, 0);
            this.tlpItems.Controls.Add(this.dtgItems, 0, 1);
            this.tlpItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItems.Location = new System.Drawing.Point(142, 251);
            this.tlpItems.Name = "tlpItems";
            this.tlpItems.RowCount = 2;
            this.tlpItems.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItems.Size = new System.Drawing.Size(1056, 179);
            this.tlpItems.TabIndex = 20;
            // 
            // lblPositions
            // 
            this.lblPositions.AutoSize = true;
            this.lblPositions.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPositions.Location = new System.Drawing.Point(30, 0);
            this.lblPositions.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lblPositions.Name = "lblPositions";
            this.lblPositions.Size = new System.Drawing.Size(82, 25);
            this.lblPositions.TabIndex = 14;
            this.lblPositions.Text = "Позиции";
            // 
            // dtgItems
            // 
            this.dtgItems.AllowUserToAddRows = false;
            this.dtgItems.AllowUserToDeleteRows = false;
            this.dtgItems.AllowUserToResizeRows = false;
            this.dtgItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgItems.ColumnHeadersHeight = 30;
            this.dtgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.PriceDate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgItems.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgItems.EnableHeadersVisualStyles = false;
            this.dtgItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgItems.Location = new System.Drawing.Point(30, 28);
            this.dtgItems.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.dtgItems.MultiSelect = false;
            this.dtgItems.Name = "dtgItems";
            this.dtgItems.ReadOnly = true;
            this.dtgItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgItems.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgItems.Size = new System.Drawing.Size(1023, 148);
            this.dtgItems.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // PriceDate
            // 
            this.PriceDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceDate.HeaderText = "Цена";
            this.PriceDate.Name = "PriceDate";
            this.PriceDate.ReadOnly = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(189, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "ПРОДАЖИ";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCurrentTime.Location = new System.Drawing.Point(20, 592);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(135, 25);
            this.lblCurrentTime.TabIndex = 5;
            this.lblCurrentTime.Text = "Текущее время:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(1000, 94);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 25);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Подробно";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroToggle1
            // 
            this.metroToggle1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroToggle1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToggle1.Checked = true;
            this.metroToggle1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle1.DisplayStatus = false;
            this.metroToggle1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroToggle1.Location = new System.Drawing.Point(1099, 97);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(122, 22);
            this.metroToggle1.TabIndex = 6;
            this.metroToggle1.Text = "On";
            this.metroToggle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // oderButtons
            // 
            this.oderButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.oderButtons.AutoSize = true;
            this.oderButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.oderButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oderButtons.Controls.Add(this.btnAdd);
            this.oderButtons.Controls.Add(this.btnEdit);
            this.oderButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.oderButtons.Location = new System.Drawing.Point(966, 569);
            this.oderButtons.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.oderButtons.Name = "oderButtons";
            this.oderButtons.Size = new System.Drawing.Size(252, 48);
            this.oderButtons.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAdd.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAdd.Location = new System.Drawing.Point(128, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.brnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEdit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnEdit.Location = new System.Drawing.Point(3, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 40);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblCount
            // 
            this.lblCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCount.AutoSize = true;
            this.lblCount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCount.Location = new System.Drawing.Point(463, 94);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(21, 25);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "0";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(359, 94);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(111, 25);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Количество: ";
            // 
            // btnMakeReport
            // 
            this.btnMakeReport.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnMakeReport.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnMakeReport.Location = new System.Drawing.Point(558, 19);
            this.btnMakeReport.Name = "btnMakeReport";
            this.btnMakeReport.Size = new System.Drawing.Size(184, 40);
            this.btnMakeReport.TabIndex = 10;
            this.btnMakeReport.Text = "Сформировать отчёт";
            this.btnMakeReport.UseSelectable = true;
            this.btnMakeReport.Click += new System.EventHandler(this.btnMakeReport_Click);
            // 
            // btnDownloadReport
            // 
            this.btnDownloadReport.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDownloadReport.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDownloadReport.Location = new System.Drawing.Point(368, 19);
            this.btnDownloadReport.Name = "btnDownloadReport";
            this.btnDownloadReport.Size = new System.Drawing.Size(184, 40);
            this.btnDownloadReport.TabIndex = 11;
            this.btnDownloadReport.Text = "Скачать договор";
            this.btnDownloadReport.UseSelectable = true;
            this.btnDownloadReport.Click += new System.EventHandler(this.btnDownloadReport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 637);
            this.Controls.Add(this.btnDownloadReport);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnMakeReport);
            this.Controls.Add(this.oderButtons);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tglShowMenu);
            this.Controls.Add(this.lblEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1241, 592);
            this.Name = "MainForm";
            this.Text = "EnterpriseGames | Главное окно";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flpShowsMenu.ResumeLayout(false);
            this.flpShowsMenu.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrders)).EndInit();
            this.tlpItems.ResumeLayout(false);
            this.tlpItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItems)).EndInit();
            this.oderButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblEmployee;
        private MetroFramework.Controls.MetroToggle tglShowMenu;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnShowGames;
        private MetroFramework.Controls.MetroButton btnShowGenres;
        private MetroFramework.Controls.MetroButton btnShowEmployees;
        private MetroFramework.Controls.MetroButton btnShowOrders;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MetroFramework.Controls.MetroButton btnShowHelp;
        private MetroFramework.Controls.MetroButton btnChangeUser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MetroFramework.Controls.MetroButton btnExit;
        private System.Windows.Forms.FlowLayoutPanel flpShowsMenu;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private MetroFramework.Controls.MetroGrid dtgOrders;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblCurrentTime;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.TableLayoutPanel tlpItems;
        private MetroFramework.Controls.MetroLabel lblPositions;
        private MetroFramework.Controls.MetroGrid dtgItems;
        private System.Windows.Forms.FlowLayoutPanel oderButtons;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateClosed;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderState;
        private MetroFramework.Controls.MetroButton btnShowCustomers;
        private MetroFramework.Controls.MetroLabel lblCount;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnMakeReport;
        private MetroFramework.Controls.MetroButton btnDownloadReport;
    }
}