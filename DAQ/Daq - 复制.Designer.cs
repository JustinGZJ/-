namespace DAQ
{
    partial class Daq
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daq));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbxSecondNum = new System.Windows.Forms.TextBox();
            this.tbxFirstNum = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.lblFirstNum = new System.Windows.Forms.Label();
            this.A = new DAQ.labeledediter();
            this.B = new DAQ.labeledediter();
            this.D = new DAQ.labeledediter();
            this.C = new DAQ.labeledediter();
            this.E = new DAQ.labeledediter();
            this.F = new DAQ.labeledediter();
            this.G = new DAQ.labeledediter();
            this.H = new DAQ.labeledediter();
            this.N = new DAQ.labeledediter();
            this.M = new DAQ.labeledediter();
            this.L = new DAQ.labeledediter();
            this.K = new DAQ.labeledediter();
            this.J = new DAQ.labeledediter();
            this.I = new DAQ.labeledediter();
            this.O = new DAQ.labeledediter();
            this.P = new DAQ.labeledediter();
            this.Q = new DAQ.labeledediter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.R = new DAQ.labeledediter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.串口设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.路径设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统补偿ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbxSecondNum);
            this.groupBox7.Controls.Add(this.tbxFirstNum);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.lblFirstNum);
            this.groupBox7.Location = new System.Drawing.Point(3, 43);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(917, 105);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "电阻测试";
            // 
            // tbxSecondNum
            // 
            this.tbxSecondNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxSecondNum.Location = new System.Drawing.Point(419, 25);
            this.tbxSecondNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSecondNum.Name = "tbxSecondNum";
            this.tbxSecondNum.ReadOnly = true;
            this.tbxSecondNum.Size = new System.Drawing.Size(243, 45);
            this.tbxSecondNum.TabIndex = 2;
            this.tbxSecondNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxFirstNum
            // 
            this.tbxFirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxFirstNum.Location = new System.Drawing.Point(83, 25);
            this.tbxFirstNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxFirstNum.Name = "tbxFirstNum";
            this.tbxFirstNum.ReadOnly = true;
            this.tbxFirstNum.Size = new System.Drawing.Size(243, 45);
            this.tbxFirstNum.TabIndex = 2;
            this.tbxFirstNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(342, 34);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 1;
            this.label24.Text = "温度示数：";
            // 
            // lblFirstNum
            // 
            this.lblFirstNum.AutoSize = true;
            this.lblFirstNum.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFirstNum.Location = new System.Drawing.Point(8, 34);
            this.lblFirstNum.Name = "lblFirstNum";
            this.lblFirstNum.Size = new System.Drawing.Size(65, 12);
            this.lblFirstNum.TabIndex = 0;
            this.lblFirstNum.Text = "电阻示数：";
            // 
            // A
            // 
            this.A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.A.Key = "装置 No：";
            this.A.Location = new System.Drawing.Point(3, 4);
            this.A.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(352, 81);
            this.A.TabIndex = 0;
            this.A.Value = "";
            // 
            // B
            // 
            this.B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B.Key = "条件编号：";
            this.B.Location = new System.Drawing.Point(361, 4);
            this.B.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(352, 81);
            this.B.TabIndex = 1;
            this.B.Value = "";
            // 
            // D
            // 
            this.D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.D.Key = "WE1 的监测电流 （PEAK）(kA)：";
            this.D.Location = new System.Drawing.Point(361, 93);
            this.D.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(352, 82);
            this.D.TabIndex = 1;
            this.D.Value = "";
            // 
            // C
            // 
            this.C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C.Key = "WE1 的监测电流（RMS）(kA)：";
            this.C.Location = new System.Drawing.Point(3, 93);
            this.C.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(352, 82);
            this.C.TabIndex = 0;
            this.C.Value = "";
            // 
            // E
            // 
            this.E.Dock = System.Windows.Forms.DockStyle.Fill;
            this.E.Key = "WE1 的监测电压（RMS）（V）：";
            this.E.Location = new System.Drawing.Point(719, 93);
            this.E.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(353, 82);
            this.E.TabIndex = 1;
            this.E.Value = "";
            // 
            // F
            // 
            this.F.Dock = System.Windows.Forms.DockStyle.Fill;
            this.F.Key = "WE1 的监测电压 （PEAK）(V)：";
            this.F.Location = new System.Drawing.Point(3, 183);
            this.F.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(352, 82);
            this.F.TabIndex = 0;
            this.F.Value = "";
            // 
            // G
            // 
            this.G.Dock = System.Windows.Forms.DockStyle.Fill;
            this.G.Key = "WE1 的监测功率(Power)(kW)：";
            this.G.Location = new System.Drawing.Point(361, 183);
            this.G.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(352, 82);
            this.G.TabIndex = 0;
            this.G.Value = "";
            // 
            // H
            // 
            this.H.Dock = System.Windows.Forms.DockStyle.Fill;
            this.H.Key = "WE1的监测电阻（mohm）：";
            this.H.Location = new System.Drawing.Point(719, 183);
            this.H.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(353, 82);
            this.H.TabIndex = 1;
            this.H.Value = "";
            // 
            // N
            // 
            this.N.Dock = System.Windows.Forms.DockStyle.Fill;
            this.N.Key = "WE2的监测电阻（mohm）：";
            this.N.Location = new System.Drawing.Point(719, 363);
            this.N.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(353, 82);
            this.N.TabIndex = 1;
            this.N.Value = "";
            // 
            // M
            // 
            this.M.Dock = System.Windows.Forms.DockStyle.Fill;
            this.M.Key = "WE2 的监测功率(Power)(kW)：";
            this.M.Location = new System.Drawing.Point(361, 363);
            this.M.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(352, 82);
            this.M.TabIndex = 0;
            this.M.Value = "";
            // 
            // L
            // 
            this.L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L.Key = "WE2 的监测电压 （PEAK）(V)：";
            this.L.Location = new System.Drawing.Point(719, 273);
            this.L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(353, 82);
            this.L.TabIndex = 0;
            this.L.Value = "";
            // 
            // K
            // 
            this.K.Dock = System.Windows.Forms.DockStyle.Fill;
            this.K.Key = "WE2 的监测电压（RMS）（V）：";
            this.K.Location = new System.Drawing.Point(3, 363);
            this.K.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(352, 82);
            this.K.TabIndex = 1;
            this.K.Value = "";
            // 
            // J
            // 
            this.J.Dock = System.Windows.Forms.DockStyle.Fill;
            this.J.Key = "WE2 的监测电流 （PEAK）(kA)：";
            this.J.Location = new System.Drawing.Point(361, 273);
            this.J.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.J.Name = "J";
            this.J.Size = new System.Drawing.Size(352, 82);
            this.J.TabIndex = 1;
            this.J.Value = "";
            // 
            // I
            // 
            this.I.Dock = System.Windows.Forms.DockStyle.Fill;
            this.I.Key = "WE2 的监测电流（RMS）(kA)：";
            this.I.Location = new System.Drawing.Point(3, 273);
            this.I.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(352, 82);
            this.I.TabIndex = 0;
            this.I.Value = "";
            // 
            // O
            // 
            this.O.Dock = System.Windows.Forms.DockStyle.Fill;
            this.O.Key = "最终位移量（mm）：";
            this.O.Location = new System.Drawing.Point(3, 453);
            this.O.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(352, 83);
            this.O.TabIndex = 0;
            this.O.Value = "";
            // 
            // P
            // 
            this.P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P.Key = "WE1 通电时间（ms）：";
            this.P.Location = new System.Drawing.Point(361, 453);
            this.P.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(352, 83);
            this.P.TabIndex = 0;
            this.P.Value = "";
            // 
            // Q
            // 
            this.Q.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Q.Key = "WE2 的通电时间（ms）：";
            this.Q.Location = new System.Drawing.Point(719, 453);
            this.Q.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(353, 83);
            this.Q.TabIndex = 0;
            this.Q.Value = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.A, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.C, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.E, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.F, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.G, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.H, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.I, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.J, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.L, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.K, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.M, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.N, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.O, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.P, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.D, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.B, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.R, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Q, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1075, 540);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // R
            // 
            this.R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.R.Key = "工件检出时的位移量（mm）：";
            this.R.Location = new System.Drawing.Point(719, 6);
            this.R.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(353, 77);
            this.R.TabIndex = 0;
            this.R.Value = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 159);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1081, 564);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "点焊机";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.帮助ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(952, 39);
            this.menuStrip2.TabIndex = 12;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.串口设置ToolStripMenuItem,
            this.其他设置ToolStripMenuItem,
            this.路径设置ToolStripMenuItem,
            this.系统补偿ToolStripMenuItem});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(84, 33);
            this.toolStripMenuItem1.Text = "参数设置";
            // 
            // 串口设置ToolStripMenuItem
            // 
            this.串口设置ToolStripMenuItem.Name = "串口设置ToolStripMenuItem";
            this.串口设置ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.串口设置ToolStripMenuItem.Text = "串口设置...";
            this.串口设置ToolStripMenuItem.Click += new System.EventHandler(this.串口设置ToolStripMenuItem_Click);
            // 
            // 其他设置ToolStripMenuItem
            // 
            this.其他设置ToolStripMenuItem.Name = "其他设置ToolStripMenuItem";
            this.其他设置ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.其他设置ToolStripMenuItem.Text = "名称设置...";
            this.其他设置ToolStripMenuItem.Click += new System.EventHandler(this.其他设置ToolStripMenuItem_Click);
            // 
            // 路径设置ToolStripMenuItem
            // 
            this.路径设置ToolStripMenuItem.Name = "路径设置ToolStripMenuItem";
            this.路径设置ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.路径设置ToolStripMenuItem.Text = "路径设置...";
            this.路径设置ToolStripMenuItem.Click += new System.EventHandler(this.路径设置ToolStripMenuItem_Click);
            // 
            // 系统补偿ToolStripMenuItem
            // 
            this.系统补偿ToolStripMenuItem.Name = "系统补偿ToolStripMenuItem";
            this.系统补偿ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.系统补偿ToolStripMenuItem.Text = "电阻参数设置...";
            this.系统补偿ToolStripMenuItem.Click += new System.EventHandler(this.系统补偿ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 33);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1087, 727);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel3.Controls.Add(this.menuStrip2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1087, 39);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::DAQ.Properties.Resources.LogowithName;
            this.pictureBox1.Location = new System.Drawing.Point(952, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "gray.png");
            this.imageList1.Images.SetKeyName(1, "red.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1087, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel2.Image")));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel2.Text = "电阻测试仪";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel3.Image")));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel3.Text = "点焊机";
            // 
            // Daq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 749);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.statusStrip1);
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Daq";
            this.Text = "数据采集程序";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tbxSecondNum;
        private System.Windows.Forms.TextBox tbxFirstNum;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblFirstNum;
        private labeledediter A;
        private labeledediter B;
        private labeledediter C;
        private labeledediter D;
        private labeledediter E;
        private labeledediter F;
        private labeledediter G;
        private labeledediter H;
        private labeledediter I;
        private labeledediter J;
        private labeledediter K;
        private labeledediter L;
        private labeledediter M;
        private labeledediter N;
        private labeledediter O;
        private labeledediter P;
        private labeledediter Q;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 串口设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private labeledediter R;
        private System.Windows.Forms.ToolStripMenuItem 路径设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统补偿ToolStripMenuItem;
    }
}

