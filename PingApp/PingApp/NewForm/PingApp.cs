using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

//Version 0.1.0.0
//.NET Framework 3.0

namespace PingApp{
    public partial class frmPingApp : Form{
        public frmPingApp(){
            InitializeComponent();
        }

        private void PingApp_Load(object sender, EventArgs e){
            setValues();

        }

        // FUNCTIONS ARE DEFINED BEFORE ALL USER INTERACTIONS!

        /// <summary>
        /// This function sets the values of ALL controls back to default.
        /// </summary>
        private void setValues(){
            numIP1.Value = 127;
            numIP2.Value = 0;
            numIP3.Value = 0;
            numIP4.Value = 1;
            numPingInterval.Value = 1;
            numClearInterval.Value = 10;
            clearListBox();
        }

        /// <summary>
        /// This function clears all items within the listbox.
        /// </summary>
        private void clearListBox(){
            listPing.Items.Clear();
        }

        /// <summary>
        /// This function ends the application.
        /// </summary>
        private void endApp(){
            Application.Exit();
        }

        /// <summary>
        /// This function will create an ip from 4 numeric values.
        /// </summary>
        private static string createIP(int num1, int num2, int num3, int num4){
            string IPAddress = num1 + "." + num2 + "." + num3 + "." + num4;
            return IPAddress;
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
            MessageBox.Show("Function not implemented yet!", "TODO", MessageBoxButtons.OK);
        }

        private void btnTest_Click(object sender, EventArgs e){
            string ip = createIP(Convert.ToInt32(numIP1.Value), 
                Convert.ToInt32(numIP2.Value), 
                Convert.ToInt32(numIP3.Value), 
                Convert.ToInt32(numIP4.Value)
            ); //End
        }
    }
}
