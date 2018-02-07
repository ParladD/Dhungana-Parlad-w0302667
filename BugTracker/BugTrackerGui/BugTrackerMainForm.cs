using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace BugTrackerGui
{
    public partial class BugTrackerMainForm : Form
    {
        private string applicationName;

        public BugTrackerMainForm()
        {
            InitializeComponent();
        }

        private void BugTrackerMainForm_Load(object sender, EventArgs e)
        {
            try
            {
                //point the value of |DataDirectory| at our database in the datalayer
                //string dataDirectory = ConfigurationManager.AppSettings["DataDirectory"];
                //string absoluteDataDirectory = Path.GetFullPath(dataDirectory);
                //AppDomain.CurrentDomain.SetData("DataDirectory", absoluteDataDirectory);

                //set application name
                applicationName = ConfigurationManager.AppSettings["ApplicationName"].ToString();

                //set connection settings
                BugTrackerDataLayer.DB.ApplicationName = applicationName;
                BugTrackerDataLayer.DB.ConnectionTimeout = 30;

                //load employees into listbox
               // LoadEmployeesList();

            }
            catch (SqlException sqlex)
            {
                //connection error...
                //DisplayErrorMessage(sqlex.Message);
            }
        }

        private void Button_Logon_Click(object sender, EventArgs e)
        {
            BugTrackerDataLayer.Users users = new BugTrackerDataLayer.Users();


            if (users.GetUserConfirmation(UserNameInput.Text.ToString()))
            {
                AppName.Text = "Hello World";
            }
            else
            {
                AppName.Text = "Bye World";
            }
        }


    }
}
