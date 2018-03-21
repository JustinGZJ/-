namespace DAQ
{
    partial class frmOhmSetting
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboSource = new System.Windows.Forms.ComboBox();
            this.cboRate = new System.Windows.Forms.ComboBox();
            this.cboRange = new System.Windows.Forms.ComboBox();
            this.cboAutoRange = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(14, 23);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 293);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 326);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 326);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "刪除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cboSource);
            this.groupBox1.Controls.Add(this.cboRate);
            this.groupBox1.Controls.Add(this.cboRange);
            this.groupBox1.Controls.Add(this.cboAutoRange);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(195, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 310);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(380, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "保存";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(126, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "偏移";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "下限";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "上限";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "触发方式";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "测试速度";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "量程";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "自动量程";
            // 
            // cboSource
            // 
            this.cboSource.FormattingEnabled = true;
            this.cboSource.Items.AddRange(new object[] {
            "INT",
            "EXT",
            "MAN",
            "A.HOLD"});
            this.cboSource.Location = new System.Drawing.Point(334, 168);
            this.cboSource.Name = "cboSource";
            this.cboSource.Size = new System.Drawing.Size(121, 25);
            this.cboSource.TabIndex = 15;
            // 
            // cboRate
            // 
            this.cboRate.FormattingEnabled = true;
            this.cboRate.Items.AddRange(new object[] {
            "FAST",
            "MED",
            "SLOW"});
            this.cboRate.Location = new System.Drawing.Point(334, 123);
            this.cboRate.Name = "cboRate";
            this.cboRate.Size = new System.Drawing.Size(121, 25);
            this.cboRate.TabIndex = 16;
            // 
            // cboRange
            // 
            this.cboRange.FormattingEnabled = true;
            this.cboRange.Items.AddRange(new object[] {
            "3mΩ",
            "300mΩ",
            "3Ω",
            "30Ω",
            "30Ω",
            "300Ω",
            "3kΩ",
            "30kΩ",
            "300kΩ",
            "3MΩ"});
            this.cboRange.Location = new System.Drawing.Point(334, 86);
            this.cboRange.Name = "cboRange";
            this.cboRange.Size = new System.Drawing.Size(121, 25);
            this.cboRange.TabIndex = 13;
            // 
            // cboAutoRange
            // 
            this.cboAutoRange.FormattingEnabled = true;
            this.cboAutoRange.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.cboAutoRange.Location = new System.Drawing.Point(334, 42);
            this.cboAutoRange.Name = "cboAutoRange";
            this.cboAutoRange.Size = new System.Drawing.Size(121, 25);
            this.cboAutoRange.TabIndex = 14;
            // 
            // frmOhmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmOhmSetting";
            this.Text = "電阻參數設置";
            this.Load += new System.EventHandler(this.frmOhmSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboSource;
        private System.Windows.Forms.ComboBox cboRate;
        private System.Windows.Forms.ComboBox cboRange;
        private System.Windows.Forms.ComboBox cboAutoRange;
    }
}