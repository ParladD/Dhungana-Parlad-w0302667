using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using BugTrackerDataLayer;


namespace BugTrackerGui
{
    public partial class BugTrackerMainForm : Form
    {
        private string applicationName;

        public BugTrackerMainForm()
        {
            InitializeComponent();
            HideTabs();
        }

        private void BugTrackerMainForm_Load(object sender, EventArgs e)
        {
            try
            {
              

                //set application name
                applicationName = ConfigurationManager.AppSettings["ApplicationName"].ToString();

                //set connection settings
               DB.ApplicationName = applicationName;
               DB.ConnectionTimeout = 30;

                // Loading the Application List
                LoadApplicationList();

                //Loading the User List
                LoadUsersList();
                //Loading BugList
               // LoadBugList();

            }
            catch (SqlException sqlex)
            {
                //connection error...
                DisplayErrorMessage(sqlex.Message);
            }
        }


        /// <summary>
        /// this method will be executed when user tries to log in to the system and check if the user exists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Logon_Click(object sender, EventArgs e)
        {
            Users users = new Users();

            if (users.GetUserConfirmation(UserNameInput.Text.ToString()))
            {//checking if the users exists in the database
                ShowTabs();
            }
            else
            { //will be printing the error msg
                DisplayErrorMessage("User Not Found, Please try again");
            }

        }//end button logon click
    


        /// <summary>
        /// This method will get the users list by executing stored Procedures and fills the list with user name
        /// </summary>
        public void LoadUsersList()
        {
            //creating new users object called users
         
             Users users = new Users();

             List<User> user = users.GetUserList(); //creating a list of User by calling the Userlist method

            user.Insert(0, new User()
            {
                UserName = "<Add New>" //adding new element in top of the user id
            });

            UserList.DataSource = user;
            UserList.DisplayMember = "UserName"; //defining the memeber that i want to display

        }//end load user list


        /// <summary>
        /// this methods loads all the applications name on the applist box
        /// </summary>

        public void LoadApplicationList()
        {
            //creating new users object called users

            Applications application = new Applications();

            List<App> app = application.GetApplicationList(); //creating a list of applications by calling the GetApplicationList method

            app.Insert(0, new App()
            {
                ApplicationName = "<Add New>"//adding new element in top of the app id
            });

            AppList.DataSource = app;
            AppList.DisplayMember = "ApplicationName"; //defining the memeber that i want to display

        }//end load user list



        public void LoadBugList()
        {
            //creating new users object called users

            Bugs bugs = new Bugs();

            List<Bug> bug = bugs.GetBugList(1); //creating a list of bugs by calling the GetApplicationList method

            bug.Insert(0, new Bug()
            {
                BugDesc = "<Add New>"//adding new element in top of the bugs id
            });

            BugListBox.DataSource = bug;
            BugListBox.DisplayMember = "BugDesc"; //defining the memeber that i want to display

        }//end load user list


        /// <summary>
        /// this method is for dispalying the error 
        /// </summary>
        /// <param name="message"></param>
        private void DisplayErrorMessage(string message)
        {
            MessageBox.Show(this,
                message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }//end dispaly error msg


        /// <summary>
        /// this method is for appList which will fill the text values based on the select indes for apps
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppList_SelectedIndexChanged(object sender, EventArgs e)
        {
            App selectedApp = (App)AppList.SelectedValue;

            if(selectedApp.ApplicationID!= 0)
            {
                AppID.Text = selectedApp.ApplicationID.ToString();
                AppName.Text = selectedApp.ApplicationName;
                AppVersion.Text = selectedApp.ApplicationVersion;
                AppDesc.Text = selectedApp.ApplicationDescription;

            }
            else
            {
                AppName.Clear();
                AppID.Visible = false;
                AppVersion.Clear();
                AppDesc.Clear();
            }
        
        }//end applist




        /// <summary>
        /// this method hides all the tabs when the programs loads
        /// </summary>
        private void HideTabs()
        {
            MenuBugTracker.TabPages.RemoveByKey("ApplicationsTab");
            MenuBugTracker.TabPages.RemoveByKey("BugsTab");
            MenuBugTracker.TabPages.RemoveByKey("UsersTab");

        }//end hide tabs

        /// <summary>
        /// this methods shows all the tabs after the user confirmation is done
        /// </summary>
        private void ShowTabs()
        {
            MenuBugTracker.TabPages.Add(ApplicationsTab);
            MenuBugTracker.TabPages.Add(BugsTab);
            MenuBugTracker.TabPages.Add(UsersTab);

        }//end show tabs


        /// <summary>
        /// this method will insert or update the button based on the selected list from the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Application_Click(object sender, EventArgs e)
        {
            Applications applications = new Applications();
            App selectedApp = (App)AppList.SelectedValue;

            int appId = Int32.Parse(AppID.Text);
            string appName = AppName.Text;
            string appVersion = AppVersion.Text;
            string appDesc = AppDesc.Text;
            try
            {
                if (selectedApp.ApplicationID == 0)
                {
                    applications.InsertApplication(appName, appVersion, appDesc);
                }
                else
                {
                    applications.UpdateApplication(appId, appName, appVersion, appDesc);
                }

                LoadApplicationList();
            }
            catch (SqlException sqlex)
            {
                DisplayErrorMessage(sqlex.Message);
            }
        
        }

        private void Delete_Application_Click(object sender, EventArgs e)
        {
            Applications applications = new Applications();
            App selectedApp = (App)AppList.SelectedValue;

            int appId = Int32.Parse(AppID.Text);

            try
            {
                if (selectedApp.ApplicationID != 0)
                {
                    applications.DeleteApplication(appId);
                }
                LoadApplicationList();
            }
            catch (SqlException sqlex)
            {
                DisplayErrorMessage(sqlex.Message);
            }
        }
    }//end main form gui

}//end namespace 
