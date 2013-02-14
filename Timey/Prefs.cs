using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApplication1
{
    public partial class Prefs : Form
    {
        private Form1 form1;
        
        public Prefs(Form1 frm)
        {
            InitializeComponent();
            form1 = frm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFreshAcct_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chkOK_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Break Time");

            key.SetValue("FreshbooksID", txtFreshAcct.Text);
            key.SetValue("Token", txtToken.Text);


            if (chkReminder.Checked == true)
            {
                key.SetValue("TimerReminder", chkReminder.Checked);
                key.SetValue("ReminderInterval", txtRemindMin.Text);
            }
            else
            {
                key.SetValue("TimerReminder", chkReminder.Checked);
            }


            if (chkInactivity.Checked == true)
            {
                key.SetValue("InactivityReminder", chkInactivity.Checked);
                key.SetValue("InactivityInterval", txtPauseMin.Text);
            }
            else
            {
                key.SetValue("InactivityReminder", chkInactivity.Checked);
            }

            key.Close();

            key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run",true);

            if (chkStartWindows.Checked == true)
            {
                key.SetValue("FreshbooksTimer", Application.ExecutablePath);
            }
            else
            {
                key.DeleteValue("FreshbooksTimer",false);
            }

            key.Close();

            form1.RegistryUpdate();

            this.Close();

        }

        private void Prefs_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Break Time");

            if (key == null) return;

            txtFreshAcct.Text = Convert.ToString(key.GetValue("FreshbooksID",""));

            txtToken.Text = Convert.ToString(key.GetValue("Token", ""));

            chkReminder.Checked = Convert.ToBoolean(key.GetValue("TimerReminder",true));
            txtRemindMin.Text = Convert.ToString(key.GetValue("ReminderInterval",5));

            chkInactivity.Checked = Convert.ToBoolean(key.GetValue("InactivityReminder",true));
            txtPauseMin.Text = Convert.ToString(key.GetValue("InactivityInterval", "5"));

            key.Close();

            key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");

            if (key.GetValue("FreshbooksTimer") != null)
            {
                chkStartWindows.Checked = true;
            }

            key.Close();

        }
    }
}
