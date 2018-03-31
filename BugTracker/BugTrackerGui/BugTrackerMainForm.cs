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
        private int bugAppID = 0;
        private int bugStatusID = 0;
        private int currentSatusID = 0;
        private int currentlyLoggedInUserId = 0;
        private DateTime bugFixDate;

        //constructor for gui 
        public BugTrackerMainForm()
        {
            InitializeComponent();
            HideTabs();
        }

        /// <summary>
        /// this method will be executed open form load and loads the nesscaary data
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">e argument</param>
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
                LoadUsersList();
                BugAppListData();
                BugStatusData(BugStatusList);
                BugStatusData(BugStatus);
                LoadBugList();

                ///disabling the status until new is clicked
                ///
                BugStatus.Enabled = false;
            }
            catch (SqlException sqlex)
            {
                //connection error...
                DisplayErrorMessage(sqlex.Message);
            }
        }//end Mainform load


        /// <summary>
        /// this method will be executed when user tries to log in to the system and check if the user exists
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">argument e</param>
        private void Button_Logon_Click(object sender, EventArgs e)
        {
            Users users = new Users();
          
            if (users.GetUserConfirmation(UserNameInput.Text.ToString()) != 0)
            {//checking if the users exists in the database
                ShowTabs();

                currentlyLoggedInUserId = users.GetUserConfirmation(UserNameInput.Text.ToString());
                bugDetail.Text = currentlyLoggedInUserId.ToString();
                //currentlyLoggedInUserId = user
            }
            else
            { //will be printing the error msg
                DisplayErrorMessage("User Not Found, Please try again");
            }

        }//end button logon click



//--------------------------------------------------------------------------------------------------------------//
//---------------------------------- Applications Group --------------------------------------------------------//
//--------------------------------------------------------------------------------------------------------------//
        
       /// <summary>
        /// this methods loads all the applications name on the applist box
        /// </summary>

        private void LoadApplicationList()
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



            /// <summary>
        /// this method is for appList which will fill the text values based on the select indexs for apps
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">argument e</param>
        private void AppList_SelectedIndexChanged(object sender, EventArgs e)
        {
            App selectedApp = (App)AppList.SelectedValue;

            if(selectedApp.ApplicationID!= 0)
            {
                AppID.Enabled = true;
                AppID.Text = selectedApp.ApplicationID.ToString();
                AppName.Text = selectedApp.ApplicationName;
                AppVersion.Text = selectedApp.ApplicationVersion;
                AppDesc.Text = selectedApp.ApplicationDescription;

            }
            else
            {
                AppID.Enabled = false;
                AppID.Text = selectedApp.ApplicationID.ToString();
                AppName.Clear();
                AppVersion.Clear();
                AppDesc.Clear();
            }
        
        }//end applist


        /// <summary>
        /// this method will insert or update the button based on the selected list from the list box
        /// </summary>
        /// <param name="sender">sender objects</param>
        /// <param name="e">arguments e</param>
        private void Save_Application_Click(object sender, EventArgs e)
        {
            Applications applications = new Applications();
            App selectedApp = (App)AppList.SelectedValue;

          
            try
            {
                int appId = Int32.Parse(AppID.Text);
                string appName = AppName.Text.ToString();
                string appVersion = AppVersion.Text.ToString();
                string appDesc = AppDesc.Text.ToString();

                if (selectedApp.ApplicationID == 0)
                {
                    applications.InsertApplication(appName, appVersion, appDesc);
                    DisplayErrorMessage("Application has been Added");
                }
                else
                {
                    applications.UpdateApplication(appId, appName, appVersion, appDesc);
                    DisplayErrorMessage("Application has been Updated");
                }

                LoadApplicationList();
            }
            catch (SqlException sqlex)
            {
                DisplayErrorMessage(sqlex.Message);

            }catch(Exception sqlex)
            {
                DisplayErrorMessage(sqlex.Message);
            }

        }//end Save_Application_Click

        /// <summary>
        /// this method will be used to delete the item based on selectedlist
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">arguments e</param>

        private void Delete_Application_Click(object sender, EventArgs e)
        {
            Applications applications = new Applications();
            App selectedApp = (App)AppList.SelectedValue;

            try
            {
                int appId = Int32.Parse(AppID.Text);
                if (selectedApp.ApplicationID != 0)
                {
                    applications.DeleteApplication(appId);
                    DisplayErrorMessage("Application has been Deleted");
                }
                LoadApplicationList();
            }
            catch (SqlException sqlex)
            {
                DisplayErrorMessage(sqlex.Message);
            }
            catch (Exception sqlex)
            {
                DisplayErrorMessage(sqlex.Message);
            }
        }//end Delete_Application_Click



