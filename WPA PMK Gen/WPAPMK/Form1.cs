using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
using System.Diagnostics;

namespace WPAPMK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private byte[] _ssidBytes;
        #region PMK Generator
        // Gets PMK From SSID and Password
        private string wpa2hash(string ssid, string password) // Main PMKID Function
        {
            var keyCalculator = Encoding.ASCII.GetBytes(ssid);
            _ssidBytes = keyCalculator;
            var key = GetWpaMasterKey(password);
            // Returns hex
            // You can check results using online calculator: http://jorisvr.nl/wpapsk.html
            return BitConverter.ToString(key).Replace("-", "");
        }
        private byte[] GetWpaMasterKey(string password)
        {
            Rfc2898DeriveBytes pbkdf2;
            // Rfc2898DeriveBytes class has restriction of salt size to >= 8
            // but not in rfc2898 (see http://www.ietf.org/rfc/rfc2898.txt)
            // Reflection used to setup private field to avoid the restriction

            // PMK = PBKDF2(HMAC−SHA1, PSK, SSID, 4096, 256) 
            // Online Explanation: https://asecuritysite.com/encryption/ssid_hm?val1=home&val2=qwerty
            if (_ssidBytes.Length >= 8)
                pbkdf2 = new Rfc2898DeriveBytes(password, _ssidBytes, 4096);
            else
            {
                // Use dummy salt here, we replace it later via reflection
                pbkdf2 = new Rfc2898DeriveBytes(password, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 4096);

                var saltField = typeof(Rfc2898DeriveBytes).GetField("m_salt", BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance);
                saltField.SetValue(pbkdf2, _ssidBytes);
            }

            // Get 256 bit PMK key
            return pbkdf2.GetBytes(32);
        }
        // Usage: string hash_result = wpa2hash(ssid, password); 
        #endregion
        private string mode12k(string PMK, string SSID)
        {
            Process process = new Process();
            process.StartInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            process.StartInfo.FileName = "wlanpmk2hcx.exe";
            process.StartInfo.Arguments = "-e \"" + SSID + "\"" + " -p " + PMK;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            string result = process.StandardOutput.ReadToEnd(); // Read the output stream first and then wait.
            process.WaitForExit();
            return result;
        }
        private void button1_PMK(object sender, EventArgs e)
        {
            string ssid = textBox1_SSID.Text;
            string password = textBox2_password.Text;
            string hash_result = wpa2hash(ssid, password); //calls the PMK Generator Function
            textBox3_resultPMK.Text = hash_result;
            try
            {
                string toHashcat = mode12k(textBox3_resultPMK.Text, ssid);
                string crlf = toHashcat.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", "\r\n"); // This will work if the input contains only one type of line breaks - either CR, or LF, or CR+LF
                textBox_mode12k.Text = crlf;
            }
            catch(Exception ex)
            {
                textBox_mode12k.Text = ex.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
