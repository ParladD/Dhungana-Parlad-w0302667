namespace BugTrackerGui
{
    partial class BugTrackerMainForm
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
            this.MenuBugTracker = new System.Windows.Forms.TabControl();
            this.IdentifyTab = new System.Windows.Forms.TabPage();
            this.Button_Logon = new System.Windows.Forms.Button();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ApplicationsTab = new System.Windows.Forms.TabPage();
            this.Delete_Application = new System.Windows.Forms.Button();
            this.AppList = new System.Windows.Forms.ListBox();
            this.Save_Application = new System.Windows.Forms.Button();
            this.AppDesc = new System.Windows.Forms.RichTextBox();
            this.AppVersion = new System.Windows.Forms.TextBox();
            this.AppName = new System.Windows.Forms.TextBox();
            this.AppID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lable8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BugsTab = new System.Windows.Forms.TabPage();
            this.BugDataGrid = new System.Windows.Forms.DataGridView();
            this.Save_Bug = new System.Windows.Forms.Button();
            this.BugUpdateComment = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.BugStatus = new System.Windows.Forms.ComboBox();
            this.BugRepSteps = new System.Windows.Forms.RichTextBox();
            this.BugDetails = new System.Windows.Forms.RichTextBox();
            this.BugFixDate = new System.Windows.Forms.TextBox();
            this.BugSubmitDate = new System.Windows.Forms.TextBox();
            this.BugDesc = new System.Windows.Forms.TextBox();
            this.BugID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Delete_Bug = new System.Windows.Forms.Button();
            this.BugListBox = new System.Windows.Forms.ListBox();
            this.BugStatusList = new System.Windows.Forms.ComboBox();
            this.BugAppList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UsersTab = new System.Windows.Forms.TabPage();
            this.Delete_User = new System.Windows.Forms.Button();
            this.UserList = new System.Windows.Forms.ListBox();
            this.Save_User = new System.Windows.Forms.Button();
            this.UserPhoneNum = new System.Windows.Forms.TextBox();
            this.UserEmail = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.MenuBugTracker.SuspendLayout();
            this.IdentifyTab.SuspendLayout();
            this.ApplicationsTab.SuspendLayout();
            this.BugsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BugDataGrid)).BeginInit();
            this.UsersTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBugTracker
            // 
            this.MenuBugTracker.Controls.Add(this.IdentifyTab);
            this.MenuBugTracker.Controls.Add(this.ApplicationsTab);
            this.MenuBugTracker.Controls.Add(this.BugsTab);
            this.MenuBugTracker.Controls.Add(this.UsersTab);
            this.MenuBugTracker.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBugTracker.Location = new System.Drawing.Point(8, 7);
            this.MenuBugTracker.Name = "MenuBugTracker";
            this.MenuBugTracker.SelectedIndex = 0;
            this.MenuBugTracker.Size = new System.Drawing.Size(997, 466);
            this.MenuBugTracker.TabIndex = 1;
            // 
            // IdentifyTab
            // 
            this.IdentifyTab.BackColor = System.Drawing.Color.White;
            this.IdentifyTab.Controls.Add(this.Button_Logon);
            this.IdentifyTab.Controls.Add(this.UserNameInput);
            this.IdentifyTab.Controls.Add(this.label2);
            this.IdentifyTab.Controls.Add(this.label1);
            this.IdentifyTab.Location = new System.Drawing.Point(4, 23);
            this.IdentifyTab.Name = "IdentifyTab";
            this.IdentifyTab.Padding = new System.Windows.Forms.Padding(3);
            this.IdentifyTab.Size = new System.Drawing.Size(989, 439);
            this.IdentifyTab.TabIndex = 0;
            this.IdentifyTab.Text = "Identify";
            // 
            // Button_Logon
            // 
            this.Button_Logon.Location = new System.Drawing.Point(641, 185);
            this.Button_Logon.Name = "Button_Logon";
            this.Button_Logon.Size = new System.Drawing.Size(62, 22);
            this.Button_Logon.TabIndex = 3;
            this.Button_Logon.Text = "Go";
            this.Button_Logon.UseVisualStyleBackColor = true;
            this.Button_Logon.Click += new System.EventHandler(this.Button_Logon_Click);
            // 
            // UserNameInput
            // 
            this.UserNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameInput.Location = new System.Drawing.Point(412, 188);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(202, 20);
            this.UserNameInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Identify yourself";
            // 
            // ApplicationsTab
            // 
            this.ApplicationsTab.Controls.Add(this.Delete_Application);
            this.ApplicationsTab.Controls.Add(this.AppList);
            this.ApplicationsTab.Controls.Add(this.Save_Application);
            this.ApplicationsTab.Controls.Add(this.AppDesc);
            this.ApplicationsTab.Controls.Add(this.AppVersion);
            this.ApplicationsTab.Controls.Add(this.AppName);
            this.ApplicationsTab.Controls.Add(this.AppID);
            this.ApplicationsTab.Controls.Add(this.label6);
            this.ApplicationsTab.Controls.Add(this.label5);
            this.ApplicationsTab.Controls.Add(this.label4);
            this.ApplicationsTab.Controls.Add(this.lable8);
            this.ApplicationsTab.Controls.Add(this.label3);
            this.ApplicationsTab.Location = new System.Drawing.Point(4, 23);
            this.ApplicationsTab.Name = "ApplicationsTab";
            this.ApplicationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ApplicationsTab.Size = new System.Drawing.Size(989, 439);
            this.ApplicationsTab.TabIndex = 1;
            this.ApplicationsTab.Text = "Applications";
            this.ApplicationsTab.UseVisualStyleBackColor = true;
            // 
            // Delete_Application
            // 
            this.Delete_Application.Location = new System.Drawing.Point(826, 383);
            this.Delete_Application.Name = "Delete_Application";
            this.Delete_Application.Size = new System.Drawing.Size(77, 37);
            this.Delete_Application.TabIndex = 11;
            this.Delete_Application.Text = "Delete";
            this.Delete_Application.UseVisualStyleBackColor = true;
            this.Delete_Application.Click += new System.EventHandler(this.Delete_Application_Click);
            // 
            // AppList
            // 
            this.AppList.FormattingEnabled = true;
            this.AppList.Items.AddRange(new object[] {
            "<Add New>"});
            this.AppList.Location = new System.Drawing.Point(678, 91);
            this.AppList.Name = "AppList";
            this.AppList.Size = new System.Drawing.Size(225, 277);
            this.AppList.TabIndex = 10;
            this.AppList.SelectedIndexChanged += new System.EventHandler(this.AppList_SelectedIndexChanged);
            // 
            // Save_Application
            // 
            this.Save_Application.Location = new System.Drawing.Point(462, 383);
            this.Save_Application.Name = "Save_Application";
            this.Save_Application.Size = new System.Drawing.Size(75, 37);
            this.Save_Application.TabIndex = 9;
            this.Save_Application.Text = "Save";
            this.Save_Application.UseVisualStyleBackColor = true;
            this.Save_Application.Click += new System.EventHandler(this.Save_Application_Click);
            // 
            // AppDesc
            // 
            this.AppDesc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AppDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppDesc.Location = new System.Drawing.Point(316, 185);
            this.AppDesc.Name = "AppDesc";
            this.AppDesc.Size = new System.Drawing.Size(220, 183);
            this.AppDesc.TabIndex = 8;
            this.AppDesc.Text = "";
            // 
            // AppVersion
            // 
            this.AppVersion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AppVersion.Location = new System.Drawing.Point(315, 137);
            this.AppVersion.Name = "AppVersion";
            this.AppVersion.Size = new System.Drawing.Size(134, 20);
            this.AppVersion.TabIndex = 7;
            // 
            // AppName
            // 
            this.AppName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AppName.Location = new System.Drawing.Point(315, 99);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(222, 20);
            this.AppName.TabIndex = 6;
            // 
            // AppID
            // 
            this.AppID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AppID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppID.Location = new System.Drawing.Point(315, 65);
            this.AppID.Name = "AppID";
            this.AppID.ReadOnly = true;
            this.AppID.Size = new System.Drawing.Size(134, 13);
            this.AppID.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Current Version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Application Name:";
            // 
            // lable8
            // 
            this.lable8.AutoSize = true;
            this.lable8.Location = new System.Drawing.Point(141, 67);
            this.lable8.Name = "lable8";
            this.lable8.Size = new System.Drawing.Size(142, 13);
            this.lable8.TabIndex = 1;
            this.lable8.Text = "Application ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Application Manger";
            // 
            // BugsTab
            // 
            this.BugsTab.Controls.Add(this.BugDataGrid);
            this.BugsTab.Controls.Add(this.Save_Bug);
            this.BugsTab.Controls.Add(this.BugUpdateComment);
            this.BugsTab.Controls.Add(this.label18);
            this.BugsTab.Controls.Add(this.label17);
            this.BugsTab.Controls.Add(this.BugStatus);
            this.BugsTab.Controls.Add(this.BugRepSteps);
            this.BugsTab.Controls.Add(this.BugDetails);
            this.BugsTab.Controls.Add(this.BugFixDate);
            this.BugsTab.Controls.Add(this.BugSubmitDate);
            this.BugsTab.Controls.Add(this.BugDesc);
            this.BugsTab.Controls.Add(this.BugID);
            this.BugsTab.Controls.Add(this.label16);
            this.BugsTab.Controls.Add(this.label15);
            this.BugsTab.Controls.Add(this.label14);
            this.BugsTab.Controls.Add(this.label13);
            this.BugsTab.Controls.Add(this.label12);
            this.BugsTab.Controls.Add(this.label11);
            this.BugsTab.Controls.Add(this.label10);
            this.BugsTab.Controls.Add(this.Delete_Bug);
            this.BugsTab.Controls.Add(this.BugListBox);
            this.BugsTab.Controls.Add(this.BugStatusList);
            this.BugsTab.Controls.Add(this.BugAppList);
            this.BugsTab.Controls.Add(this.label9);
            this.BugsTab.Controls.Add(this.label8);
            this.BugsTab.Controls.Add(this.label7);
            this.BugsTab.Location = new System.Drawing.Point(4, 23);
            this.BugsTab.Name = "BugsTab";
            this.BugsTab.Size = new System.Drawing.Size(989, 439);
            this.BugsTab.TabIndex = 2;
            this.BugsTab.Text = "Bugs";
            this.BugsTab.UseVisualStyleBackColor = true;
            // 
            // BugDataGrid
            // 
            this.BugDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BugDataGrid.Location = new System.Drawing.Point(712, 50);
            this.BugDataGrid.Name = "BugDataGrid";
            this.BugDataGrid.Size = new System.Drawing.Size(260, 194);
            this.BugDataGrid.TabIndex = 25;
            // 
            // Save_Bug
            // 
            this.Save_Bug.Location = new System.Drawing.Point(871, 379);
            this.Save_Bug.Name = "Save_Bug";
            this.Save_Bug.Size = new System.Drawing.Size(102, 38);
            this.Save_Bug.TabIndex = 24;
            this.Save_Bug.Text = "Save ";
            this.Save_Bug.UseVisualStyleBackColor = true;
            // 
            // BugUpdateComment
            // 
            this.BugUpdateComment.Location = new System.Drawing.Point(710, 273);
            this.BugUpdateComment.Name = "BugUpdateComment";
            this.BugUpdateComment.Size = new System.Drawing.Size(263, 87);
            this.BugUpdateComment.TabIndex = 23;
            this.BugUpdateComment.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(707, 257);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Update Comments:\r\n";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(707, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Bug Activity Log:\r\n";
            // 
            // BugStatus
            // 
            this.BugStatus.FormattingEnabled = true;
            this.BugStatus.Location = new System.Drawing.Point(469, 326);
            this.BugStatus.Name = "BugStatus";
            this.BugStatus.Size = new System.Drawing.Size(199, 21);
            this.BugStatus.TabIndex = 20;
            // 
            // BugRepSteps
            // 
            this.BugRepSteps.Location = new System.Drawing.Point(469, 232);
            this.BugRepSteps.Name = "BugRepSteps";
            this.BugRepSteps.Size = new System.Drawing.Size(199, 76);
            this.BugRepSteps.TabIndex = 19;
            this.BugRepSteps.Text = "";
            // 
            // BugDetails
            // 
            this.BugDetails.Location = new System.Drawing.Point(469, 135);
            this.BugDetails.Name = "BugDetails";
            this.BugDetails.Size = new System.Drawing.Size(199, 79);
            this.BugDetails.TabIndex = 18;
            this.BugDetails.Text = "";
            // 
            // BugFixDate
            // 
            this.BugFixDate.Location = new System.Drawing.Point(469, 365);
            this.BugFixDate.Name = "BugFixDate";
            this.BugFixDate.Size = new System.Drawing.Size(142, 20);
            this.BugFixDate.TabIndex = 17;
            // 
            // BugSubmitDate
            // 
            this.BugSubmitDate.Location = new System.Drawing.Point(469, 56);
            this.BugSubmitDate.Name = "BugSubmitDate";
            this.BugSubmitDate.Size = new System.Drawing.Size(153, 20);
            this.BugSubmitDate.TabIndex = 16;
            // 
            // BugDesc
            // 
            this.BugDesc.Location = new System.Drawing.Point(469, 93);
            this.BugDesc.Name = "BugDesc";
            this.BugDesc.Size = new System.Drawing.Size(199, 20);
            this.BugDesc.TabIndex = 15;
            // 
            // BugID
            // 
            this.BugID.Location = new System.Drawing.Point(469, 22);
            this.BugID.Name = "BugID";
            this.BugID.Size = new System.Drawing.Size(114, 20);
            this.BugID.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(348, 368);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Fix Date:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(348, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Status:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(348, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Rep Steps:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(348, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Submit Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(348, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Description:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(348, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Details:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(348, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Bug ID:";
            // 
            // Delete_Bug
            // 
            this.Delete_Bug.Location = new System.Drawing.Point(206, 379);
            this.Delete_Bug.Name = "Delete_Bug";
            this.Delete_Bug.Size = new System.Drawing.Size(114, 38);
            this.Delete_Bug.TabIndex = 6;
            this.Delete_Bug.Text = "Delete Bug";
            this.Delete_Bug.UseVisualStyleBackColor = true;
            // 
            // BugListBox
            // 
            this.BugListBox.FormattingEnabled = true;
            this.BugListBox.Items.AddRange(new object[] {
            "<Add New>"});
            this.BugListBox.Location = new System.Drawing.Point(14, 148);
            this.BugListBox.Name = "BugListBox";
            this.BugListBox.Size = new System.Drawing.Size(306, 212);
            this.BugListBox.TabIndex = 5;
            // 
            // BugStatusList
            // 
            this.BugStatusList.FormattingEnabled = true;
            this.BugStatusList.Location = new System.Drawing.Point(150, 78);
            this.BugStatusList.Name = "BugStatusList";
            this.BugStatusList.Size = new System.Drawing.Size(170, 21);
            this.BugStatusList.TabIndex = 4;
            // 
            // BugAppList
            // 
            this.BugAppList.FormattingEnabled = true;
            this.BugAppList.Location = new System.Drawing.Point(150, 26);
            this.BugAppList.Name = "BugAppList";
            this.BugAppList.Size = new System.Drawing.Size(170, 21);
            this.BugAppList.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Bug List:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Status Filter:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Application:";
            // 
            // UsersTab
            // 
            this.UsersTab.Controls.Add(this.Delete_User);
            this.UsersTab.Controls.Add(this.UserList);
            this.UsersTab.Controls.Add(this.Save_User);
            this.UsersTab.Controls.Add(this.UserPhoneNum);
            this.UsersTab.Controls.Add(this.UserEmail);
            this.UsersTab.Controls.Add(this.UserName);
            this.UsersTab.Controls.Add(this.UserID);
            this.UsersTab.Controls.Add(this.label23);
            this.UsersTab.Controls.Add(this.label22);
            this.UsersTab.Controls.Add(this.label21);
            this.UsersTab.Controls.Add(this.label20);
            this.UsersTab.Controls.Add(this.label19);
            this.UsersTab.Location = new System.Drawing.Point(4, 23);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Size = new System.Drawing.Size(989, 439);
            this.UsersTab.TabIndex = 3;
            this.UsersTab.Text = "Users";
            this.UsersTab.UseVisualStyleBackColor = true;
            // 
            // Delete_User
            // 
            this.Delete_User.Location = new System.Drawing.Point(796, 371);
            this.Delete_User.Name = "Delete_User";
            this.Delete_User.Size = new System.Drawing.Size(88, 40);
            this.Delete_User.TabIndex = 11;
            this.Delete_User.Text = "Delete";
            this.Delete_User.UseVisualStyleBackColor = true;
            // 
            // UserList
            // 
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(661, 95);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(223, 238);
            this.UserList.TabIndex = 10;
            // 
            // Save_User
            // 
            this.Save_User.Location = new System.Drawing.Point(426, 371);
            this.Save_User.Name = "Save_User";
            this.Save_User.Size = new System.Drawing.Size(88, 40);
            this.Save_User.TabIndex = 9;
            this.Save_User.Text = "Save";
            this.Save_User.UseVisualStyleBackColor = true;
            // 
            // UserPhoneNum
            // 
            this.UserPhoneNum.Location = new System.Drawing.Point(280, 215);
            this.UserPhoneNum.Name = "UserPhoneNum";
            this.UserPhoneNum.Size = new System.Drawing.Size(234, 20);
            this.UserPhoneNum.TabIndex = 8;
            // 
            // UserEmail
            // 
            this.UserEmail.Location = new System.Drawing.Point(280, 174);
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.Size = new System.Drawing.Size(234, 20);
            this.UserEmail.TabIndex = 7;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(280, 134);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(234, 20);
            this.UserName.TabIndex = 6;
            // 
            // UserID
            // 
            this.UserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserID.Location = new System.Drawing.Point(280, 95);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(137, 13);
            this.UserID.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(126, 218);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "Phone Num:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(126, 177);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(133, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Email Address:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(126, 137);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "User Name:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(126, 96);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "User ID:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(53, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 18);
            this.label19.TabIndex = 0;
            this.label19.Text = "User Manager";
            // 
            // BugTrackerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 473);
            this.Controls.Add(this.MenuBugTracker);
            this.Name = "BugTrackerMainForm";
            this.Text = "Bug Tracker";
            this.Load += new System.EventHandler(this.BugTrackerMainForm_Load);
            this.MenuBugTracker.ResumeLayout(false);
            this.IdentifyTab.ResumeLayout(false);
            this.IdentifyTab.PerformLayout();
            this.ApplicationsTab.ResumeLayout(false);
            this.ApplicationsTab.PerformLayout();
            this.BugsTab.ResumeLayout(false);
            this.BugsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BugDataGrid)).EndInit();
            this.UsersTab.ResumeLayout(false);
            this.UsersTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MenuBugTracker;
        private System.Windows.Forms.TabPage IdentifyTab;
        private System.Windows.Forms.TabPage ApplicationsTab;
        private System.Windows.Forms.TabPage BugsTab;
        private System.Windows.Forms.TabPage UsersTab;
        private System.Windows.Forms.Button Button_Logon;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AppID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Delete_Application;
        private System.Windows.Forms.ListBox AppList;
        private System.Windows.Forms.Button Save_Application;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox BugStatus;
        private System.Windows.Forms.RichTextBox BugRepSteps;
        private System.Windows.Forms.RichTextBox BugDetails;
        private System.Windows.Forms.TextBox BugFixDate;
        private System.Windows.Forms.TextBox BugSubmitDate;
        private System.Windows.Forms.TextBox BugDesc;
        private System.Windows.Forms.TextBox BugID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Delete_Bug;
        private System.Windows.Forms.ListBox BugListBox;
        private System.Windows.Forms.ComboBox BugStatusList;
        private System.Windows.Forms.ComboBox BugAppList;
        private System.Windows.Forms.Button Save_Bug;
        private System.Windows.Forms.RichTextBox BugUpdateComment;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button Delete_User;
        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.Button Save_User;
        private System.Windows.Forms.TextBox UserPhoneNum;
        private System.Windows.Forms.TextBox UserEmail;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView BugDataGrid;
        protected System.Windows.Forms.TextBox AppVersion;
        protected System.Windows.Forms.TextBox AppName;
        protected System.Windows.Forms.RichTextBox AppDesc;
    }
}

