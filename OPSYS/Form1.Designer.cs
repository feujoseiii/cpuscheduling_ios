namespace OPSYS
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.scheduling_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p0_at = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.p0_bt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.p0_p = new System.Windows.Forms.TextBox();
            this.p1_p = new System.Windows.Forms.TextBox();
            this.p1_bt = new System.Windows.Forms.TextBox();
            this.p1_at = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.p2_p = new System.Windows.Forms.TextBox();
            this.p2_bt = new System.Windows.Forms.TextBox();
            this.p2_at = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.p3_p = new System.Windows.Forms.TextBox();
            this.p3_bt = new System.Windows.Forms.TextBox();
            this.p3_at = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.processBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 355);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(842, 70);
            this.webBrowser1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 431);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(842, 166);
            this.textBox1.TabIndex = 14;
            // 
            // scheduling_type
            // 
            this.scheduling_type.FormattingEnabled = true;
            this.scheduling_type.Items.AddRange(new object[] {
            "First Come First Serve (non-preemptive)",
            "First Come First Serve (pre-emptive)",
            "Shortest Job Next (non-preemptive)",
            "Shortest Job Next (preemptive)",
            "Shortest Remaining Time",
            "Priority Scheduling (non-preemptive)",
            "Priority Scheduling (pre-emptive)",
            "Round Robin Scheduling"});
            this.scheduling_type.Location = new System.Drawing.Point(342, 37);
            this.scheduling_type.Name = "scheduling_type";
            this.scheduling_type.Size = new System.Drawing.Size(286, 21);
            this.scheduling_type.TabIndex = 0;
            this.scheduling_type.SelectedValueChanged += new System.EventHandler(this.scheduling_type_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scheduling Algorithm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "P0";
            // 
            // p0_at
            // 
            this.p0_at.Location = new System.Drawing.Point(122, 111);
            this.p0_at.Name = "p0_at";
            this.p0_at.Size = new System.Drawing.Size(193, 20);
            this.p0_at.TabIndex = 1;
            this.p0_at.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arrival Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Burst Time";
            // 
            // p0_bt
            // 
            this.p0_bt.Location = new System.Drawing.Point(360, 111);
            this.p0_bt.Name = "p0_bt";
            this.p0_bt.Size = new System.Drawing.Size(193, 20);
            this.p0_bt.TabIndex = 2;
            this.p0_bt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(676, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Priority";
            // 
            // p0_p
            // 
            this.p0_p.Location = new System.Drawing.Point(596, 111);
            this.p0_p.Name = "p0_p";
            this.p0_p.Size = new System.Drawing.Size(193, 20);
            this.p0_p.TabIndex = 3;
            this.p0_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p1_p
            // 
            this.p1_p.Location = new System.Drawing.Point(596, 150);
            this.p1_p.Name = "p1_p";
            this.p1_p.Size = new System.Drawing.Size(193, 20);
            this.p1_p.TabIndex = 6;
            this.p1_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p1_bt
            // 
            this.p1_bt.Location = new System.Drawing.Point(360, 150);
            this.p1_bt.Name = "p1_bt";
            this.p1_bt.Size = new System.Drawing.Size(193, 20);
            this.p1_bt.TabIndex = 5;
            this.p1_bt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p1_at
            // 
            this.p1_at.Location = new System.Drawing.Point(122, 150);
            this.p1_at.Name = "p1_at";
            this.p1_at.Size = new System.Drawing.Size(193, 20);
            this.p1_at.TabIndex = 4;
            this.p1_at.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "P1";
            // 
            // p2_p
            // 
            this.p2_p.Location = new System.Drawing.Point(596, 189);
            this.p2_p.Name = "p2_p";
            this.p2_p.Size = new System.Drawing.Size(193, 20);
            this.p2_p.TabIndex = 9;
            this.p2_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p2_bt
            // 
            this.p2_bt.Location = new System.Drawing.Point(360, 189);
            this.p2_bt.Name = "p2_bt";
            this.p2_bt.Size = new System.Drawing.Size(193, 20);
            this.p2_bt.TabIndex = 8;
            this.p2_bt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p2_at
            // 
            this.p2_at.Location = new System.Drawing.Point(122, 189);
            this.p2_at.Name = "p2_at";
            this.p2_at.Size = new System.Drawing.Size(193, 20);
            this.p2_at.TabIndex = 7;
            this.p2_at.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "P2";
            // 
            // p3_p
            // 
            this.p3_p.Location = new System.Drawing.Point(596, 226);
            this.p3_p.Name = "p3_p";
            this.p3_p.Size = new System.Drawing.Size(193, 20);
            this.p3_p.TabIndex = 12;
            this.p3_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p3_bt
            // 
            this.p3_bt.Location = new System.Drawing.Point(360, 226);
            this.p3_bt.Name = "p3_bt";
            this.p3_bt.Size = new System.Drawing.Size(193, 20);
            this.p3_bt.TabIndex = 11;
            this.p3_bt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p3_at
            // 
            this.p3_at.Location = new System.Drawing.Point(122, 226);
            this.p3_at.Name = "p3_at";
            this.p3_at.Size = new System.Drawing.Size(193, 20);
            this.p3_at.TabIndex = 10;
            this.p3_at.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "P3";
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(272, 273);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(345, 46);
            this.processBtn.TabIndex = 13;
            this.processBtn.Text = "Process";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 609);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.p3_p);
            this.Controls.Add(this.p3_bt);
            this.Controls.Add(this.p3_at);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.p2_p);
            this.Controls.Add(this.p2_bt);
            this.Controls.Add(this.p2_at);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.p1_p);
            this.Controls.Add(this.p1_bt);
            this.Controls.Add(this.p1_at);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.p0_p);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p0_bt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.p0_at);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scheduling_type);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox scheduling_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox p0_at;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox p0_bt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox p0_p;
        private System.Windows.Forms.TextBox p1_p;
        private System.Windows.Forms.TextBox p1_bt;
        private System.Windows.Forms.TextBox p1_at;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox p2_p;
        private System.Windows.Forms.TextBox p2_bt;
        private System.Windows.Forms.TextBox p2_at;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox p3_p;
        private System.Windows.Forms.TextBox p3_bt;
        private System.Windows.Forms.TextBox p3_at;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button processBtn;
    }
}

