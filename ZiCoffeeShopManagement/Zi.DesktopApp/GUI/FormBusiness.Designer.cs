namespace Zi.DesktopApp.GUI
{
    partial class formBusiness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBusiness));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbProgramName = new System.Windows.Forms.Label();
            this.picMaximize = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lbPendingTable = new System.Windows.Forms.Label();
            this.lbReadyTable = new System.Windows.Forms.Label();
            this.lbUsingTable = new System.Windows.Forms.Label();
            this.lbTotalTable = new System.Windows.Forms.Label();
            this.lbCopyright = new System.Windows.Forms.Label();
            this.pnlAccountSideBar = new System.Windows.Forms.Panel();
            this.txbRoleName = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbCitizenId = new System.Windows.Forms.TextBox();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.txbBirthday = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnlMarginLeft = new System.Windows.Forms.Panel();
            this.pnlSideBarController = new System.Windows.Forms.Panel();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.pnlBusinessSideBar = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnMergeTable = new System.Windows.Forms.Button();
            this.btnMoveTable = new System.Windows.Forms.Button();
            this.btnLockTable = new System.Windows.Forms.Button();
            this.txbSelectingTable = new System.Windows.Forms.TextBox();
            this.fpnlArea = new System.Windows.Forms.FlowLayoutPanel();
            this.fpnlTable = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlAccountSideBar.SuspendLayout();
            this.pnlAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlSideBarController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.pnlBusinessSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lbProgramName);
            this.pnlHeader.Controls.Add(this.picMaximize);
            this.pnlHeader.Controls.Add(this.picMinimize);
            this.pnlHeader.Controls.Add(this.picClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 50);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // lbProgramName
            // 
            this.lbProgramName.AutoSize = true;
            this.lbProgramName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgramName.Location = new System.Drawing.Point(12, 12);
            this.lbProgramName.Name = "lbProgramName";
            this.lbProgramName.Size = new System.Drawing.Size(89, 27);
            this.lbProgramName.TabIndex = 0;
            this.lbProgramName.Text = "Zi CSM";
            this.lbProgramName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // picMaximize
            // 
            this.picMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMaximize.Image = global::Zi.DesktopApp.Properties.Resources.maximize;
            this.picMaximize.Location = new System.Drawing.Point(1122, 12);
            this.picMaximize.Name = "picMaximize";
            this.picMaximize.Size = new System.Drawing.Size(30, 30);
            this.picMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMaximize.TabIndex = 2;
            this.picMaximize.TabStop = false;
            this.picMaximize.Click += new System.EventHandler(this.picMaximize_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picMinimize.Image")));
            this.picMinimize.Location = new System.Drawing.Point(1086, 12);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(30, 30);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimize.TabIndex = 1;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(1158, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(30, 30);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lbPendingTable);
            this.pnlFooter.Controls.Add(this.lbReadyTable);
            this.pnlFooter.Controls.Add(this.lbUsingTable);
            this.pnlFooter.Controls.Add(this.lbTotalTable);
            this.pnlFooter.Controls.Add(this.lbCopyright);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 770);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1200, 30);
            this.pnlFooter.TabIndex = 0;
            // 
            // lbPendingTable
            // 
            this.lbPendingTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPendingTable.AutoSize = true;
            this.lbPendingTable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPendingTable.ForeColor = System.Drawing.Color.Yellow;
            this.lbPendingTable.Location = new System.Drawing.Point(373, 4);
            this.lbPendingTable.Name = "lbPendingTable";
            this.lbPendingTable.Size = new System.Drawing.Size(131, 17);
            this.lbPendingTable.TabIndex = 0;
            this.lbPendingTable.Text = "Pending Table: 100";
            this.lbPendingTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbReadyTable
            // 
            this.lbReadyTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbReadyTable.AutoSize = true;
            this.lbReadyTable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReadyTable.ForeColor = System.Drawing.Color.LightGreen;
            this.lbReadyTable.Location = new System.Drawing.Point(247, 4);
            this.lbReadyTable.Name = "lbReadyTable";
            this.lbReadyTable.Size = new System.Drawing.Size(120, 17);
            this.lbReadyTable.TabIndex = 0;
            this.lbReadyTable.Text = "Ready Table: 100";
            this.lbReadyTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUsingTable
            // 
            this.lbUsingTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUsingTable.AutoSize = true;
            this.lbUsingTable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsingTable.ForeColor = System.Drawing.Color.Red;
            this.lbUsingTable.Location = new System.Drawing.Point(126, 4);
            this.lbUsingTable.Name = "lbUsingTable";
            this.lbUsingTable.Size = new System.Drawing.Size(115, 17);
            this.lbUsingTable.TabIndex = 0;
            this.lbUsingTable.Text = "Using Table: 100";
            this.lbUsingTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalTable
            // 
            this.lbTotalTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotalTable.AutoSize = true;
            this.lbTotalTable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalTable.Location = new System.Drawing.Point(12, 4);
            this.lbTotalTable.Name = "lbTotalTable";
            this.lbTotalTable.Size = new System.Drawing.Size(108, 17);
            this.lbTotalTable.TabIndex = 0;
            this.lbTotalTable.Text = "Total Table: 100";
            this.lbTotalTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCopyright
            // 
            this.lbCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCopyright.AutoSize = true;
            this.lbCopyright.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCopyright.Location = new System.Drawing.Point(1020, 2);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(168, 20);
            this.lbCopyright.TabIndex = 0;
            this.lbCopyright.Text = "ZiTechDev Copyright © 2023";
            this.lbCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAccountSideBar
            // 
            this.pnlAccountSideBar.Controls.Add(this.txbRoleName);
            this.pnlAccountSideBar.Controls.Add(this.btnLogout);
            this.pnlAccountSideBar.Controls.Add(this.txbAddress);
            this.pnlAccountSideBar.Controls.Add(this.btnChangePassword);
            this.pnlAccountSideBar.Controls.Add(this.txbEmail);
            this.pnlAccountSideBar.Controls.Add(this.txbCitizenId);
            this.pnlAccountSideBar.Controls.Add(this.txbPhoneNumber);
            this.pnlAccountSideBar.Controls.Add(this.txbBirthday);
            this.pnlAccountSideBar.Controls.Add(this.txbName);
            this.pnlAccountSideBar.Controls.Add(this.txbUsername);
            this.pnlAccountSideBar.Controls.Add(this.panel1);
            this.pnlAccountSideBar.Controls.Add(this.pnlAvatar);
            this.pnlAccountSideBar.Controls.Add(this.pnlSideBarController);
            this.pnlAccountSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccountSideBar.Location = new System.Drawing.Point(0, 50);
            this.pnlAccountSideBar.Name = "pnlAccountSideBar";
            this.pnlAccountSideBar.Size = new System.Drawing.Size(300, 720);
            this.pnlAccountSideBar.TabIndex = 0;
            // 
            // txbRoleName
            // 
            this.txbRoleName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRoleName.Location = new System.Drawing.Point(40, 543);
            this.txbRoleName.Name = "txbRoleName";
            this.txbRoleName.ReadOnly = true;
            this.txbRoleName.Size = new System.Drawing.Size(247, 30);
            this.txbRoleName.TabIndex = 0;
            this.txbRoleName.Text = "Admin";
            this.txbRoleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(202)))), ((int)(((byte)(178)))));
            this.btnLogout.FlatAppearance.BorderSize = 3;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(40, 654);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(247, 50);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.picClose_Click);
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.Location = new System.Drawing.Point(40, 507);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.ReadOnly = true;
            this.txbAddress.Size = new System.Drawing.Size(247, 30);
            this.txbAddress.TabIndex = 0;
            this.txbAddress.Text = "441/42 Điện Biên Phủ, p25, Bình Thạnh";
            this.txbAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(202)))), ((int)(((byte)(178)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 3;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(40, 598);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(247, 50);
            this.btnChangePassword.TabIndex = 0;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(40, 471);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.ReadOnly = true;
            this.txbEmail.Size = new System.Drawing.Size(247, 30);
            this.txbEmail.TabIndex = 0;
            this.txbEmail.Text = "zitech.dev@gmail.com";
            this.txbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbCitizenId
            // 
            this.txbCitizenId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCitizenId.Location = new System.Drawing.Point(40, 435);
            this.txbCitizenId.Name = "txbCitizenId";
            this.txbCitizenId.ReadOnly = true;
            this.txbCitizenId.Size = new System.Drawing.Size(247, 30);
            this.txbCitizenId.TabIndex = 0;
            this.txbCitizenId.Text = "147852369000";
            this.txbCitizenId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhoneNumber.Location = new System.Drawing.Point(40, 399);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.ReadOnly = true;
            this.txbPhoneNumber.Size = new System.Drawing.Size(247, 30);
            this.txbPhoneNumber.TabIndex = 0;
            this.txbPhoneNumber.Text = "0147258369";
            this.txbPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbBirthday
            // 
            this.txbBirthday.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBirthday.Location = new System.Drawing.Point(40, 363);
            this.txbBirthday.Name = "txbBirthday";
            this.txbBirthday.ReadOnly = true;
            this.txbBirthday.Size = new System.Drawing.Size(247, 30);
            this.txbBirthday.TabIndex = 0;
            this.txbBirthday.Text = "05/02/1998";
            this.txbBirthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(40, 327);
            this.txbName.Name = "txbName";
            this.txbName.ReadOnly = true;
            this.txbName.Size = new System.Drawing.Size(247, 30);
            this.txbName.TabIndex = 0;
            this.txbName.Text = "Hiếu";
            this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbUsername
            // 
            this.txbUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(40, 291);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.ReadOnly = true;
            this.txbUsername.Size = new System.Drawing.Size(247, 30);
            this.txbUsername.TabIndex = 0;
            this.txbUsername.Text = "Username";
            this.txbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 435);
            this.panel1.TabIndex = 0;
            // 
            // pnlAvatar
            // 
            this.pnlAvatar.Controls.Add(this.picAvatar);
            this.pnlAvatar.Controls.Add(this.pnlMarginLeft);
            this.pnlAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAvatar.Location = new System.Drawing.Point(0, 50);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(300, 235);
            this.pnlAvatar.TabIndex = 0;
            // 
            // picAvatar
            // 
            this.picAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.picAvatar.Image = global::Zi.DesktopApp.Properties.Resources.user;
            this.picAvatar.Location = new System.Drawing.Point(40, 0);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(260, 220);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 6;
            this.picAvatar.TabStop = false;
            // 
            // pnlMarginLeft
            // 
            this.pnlMarginLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMarginLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlMarginLeft.Name = "pnlMarginLeft";
            this.pnlMarginLeft.Size = new System.Drawing.Size(40, 235);
            this.pnlMarginLeft.TabIndex = 0;
            // 
            // pnlSideBarController
            // 
            this.pnlSideBarController.Controls.Add(this.picHide);
            this.pnlSideBarController.Controls.Add(this.picShow);
            this.pnlSideBarController.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSideBarController.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBarController.Name = "pnlSideBarController";
            this.pnlSideBarController.Size = new System.Drawing.Size(300, 50);
            this.pnlSideBarController.TabIndex = 0;
            // 
            // picHide
            // 
            this.picHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHide.Image = global::Zi.DesktopApp.Properties.Resources.leftArrow;
            this.picHide.Location = new System.Drawing.Point(267, 6);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(30, 30);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHide.TabIndex = 4;
            this.picHide.TabStop = false;
            this.picHide.Click += new System.EventHandler(this.picHide_Click);
            // 
            // picShow
            // 
            this.picShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShow.Image = global::Zi.DesktopApp.Properties.Resources.rightArrow;
            this.picShow.Location = new System.Drawing.Point(3, 6);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(30, 30);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShow.TabIndex = 3;
            this.picShow.TabStop = false;
            this.picShow.Visible = false;
            this.picShow.Click += new System.EventHandler(this.picShow_Click);
            // 
            // pnlBusinessSideBar
            // 
            this.pnlBusinessSideBar.Controls.Add(this.btnPay);
            this.pnlBusinessSideBar.Controls.Add(this.btnOrder);
            this.pnlBusinessSideBar.Controls.Add(this.btnMergeTable);
            this.pnlBusinessSideBar.Controls.Add(this.btnMoveTable);
            this.pnlBusinessSideBar.Controls.Add(this.btnLockTable);
            this.pnlBusinessSideBar.Controls.Add(this.txbSelectingTable);
            this.pnlBusinessSideBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBusinessSideBar.Location = new System.Drawing.Point(900, 50);
            this.pnlBusinessSideBar.Name = "pnlBusinessSideBar";
            this.pnlBusinessSideBar.Size = new System.Drawing.Size(300, 720);
            this.pnlBusinessSideBar.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(202)))), ((int)(((byte)(178)))));
            this.btnPay.FlatAppearance.BorderSize = 3;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(5, 266);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(283, 50);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(202)))), ((int)(((byte)(178)))));
            this.btnOrder.FlatAppearance.BorderSize = 3;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(5, 210);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(283, 50);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnMergeTable
            // 
            this.btnMergeTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMergeTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(202)))), ((int)(((byte)(178)))));
            this.btnMergeTable.FlatAppearance.BorderSize = 3;
            this.btnMergeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMergeTable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMergeTable.Location = new System.Drawing.Point(5, 154);
            this.btnMergeTable.Name = "btnMergeTable";
            this.btnMergeTable.Size = new System.Drawing.Size(283, 50);
            this.btnMergeTable.TabIndex = 0;
            this.btnMergeTable.Text = "Merge";
            this.btnMergeTable.UseVisualStyleBackColor = true;
            // 
            // btnMoveTable
            // 
            this.btnMoveTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(202)))), ((int)(((byte)(178)))));
            this.btnMoveTable.FlatAppearance.BorderSize = 3;
            this.btnMoveTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveTable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveTable.Location = new System.Drawing.Point(5, 98);
            this.btnMoveTable.Name = "btnMoveTable";
            this.btnMoveTable.Size = new System.Drawing.Size(283, 50);
            this.btnMoveTable.TabIndex = 0;
            this.btnMoveTable.Text = "Move";
            this.btnMoveTable.UseVisualStyleBackColor = true;
            // 
            // btnLockTable
            // 
            this.btnLockTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLockTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(202)))), ((int)(((byte)(178)))));
            this.btnLockTable.FlatAppearance.BorderSize = 3;
            this.btnLockTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockTable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockTable.Location = new System.Drawing.Point(5, 42);
            this.btnLockTable.Name = "btnLockTable";
            this.btnLockTable.Size = new System.Drawing.Size(283, 50);
            this.btnLockTable.TabIndex = 0;
            this.btnLockTable.Text = "Lock";
            this.btnLockTable.UseVisualStyleBackColor = true;
            // 
            // txbSelectingTable
            // 
            this.txbSelectingTable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSelectingTable.Location = new System.Drawing.Point(5, 6);
            this.txbSelectingTable.Name = "txbSelectingTable";
            this.txbSelectingTable.ReadOnly = true;
            this.txbSelectingTable.Size = new System.Drawing.Size(283, 30);
            this.txbSelectingTable.TabIndex = 0;
            this.txbSelectingTable.Text = "No selected table";
            this.txbSelectingTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fpnlArea
            // 
            this.fpnlArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpnlArea.Location = new System.Drawing.Point(300, 50);
            this.fpnlArea.Name = "fpnlArea";
            this.fpnlArea.Size = new System.Drawing.Size(600, 200);
            this.fpnlArea.TabIndex = 0;
            // 
            // fpnlTable
            // 
            this.fpnlTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlTable.Location = new System.Drawing.Point(300, 250);
            this.fpnlTable.Name = "fpnlTable";
            this.fpnlTable.Size = new System.Drawing.Size(600, 520);
            this.fpnlTable.TabIndex = 0;
            // 
            // formBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.fpnlTable);
            this.Controls.Add(this.fpnlArea);
            this.Controls.Add(this.pnlBusinessSideBar);
            this.Controls.Add(this.pnlAccountSideBar);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formBusiness";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBusiness";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlAccountSideBar.ResumeLayout(false);
            this.pnlAccountSideBar.PerformLayout();
            this.pnlAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlSideBarController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.pnlBusinessSideBar.ResumeLayout(false);
            this.pnlBusinessSideBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picMaximize;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lbProgramName;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lbCopyright;
        private System.Windows.Forms.Label lbPendingTable;
        private System.Windows.Forms.Label lbReadyTable;
        private System.Windows.Forms.Label lbUsingTable;
        private System.Windows.Forms.Label lbTotalTable;
        private System.Windows.Forms.Panel pnlAccountSideBar;
        private System.Windows.Forms.PictureBox picHide;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel pnlMarginLeft;
        private System.Windows.Forms.Panel pnlSideBarController;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbCitizenId;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.TextBox txbBirthday;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txbRoleName;
        private System.Windows.Forms.Panel pnlBusinessSideBar;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnMergeTable;
        private System.Windows.Forms.Button btnMoveTable;
        private System.Windows.Forms.Button btnLockTable;
        private System.Windows.Forms.TextBox txbSelectingTable;
        private System.Windows.Forms.FlowLayoutPanel fpnlArea;
        private System.Windows.Forms.FlowLayoutPanel fpnlTable;
    }
}