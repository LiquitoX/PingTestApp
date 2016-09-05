namespace PingApp
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.testIP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hostIP1 = new System.Windows.Forms.TextBox();
            this.hostIP2 = new System.Windows.Forms.TextBox();
            this.hostIP3 = new System.Windows.Forms.TextBox();
            this.hostIP4 = new System.Windows.Forms.TextBox();
            this.pingTimer = new System.Windows.Forms.Timer(this.components);
            this.StopIPTest = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.listBoxClearTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.numPingInterval = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numClearInterval = new System.Windows.Forms.NumericUpDown();
            this.numDel = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPingInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClearInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 134);
            this.listBox1.TabIndex = 999999;
            // 
            // testIP
            // 
            this.testIP.Location = new System.Drawing.Point(11, 32);
            this.testIP.Name = "testIP";
            this.testIP.Size = new System.Drawing.Size(125, 23);
            this.testIP.TabIndex = 5;
            this.testIP.Text = "Start";
            this.testIP.UseVisualStyleBackColor = true;
            this.testIP.Click += new System.EventHandler(this.testIP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "IP Address";
            // 
            // hostIP1
            // 
            this.hostIP1.Location = new System.Drawing.Point(89, 6);
            this.hostIP1.MaxLength = 3;
            this.hostIP1.Name = "hostIP1";
            this.hostIP1.Size = new System.Drawing.Size(47, 20);
            this.hostIP1.TabIndex = 1;
            this.hostIP1.Text = "127";
            this.hostIP1.TextChanged += new System.EventHandler(this.hostIP1_TextChanged);
            this.hostIP1.Enter += new System.EventHandler(this.hostIP1_Enter);
            // 
            // hostIP2
            // 
            this.hostIP2.Location = new System.Drawing.Point(143, 6);
            this.hostIP2.MaxLength = 3;
            this.hostIP2.Name = "hostIP2";
            this.hostIP2.Size = new System.Drawing.Size(47, 20);
            this.hostIP2.TabIndex = 2;
            this.hostIP2.Text = "0";
            this.hostIP2.TextChanged += new System.EventHandler(this.hostIP2_TextChanged);
            this.hostIP2.Enter += new System.EventHandler(this.hostIP2_Enter);
            // 
            // hostIP3
            // 
            this.hostIP3.Location = new System.Drawing.Point(195, 6);
            this.hostIP3.MaxLength = 3;
            this.hostIP3.Name = "hostIP3";
            this.hostIP3.Size = new System.Drawing.Size(47, 20);
            this.hostIP3.TabIndex = 3;
            this.hostIP3.Text = "0";
            this.hostIP3.TextChanged += new System.EventHandler(this.hostIP3_TextChanged);
            this.hostIP3.Enter += new System.EventHandler(this.hostIP3_Enter);
            // 
            // hostIP4
            // 
            this.hostIP4.Location = new System.Drawing.Point(248, 6);
            this.hostIP4.MaxLength = 3;
            this.hostIP4.Name = "hostIP4";
            this.hostIP4.Size = new System.Drawing.Size(47, 20);
            this.hostIP4.TabIndex = 4;
            this.hostIP4.Text = "1";
            this.hostIP4.TextChanged += new System.EventHandler(this.hostIP4_TextChanged);
            this.hostIP4.Enter += new System.EventHandler(this.hostIP4_Enter);
            // 
            // pingTimer
            // 
            this.pingTimer.Interval = 1000;
            this.pingTimer.Tick += new System.EventHandler(this.pingTimer_Tick);
            // 
            // StopIPTest
            // 
            this.StopIPTest.Location = new System.Drawing.Point(170, 32);
            this.StopIPTest.Name = "StopIPTest";
            this.StopIPTest.Size = new System.Drawing.Size(125, 23);
            this.StopIPTest.TabIndex = 6;
            this.StopIPTest.Text = "Stop Testing";
            this.StopIPTest.UseVisualStyleBackColor = true;
            this.StopIPTest.Click += new System.EventHandler(this.StopIPTest_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(166, 276);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(11, 276);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(125, 23);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // listBoxClearTimer
            // 
            this.listBoxClearTimer.Interval = 10000;
            this.listBoxClearTimer.Tick += new System.EventHandler(this.listBoxClearTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ping Interval:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numPingInterval
            // 
            this.numPingInterval.Location = new System.Drawing.Point(89, 61);
            this.numPingInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numPingInterval.Name = "numPingInterval";
            this.numPingInterval.Size = new System.Drawing.Size(150, 20);
            this.numPingInterval.TabIndex = 1000000;
            this.numPingInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seconds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Clear Interval:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seconds";
            // 
            // numClearInterval
            // 
            this.numClearInterval.Location = new System.Drawing.Point(89, 87);
            this.numClearInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numClearInterval.Name = "numClearInterval";
            this.numClearInterval.Size = new System.Drawing.Size(150, 20);
            this.numClearInterval.TabIndex = 1000000;
            this.numClearInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numDel
            // 
            this.numDel.AutoSize = true;
            this.numDel.Location = new System.Drawing.Point(11, 253);
            this.numDel.Name = "numDel";
            this.numDel.Size = new System.Drawing.Size(144, 17);
            this.numDel.TabIndex = 1000002;
            this.numDel.Text = "Restart count with clear?";
            this.numDel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 307);
            this.ControlBox = false;
            this.Controls.Add(this.numDel);
            this.Controls.Add(this.numClearInterval);
            this.Controls.Add(this.numPingInterval);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.hostIP4);
            this.Controls.Add(this.hostIP3);
            this.Controls.Add(this.hostIP2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hostIP1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StopIPTest);
            this.Controls.Add(this.testIP);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PingApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPingInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClearInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button testIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hostIP1;
        private System.Windows.Forms.TextBox hostIP2;
        private System.Windows.Forms.TextBox hostIP3;
        private System.Windows.Forms.TextBox hostIP4;
        private System.Windows.Forms.Timer pingTimer;
        private System.Windows.Forms.Button StopIPTest;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Timer listBoxClearTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPingInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numClearInterval;
        private System.Windows.Forms.CheckBox numDel;
    }
}

