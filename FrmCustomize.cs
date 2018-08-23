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

namespace CaryDashboard
{
    public partial class FrmCustomize : Form
    {

        /*
         * ______________________________________________________________________________________________________________________________________________________________
         * Fields
         * This section contains global variables and properties utilized by other objects and classes
         */

        //Variable to store reference to Dashboard 
        private FrmDash parent;

        private int btnNumber;

        /* 
         * ______________________________________________________________________________________________________________________________________________________________
         * Constructor
         * This section contains a function utilized in the instantiation of this object
         */

        public FrmCustomize(FrmDash parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        /*
         * _____________________________________________________________________________________________________________________________________________________
         * Interface Functions
         * This section contains functions utilized in various events / behaviors of the form object
         */

        //Event handler clears each field on the form
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmboxBtnSelect.SelectedItem = null;
            cmboxLinkSelect.SelectedItem = null;
            txtExecutable.Text = "";
            txtPathEntry.Text = "";
            txtNameEntry.Text = "";
        }

        //Event handler saves user's custom button information to the selected button
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnNumber == 1)
            {
                if (cmboxLinkSelect.SelectedIndex == 0)
                {
                    Properties.Settings.Default.btn1Launcher = "chrome.exe";
                }
                else if (cmboxLinkSelect.SelectedIndex == 1)
                {
                    Properties.Settings.Default.btn1Launcher = "mstsc.exe";
                }
                else if (cmboxLinkSelect.SelectedIndex == 2)
                {
                    Properties.Settings.Default.btn1Launcher = txtExecutable.Text;
                }
                else if (cmboxLinkSelect.SelectedIndex == 3)
                {
                    Properties.Settings.Default.btn1Launcher = "explorer.exe";
                }

                Properties.Settings.Default.btn1Path = txtPathEntry.Text;
                Properties.Settings.Default.btn1Name = txtNameEntry.Text;
                Properties.Settings.Default.btn1Created = true;
            }
            else if (btnNumber == 2)
            {
                if (cmboxLinkSelect.SelectedIndex == 0)
                {
                    Properties.Settings.Default.btn2Launcher = "chrome.exe";
                }
                else if (cmboxLinkSelect.SelectedIndex == 1)
                {
                    Properties.Settings.Default.btn2Launcher = "mstsc.exe";
                }
                else if (cmboxLinkSelect.SelectedIndex == 2)
                {
                    Properties.Settings.Default.btn2Launcher = txtExecutable.Text;
                }
                else if (cmboxLinkSelect.SelectedIndex == 3)
                {
                    Properties.Settings.Default.btn2Launcher = "explorer.exe";
                }

                Properties.Settings.Default.btn2Path = txtPathEntry.Text;
                Properties.Settings.Default.btn2Name = txtNameEntry.Text;
                Properties.Settings.Default.btn2Created = true;
            }
            else if (btnNumber == 3)
            {
                if (cmboxLinkSelect.SelectedIndex == 0)
                {
                    Properties.Settings.Default.btn3Launcher = "chrome.exe";
                }
                else if (cmboxLinkSelect.SelectedIndex == 1)
                {
                    Properties.Settings.Default.btn3Launcher = "mstsc.exe";
                }
                else if (cmboxLinkSelect.SelectedIndex == 2)
                {
                    Properties.Settings.Default.btn3Launcher = txtExecutable.Text;
                }
                else if (cmboxLinkSelect.SelectedIndex == 3)
                {
                    Properties.Settings.Default.btn3Launcher = "explorer.exe";
                }

                Properties.Settings.Default.btn3Path = txtPathEntry.Text;
                Properties.Settings.Default.btn3Name = txtNameEntry.Text;
                Properties.Settings.Default.btn3Created = true;
            }
            else if (btnNumber == 4)
            {
                if (cmboxLinkSelect.SelectedIndex == 0)
                {
                    Properties.Settings.Default.btn4Launcher = "chrome.exe";
                }
                else if (cmboxLinkSelect.SelectedIndex == 1)
                {
                    Properties.Settings.Default.btn4Launcher = "mstsc.exe";
                }
                else if (cmboxLinkSelect.SelectedIndex == 2)
                {
                    Properties.Settings.Default.btn4Launcher = txtExecutable.Text;
                }
                else if (cmboxLinkSelect.SelectedIndex == 3)
                {
                    Properties.Settings.Default.btn4Launcher = "explorer.exe";
                }

                Properties.Settings.Default.btn4Path = txtPathEntry.Text;
                Properties.Settings.Default.btn4Name = txtNameEntry.Text;
                Properties.Settings.Default.btn4Created = true;
            }
            else if (btnNumber == 5)
            {
                if (cmboxLinkSelect.SelectedIndex == 0)
                {
                    Properties.Settings.Default.btn5Launcher = "chrome.exe";
                }
                else if (cmboxLinkSelect.SelectedIndex == 1)
                {
                    Properties.Settings.Default.btn5Launcher = "mstsc.exe";
                }
                else if (cmboxLinkSelect.SelectedIndex == 2)
                {
                    Properties.Settings.Default.btn5Launcher = txtExecutable.Text;
                }
                else if (cmboxLinkSelect.SelectedIndex == 3)
                {
                    Properties.Settings.Default.btn5Launcher = "explorer.exe";
                }

                Properties.Settings.Default.btn5Path = txtPathEntry.Text;
                Properties.Settings.Default.btn5Name = txtNameEntry.Text;
                Properties.Settings.Default.btn5Created = true;
            }
        }

        //Event handler adjusts int which relays which btn the user will customize
        private void cmboxBtnSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxBtnSelect.SelectedIndex == 0)
            {
                btnNumber = 1;
            }
            else if (cmboxBtnSelect.SelectedIndex == 1)
            {
                btnNumber = 2;
            }
            else if (cmboxBtnSelect.SelectedIndex == 2)
            {
                btnNumber = 3;
            }
            else if (cmboxBtnSelect.SelectedIndex == 3)
            {
                btnNumber = 4;
            }
            else if (cmboxBtnSelect.SelectedIndex == 4)
            {
                btnNumber = 5;
            }

            fieldsCheck();
        }

        //Event handler adjusts the launcher string for the button the user will customize
        private void cmboxLinkSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxLinkSelect.SelectedIndex == 2)
            {
                txtExecutable.Enabled = true;
                lblPathEntry.Text = "Parameters";
            }
            
            if (cmboxLinkSelect.SelectedIndex != 2)
            {
                txtExecutable.Enabled = false;
                txtExecutable.Text = "";
                lblPathEntry.Text = "Path Entry:";
            }

            fieldsCheck();
        }

        //Event handler adjusts the launcher string for the application button type if selected
        private void txtExecutable_TextChanged(object sender, EventArgs e)
        {
            if (txtExecutable.Enabled == true)
            {
                fieldsCheck();
            }
        }

        //Event handler adjusts the path string for the button the user will customize
        private void txtPathEntry_TextChanged(object sender, EventArgs e)
        {
            fieldsCheck();
        }

        //Event handler adjusts the name string for the button the user will customize
        private void txtNameEntry_TextChanged(object sender, EventArgs e)
        {
            fieldsCheck();
        }

        //Function checks whether or not all fields have entries
        private void fieldsCheck()
        {
            if (cmboxLinkSelect.SelectedIndex == 0 || cmboxLinkSelect.SelectedIndex == 1 || cmboxLinkSelect.SelectedIndex == 3)
            {
                if (cmboxBtnSelect != null && cmboxLinkSelect.SelectedItem != null &&
                    txtPathEntry.Text != "" && txtNameEntry.Text != "")
                {
                    btnCreate.Enabled = true;
                }
                else
                {
                    btnCreate.Enabled = false;
                }
            }
            else if (cmboxLinkSelect.SelectedIndex == 2)
            {
                if (cmboxBtnSelect != null && cmboxLinkSelect.SelectedItem != null && 
                    txtExecutable.Text != "" && txtNameEntry.Text != "")
                {
                    btnCreate.Enabled = true;
                }
                else
                {
                    btnCreate.Enabled = false;
                }
            }
        }
    }
}
