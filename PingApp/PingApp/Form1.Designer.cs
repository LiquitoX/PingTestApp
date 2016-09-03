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
            this.label1 = new System.Windows.Forms.Label();
            this.hostName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hostIP1 = new System.Windows.Forms.TextBox();
            this.hostIP2 = new System.Windows.Forms.TextBox();
            this.hostIP3 = new System.Windows.Forms.TextBox();
            this.hostIP4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // hostName
            // 
            this.hostName.Location = new System.Drawing.Point(90, 12);
            this.hostName.Name = "hostName";
            this.hostName.Size = new System.Drawing.Size(206, 20);
            this.hostName.TabIndex = 1;
            this.hostName.Text = "www.google.com";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(90, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 95);
            this.listBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Test IP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "IP Address";
            // 
            // hostIP1
            // 
            this.hostIP1.Location = new System.Drawing.Point(90, 38);
            this.hostIP1.Name = "hostIP1";
            this.hostIP1.Size = new System.Drawing.Size(47, 20);
            this.hostIP1.TabIndex = 8;
            this.hostIP1.TextChanged += new System.EventHandler(this.hostIP1_TextChanged);
            this.hostIP1.Enter += new System.EventHandler(this.hostIP1_Enter);
            // 
            // hostIP2
            // 
            this.hostIP2.Location = new System.Drawing.Point(143, 38);
            this.hostIP2.Name = "hostIP2";
            this.hostIP2.Size = new System.Drawing.Size(47, 20);
            this.hostIP2.TabIndex = 9;
            this.hostIP2.TextChanged += new System.EventHandler(this.hostIP2_TextChanged);
            this.hostIP2.Enter += new System.EventHandler(this.hostIP2_Enter);
            // 
            // hostIP3
            // 
            this.hostIP3.Location = new System.Drawing.Point(196, 38);
            this.hostIP3.Name = "hostIP3";
            this.hostIP3.Size = new System.Drawing.Size(47, 20);
            this.hostIP3.TabIndex = 10;
            this.hostIP3.TextChanged += new System.EventHandler(this.hostIP3_TextChanged);
            this.hostIP3.Enter += new System.EventHandler(this.hostIP3_Enter);
            // 
            // hostIP4
            // 
            this.hostIP4.Location = new System.Drawing.Point(249, 38);
            this.hostIP4.Name = "hostIP4";
            this.hostIP4.Size = new System.Drawing.Size(47, 20);
            this.hostIP4.TabIndex = 11;
            this.hostIP4.TextChanged += new System.EventHandler(this.hostIP4_TextChanged);
            this.hostIP4.Enter += new System.EventHandler(this.hostIP4_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 252);
            this.Controls.Add(this.hostIP4);
            this.Controls.Add(this.hostIP3);
            this.Controls.Add(this.hostIP2);
            this.Controls.Add(this.hostIP1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hostName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "PingApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hostName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hostIP1;
        private System.Windows.Forms.TextBox hostIP2;
        private System.Windows.Forms.TextBox hostIP3;
        private System.Windows.Forms.TextBox hostIP4;
    }
}

