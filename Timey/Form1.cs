using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Xml;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        // Globals 
        bool TimerRunning = false;
        bool TimerPaused = false;
        bool EditLocked = true;

        TimeSpan TimerValue;

        string FreshBooksID;
        string Token;
        int ReminderInterval;
        bool TimerReminder;
        bool InactiveReminder;
        int InactiveInterval;

        DataTable Projects = new DataTable();
        DataTable Client = new DataTable();
        DataTable Tasks = new DataTable();

        // LASTINPUTINFO
        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        internal struct LASTINPUTINFO
        {
            public uint cbSize;

            public uint dwTime;
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                statusLbl.Text = "Pause timer before editing!";
                return;
            }
            if (EditLocked == false) lockEdit();
            else if (EditLocked == true) unlockEdit();
        }

        private void txtMinute_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtMinute.Text) > 59) txtMinute.Text = "59";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string balloon;
            if (TimerValue.Minutes > 0)
            {
               balloon = getElapsedTime();
            }
            else balloon = ">1 minute";

            if (TimerRunning == false || TimerPaused == true)
            {

                notifyIcon1.ShowBalloonTip(3000, "Timer Started", balloon, ToolTipIcon.Info);
                startTimer();
            }

            else if (TimerPaused == false)
            {
                notifyIcon1.ShowBalloonTip(3000, "Timer Paused", balloon, ToolTipIcon.Info);
                pauseTimer();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TimerRunning == true)
            {
                DialogResult clearWarn = MessageBox.Show("Clear the timer?", "Clear Timer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (clearWarn == DialogResult.Yes)
                {
                    TimerPaused = false;
                    TimerRunning = false;
                    timer1.Enabled = false;
                    btnStart.ImageIndex = 1;
                    btnStart.Text = " Start";
                    txtHour.Text = "00";
                    txtMinute.Text = "00";
                    txtSecond.Text = "00";
                    txtFraction.Text = "0.00";
                    TimerValue = TimeSpan.Zero;
                    statusLbl.Text = "Timer cleared";
                    notifyIcon1.Icon = Properties.Resources.clock_stop;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan newTimerValue = TimerValue.Add(TimeSpan.FromSeconds(1));
            TimerValue = newTimerValue;

            txtSecond.Text = Convert.ToString(TimerValue.Seconds.ToString("D2"));
            txtMinute.Text = Convert.ToString(TimerValue.Minutes.ToString("D2"));
            txtHour.Text = Convert.ToString(TimerValue.Hours.ToString("D2"));

            txtFraction.Text = Convert.ToString(TimerValue.TotalHours.ToString("00.00"));

            notifyIcon1.Text = "Timer:\n" + TimerValue.ToString("g");

            if (TimerValue.Minutes % ReminderInterval == 0 && TimerValue.Seconds == 0 && TimerReminder == true)
            {
                string timeDisplay = getElapsedTime();

                notifyIcon1.ShowBalloonTip(3000, "Time Elapsed", timeDisplay, ToolTipIcon.Info);
            }

            if(InactiveReminder == true && InactiveInterval > 0)
            {
                LASTINPUTINFO lastInput = new LASTINPUTINFO();
                lastInput.cbSize = (uint)Marshal.SizeOf(lastInput);
                GetLastInputInfo(ref lastInput);

                int idleTicks = Environment.TickCount - (int)lastInput.dwTime;

                TimeSpan idleSpan = TimeSpan.FromMilliseconds(idleTicks);
                double idleMinutes = idleSpan.TotalMinutes;

                //System.Diagnostics.Debug.Print(idleMinutes.ToString());

                if (idleMinutes >= InactiveInterval)
                {
                    notifyIcon1.ShowBalloonTip(10000, "Timer Paused", "Idle for " + InactiveInterval + " minutes", ToolTipIcon.Warning);
                    pauseTimer();
                }
            }
            
        }

        private string getElapsedTime()
        {
            string timeDisplay;
            if (TimerValue.Hours > 0)
            {
                string hourString;
                if (TimerValue.Hours > 1)
                {
                    hourString = " hours, ";
                }
                else hourString = " hour, ";
                timeDisplay = TimerValue.Hours.ToString("g") + hourString + TimerValue.Minutes.ToString("g") + " minutes";
            }
            else timeDisplay = TimerValue.Minutes.ToString("g") + " minutes";

            return (timeDisplay);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Projects.Columns.Add("project_id");
            Projects.Columns.Add("name");
            Projects.Columns.Add("client_id");

            Client.Columns.Add("client_id");
            Client.Columns.Add("organization");

            Tasks.Columns.Add("task_id");
            Tasks.Columns.Add("name");

            bool regEntries = RegistryUpdate();
            if (regEntries == false)
            {
                btnPrefs_Click(null, null);
            }

            this.Show();

            retrieveAllProjects();
        }

        private void editTimer()
        {
            if (EditLocked == false)
            {
                TimeSpan newHour = TimeSpan.FromHours(Convert.ToDouble(txtHour.Text));
                TimeSpan newMinute = newHour.Add(TimeSpan.FromMinutes(Convert.ToDouble(txtMinute.Text)));
                TimeSpan newTimer = newMinute.Add(TimeSpan.FromSeconds(Convert.ToDouble(txtSecond.Text)));

                TimerValue = newTimer;

                txtFraction.Text = Convert.ToString(TimerValue.TotalHours.ToString("00.00"));

                statusLbl.Text = "Timer edited";
            }
        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtSecond.Text) > 59) txtSecond.Text = "59";
        }

        private void btnAddMinutes_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                statusLbl.Text = "Pause timer first before adding minutes!";
                return;
            }
            
            int addMinutes = Convert.ToInt16(cboSelectMinutes.Text);

            if (addMinutes > 0)
            {
                TimeSpan minuteAdd = TimerValue.Add(TimeSpan.FromMinutes(addMinutes));
                TimerValue = minuteAdd;
                statusLbl.Text = addMinutes + " minutes added to timer";

                txtSecond.Text = Convert.ToString(TimerValue.Seconds.ToString("D2"));
                txtMinute.Text = Convert.ToString(TimerValue.Minutes.ToString("D2"));
                txtHour.Text = Convert.ToString(TimerValue.Hours.ToString("D2"));

                txtFraction.Text = Convert.ToString(TimerValue.TotalHours.ToString("00.00"));
            }
        }

        private void cboSelectMinutes_TextChanged(object sender, EventArgs e)
        {
            int minutes;
            int.TryParse(cboSelectMinutes.Text, out minutes);
            cboSelectMinutes.Text = Convert.ToString(minutes);
        }

        private void btnSubtractMinutes_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled == true)
            {
                statusLbl.Text = "Pause timer first before subtracting minutes!";
                return;
            }
            
            int subMinutes = Convert.ToInt16(cboSelectMinutes.Text);

            if (subMinutes > 0 && TimerValue > TimeSpan.Zero)
            {
                TimeSpan minuteSub = TimerValue.Subtract(TimeSpan.FromMinutes(subMinutes));
                TimerValue = minuteSub;
                if (TimerValue < TimeSpan.Zero) TimerValue = TimeSpan.Zero;
                statusLbl.Text = subMinutes + " minutes subtracted from timer";

                txtSecond.Text = Convert.ToString(TimerValue.Seconds.ToString("D2"));
                txtMinute.Text = Convert.ToString(TimerValue.Minutes.ToString("D2"));
                txtHour.Text = Convert.ToString(TimerValue.Hours.ToString("D2"));

                txtFraction.Text = Convert.ToString(TimerValue.TotalHours.ToString("00.00"));
            }
        }

        private void startTimer()
        {
            TimerRunning = true;
            TimerPaused = false;
            timer1.Enabled = true;
            btnStart.ImageIndex = 0;
            btnStart.Text = " Pause";
            lockEdit();
            statusLbl.Text = "Timer running...";
            menuStart.Text = "Pause Timer";
            notifyIcon1.Icon = Properties.Resources.clock_play;
        }

        private void pauseTimer()
        {
            TimerPaused = true;
            timer1.Enabled = false;
            btnStart.ImageIndex = 1;
            btnStart.Text = " Resume";
            statusLbl.Text = "Timer paused";
            menuStart.Text = "Start Timer";
            notifyIcon1.Icon = Properties.Resources.clock_stop;
        }

        private void lockEdit()
        {
            btnLock.ImageIndex = 1;
            txtFraction.ReadOnly = true;
            txtHour.ReadOnly = true;
            txtMinute.ReadOnly = true;
            txtSecond.ReadOnly = true;

            EditLocked = true;
            statusLbl.Text = "Time editing locked";

            pnlTimer.BackColor = SystemColors.Control;
            lblColon.BackColor = SystemColors.Control;
            lblColon2.BackColor = SystemColors.Control;
        }

        private void unlockEdit()
        {
            btnLock.ImageIndex = 0;
            txtFraction.ReadOnly = false;
            txtHour.ReadOnly = false;
            txtMinute.ReadOnly = false;
            txtSecond.ReadOnly = false;

            if (timer1.Enabled == true) pauseTimer();

            EditLocked = false;
            statusLbl.Text = "Time editing unlocked";

            pnlTimer.BackColor = SystemColors.Window;
            lblColon.BackColor = SystemColors.Window;
            lblColon2.BackColor = SystemColors.Window;
        }

        private void txtFraction_Leave(object sender, EventArgs e)
        {
            double fraction = Convert.ToDouble(txtFraction.Text) / 100;
            TimeSpan newFraction = TimeSpan.FromHours(fraction);
            TimerValue = newFraction;

            txtSecond.Text = Convert.ToString(TimerValue.Seconds.ToString("D2"));
            txtMinute.Text = Convert.ToString(TimerValue.Minutes.ToString("D2"));
            txtHour.Text = Convert.ToString(TimerValue.Hours.ToString("D2"));
        }

        private void txtHour_Leave(object sender, EventArgs e)
        {
            editTimer();
        }

        private void txtMinute_Leave(object sender, EventArgs e)
        {
            editTimer();
        }

        private void txtSecond_Leave(object sender, EventArgs e)
        {
            editTimer();
        }

        private void btnPrefs_Click(object sender, EventArgs e)
        {
            Prefs showPrefs = new Prefs(this);
            showPrefs.ShowDialog();
        }

        private void btnRoundUp_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                statusLbl.Text = "Pause timer first before rounding!";
                return;
            }

            int roundBy = Convert.ToInt16(cboRound.Text);

            if (roundBy > 0 && TimerValue > TimeSpan.Zero)
            {
                int minuteRound = TimerValue.Minutes;
                
                int roundUp = 0;
                int inc = 1;

                while (minuteRound > roundUp)
                {
                    roundUp = roundBy * inc;
                    inc++;
                }

                if (minuteRound == roundUp)
                {
                    statusLbl.Text = "Time already rounded to nearest " + roundBy + " minute interval!";
                    return;
                }

                int newMinute = roundUp - minuteRound;

                TimeSpan minuteAdd = TimerValue.Add(TimeSpan.FromMinutes(newMinute));
                TimerValue = minuteAdd;

                if (TimerValue < TimeSpan.Zero) TimerValue = TimeSpan.Zero;
                statusLbl.Text = "Timer rounded up to nearest " + roundBy + " minute interval";

                txtSecond.Text = Convert.ToString(TimerValue.Seconds.ToString("D2"));
                txtMinute.Text = Convert.ToString(TimerValue.Minutes.ToString("D2"));
                txtHour.Text = Convert.ToString(TimerValue.Hours.ToString("D2"));
                txtSecond.Text = "00";

                txtFraction.Text = Convert.ToString(TimerValue.TotalHours.ToString("00.00"));
            }
        }

        private void btnRoundDown_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                statusLbl.Text = "Pause timer first before rounding!";
                return;
            }

            int roundBy = Convert.ToInt16(cboRound.Text);

            if (roundBy > 0 && TimerValue > TimeSpan.Zero)
            {
                int minuteRound = TimerValue.Minutes;
                int roundDown = 0;
                int inc = 0;

                while (minuteRound > roundDown)
                {
                    roundDown = roundBy * inc;
                    inc++;
                }

                if (minuteRound == roundDown)
                {
                    statusLbl.Text = "Time already rounded to nearest " + roundBy + " minute interval!";
                    return;
                }

                int newMinute = minuteRound - (roundBy * (inc - 2));

                TimeSpan minuteAdd = TimerValue.Subtract(TimeSpan.FromMinutes(newMinute));
                TimerValue = minuteAdd;

                if (TimerValue < TimeSpan.Zero) TimerValue = TimeSpan.Zero;
                statusLbl.Text = "Timer rounded down to nearest " + roundBy + " minute interval";

                txtSecond.Text = Convert.ToString(TimerValue.Seconds.ToString("D2"));
                txtMinute.Text = Convert.ToString(TimerValue.Minutes.ToString("D2"));
                txtHour.Text = Convert.ToString(TimerValue.Hours.ToString("D2"));
                txtSecond.Text = "00";

                txtFraction.Text = Convert.ToString(TimerValue.TotalHours.ToString("00.00"));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=NLZE6BSNUTQSC");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            this.ShowInTaskbar = true;
        }

        public bool RegistryUpdate()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Break Time");

            FreshBooksID = Convert.ToString(key.GetValue("FreshbooksID", ""));

            Token = Convert.ToString(key.GetValue("Token", ""));

            TimerReminder = Convert.ToBoolean(key.GetValue("TimerReminder", true));
            ReminderInterval = Convert.ToInt16(key.GetValue("ReminderInterval", 5));

            InactiveReminder = Convert.ToBoolean(key.GetValue("InactivityReminder", true));
            InactiveInterval = Convert.ToInt16(key.GetValue("InactivityInterval", "5"));

            key.Close();

            if (FreshBooksID == "" || Token == "") return false;
            else return true;
        }

        private bool freshAPI(ref string xml)
        {
            string requestURL = "https://" + FreshBooksID + ".freshbooks.com/api/2.1/xml-in"; 
            if(FreshBooksID == "")
            {
                MessageBox.Show("Invalid Freshbooks ID. Enter a valid Freshbooks ID in the Preferences dialog", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            WebClient auth = new WebClient();

            auth.Credentials = new NetworkCredential(Token, "");

            auth.Headers.Add("user-agent","Break Time!");

            //string response = "";

            try
            {
                xml = auth.UploadString(requestURL, xml);
            }
            catch(WebException ex)
            {
                if (ex.Message == "The remote server returned an error: (401) Unauthorized.")
                {
                    MessageBox.Show("Invalid Authentication Token. Log into your Freshbooks account and find your authentication token in My Account -> Freshbooks API", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("Could not connect to Freshbooks API. " + ex.Message, "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (xml.Substring(0, 14) == "<!DOCTYPE html")
            {
                MessageBox.Show("Invalid Freshbooks ID. Enter a valid Freshbooks ID in the Preferences dialog", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            retrieveAllProjects();
        }

        private void retrieveAllProjects()
        {
            if (FreshBooksID == "" || Token == "")
            {
                statusLbl.Text = "No Freshbooks ID or Authentication Token entered!";
                return;
            }
            
            statusLbl.Text = "Please wait, retrieving project list...";
            Cursor = Cursors.AppStarting;

            Projects.Clear();
            Client.Clear();

            // Request XML
            StringBuilder requestXml = new StringBuilder();
            XmlWriter request = XmlWriter.Create(requestXml);

            request.WriteStartElement("request");
            request.WriteAttributeString("method", "project.list");
            request.WriteElementString("page", "1");
            //request.WriteElementString("per_page", "10");
            request.WriteEndElement();
            request.Close();

            string sendXml = requestXml.ToString();
            bool apiErr = freshAPI(ref sendXml);
            if (apiErr == false)
            {
                statusLbl.Text = "Error downloading project list";
                Cursor = Cursors.Default;
                return;
            }
            string responseXml = sendXml;

            // Response XML
            StringReader inputXml = new StringReader(responseXml);
            XmlReader readXml = XmlReader.Create(inputXml);          

            // Read XML and create project table
            readXml.ReadToFollowing("projects");
            int pages = Convert.ToInt16(readXml.GetAttribute("pages"));
            //int total = Convert.ToInt16(readXml.GetAttribute("total"));

            string[] clientIDs = new string[1];
            int i = 0;

            readXml.ReadToFollowing("project");

            for (int p = 1; p <= pages; p++)
            {
                while (readXml.EOF == false)
                {
                    readXml.ReadToDescendant("project_id");
                    string projectID = readXml.ReadElementString("project_id");

                    readXml.ReadToNextSibling("name");
                    string name = readXml.ReadElementString("name");

                    readXml.ReadToNextSibling("client_id");
                    string clientID = readXml.ReadElementString("client_id");

                    if (clientIDs.Contains(clientID) == false)
                    {
                        if (i > 0) Array.Resize(ref clientIDs, i + 1);
                        clientIDs[i] = clientID;
                        i++;
                    }

                    Application.DoEvents();

                    readXml.ReadToFollowing("project");

                    DataRow row = Projects.NewRow();

                    row["project_id"] = projectID;
                    row["name"] = name;
                    row["client_id"] = clientID;

                    Projects.Rows.Add(row);
                }

                if (pages > 1 && p < pages)
                {
                    requestXml = new StringBuilder();
                    request = XmlWriter.Create(requestXml);
                    
                    request.WriteStartElement("request");
                    request.WriteAttributeString("method", "project.list");
                    request.WriteElementString("page", Convert.ToString(p + 1));
                    //request.WriteElementString("per_page", "10");
                    request.WriteEndElement();
                    request.Close();

                    sendXml = requestXml.ToString();
                    apiErr = freshAPI(ref sendXml);
                    if (apiErr == false)
                    {
                        statusLbl.Text = "Error downloading project list";
                        Cursor = Cursors.Default;
                        return;
                    }
                    responseXml = sendXml;

                    // Response XML
                    inputXml = new StringReader(responseXml);
                    readXml = XmlReader.Create(inputXml);

                    readXml.ReadToFollowing("project");

                    Application.DoEvents();
                }
            }


            // Create client table
            foreach (string id in clientIDs)
            {
                StringBuilder clientXml = new StringBuilder();
                XmlWriter clientRequest = XmlWriter.Create(clientXml);

                clientRequest.WriteStartElement("request");
                clientRequest.WriteAttributeString("method", "client.get");
                clientRequest.WriteElementString("client_id", id);
                clientRequest.WriteEndElement();
                clientRequest.Close();

                string sendClientXml = clientXml.ToString();
                apiErr = freshAPI(ref sendClientXml);
                if (apiErr == false)
                {
                    statusLbl.Text = "Error downloading project list";
                    Cursor = Cursors.Default;
                    return;
                }
                string clientResponseXml = sendClientXml;

                StringReader clientInputXml = new StringReader(clientResponseXml);
                XmlReader clientReadXml = XmlReader.Create(clientInputXml);

                bool name = clientReadXml.ReadToFollowing("organization");
                if (name == false) continue;
                string organization = clientReadXml.ReadElementString("organization");

                DataRow row = Client.NewRow();
                row["client_id"] = id;
                row["organization"] = organization;

                Client.Rows.Add(row);

                Application.DoEvents();
            }

            // Add clients to combo box
            Client.DefaultView.Sort = "organization";
            string[] clientList = new string[Client.Rows.Count];

            for (int x=0; x<Client.Rows.Count; x++)
            {
                clientList[x] = Convert.ToString(Client.DefaultView[x]["organization"]);
                Application.DoEvents();
            }

            cboClient.Items.Clear();
            cboClient.Items.AddRange(clientList);
            cboClient.Items.Add("(All Clients)");
            cboClient.Text = "(All Clients)";

            // Add projects to combo box
            string[] projectList = new string[Projects.Rows.Count];

            for (int x = 0; x < Projects.Rows.Count; x++)
            {
                projectList[x] = Convert.ToString(Projects.Rows[x]["name"]);
                Application.DoEvents();
            }

            cboProject.Items.Clear();
            cboTasks.Items.Clear();
            cboTasks.Text = "";
            cboProject.Items.AddRange(projectList);
            cboProject.Text = "--- Select Project ---";

            statusLbl.Text = "Done";
            Cursor = Cursors.Default;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Dispose();
        }

        private void cboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClient.Text == "(All Clients)")
            {
                // Add projects to combo box
                string[] projectList = new string[Projects.Rows.Count];

                for (int x = 0; x < Projects.Rows.Count; x++)
                {
                    projectList[x] = Convert.ToString(Projects.Rows[x]["name"]);
                }

                cboProject.Items.Clear();
                cboProject.Text = "--- Select Project ---";
                cboTasks.Items.Clear();
                cboTasks.Text = "";
                cboProject.Items.AddRange(projectList);
            }

            else
            {
                Client.DefaultView.Sort = "organization";
                int findRow = Client.DefaultView.Find(cboClient.Text);

                string clientID = Convert.ToString(Client.DefaultView[findRow]["client_id"]);

                Projects.DefaultView.Sort = "client_id";
                DataRowView[] projects = Projects.DefaultView.FindRows(clientID);

                string[] projectsList = new string[projects.Length];

                for (int x = 0; x < projectsList.Length; x++)
                {
                    projectsList[x] = Convert.ToString(projects[x].Row["name"]);
                }

                cboProject.Items.Clear();
                cboTasks.Items.Clear();
                cboProject.Text = "--- Select Project ---";
                cboTasks.Text = "";
                cboProject.Items.AddRange(projectsList);
            }
        }

        private void cboProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tasks.Clear();
            cboTasks.Text = "";
            statusLbl.Text = "Please wait, downloading task list...";
            
            Projects.DefaultView.Sort = "name";
            int findRow = Projects.DefaultView.Find(cboProject.Text);

            string projectID = Convert.ToString(Projects.DefaultView[findRow]["project_id"]);
            
            // Request XML
            StringBuilder requestXml = new StringBuilder();
            XmlWriter request = XmlWriter.Create(requestXml);

            request.WriteStartElement("request");
            request.WriteAttributeString("method", "task.list");
            request.WriteElementString("project_id", projectID);
            request.WriteEndElement();
            request.Close();

            string sendXml = requestXml.ToString();
            
            bool apiErr = freshAPI(ref sendXml);
            if (apiErr == false)
            {
                statusLbl.Text = "Error downloading task list";
                Cursor = Cursors.Default;
                return;
            }
            string responseXml = sendXml;

            // Response XML
            StringReader inputXml = new StringReader(responseXml);
            XmlReader readXml = XmlReader.Create(inputXml);

            // Read XML and create tasks table
            readXml.ReadToFollowing("task");
            while (readXml.EOF == false)
            {
                readXml.ReadToDescendant("task_id");
                string taskID = readXml.ReadElementString("task_id");
                
                readXml.ReadToNextSibling("name");
                string name = readXml.ReadElementString("name");

                readXml.ReadToFollowing("task");

                DataRow row = Tasks.NewRow();

                row["task_id"] = taskID;
                row["name"] = name;

                Tasks.Rows.Add(row);
            }

            // Add taks to combo box
            string[] taskList = new string[Tasks.Rows.Count];

            for (int x = 0; x < Tasks.Rows.Count; x++)
            {
                taskList[x] = Convert.ToString(Tasks.Rows[x]["name"]);
            }

            cboTasks.Items.Clear();
            cboTasks.Text = "--- Select Task ---";
            cboTasks.Items.AddRange(taskList);
            statusLbl.Text = "Done";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cboProject.Text == "--- Select Project ---" || cboProject.Text == "")
            {
                statusLbl.Text = "Please select a project first!";
                return;
            }

            if (cboTasks.Text == "--- Select Task ---" || cboTasks.Text == "")
            {
                statusLbl.Text = "Please select a task first!";
                return;
            }

            if (TimerValue == TimeSpan.Zero || txtFraction.Text == "0000")
            {
                statusLbl.Text = "Timer value is zero! Please add time first.";
                return;
            }

            if (timer1.Enabled == true)
            {
                statusLbl.Text = "Pause timer first before submitting!";
                return;
            }

            double hoursNum = Convert.ToDouble(txtFraction.Text);
            string hours = Convert.ToString(hoursNum * 0.01);

            string entryConfirm = " Submit this time entry?" + "\n\n" + " Project: " + cboProject.Text + "\n" + " Task: " + cboTasks.Text + "\n"
                + " Time: " + hours;
            DialogResult result = MessageBox.Show(entryConfirm, "Confirm Time Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                statusLbl.Text = "Time entry submission canceled";
                return;
            }


            // Get project ID
            Projects.DefaultView.Sort = "name";
            int findrow = Projects.DefaultView.Find(cboProject.Text);
            string projectID = Convert.ToString(Projects.DefaultView[findrow]["project_id"]);

            // Get task ID
            Tasks.DefaultView.Sort = "name";
            findrow = Tasks.DefaultView.Find(cboTasks.Text);
            string taskID = Convert.ToString(Tasks.DefaultView[findrow]["task_id"]);

            string notes = txtNotes.Text;

            // Request XML
            StringBuilder requestXml = new StringBuilder();
            XmlWriter request = XmlWriter.Create(requestXml);

            request.WriteStartElement("request");
            request.WriteAttributeString("method", "time_entry.create");
            request.WriteStartElement("time_entry");
            request.WriteElementString("project_id", projectID);
            request.WriteElementString("task_id", taskID);
            request.WriteElementString("hours", hours);
            request.WriteElementString("notes", notes);
            request.WriteEndElement();
            request.WriteEndElement();
            request.Close();

            string sendXml = requestXml.ToString();
            bool apiErr = freshAPI(ref sendXml);
            if (apiErr == false)
            {
                statusLbl.Text = "Error submitting time entry";
                return;
            }
            string responseXml = sendXml;

            // Response XML
            StringReader inputXml = new StringReader(responseXml);
            XmlReader readXml = XmlReader.Create(inputXml);

            readXml.ReadToFollowing("response");
            string status = readXml.GetAttribute("status");
            if (status == "ok")
            {
                statusLbl.Text = "Time entry submitted successfully!";

                // Clear timer
                TimerPaused = false;
                TimerRunning = false;
                timer1.Enabled = false;
                btnStart.ImageIndex = 1;
                btnStart.Text = " Start";
                txtHour.Text = "00";
                txtMinute.Text = "00";
                txtSecond.Text = "00";
                txtFraction.Text = "0.00";
                TimerValue = TimeSpan.Zero;
                //statusLbl.Text = "Timer cleared";
                notifyIcon1.Icon = Properties.Resources.clock_stop;
                notifyIcon1.Text = "Timer:\n" + TimeSpan.Zero.ToString("g");
                cboTasks.Text = "";
                cboProject.Text = "--- Select Project ---";
                txtNotes.Text = "";
            }
            else
            {
                MessageBox.Show("Error uploading time entry","Upload Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            //contextMenuStrip1.
            //contextMenuStrip1.Show();
        }

        private void menuStart_Click(object sender, EventArgs e)
        {
            btnStart_Click(null, null);
        }

        private void menuMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TimerValue > TimeSpan.Zero)
            {
                DialogResult close = MessageBox.Show("Exit the program?","Close",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (close == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }


    }
}
