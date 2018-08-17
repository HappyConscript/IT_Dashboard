/*
 * Author: Evan Brooks
 * Date: 8/17/2018
 * Synopsis: prototype for color guessing game
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CaryDashboard
{
    public partial class FrmDash : Form
    {

        /*
         * ______________________________________________________________________________________________________________________________________________________________
         * Fields
         * This section contains global variables and properties utilized by other objects and classes
         */

        //Variable to store reference to customize form
        private FrmCustomize frmCustomize;
        private FrmAbout frmAbout;

        /* 
         * ______________________________________________________________________________________________________________________________________________________________
         * Constructor
         * This section contains a function utilized in the instantiation of this object
         */

        public FrmDash()
        {
            InitializeComponent();
        }

        //Load saved settings? Necessary? ? ?
        private void frmDash_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
        }

        //Placeholder

        /*
         * _____________________________________________________________________________________________________________________________________________________
         * Interface Functions
         * This section contains functions utilized in various events / behaviors of the form object
         */

        //Web Links

        //Event handler executes event handlers for all web links
        private void btnWebAll_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Open All?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (yesno == DialogResult.Yes)
            {
                btnO365Link_Click(sender, e);
                btnLanLink_Click(sender, e);
                btnSamLink_Click(sender, e);
                btnFinesseLink_Click(sender, e);
                btnJiraLink_Click(sender, e);
            }
        }

        //Event handler opens Chrome window with O365 tab
        private void btnO365Link_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", @"https://www.office.com/?auth=2&home=1");
        }

        //Event handler opens Chrome window with Lansweeper tab
        private void btnLanLink_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", @"https://lansweeper/Default.aspx");
        }

        //Event handler opens Chrome window with Samanage dashboard tab
        private void btnSamLink_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", @"https://townofcary.samanage.com/");
        }

        //Event handler opens Chrome window with Salesforce home tab
        private void btnFinesseLink_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", @"https://uccx1.ci.cary.nc.us:8445/desktop");
        }

        //Event handler opens Chrome window with Jira dashboard tab
        private void btnJiraLink_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", @"https://carync.atlassian.net/secure/Dashboard.jspa");
        }

        //Server Links

        //Event handler executes event handlers for all server links
        private void btnServAll_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Open All?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (yesno == DialogResult.Yes)
            {
                btnCnetLink_Click(sender, e);
                btnMailLink_Click(sender, e);
                btnClass_Click(sender, e);
                btnC2faLink_Click(sender, e);
                btnSpeedTestLink_Click(sender, e);
            }
        }

        //Event handler opens RDP with Cnet server address
        private void btnCnetLink_Click(object sender, EventArgs e)
        {
            Process.Start("mstsc.exe", @"/v:cnet.ci.cary.nc.us");
        }

        //Event handler opens RDP with Mail01 server address
        private void btnMailLink_Click(object sender, EventArgs e)
        {
            Process.Start("mstsc.exe", @"/v:mailbox01");
        }

        //Event handler opens RDP with Class server address
        private void btnClass_Click(object sender, EventArgs e)
        {
            Process.Start("mstsc.exe", @"/v:csqlp02a");
        }

        //Event handler opens RDP with 2FA server address
        private void btnC2faLink_Click(object sender, EventArgs e)
        {
            Process.Start("mstsc.exe", @"/v:c2fa01a");
        }

        //Event handler opens RDP with Speed Test server address
        private void btnSpeedTestLink_Click(object sender, EventArgs e)
        {
            Process.Start("mstsc.exe", @"speedtest.cary.ci");
        }

        //Application Links

        //Event handler executes event handlers for all application links
        private void btnAppAll_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Open All?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (yesno == DialogResult.Yes)
            {
                btnActiveLink_Click(sender, e);
                btnDeviceLink_Click(sender, e);
                btnPerformanceLink_Click(sender, e);
                btnEventLink_Click(sender, e);
            }
        }

        //Event handler opens Active Directory application
        private void btnActiveLink_Click(object sender, EventArgs e)
        {
            Process.Start("mmc.exe", @"dsa.msc");
        }

        //Event handler opens Device Manager application
        private void btnDeviceLink_Click(object sender, EventArgs e)
        {
            Process.Start("mmc.exe", @"devmgmt.msc");
        }

        //Event handler opens Resource Monitor application
        private void btnPerformanceLink_Click(object sender, EventArgs e)
        {
            Process.Start("mmc.exe", @"perfmon.msc");
        }

        //Event handler opens Event Viewer application
        private void btnEventLink_Click(object sender, EventArgs e)
        {
            Process.Start("mmc.exe", @"eventvwr.msc");
        }

        //Event viewer opens the Task Manager application
        private void btnTaskLink_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr.exe", @"C:\Windows\System32\");
        }

        //File Links

        //Event handler executes event handlers for all file links
        private void btnFileAll_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Open All?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (yesno == DialogResult.Yes)
            {
                btnSwportalLink_Click(sender, e);
                btnSwlibLink_Click(sender, e);
                btnSwpackLink_Click(sender, e);
                btnTsdriveLink_Click(sender, e);
                btnBackupLink_Click(sender, e);
            }
        }

        //Event handler opens file explorer with R-Drive backup address
        private void btnBackupLink_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"\\carynas\data\~snapshot");
        }

        //Event handler opens file explorer with SW Portal address
        private void btnSwportalLink_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"\\it\swportal");
        }

        //Event handler opens file explorer with SW Lib address
        private void btnSwlibLink_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"\\ts\swlib");
        }

        //Event handler opens file explorer with SW Pack address
        private void btnSwpackLink_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"\\it\SWPack");
        }

        //Event handler opens file explorer with TS Drive address
        private void btnTsdriveLink_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"R:\TSdrv");
        }

        //Menu Strip

        //Instantiate the about form
        private void mbAbout_Click(object sender, EventArgs e)
        {
            frmAbout = new FrmAbout();
            frmAbout.Show();
        }

        //Event handler prompts user for confirmation of exit
        private void mbExit_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Exit Application?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (yesno == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Run the customize button event handler
        private void mbCreate_Click(object sender, EventArgs e)
        {
            btnCustomize_Click(sender, e);
        }

        //Event handler prompts user for confirmation of erasing custom button presets
        private void mbClear_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Reset Custom Buttons?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (yesno == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();

                btnCustom1.Text = "Custom Btn 1";
                btnCustom2.Text = "Custom Btn 2";
                btnCustom3.Text = "Custom Btn 3";
                btnCustom4.Text = "Custom Btn 4";
                btnCustom5.Text = "Custom Btn 5";
            }
        }

        //Custom Buttons

        //Instantiate the button customization form and pass this form (main form) in
        private void btnCustomize_Click(object sender, EventArgs e)
        {
            frmCustomize = new FrmCustomize(this);
            frmCustomize.Show();
        }

        //Event handler launches accoridng to custom parameters defined by yser
        private void btnCustom1_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Settings.Default.btn1Launcher, @Properties.Settings.Default.btn1Path);
        }

        //Event handler launches accoridng to custom parameters defined by yser
        private void btnCustom2_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Settings.Default.btn2Launcher, @Properties.Settings.Default.btn2Path);
        }

        //Event handler launches accoridng to custom parameters defined by yser
        private void btnCustom3_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Settings.Default.btn3Launcher, @Properties.Settings.Default.btn3Path);
        }

        //Event handler launches accoridng to custom parameters defined by yser
        private void btnCustom4_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Settings.Default.btn4Launcher, @Properties.Settings.Default.btn4Path);
        }

        //Event handler launches accoridng to custom parameters according to user configuration settings
        //Project -> Properties -> Settings
        private void btnCustom5_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Settings.Default.btn5Launcher, @Properties.Settings.Default.btn5Path);
        }

        //Event handler updates custom buttons when entering the custom tab according to user configuration settings
        //Project -> Properties -> Settings
        private void FrmDash_Activated(object sender, EventArgs e)
        {
            //if (tbcDash.SelectedIndex == 4)
                //if (frmCustomize != null)
                //{
                    if (Properties.Settings.Default.btn1Name != "" && Properties.Settings.Default.btn1Created == true)
                    {
                        btnCustom1.Text = Properties.Settings.Default.btn1Name;
                        btnCustom1.Enabled = true;
                    }
                    if (Properties.Settings.Default.btn2Name != "" && Properties.Settings.Default.btn2Created == true)
                    {
                        btnCustom2.Text = Properties.Settings.Default.btn2Name;
                        btnCustom2.Enabled = true;
                    }
                    if (Properties.Settings.Default.btn3Name != "" && Properties.Settings.Default.btn3Created == true)
                    {
                        btnCustom3.Text = Properties.Settings.Default.btn3Name;
                        btnCustom3.Enabled = true;
                    }
                    if (Properties.Settings.Default.btn4Name != "" && Properties.Settings.Default.btn4Created == true)
                    {
                        btnCustom4.Text = Properties.Settings.Default.btn4Name;
                        btnCustom4.Enabled = true;
                    }
                    if (Properties.Settings.Default.btn5Name != "" && Properties.Settings.Default.btn5Created == true)
                    {
                        btnCustom5.Text = Properties.Settings.Default.btn5Name;
                        btnCustom5.Enabled = true;
                    }
                //}
        }

        private void tbcDash_TabIndexChanged(object sender, EventArgs e)
        {
            FrmDash_Activated(sender, e);
        }

        //Save user configuration settings (custom buttons) when the form is closing
        //Project -> Properties -> Settings
        private void FrmDash_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        //Save user configuration settings (custom buttons) when the form is closed
        //Project -> Properties -> Settings
        private void FrmDash_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
