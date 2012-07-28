using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using System.Xml;

namespace Ping_sweep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TraceListener debugListener = new MyTraceListener(logbox);
            Debug.Listeners.Add(debugListener);
            Control.CheckForIllegalCrossThreadCalls = false;
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            do_the_call();
        }


        private void get_hostname_CheckedChanged(object sender, EventArgs e)
        {
            if (get_hostname.Checked)
            {
                strip_domainname.Enabled = true;
            }
            else {
                strip_domainname.Enabled = false;
            }

        }
        private void finish_up() {
            start.Enabled = true;

            if (status.Text != "Status: Error Occurred. See Log")
            {
                status.Text = "Status: Finished";
            }
        }


        private void do_the_call() {

            if (d42url.Text == "https://" || urluser.Text == "" || urlpass.Text == "") { MessageBox.Show("Enter info for device42 appliance"); }
            else
            {
                start.Enabled = false;
  
                string API_IP_URL;
                if (d42url.Text[d42url.Text.Length - 1] == '/')
                {
                    API_IP_URL = d42url.Text + "api/ip/";
                }
                else
                {
                    API_IP_URL = d42url.Text + "/api/ip/";
                }

                string toEncode = urluser.Text + ":" + urlpass.Text;
                byte[] toEncodeAsBytes = System.Text.Encoding.Default.GetBytes(toEncode);
                string returnValue = "Basic " + System.Convert.ToBase64String(toEncodeAsBytes);

                status.Text = "Status: Starting, Please wait....";
                
                System.Threading.Tasks.Task task_1 = new System.Threading.Tasks.Task(() =>
                {

                    try
                    {
                        if ((network_range.Text.Trim().CompareTo("")) != 0)
                        {
                            Process p = new Process();
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.RedirectStandardOutput = true;
                            p.StartInfo.FileName = "nmap.exe";
                            p.StartInfo.Arguments = " -oX - --system-dns -sn " + network_range.Text;
                            p.Start();
                            status.Text = "Status: Waiting for nmap to finish....";
                            string output = p.StandardOutput.ReadToEnd();
                            p.WaitForExit();

                            //XML parser might be better suited for following.
                            status.Text = "Status: Parse, upload results to d42, Please wait...";
                            string[] ifaces = Regex.Split(output, "</host>");
                            output = null;
                            
                            foreach (string iface in ifaces)
                            {
                                var result = "";
                                if (iface.Contains("ipv4"))
                                {
                                    string[] iface_line = Regex.Split(iface, "\n");
                                    string UPLOADdata = "";
                                    foreach (string ln in iface_line)
                                    {

                                        if (ln.Contains("addrtype=\"ipv4\""))
                                        {
                                            string ipv4_address = new StringBuilder(ln)
                                            .Replace("<address addr=\"", "")
                                            .Replace("\"", "").ToString().Split(' ')[0];
                                            UPLOADdata = "ipaddress=" + ipv4_address;
                                        }
                                        if (ln.Contains("addrtype=\"mac\""))
                                        {
                                            string mac = new StringBuilder(ln)
                                            .Replace("<address addr=\"", "")
                                            .Replace("\"","").ToString().Split(' ')[0];
                                            UPLOADdata += "&macaddress=" + mac;
                                        }
                                        if (get_hostname.Checked && ln.Contains("type=\"PTR\""))
                                        {
                                            string dev_name = new StringBuilder(ln)
                                            .Replace("<hostname name=\"", "")
                                            .Replace("\"", "").ToString().Split(' ')[0];
                                            if (strip_domainname.Checked) { dev_name = dev_name.Split('.')[0]; }
                                          if (! UPLOADdata.Contains("device")){  UPLOADdata += "&device=" + dev_name;}
                                        }

                                    }
                                    if (UPLOADdata != "")
                                    {
                                        Trace.WriteLine("Uploading: " + UPLOADdata);

                                        try
                                        {
                                            result = Post_to_d42(API_IP_URL, returnValue, UPLOADdata);
                                            Trace.WriteLine("Success:  " + result);
                                        }

                                        catch (Exception ex)
                                        {
                                            Trace.WriteLine("Error: " + ex.ToString());
                                        }
                                    }

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Trace.WriteLine("Error: " + ex.ToString());
                        status.Text = "Status: Error Occurred. See log below.";
                    }

                    
                });

                task_1.Start();
                task_1.ContinueWith(t => finish_up());
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox1 abtDialog = new AboutBox1();
            abtDialog.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.device42.com/pingsweep_twitter/");
        }
        private string Post_to_d42(string URL, string returnValue, string UPLOADdata)
        {
            using (var client = new WebClient())
            {                //Change SSL checks so that all checks pass? 
                System.Net.ServicePointManager.ServerCertificateValidationCallback += delegate { return true; };
                Uri requestUri = new Uri(URL);
                client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                client.Headers.Add("AUTHORIZATION", returnValue);
                return client.UploadString(requestUri, UPLOADdata);
            }

        }


    }

    public class MyTraceListener : TraceListener
    {
        private TextBoxBase output;

        public MyTraceListener(TextBoxBase output)
        {
            this.Name = "Trace";
            this.output = output;
        }


        public override void Write(string message)
        {

            Action append = delegate()
            {
                //output.AppendText(string.Format("[{0}] ", DateTime.Now.ToString()));
                //output.AppendText(message);
                output.Text += message;
            };
            if (output.InvokeRequired)
            {
                output.BeginInvoke(append);
            }
            else
            {
                append();
            }

        }

        public override void WriteLine(string message)
        {
            Write(message + Environment.NewLine);
        }



    }

}
