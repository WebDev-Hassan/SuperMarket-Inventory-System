
namespace SuperMarket_Inventory_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation2 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_dashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_products = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_report = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DashboardPages = new Bunifu.UI.WinForms.BunifuPages();
            this.DashboardHome = new System.Windows.Forms.TabPage();
            this.DashboardTransactions = new System.Windows.Forms.TabPage();
            this.DashboardProducts = new System.Windows.Forms.TabPage();
            this.DashboardReport = new System.Windows.Forms.TabPage();
            this.DashboardProfile = new System.Windows.Forms.TabPage();
            this.DashboardExit = new System.Windows.Forms.TabPage();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_transactions = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DashboardPages.SuspendLayout();
            this.DashboardHome.SuspendLayout();
            this.DashboardTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 546);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 14);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(234, 65);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "SUPERMARKET INVENTORY SYSTEM";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Active = true;
            this.btn_dashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.btn_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.btn_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dashboard.BorderRadius = 7;
            this.btn_dashboard.ButtonText = "          Dashboard";
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btn_dashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_dashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_dashboard.Iconimage")));
            this.btn_dashboard.Iconimage_right = null;
            this.btn_dashboard.Iconimage_right_Selected = null;
            this.btn_dashboard.Iconimage_Selected = null;
            this.btn_dashboard.IconMarginLeft = 0;
            this.btn_dashboard.IconMarginRight = 0;
            this.btn_dashboard.IconRightVisible = true;
            this.btn_dashboard.IconRightZoom = 0D;
            this.btn_dashboard.IconVisible = true;
            this.btn_dashboard.IconZoom = 40D;
            this.btn_dashboard.IsTab = true;
            this.btn_dashboard.Location = new System.Drawing.Point(17, 100);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btn_dashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.btn_dashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_dashboard.selected = true;
            this.btn_dashboard.Size = new System.Drawing.Size(229, 48);
            this.btn_dashboard.TabIndex = 2;
            this.btn_dashboard.Text = "          Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Textcolor = System.Drawing.Color.Black;
            this.btn_dashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_products
            // 
            this.btn_products.Active = false;
            this.btn_products.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.btn_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btn_products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_products.BorderRadius = 7;
            this.btn_products.ButtonText = "          Products";
            this.btn_products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_products.DisabledColor = System.Drawing.Color.Gray;
            this.btn_products.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_products.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_products.Iconimage")));
            this.btn_products.Iconimage_right = null;
            this.btn_products.Iconimage_right_Selected = null;
            this.btn_products.Iconimage_Selected = null;
            this.btn_products.IconMarginLeft = 0;
            this.btn_products.IconMarginRight = 0;
            this.btn_products.IconRightVisible = true;
            this.btn_products.IconRightZoom = 0D;
            this.btn_products.IconVisible = true;
            this.btn_products.IconZoom = 40D;
            this.btn_products.IsTab = true;
            this.btn_products.Location = new System.Drawing.Point(17, 170);
            this.btn_products.Name = "btn_products";
            this.btn_products.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btn_products.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.btn_products.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_products.selected = false;
            this.btn_products.Size = new System.Drawing.Size(229, 48);
            this.btn_products.TabIndex = 4;
            this.btn_products.Text = "          Products";
            this.btn_products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products.Textcolor = System.Drawing.Color.Black;
            this.btn_products.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Active = false;
            this.btn_exit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.BorderRadius = 7;
            this.btn_exit.ButtonText = "          Exit";
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_exit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_exit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_exit.Iconimage")));
            this.btn_exit.Iconimage_right = null;
            this.btn_exit.Iconimage_right_Selected = null;
            this.btn_exit.Iconimage_Selected = null;
            this.btn_exit.IconMarginLeft = 0;
            this.btn_exit.IconMarginRight = 0;
            this.btn_exit.IconRightVisible = true;
            this.btn_exit.IconRightZoom = 0D;
            this.btn_exit.IconVisible = true;
            this.btn_exit.IconZoom = 40D;
            this.btn_exit.IsTab = true;
            this.btn_exit.Location = new System.Drawing.Point(17, 450);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btn_exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.btn_exit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_exit.selected = false;
            this.btn_exit.Size = new System.Drawing.Size(229, 48);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "          Exit";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Textcolor = System.Drawing.Color.Black;
            this.btn_exit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Active = false;
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 7;
            this.bunifuFlatButton6.ButtonText = "          Profile";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 40D;
            this.bunifuFlatButton6.IsTab = true;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(17, 380);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(229, 48);
            this.bunifuFlatButton6.TabIndex = 7;
            this.bunifuFlatButton6.Text = "          Profile";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_report
            // 
            this.btn_report.Active = false;
            this.btn_report.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btn_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_report.BorderRadius = 7;
            this.btn_report.ButtonText = "          Report";
            this.btn_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_report.DisabledColor = System.Drawing.Color.Gray;
            this.btn_report.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_report.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_report.Iconimage")));
            this.btn_report.Iconimage_right = null;
            this.btn_report.Iconimage_right_Selected = null;
            this.btn_report.Iconimage_Selected = null;
            this.btn_report.IconMarginLeft = 0;
            this.btn_report.IconMarginRight = 0;
            this.btn_report.IconRightVisible = true;
            this.btn_report.IconRightZoom = 0D;
            this.btn_report.IconVisible = true;
            this.btn_report.IconZoom = 40D;
            this.btn_report.IsTab = true;
            this.btn_report.Location = new System.Drawing.Point(17, 240);
            this.btn_report.Name = "btn_report";
            this.btn_report.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btn_report.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.btn_report.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_report.selected = false;
            this.btn_report.Size = new System.Drawing.Size(229, 48);
            this.btn_report.TabIndex = 6;
            this.btn_report.Text = "          Report";
            this.btn_report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report.Textcolor = System.Drawing.Color.Black;
            this.btn_report.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // DashboardPages
            // 
            this.DashboardPages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.DashboardPages.AllowTransitions = true;
            this.DashboardPages.Controls.Add(this.DashboardHome);
            this.DashboardPages.Controls.Add(this.DashboardProducts);
            this.DashboardPages.Controls.Add(this.DashboardReport);
            this.DashboardPages.Controls.Add(this.DashboardTransactions);
            this.DashboardPages.Controls.Add(this.DashboardProfile);
            this.DashboardPages.Controls.Add(this.DashboardExit);
            this.DashboardPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardPages.Location = new System.Drawing.Point(259, 0);
            this.DashboardPages.Multiline = true;
            this.DashboardPages.Name = "DashboardPages";
            this.DashboardPages.Page = this.DashboardHome;
            this.DashboardPages.PageIndex = 0;
            this.DashboardPages.PageName = "DashboardHome";
            this.DashboardPages.PageTitle = "Dashboard";
            this.DashboardPages.SelectedIndex = 0;
            this.DashboardPages.Size = new System.Drawing.Size(719, 546);
            this.DashboardPages.TabIndex = 9;
            animation2.AnimateOnlyDifferences = false;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.DashboardPages.Transition = animation2;
            this.DashboardPages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // DashboardHome
            // 
            this.DashboardHome.AccessibleName = "";
            this.DashboardHome.Controls.Add(this.bunifuCustomLabel2);
            this.DashboardHome.Location = new System.Drawing.Point(4, 4);
            this.DashboardHome.Name = "DashboardHome";
            this.DashboardHome.Padding = new System.Windows.Forms.Padding(3);
            this.DashboardHome.Size = new System.Drawing.Size(711, 520);
            this.DashboardHome.TabIndex = 0;
            this.DashboardHome.Text = "Dashboard";
            this.DashboardHome.UseVisualStyleBackColor = true;
            // 
            // DashboardTransactions
            // 
            this.DashboardTransactions.Controls.Add(this.bunifuDataGridView1);
            this.DashboardTransactions.Controls.Add(this.bunifuCustomLabel3);
            this.DashboardTransactions.Location = new System.Drawing.Point(4, 4);
            this.DashboardTransactions.Name = "DashboardTransactions";
            this.DashboardTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.DashboardTransactions.Size = new System.Drawing.Size(711, 520);
            this.DashboardTransactions.TabIndex = 1;
            this.DashboardTransactions.Text = "Transactions";
            this.DashboardTransactions.UseVisualStyleBackColor = true;
            // 
            // DashboardProducts
            // 
            this.DashboardProducts.Location = new System.Drawing.Point(4, 4);
            this.DashboardProducts.Name = "DashboardProducts";
            this.DashboardProducts.Size = new System.Drawing.Size(711, 520);
            this.DashboardProducts.TabIndex = 2;
            this.DashboardProducts.Text = "Products";
            this.DashboardProducts.UseVisualStyleBackColor = true;
            // 
            // DashboardReport
            // 
            this.DashboardReport.Location = new System.Drawing.Point(4, 4);
            this.DashboardReport.Name = "DashboardReport";
            this.DashboardReport.Size = new System.Drawing.Size(711, 520);
            this.DashboardReport.TabIndex = 3;
            this.DashboardReport.Text = "Report";
            this.DashboardReport.UseVisualStyleBackColor = true;
            // 
            // DashboardProfile
            // 
            this.DashboardProfile.Location = new System.Drawing.Point(4, 4);
            this.DashboardProfile.Name = "DashboardProfile";
            this.DashboardProfile.Size = new System.Drawing.Size(711, 520);
            this.DashboardProfile.TabIndex = 4;
            this.DashboardProfile.Text = "Profile";
            this.DashboardProfile.UseVisualStyleBackColor = true;
            // 
            // DashboardExit
            // 
            this.DashboardExit.Location = new System.Drawing.Point(4, 4);
            this.DashboardExit.Name = "DashboardExit";
            this.DashboardExit.Size = new System.Drawing.Size(711, 520);
            this.DashboardExit.TabIndex = 5;
            this.DashboardExit.Text = "Exit";
            this.DashboardExit.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(48, 148);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(615, 180);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "WELCOME TO SUPERMARKET INVENTORY SYSTEM";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 10);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(705, 65);
            this.bunifuCustomLabel3.TabIndex = 1;
            this.bunifuCustomLabel3.Text = "INVENTORY LIST";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            this.bunifuDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TITLE,
            this.QUANTITY,
            this.Actions});
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(9, 105);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.ReadOnly = true;
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(687, 409);
            this.bunifuDataGridView1.TabIndex = 2;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.FillWeight = 101.5228F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ID.Width = 50;
            // 
            // TITLE
            // 
            this.TITLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TITLE.FillWeight = 99.49239F;
            this.TITLE.HeaderText = "TITLE";
            this.TITLE.Name = "TITLE";
            this.TITLE.ReadOnly = true;
            // 
            // QUANTITY
            // 
            this.QUANTITY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QUANTITY.FillWeight = 99.49239F;
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.ReadOnly = true;
            // 
            // Actions
            // 
            this.Actions.FillWeight = 99.49239F;
            this.Actions.HeaderText = "Actions";
            this.Actions.Name = "Actions";
            this.Actions.ReadOnly = true;
            // 
            // btn_transactions
            // 
            this.btn_transactions.Active = false;
            this.btn_transactions.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.btn_transactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btn_transactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_transactions.BorderRadius = 7;
            this.btn_transactions.ButtonText = "          Transactions";
            this.btn_transactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_transactions.DisabledColor = System.Drawing.Color.Gray;
            this.btn_transactions.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_transactions.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_transactions.Iconimage")));
            this.btn_transactions.Iconimage_right = null;
            this.btn_transactions.Iconimage_right_Selected = null;
            this.btn_transactions.Iconimage_Selected = null;
            this.btn_transactions.IconMarginLeft = 0;
            this.btn_transactions.IconMarginRight = 0;
            this.btn_transactions.IconRightVisible = true;
            this.btn_transactions.IconRightZoom = 0D;
            this.btn_transactions.IconVisible = true;
            this.btn_transactions.IconZoom = 40D;
            this.btn_transactions.IsTab = true;
            this.btn_transactions.Location = new System.Drawing.Point(17, 310);
            this.btn_transactions.Name = "btn_transactions";
            this.btn_transactions.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.btn_transactions.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.btn_transactions.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_transactions.selected = false;
            this.btn_transactions.Size = new System.Drawing.Size(229, 48);
            this.btn_transactions.TabIndex = 13;
            this.btn_transactions.Text = "          Transactions";
            this.btn_transactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transactions.Textcolor = System.Drawing.Color.Black;
            this.btn_transactions.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 546);
            this.Controls.Add(this.DashboardPages);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_transactions);
            this.Controls.Add(this.bunifuFlatButton6);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_products);
            this.Controls.Add(this.btn_dashboard);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DashboardPages.ResumeLayout(false);
            this.DashboardHome.ResumeLayout(false);
            this.DashboardTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_dashboard;
        private Bunifu.Framework.UI.BunifuFlatButton btn_products;
        private Bunifu.Framework.UI.BunifuFlatButton btn_exit;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton btn_report;
        private Bunifu.UI.WinForms.BunifuPages DashboardPages;
        private System.Windows.Forms.TabPage DashboardHome;
        private System.Windows.Forms.TabPage DashboardTransactions;
        private System.Windows.Forms.TabPage DashboardProducts;
        private System.Windows.Forms.TabPage DashboardReport;
        private System.Windows.Forms.TabPage DashboardProfile;
        private System.Windows.Forms.TabPage DashboardExit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actions;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_transactions;
    }
}