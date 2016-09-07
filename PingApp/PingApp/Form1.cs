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
using System.Net.NetworkInformation;
using System.Threading;
using System.Net;

namespace PingApp
{
    public partial class Form1 : Form{
        //  Declarations
        private int num = 1;

        //  Application
        public Form1()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Loads the form with the focus on the 1st inputbox.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e){
            
            hostIP1.Focus();
            StopIPTest.Enabled = false;

            //  MessageBox needs to be deleted after 1st release
            MessageBox.Show("Thank you for testing this app!\n" +
                "Don't put an value higher than 255 in the textboxes\n" +
                "This is an known bug.\n\n" +
                "If you find any other bugs, please report them immediately to Wenzel\n" +
                "https://github.com/LiquitoX/PingTestApp/issues", "Thank you");
        }

        //
        //  Activates the pingTimer and enabeles the "stop" button
        //  This "Click" event will also preform some checks.
        //        
        private void testIP_Click(object sender, EventArgs e){
            clearListBox();
            pingTimer.Enabled = true;
            testIP.Enabled = false;
            StopIPTest.Enabled = true;
            btnClose.Enabled = false;
            listBoxClearTimer.Enabled = true;
            textBoxState(false);
            checkIntervals();
            pingTimer.Interval = Convert.ToInt32(numPingInterval.Value*1000);
            listBoxClearTimer.Interval = Convert.ToInt32(numClearInterval.Value*1000);
        }

        /// <summary>
        /// Checks if numPintInterval and numClearInterval are above 0.
        /// </summary>
        private void checkIntervals(){
            if (numPingInterval.Value <= 0){
                numPingInterval.Value = 1;
            }
            if (numClearInterval.Value <= 0){
                numClearInterval.Value = 1;
            }
        }

        /// <summary>
        /// Sets the state of all fields with input.
        /// </summary>
        /// <param name="state"></param>
        private void textBoxState(bool state){
            hostIP1.Enabled = state;
            hostIP2.Enabled = state;
            hostIP3.Enabled = state;
            hostIP4.Enabled = state;
            numPingInterval.Enabled = state;
            numClearInterval.Enabled = state;
        }
        //
        // Stops the pingTimer and activates the "start" button
        //
        private void StopIPTest_Click(object sender, EventArgs e){
            pingTimer.Enabled = false;
            listBox1.Items.Add("Test stopped!");
            selectLastItem();
            testIP.Enabled = true;
            StopIPTest.Enabled = false;
            btnClose.Enabled = true;
            listBoxClearTimer.Enabled = false;
            textBoxState(true);
            GC.Collect();

        }
        /// <summary>
        /// pingTest()
        ///     Pastes the 4 inputboxes together to one string and then 
        ///     tests if there is a pingable connection between the host
        ///     and the given IP-Address. The results are displayed in
        ///     an listbox.
        /// </summary>
        private void pingTest(){
            
            
            string ip =
                hostIP1.Text + "." +
                hostIP2.Text + "." +
                hostIP3.Text + "." +
                hostIP4.Text;
            Ping ping = new Ping();

            PingReply pingStatus = ping.Send(IPAddress.Parse(ip));

            if (pingStatus.Status == IPStatus.Success){
                listBox1.Items.Add(num + ") Ping to " + ip + " was successful");
                num++;
            } else {
                listBox1.Items.Add("Ping has Failed!");
                pingTimer.Enabled = false;
                listBoxClearTimer.Enabled = false;
                MessageBox.Show("ERRORCODE: 01\n" + "Ping was not resolved!", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                resetTest();
            }
        }

        /// <summary>
        /// Resets the Pingtest to its "start" parameters
        /// </summary>
        private void resetTest(){
            StopIPTest.Enabled = false;
            testIP.Enabled = true;
            btnClose.Enabled = true;
            hostIP1.Focus();
            textBoxState(true);
            GC.Collect();
        }

        /// <summary>
        /// Clears all the listbox items. And resets the global num value if numDel is checked.
        /// </summary>
        private void clearListBox(){
            listBox1.Items.Clear();
            if (numDel.Checked){
                num = 1;
            }
        }
        
        /// <summary>
        /// When the length is 3 or greater, move to the next inputfield.
        /// </summary>
        private void hostIP1_TextChanged(object sender, EventArgs e){
            validateText(1);
            int len = hostIP1.TextLength;
            if (len >= 3){
                hostIP2.Focus();
            }
        }
        private void hostIP2_TextChanged(object sender, EventArgs e){
            validateText(2);
            int len = hostIP2.TextLength;
            if (len >= 3){
                hostIP3.Focus();
            }
        }
        private void hostIP3_TextChanged(object sender, EventArgs e){
            validateText(3);
            int len = hostIP3.TextLength;
            if (len >= 3){
                hostIP4.Focus();
            }
        }
        private void hostIP4_TextChanged(object sender, EventArgs e){
            validateText(4);
            int len = hostIP4.TextLength;
            if (len >= 3){
                hostIP1.Focus();
            }
        }
        private void hostIP1_Enter(object sender, EventArgs e){
            hostIP1.SelectAll();
        }
        private void hostIP2_Enter(object sender, EventArgs e){
            hostIP2.SelectAll();
        }
        private void hostIP3_Enter(object sender, EventArgs e){
            hostIP3.SelectAll();
        }
        private void hostIP4_Enter(object sender, EventArgs e){
            hostIP4.SelectAll();
        }

        private void pingTimer_Tick(object sender, EventArgs e)
        {
            pingTest();
            selectLastItem();
        }



        
        private void selectLastItem(){
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
        private void validateText(int Number)
        {
            string ErrNumber = "Please enter only numbers!";
            if (Number == 1){
                if (System.Text.RegularExpressions.Regex.IsMatch(hostIP1.Text, "[^0-9]")){
                    hostIP1.Text = "";
                    MessageBox.Show(ErrNumber);
                    
                }
            } else if (Number == 2){
                if (System.Text.RegularExpressions.Regex.IsMatch(hostIP2.Text, "[^0-9]")){ 
                    MessageBox.Show(ErrNumber);
                    hostIP2.Text = "";
                }
            } else if (Number == 3){
                if (System.Text.RegularExpressions.Regex.IsMatch(hostIP3.Text, "[^0-9]")){
                    MessageBox.Show(ErrNumber);
                    hostIP3.Text = "";
                }
            } else if (Number == 4) {
                if (System.Text.RegularExpressions.Regex.IsMatch(hostIP4.Text, "[^0-9]")){ 
                    MessageBox.Show(ErrNumber);
                    hostIP4.Text = "";
                }
            }
            
        }

        /// <summary>
        /// Exits the program
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            end();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            // TODO: Implement About page.
            MessageBox.Show("Function not implemented yet!");
        }

        private void listBoxClearTimer_Tick(object sender, EventArgs e)
        {
            clearListBox();
            GC.Collect();
        }

        private void linkIssue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            Process.Start("https://github.com/LiquitoX/PingTestApp/issues");
        }

        /// <summary>
        /// Ends the Application.
        /// </summary>
        private void end(){
            Application.Exit();
        }
    }
}
