namespace Ping_sweep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.d42url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urluser = new System.Windows.Forms.TextBox();
            this.urlpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.get_hostname = new System.Windows.Forms.CheckBox();
            this.strip_domainname = new System.Windows.Forms.CheckBox();
            this.logbox = new System.Windows.Forms.RichTextBox();
            this.network_range = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // d42url
            // 
            this.d42url.Location = new System.Drawing.Point(123, 12);
            this.d42url.Name = "d42url";
            this.d42url.Size = new System.Drawing.Size(137, 20);
            this.d42url.TabIndex = 0;
            this.d42url.Text = "https://";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Device42 URL";
            // 
            // urluser
            // 
            this.urluser.Location = new System.Drawing.Point(34, 57);
            this.urluser.Name = "urluser";
            this.urluser.Size = new System.Drawing.Size(100, 20);
            this.urluser.TabIndex = 2;
            // 
            // urlpass
            // 
            this.urlpass.Location = new System.Drawing.Point(160, 57);
            this.urlpass.Name = "urlpass";
            this.urlpass.Size = new System.Drawing.Size(100, 20);
            this.urlpass.TabIndex = 3;
            this.urlpass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Network Range Lists(Separated by space)";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(160, 292);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 23);
            this.start.TabIndex = 8;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(34, 193);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(43, 13);
            this.status.TabIndex = 10;
            this.status.Text = "Status: ";
            // 
            // get_hostname
            // 
            this.get_hostname.AutoSize = true;
            this.get_hostname.Location = new System.Drawing.Point(34, 84);
            this.get_hostname.Name = "get_hostname";
            this.get_hostname.Size = new System.Drawing.Size(192, 17);
            this.get_hostname.TabIndex = 12;
            this.get_hostname.Text = "Get Device Name via reverse DNS";
            this.get_hostname.UseVisualStyleBackColor = true;
            this.get_hostname.CheckedChanged += new System.EventHandler(this.get_hostname_CheckedChanged);
            // 
            // strip_domainname
            // 
            this.strip_domainname.AutoSize = true;
            this.strip_domainname.Enabled = false;
            this.strip_domainname.Location = new System.Drawing.Point(34, 102);
            this.strip_domainname.Name = "strip_domainname";
            this.strip_domainname.Size = new System.Drawing.Size(204, 17);
            this.strip_domainname.TabIndex = 13;
            this.strip_domainname.Text = "Strip domain Suffix from Device Name";
            this.strip_domainname.UseVisualStyleBackColor = true;
            // 
            // logbox
            // 
            this.logbox.Location = new System.Drawing.Point(34, 209);
            this.logbox.Name = "logbox";
            this.logbox.ReadOnly = true;
            this.logbox.Size = new System.Drawing.Size(226, 74);
            this.logbox.TabIndex = 14;
            this.logbox.Text = "";
            // 
            // network_range
            // 
            this.network_range.Location = new System.Drawing.Point(34, 144);
            this.network_range.Name = "network_range";
            this.network_range.Size = new System.Drawing.Size(226, 20);
            this.network_range.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "(e.g.: 192.168.11.0/24 10.10.0.0-10.254 172.16.0.0/16)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(61, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 323);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.network_range);
            this.Controls.Add(this.logbox);
            this.Controls.Add(this.strip_domainname);
            this.Controls.Add(this.get_hostname);
            this.Controls.Add(this.status);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urlpass);
            this.Controls.Add(this.urluser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.d42url);
            this.Name = "Form1";
            this.Text = "D42 Ping Sweep v2.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox d42url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urluser;
        private System.Windows.Forms.TextBox urlpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.CheckBox get_hostname;
        private System.Windows.Forms.CheckBox strip_domainname;
        private System.Windows.Forms.RichTextBox logbox;
        private System.Windows.Forms.TextBox network_range;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

