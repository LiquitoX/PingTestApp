using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq; //Not available in .NET 3.0
using System.Text;
//using System.Threading.Tasks; //Not available in .NET 3.0
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net;

//Version 0.2.0.1
//.NET Framework 3.0

namespace PingApp{
    public partial class frmPingApp : Form {
        private int num = 1;

        public frmPingApp() {
            InitializeComponent();
        }

        private void PingApp_Load(object sender, EventArgs e) {
            setValues();
            btnStopTest.Enabled = false;


        }

        // FUNCTIONS ARE DEFINED BEFORE ALL USER INTERACTIONS!

        /// <summary>
        /// This function sets the values of ALL controls back to default.
        /// </summary>
        private void setValues() {
            numIP1.Value = 127;
            numIP2.Value = 0;
            numIP3.Value = 0;
            numIP4.Value = 1;
            numPingInterval.Value = 1;
            numClearInterval.Value = 10;
            chkClear.Checked = false;
            clearListBox();
        }

        /// <summary>
        /// This function clears all items within the listbox.
        /// </summary>
        private void clearListBox() {
            listPing.Items.Clear();
        }

        /// <summary>
        /// This function ends the application.
        /// </summary>
        private void endApp() {
            Application.Exit();
        }

        /// <summary>
        /// This function will create an ip from 4 numeric values.
        /// </summary>
        private string createIP(int num1, int num2, int num3, int num4) {
            string IPAddress = num1 + "." + num2 + "." + num3 + "." + num4;
            return IPAddress;
        }

        /// <summary>
        /// This funtion enabeles or disabeles all controls on the form.
        /// </summary>
        /// <param name="state"></param>
        private void setState(bool state) {
            numIP1.Enabled = state;
            numIP2.Enabled = state;
            numIP3.Enabled = state;
            numIP4.Enabled = state;
            numPingInterval.Enabled = state;
            numClearInterval.Enabled = state;
            chkClear.Enabled = state;
            btnReset.Enabled = state;
            btnClose.Enabled = state;
        }

        private void setTimerState(bool state) {
            tmrClearInterval.Enabled = state;
            tmrPingInterval.Enabled = state;
        }

        /// <summary>
        /// This function tests the given ip for connectivity.
        /// </summary>
        private void pingTest() {
            string ip = createIP(
                Convert.ToInt32(numIP1.Value),
                Convert.ToInt32(numIP2.Value),
                Convert.ToInt32(numIP3.Value),
                Convert.ToInt32(numIP4.Value)
            );
            // Create the ping Object.
            Ping ping = new Ping();

            // Ping the desired IPAddress.
            PingReply pingStatus = ping.Send(IPAddress.Parse(ip));
            if (pingStatus.Status == IPStatus.Success) {
                listPing.Items.Add(num + ".) Ping to " + ip + " was successful");
                num++;
            }
            else {
                num = 1;
                listPing.Items.Add("Ping has Failed!");
                tmrPingInterval.Enabled = false;
                btnStopTest.Enabled = false;
                btnStartTest.Enabled = true;
                setTimerState(false);
                MessageBox.Show("ERRORCODE: 01\n" + "Ping was not resolved!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setState(true);
            }
        }

        /// <summary>
        /// Selects the last item in the List
        /// </summary>
        private void selectLastItem() {
            listPing.SelectedIndex = listPing.Items.Count - 1;
        }
        // END DEFINING FUNCTIONS


        private void linkReportIssue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            Process.Start("https://github.com/LiquitoX/PingTestApp/issues");
        }

        private void btnClose_Click(object sender, EventArgs e){
            endApp();
        }

        private void btnAbout_Click(object sender, EventArgs e){
            // TODO: Add about form.
            // MessageBox.Show("Function not implemented yet!", "TODO", MessageBoxButtons.OK);
            MessageBox.Show(string.Format("This app was made by:\nLiquitoX Development\nVersion: {0}", this.ProductVersion));
        }

        private void btnTest_Click(object sender, EventArgs e){
            string ip = createIP(Convert.ToInt32(numIP1.Value), 
                Convert.ToInt32(numIP2.Value), 
                Convert.ToInt32(numIP3.Value), 
                Convert.ToInt32(numIP4.Value)
            ); //End
        }

        private void btnReset_Click(object sender, EventArgs e){
            setValues();
            listPing.Items.Add("Values reverted to default!");
        }

        private void btnStartTest_Click(object sender, EventArgs e){
            setState(false);
            setTimerState(true);
            btnStartTest.Enabled = false;
            btnStopTest.Enabled = true;
            tmrPingInterval.Interval = Convert.ToInt32(numPingInterval.Value)*1000;
            tmrClearInterval.Interval = Convert.ToInt32(numClearInterval.Value)*1000;
            clearListBox();
        }

        private void btnStopTest_Click(object sender, EventArgs e){
            setState(true);
            setTimerState(false);
            btnStartTest.Enabled = true;
            btnStopTest.Enabled = false;
            listPing.Items.Add("Test stopped by user!");
            numIP1.Focus();
        }

        private void tmrPingInterval_Tick(object sender, EventArgs e){
            pingTest();
            selectLastItem();

        }

        private void tmrClearInterval_Tick(object sender, EventArgs e){
            clearListBox();
            if (chkClear.Checked){
                num = 1;
            }
            GC.Collect();
        }

        // Select all within the numupdown boxes
        private void numIP1_Enter(object sender, EventArgs e){
            numIP1.Select(0, numIP1.Text.Length);
        }

        private void numIP2_Enter(object sender, EventArgs e){
            numIP2.Select(0, numIP2.Text.Length);
        }

        private void numIP3_Enter(object sender, EventArgs e){
            numIP3.Select(0, numIP3.Text.Length);
        }

        private void numIP4_Enter(object sender, EventArgs e){
            numIP4.Select(0, numIP4.Text.Length);
        }

        private void numPingInterval_Enter(object sender, EventArgs e){
            numPingInterval.Select(0, numPingInterval.Text.Length);
        }

        private void numClearInterval_Enter(object sender, EventArgs e){
            numClearInterval.Select(0, numClearInterval.Text.Length);
        }
        // End SelectAll
    }
}