//--------------------------------------------------------------------------------------------------------------//
//---------------------------------- Bugs Group ----------------------------------------------------------------//
//--------------------------------------------------------------------------------------------------------------//
       
            /// <summary>
            /// this methods loads all the bugs on list box
            /// </summary>
        private void LoadBugList()
        {
            //creating new users object called users

            Bugs bugs = new Bugs();

            List<Bug> bug = bugs.GetBugList(bugAppID, bugStatusID); //creating a list of bugs by calling the GetApplicationList method

            bug.Insert(0, new Bug()
            {
                BugDesc = "<Add New>",//adding new element in top of the bugs id
              
            
            });

            BugListBox.DataSource = bug;
            BugListBox.DisplayMember = "BugDesc"; //defining the memeber that i want to display

        }//end load user list
            
        /// <summary>
        /// this method will load the appllications on llist box
        /// </summary>
        private void BugAppListData()
        {
            Applications applications = new Applications();

            List<App> app = applications.GetApplicationList(); //creating a list of applications by calling the GetApplicationList method

            app.Insert(0, new App()
            {
                ApplicationName = "<Select Application>"//adding new element in top of the app id
            });
            BugAppList.DataSource = app;
            BugAppList.DisplayMember = "ApplicationName";
        }

        /// <summary>
        /// this method loads the data in the status combobox
        /// </summary>
        /// <param name="c">combox </param>
        private void BugStatusData(ComboBox c)
        {
            StatusCodes statusCodes = new StatusCodes();

            List<StatusCode> stat = statusCodes.GetStatusCodeList(); //creating a list of applications by calling the GetApplicationList method

            stat.Insert(0, new StatusCode()
            {
                 StatusCodeDescription= "<Select Status>"//adding new element in top of the app id
            });
            c.DataSource = stat;
            c.DisplayMember = "StatusCodeDescription";
        }

        /// <summary>
        /// this method will filter the bug based on the applications
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">arguments e</param>
        private void BugAppList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            App selectedApp = (App)BugAppList.SelectedValue;
   
            try
            {
                bugAppID = selectedApp.ApplicationID;

                if (bugAppID != 0)
                {
                    LoadBugList();

                }
               
            }
            catch (SqlException sqlex)
            {
                DisplayErrorMessage(sqlex.Message);
            }
           
            catch (Exception sqlex)
            {
                DisplayErrorMessage(sqlex.Message );
            }
        }
        /// <summary>
        /// this method will filter the bug based on the status
        /// </summary>
        /// <param name="sender">sender object </param>
        /// <param name="e">arguments e</param>
        private void BugStatusList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatusCode status  = (StatusCode)BugStatusList.SelectedValue;

            try
            {
                bugStatusID = status.StatusCodeID;

                if (bugStatusID != 0)
                {
                    LoadBugList();

                }

            }
            catch (SqlException sqlex)
            {
                DisplayErrorMessage(sqlex.Message);
            }

            catch (Exception sqlex)
            {
                DisplayErrorMessage(sqlex.Message);
            }
        }//end bug status list

        /// <summary>
        /// this method will display the details of the specific bugs
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">arguments e</param>
        private void BugListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bugs bugs = new Bugs();
            Bug bug = (Bug)BugListBox.SelectedValue;
            try
            {
                int bugID = bug.BugID;

                if (bugID != 0)
                {
                    //BugStatus.Visible = false;
                    BugID.Enabled = true;
                    BugSubmitDate.Enabled = true;
                    BugFixDate.Enabled = true;
                    List<Bug> b = bugs.GetBug(bugID);


                    BugID.Text = b[0].BugID.ToString();
                    BugSubmitDate.Text = b[0].BugDate.ToString();
                    BugDesc.Text = b[0].BugDesc;
                    bugDetail.Text = b[0].BugDetailInfo;
                    bugRepStep.Text = b[0].BugRepStepInfo;
                    BugFixDate.Text = b[0].BugFixDate.ToString();

                    DataTable logTable = Bugs.GetLog(bugID);
                    BugDataGrid.DataSource = logTable;

                }
                else
                {
                    BugStatus.Enabled = true;
                    //BugStatus.Visible = true;
                    BugID.Text = bugID.ToString();
                    BugID.Enabled = false;
                    BugSubmitDate.Clear();
                    BugSubmitDate.Enabled = false;
                    BugDesc.Clear();
                    bugDetail.Clear();
                    bugRepStep.Clear();
                    BugFixDate.Clear();
                    BugFixDate.Enabled = false;
                    BugDataGrid.ClearSelection();
                }
            }
            catch (SqlException sqlex)
            {
                DisplayErrorMessage(sqlex.Message);
            }

            catch (Exception sqlex)
            {
                DisplayErrorMessage(sqlex.Message);
            }


        }//end box list

        /// <summary>
        /// this method will save the data into the method or update the data based on the passed in id
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e"> arguments e</param>
        private void Save_Bug_Click(object sender, EventArgs e)
        {
            Bugs bugs = new Bugs();
            Bug bug = (Bug)BugListBox.SelectedValue;

            try
            {
                int bugID = Int32.Parse(BugID.Text.ToString());
                //int userID = 
                DateTime bugSubmitDate = Convert.ToDateTime(DateTime.UtcNow.Date);
                string bugDesc = BugDesc.Text.ToString();
                string bugDetails = bugDetail.Text.ToString();
                string bugRepSteps = bugRepStep.Text.ToString();
               // string bugUpdate = BugUpdateComment.Text.ToString();
                


                if (bug.BugID == 0) {

                    bugs.InsertBug(bugAppID, currentlyLoggedInUserId, bugSubmitDate, bugDesc, bugDetails, bugRepSteps);
                    LoadBugList();
                    //inserting and loading bug
                }
                else
                {
                   

                    bugs.UpdateBug(currentlyLoggedInUserId, bugDesc, bugDetails, bugRepSteps, bugFixDate, bugID, currentSatusID);
                    LoadBugList();
                    //updating and loading bug
                }

            }
            catch (SqlException sqlex)
            {
                DisplayErrorMessage(sqlex.Message);
            }

            catch (Exception sqlex)
            {
                DisplayErrorMessage(sqlex.Message);
            }


        }//end save bug_click

        /// <summary>
        /// this methods returns the status id of selected status
        /// </summary>
        /// <param name="sender">send object</param>
        /// <param name="e">argumesnts</param>
        private void BugStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            StatusCode stat = (StatusCode)BugStatus.SelectedValue;

            if(stat.StatusCodeID != 0)
            {

                currentSatusID = stat.StatusCodeID;
                if(stat.StatusCodeID == 5)
                {
                    bugFixDate = System.DateTime.Now;
                }
            }
        }//End BugStatus






        //--------------------------------------------------------------------------------------------------------------//
        //---------------------------------- Users Group ---------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// This method will get the users list by executing stored Procedures and fills the list with user name
        /// </summary>
        private void LoadUsersList()
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
        /// this method populates the user information based on the selected user
        /// </summary>
        /// <param name="sender">send object</param>
        /// <param name="e">arguments</param>
        private void UserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = (User)UserList.SelectedValue;

            if (selectedUser.UserID!= 0)
            {
                UserID.Enabled = true;

                UserID.Text = selectedUser.UserID.ToString();
                UserName.Text = selectedUser.UserName;
                UserEmail.Text = selectedUser.UserEmail;
                UserPhoneNum.Text = selectedUser.UserTel;

            }
            else
            {
              
                UserID.Enabled = false;
                UserID.Text = selectedUser.UserID.ToString();
                UserName.Clear();
                UserEmail.Clear();
                UserPhoneNum.Clear();
            }

        }//end  UserList_SelectedIndexChanged

        /// <summary>
        /// this method will save / update the user based on the selected id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_User_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            User selectedUser = (User)UserList.SelectedValue;

          
            try
            {
                int userID = Int32.Parse(UserID.Text);
                string userName = UserName.Text.ToString();
                string userEmail = UserEmail.Text.ToString();
                string userTel = UserPhoneNum.Text.ToString();

                if (selectedUser.UserID == 0)
                {
                    users.InserUser(userName, userEmail, userTel);
                    DisplayErrorMessage("User has been Added");

                }
                else
                {
                    users.UpdateUser(userID, userName, userEmail, userTel);
                    DisplayErrorMessage("User has been updated");
                }

                LoadUsersList();

            }catch(SqlException sqlex)
            {
                DisplayErrorMessage(sqlex.Message);
            }
            catch (Exception sqlex)
            {
                DisplayErrorMessage(sqlex.Message);
            }
        } //end Save_User_Click



        /// <summary>
        /// this method will delete the user record based on the id
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">arguments</param>
        private void Delete_User_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            User selectedUser = (User)UserList.SelectedValue;
           

            try
            {
                int userID = Int32.Parse(UserID.Text.ToString());

                if (selectedUser.UserID != 0)
                {
                    users.DeleteUser(userID);
                    DisplayErrorMessage("User has been deleted");
                }
                LoadUsersList();
            }
            catch (SqlException sqlex)
            {
                DisplayErrorMessage(sqlex.Message);
            }
            catch (Exception sqlex)
            {
                DisplayErrorMessage(sqlex.Message);
            }
        }//end delete USER



        //--------------------------------------------------------------------------------------------------------------//
        //---------------------------------- Tabs Group and Dispaly Error ----------------------------------------------------------------//
        //--------------------------------------------------------------------------------------------------------------//

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

        
    }//end main form gui

}//end namespace 
