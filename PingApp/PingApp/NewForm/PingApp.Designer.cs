namespace PingApp
{
    partial class frmPingApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.numIP1 = new System.Windows.Forms.NumericUpDown();
            this.numIP2 = new System.Windows.Forms.NumericUpDown();
            this.numIP3 = new System.Windows.Forms.NumericUpDown();
            this.numIP4 = new System.Windows.Forms.NumericUpDown();
            this.lblPingInterval = new System.Windows.Forms.Label();
            this.numPingInterval = new System.Windows.Forms.NumericUpDown();
            this.lblSeconds1 = new System.Windows.Forms.Label();
            this.numClearInterval = new System.Windows.Forms.NumericUpDown();
            this.lblClearInterval = new System.Windows.Forms.Label();
            this.lblSeconds2 = new System.Windows.Forms.Label();
            this.tmrPingInterval = new System.Windows.Forms.Timer(this.components);
            this.tmrClearInterval = new System.Windows.Forms.Timer(this.components);
            this.listPing = new System.Windows.Forms.ListBox();
            this.linkReportIssue = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numIP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIP4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPingInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClearInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(9, 9);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(61, 13);
            this.lblIPAddress.TabIndex = 0;
            this.lblIPAddress.Text = "IP Address:";
            // 
            // numIP1
            // 
            this.numIP1.Location = new System.Drawing.Point(132, 7);
            this.numIP1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numIP1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIP1.Name = "numIP1";
            this.numIP1.Size = new System.Drawing.Size(38, 20);
            this.numIP1.TabIndex = 1;
            this.numIP1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // numIP2
            // 
            this.numIP2.Location = new System.Drawing.Point(176, 7);
            this.numIP2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numIP2.Name = "numIP2";
            this.numIP2.Size = new System.Drawing.Size(38, 20);
            this.numIP2.TabIndex = 1;
            this.numIP2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // numIP3
            // 
            this.numIP3.Location = new System.Drawing.Point(220, 7);
            this.numIP3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numIP3.Name = "numIP3";
            this.numIP3.Size = new System.Drawing.Size(38, 20);
            this.numIP3.TabIndex = 1;
            this.numIP3.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // numIP4
            // 
            this.numIP4.Location = new System.Drawing.Point(264, 7);
            this.numIP4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numIP4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIP4.Name = "numIP4";
            this.numIP4.Size = new System.Drawing.Size(38, 20);
            this.numIP4.TabIndex = 1;
            this.numIP4.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // lblPingInterval
            // 
            this.lblPingInterval.AutoSize = true;
            this.lblPingInterval.Location = new System.Drawing.Point(9, 35);
            this.lblPingInterval.Name = "lblPingInterval";
            this.lblPingInterval.Size = new System.Drawing.Size(68, 13);
            this.lblPingInterval.TabIndex = 2;
            this.lblPingInterval.Text = "Ping interval:";
            // 
            // numPingInterval
            // 
            this.numPingInterval.Location = new System.Drawing.Point(132, 33);
            this.numPingInterval.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numPingInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPingInterval.Name = "numPingInterval";
            this.numPingInterval.Size = new System.Drawing.Size(115, 20);
            this.numPingInterval.TabIndex = 1;
            this.numPingInterval.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // lblSeconds1
            // 
            this.lblSeconds1.AutoSize = true;
            this.lblSeconds1.Location = new System.Drawing.Point(253, 35);
            this.lblSeconds1.Name = "lblSeconds1";
            this.lblSeconds1.Size = new System.Drawing.Size(49, 13);
            this.lblSeconds1.TabIndex = 2;
            this.lblSeconds1.Text = "Seconds";
            // 
            // numClearInterval
            // 
            this.numClearInterval.Location = new System.Drawing.Point(132, 59);
            this.numClearInterval.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numClearInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numClearInterval.Name = "numClearInterval";
            this.numClearInterval.Size = new System.Drawing.Size(115, 20);
            this.numClearInterval.TabIndex = 1;
            this.numClearInterval.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // lblClearInterval
            // 
            this.lblClearInterval.AutoSize = true;
            this.lblClearInterval.Location = new System.Drawing.Point(9, 61);
            this.lblClearInterval.Name = "lblClearInterval";
            this.lblClearInterval.Size = new System.Drawing.Size(72, 13);
            this.lblClearInterval.TabIndex = 2;
            this.lblClearInterval.Text = "Clear Interval:";
            // 
            // lblSeconds2
            // 
            this.lblSeconds2.AutoSize = true;
            this.lblSeconds2.Location = new System.Drawing.Point(253, 61);
            this.lblSeconds2.Name = "lblSeconds2";
            this.lblSeconds2.Size = new System.Drawing.Size(49, 13);
            this.lblSeconds2.TabIndex = 2;
            this.lblSeconds2.Text = "Seconds";
            // 
            // listPing
            // 
            this.listPing.FormattingEnabled = true;
            this.listPing.Location = new System.Drawing.Point(12, 90);
            this.listPing.Name = "listPing";
            this.listPing.Size = new System.Drawing.Size(293, 134);
            this.listPing.TabIndex = 3;
            // 
            // linkReportIssue
            // 
            this.linkReportIssue.Location = new System.Drawing.Point(179, 283);
            this.linkReportIssue.Name = "linkReportIssue";
            this.linkReportIssue.Size = new System.Drawing.Size(126, 16);
            this.linkReportIssue.TabIndex = 4;
            this.linkReportIssue.TabStop = true;
            this.linkReportIssue.Text = "Report issue";
            this.linkReportIssue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkReportIssue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReportIssue_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(179, 302);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 302);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(126, 23);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 273);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(126, 23);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "TestButton";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start test";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmPingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 337);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linkReportIssue);
            this.Controls.Add(this.listPing);
            this.Controls.Add(this.lblSeconds2);
            this.Controls.Add(this.lblSeconds1);
            this.Controls.Add(this.lblClearInterval);
            this.Controls.Add(this.lblPingInterval);
            this.Controls.Add(this.numIP4);
            this.Controls.Add(this.numIP3);
            this.Controls.Add(this.numIP2);
            this.Controls.Add(this.numClearInterval);
            this.Controls.Add(this.numPingInterval);
            this.Controls.Add(this.numIP1);
            this.Controls.Add(this.lblIPAddress);
            this.Name = "frmPingApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PingApp";
            this.Load += new System.EventHandler(this.PingApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numIP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIP4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPingInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClearInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.NumericUpDown numIP1;
        private System.Windows.Forms.NumericUpDown numIP2;
        private System.Windows.Forms.NumericUpDown numIP3;
        private System.Windows.Forms.NumericUpDown numIP4;
        private System.Windows.Forms.Label lblPingInterval;
        private System.Windows.Forms.NumericUpDown numPingInterval;
        private System.Windows.Forms.Label lblSeconds1;
        private System.Windows.Forms.NumericUpDown numClearInterval;
        private System.Windows.Forms.Label lblClearInterval;
        private System.Windows.Forms.Label lblSeconds2;
        private System.Windows.Forms.Timer tmrPingInterval;
        private System.Windows.Forms.Timer tmrClearInterval;
        private System.Windows.Forms.ListBox listPing;
        private System.Windows.Forms.LinkLabel linkReportIssue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button button1;
    }
}