namespace WPAPMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1_SSID = new System.Windows.Forms.TextBox();
            this.textBox2_password = new System.Windows.Forms.TextBox();
            this.textBox3_resultPMK = new System.Windows.Forms.TextBox();
            this.button_wpahasher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_mode12k = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1_SSID
            // 
            this.textBox1_SSID.Location = new System.Drawing.Point(164, 57);
            this.textBox1_SSID.MaxLength = 31;
            this.textBox1_SSID.Name = "textBox1_SSID";
            this.textBox1_SSID.Size = new System.Drawing.Size(429, 20);
            this.textBox1_SSID.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox1_SSID, "Wifi Name\r\n8 chars or more");
            // 
            // textBox2_password
            // 
            this.textBox2_password.Location = new System.Drawing.Point(164, 100);
            this.textBox2_password.MaxLength = 63;
            this.textBox2_password.Name = "textBox2_password";
            this.textBox2_password.Size = new System.Drawing.Size(429, 20);
            this.textBox2_password.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBox2_password, "Wifi Password");
            // 
            // textBox3_resultPMK
            // 
            this.textBox3_resultPMK.Location = new System.Drawing.Point(164, 143);
            this.textBox3_resultPMK.Name = "textBox3_resultPMK";
            this.textBox3_resultPMK.ReadOnly = true;
            this.textBox3_resultPMK.Size = new System.Drawing.Size(429, 20);
            this.textBox3_resultPMK.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox3_resultPMK, resources.GetString("textBox3_resultPMK.ToolTip"));
            // 
            // button_wpahasher
            // 
            this.button_wpahasher.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_wpahasher.Location = new System.Drawing.Point(164, 183);
            this.button_wpahasher.Name = "button_wpahasher";
            this.button_wpahasher.Size = new System.Drawing.Size(141, 23);
            this.button_wpahasher.TabIndex = 3;
            this.button_wpahasher.Text = "Generate PMK";
            this.button_wpahasher.UseVisualStyleBackColor = true;
            this.button_wpahasher.Click += new System.EventHandler(this.button1_PMK);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "SSID (WiFi Name)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pairwise Master Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "PBKDF2-SHA1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(644, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Generates plainmasterkeys (CPU) from essid and password for use with hashcat hash" +
    "-mode 2501\r\nWPA/WPA2/WPA3 PMK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(462, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hashcat and John format to use with mode 12000 - PBKDF2-HMAC-SHA1";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Hint";
            // 
            // textBox_mode12k
            // 
            this.textBox_mode12k.Location = new System.Drawing.Point(15, 262);
            this.textBox_mode12k.Multiline = true;
            this.textBox_mode12k.Name = "textBox_mode12k";
            this.textBox_mode12k.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_mode12k.Size = new System.Drawing.Size(645, 122);
            this.textBox_mode12k.TabIndex = 10;
            this.textBox_mode12k.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "by @RomelSan - https://www.github.com/RomelSan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_mode12k);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_wpahasher);
            this.Controls.Add(this.textBox3_resultPMK);
            this.Controls.Add(this.textBox2_password);
            this.Controls.Add(this.textBox1_SSID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WiFi WPA PMK Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_SSID;
        private System.Windows.Forms.TextBox textBox2_password;
        private System.Windows.Forms.TextBox textBox3_resultPMK;
        private System.Windows.Forms.Button button_wpahasher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox_mode12k;
        private System.Windows.Forms.Label label7;
    }
}

