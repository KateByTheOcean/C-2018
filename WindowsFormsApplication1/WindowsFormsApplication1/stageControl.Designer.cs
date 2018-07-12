namespace WindowsFormsApplication1
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
            this.connectStage1 = new System.Windows.Forms.Button();
            this.DisplayWindow = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1Refresh = new System.Windows.Forms.Button();
            this.stage1Status = new System.Windows.Forms.TextBox();
            this.Axis1 = new System.Windows.Forms.TextBox();
            this.axis1Left = new System.Windows.Forms.Button();
            this.axis1Right = new System.Windows.Forms.Button();
            this.axis2Left = new System.Windows.Forms.Button();
            this.axis2Right = new System.Windows.Forms.Button();
            this.Axis2 = new System.Windows.Forms.TextBox();
            this.Axis3 = new System.Windows.Forms.TextBox();
            this.axis3Down = new System.Windows.Forms.Button();
            this.axis3Up = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.stage2Status = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Scale = new System.Windows.Forms.Label();
            this.scaleBar = new System.Windows.Forms.PictureBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.stage2Axis1Right = new System.Windows.Forms.Button();
            this.stage2Axis1 = new System.Windows.Forms.TextBox();
            this.stage2Axis1Left = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stage2Axis2 = new System.Windows.Forms.TextBox();
            this.stage2Axis2Left = new System.Windows.Forms.Button();
            this.stage2Axis2Right = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.stage2Axis3 = new System.Windows.Forms.TextBox();
            this.stage2Axis3Up = new System.Windows.Forms.Button();
            this.stage2Axis3Down = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.serialPort2Refresh = new System.Windows.Forms.Button();
            this.connectStage2 = new System.Windows.Forms.Button();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.cmbEdgeDetection = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.camStart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pixelCounts = new System.Windows.Forms.ListBox();
            this.pixelCounts2 = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.setScale = new System.Windows.Forms.Button();
            this.zoomSettings = new System.Windows.Forms.ComboBox();
            this.showScale1 = new System.Windows.Forms.CheckBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.lineDistance = new System.Windows.Forms.Label();
            this.dragDistance = new System.Windows.Forms.TextBox();
            this.dragDistanceEnable = new System.Windows.Forms.CheckBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.saveImage = new System.Windows.Forms.Button();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectStage1
            // 
            this.connectStage1.Location = new System.Drawing.Point(218, 16);
            this.connectStage1.Name = "connectStage1";
            this.connectStage1.Size = new System.Drawing.Size(131, 39);
            this.connectStage1.TabIndex = 0;
            this.connectStage1.Text = "CONNECT STAGE";
            this.connectStage1.UseVisualStyleBackColor = true;
            this.connectStage1.Click += new System.EventHandler(this.connectStage1_Click);
            // 
            // DisplayWindow
            // 
            this.DisplayWindow.Location = new System.Drawing.Point(8, 57);
            this.DisplayWindow.Name = "DisplayWindow";
            this.DisplayWindow.Size = new System.Drawing.Size(682, 512);
            this.DisplayWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DisplayWindow.TabIndex = 34;
            this.DisplayWindow.TabStop = false;
            this.DisplayWindow.Click += new System.EventHandler(this.DisplayWindow_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            this.serialPort1.RtsEnable = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // serialPort1Refresh
            // 
            this.serialPort1Refresh.Location = new System.Drawing.Point(6, 16);
            this.serialPort1Refresh.Name = "serialPort1Refresh";
            this.serialPort1Refresh.Size = new System.Drawing.Size(89, 39);
            this.serialPort1Refresh.TabIndex = 38;
            this.serialPort1Refresh.Text = "REFRESH";
            this.serialPort1Refresh.UseVisualStyleBackColor = true;
            this.serialPort1Refresh.Click += new System.EventHandler(this.button2_Click);
            // 
            // stage1Status
            // 
            this.stage1Status.Location = new System.Drawing.Point(220, 17);
            this.stage1Status.Name = "stage1Status";
            this.stage1Status.Size = new System.Drawing.Size(131, 20);
            this.stage1Status.TabIndex = 39;
            // 
            // Axis1
            // 
            this.Axis1.Location = new System.Drawing.Point(106, 24);
            this.Axis1.Name = "Axis1";
            this.Axis1.Size = new System.Drawing.Size(65, 20);
            this.Axis1.TabIndex = 41;
            // 
            // axis1Left
            // 
            this.axis1Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("axis1Left.BackgroundImage")));
            this.axis1Left.Image = ((System.Drawing.Image)(resources.GetObject("axis1Left.Image")));
            this.axis1Left.Location = new System.Drawing.Point(218, 16);
            this.axis1Left.Name = "axis1Left";
            this.axis1Left.Size = new System.Drawing.Size(59, 35);
            this.axis1Left.TabIndex = 42;
            this.axis1Left.Text = "LEFT";
            this.axis1Left.UseMnemonic = false;
            this.axis1Left.UseVisualStyleBackColor = false;
            this.axis1Left.Click += new System.EventHandler(this.axis1Left_Click);
            // 
            // axis1Right
            // 
            this.axis1Right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("axis1Right.BackgroundImage")));
            this.axis1Right.Image = ((System.Drawing.Image)(resources.GetObject("axis1Right.Image")));
            this.axis1Right.Location = new System.Drawing.Point(290, 16);
            this.axis1Right.Name = "axis1Right";
            this.axis1Right.Size = new System.Drawing.Size(59, 35);
            this.axis1Right.TabIndex = 43;
            this.axis1Right.Text = "RIGHT";
            this.axis1Right.UseMnemonic = false;
            this.axis1Right.UseVisualStyleBackColor = false;
            this.axis1Right.Click += new System.EventHandler(this.axis1Right_Click);
            // 
            // axis2Left
            // 
            this.axis2Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("axis2Left.BackgroundImage")));
            this.axis2Left.Image = ((System.Drawing.Image)(resources.GetObject("axis2Left.Image")));
            this.axis2Left.Location = new System.Drawing.Point(217, 15);
            this.axis2Left.Name = "axis2Left";
            this.axis2Left.Size = new System.Drawing.Size(59, 35);
            this.axis2Left.TabIndex = 44;
            this.axis2Left.Text = "LEFT";
            this.axis2Left.UseMnemonic = false;
            this.axis2Left.UseVisualStyleBackColor = false;
            this.axis2Left.Click += new System.EventHandler(this.axis2Left_Click);
            // 
            // axis2Right
            // 
            this.axis2Right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("axis2Right.BackgroundImage")));
            this.axis2Right.Image = ((System.Drawing.Image)(resources.GetObject("axis2Right.Image")));
            this.axis2Right.Location = new System.Drawing.Point(290, 15);
            this.axis2Right.Name = "axis2Right";
            this.axis2Right.Size = new System.Drawing.Size(57, 35);
            this.axis2Right.TabIndex = 45;
            this.axis2Right.Text = "RIGHT";
            this.axis2Right.UseMnemonic = false;
            this.axis2Right.UseVisualStyleBackColor = false;
            this.axis2Right.Click += new System.EventHandler(this.axis2Right_Click);
            // 
            // Axis2
            // 
            this.Axis2.Location = new System.Drawing.Point(106, 23);
            this.Axis2.Name = "Axis2";
            this.Axis2.Size = new System.Drawing.Size(65, 20);
            this.Axis2.TabIndex = 46;
            // 
            // Axis3
            // 
            this.Axis3.Location = new System.Drawing.Point(106, 23);
            this.Axis3.Name = "Axis3";
            this.Axis3.Size = new System.Drawing.Size(65, 20);
            this.Axis3.TabIndex = 49;
            // 
            // axis3Down
            // 
            this.axis3Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("axis3Down.BackgroundImage")));
            this.axis3Down.Image = ((System.Drawing.Image)(resources.GetObject("axis3Down.Image")));
            this.axis3Down.Location = new System.Drawing.Point(218, 15);
            this.axis3Down.Name = "axis3Down";
            this.axis3Down.Size = new System.Drawing.Size(59, 35);
            this.axis3Down.TabIndex = 48;
            this.axis3Down.Text = "DOWN";
            this.axis3Down.UseMnemonic = false;
            this.axis3Down.UseVisualStyleBackColor = false;
            this.axis3Down.Click += new System.EventHandler(this.axis3Down_Click);
            // 
            // axis3Up
            // 
            this.axis3Up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("axis3Up.BackgroundImage")));
            this.axis3Up.Image = ((System.Drawing.Image)(resources.GetObject("axis3Up.Image")));
            this.axis3Up.Location = new System.Drawing.Point(290, 14);
            this.axis3Up.Name = "axis3Up";
            this.axis3Up.Size = new System.Drawing.Size(59, 34);
            this.axis3Up.TabIndex = 47;
            this.axis3Up.Text = "UP";
            this.axis3Up.UseMnemonic = false;
            this.axis3Up.UseVisualStyleBackColor = false;
            this.axis3Up.Click += new System.EventHandler(this.axis3Up_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.serialPort1Refresh);
            this.groupBox3.Controls.Add(this.connectStage1);
            this.groupBox3.Location = new System.Drawing.Point(695, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 66);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.axis1Right);
            this.groupBox6.Controls.Add(this.Axis1);
            this.groupBox6.Controls.Add(this.axis1Left);
            this.groupBox6.Location = new System.Drawing.Point(695, 120);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(358, 61);
            this.groupBox6.TabIndex = 71;
            this.groupBox6.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(173, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 25);
            this.label10.TabIndex = 68;
            this.label10.Text = "μm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 67;
            this.label1.Text = "X AXIS:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox5.Controls.Add(this.stage2Status);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox5.Location = new System.Drawing.Point(695, 307);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(358, 50);
            this.groupBox5.TabIndex = 70;
            this.groupBox5.TabStop = false;
            // 
            // stage2Status
            // 
            this.stage2Status.Location = new System.Drawing.Point(218, 18);
            this.stage2Status.Name = "stage2Status";
            this.stage2Status.Size = new System.Drawing.Size(131, 20);
            this.stage2Status.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 67;
            this.label3.Text = "CONTROLLER 2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.Axis3);
            this.groupBox4.Controls.Add(this.axis3Up);
            this.groupBox4.Controls.Add(this.axis3Down);
            this.groupBox4.Location = new System.Drawing.Point(695, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(358, 61);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(173, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 25);
            this.label12.TabIndex = 70;
            this.label12.Text = "μm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 69;
            this.label4.Text = "Z AXIS:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.Axis2);
            this.groupBox7.Controls.Add(this.axis2Left);
            this.groupBox7.Controls.Add(this.axis2Right);
            this.groupBox7.Location = new System.Drawing.Point(695, 180);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(358, 61);
            this.groupBox7.TabIndex = 72;
            this.groupBox7.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(173, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 25);
            this.label11.TabIndex = 69;
            this.label11.Text = "μm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "Y AXIS:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Scale);
            this.groupBox1.Controls.Add(this.scaleBar);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.DisplayWindow);
            this.groupBox1.Location = new System.Drawing.Point(-1, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 587);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // Scale
            // 
            this.Scale.AutoSize = true;
            this.Scale.BackColor = System.Drawing.Color.Transparent;
            this.Scale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scale.ForeColor = System.Drawing.Color.Black;
            this.Scale.Location = new System.Drawing.Point(592, 494);
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(0, 20);
            this.Scale.TabIndex = 73;
            this.Scale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scaleBar
            // 
            this.scaleBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scaleBar.InitialImage = ((System.Drawing.Image)(resources.GetObject("scaleBar.InitialImage")));
            this.scaleBar.Location = new System.Drawing.Point(565, 520);
            this.scaleBar.Name = "scaleBar";
            this.scaleBar.Size = new System.Drawing.Size(100, 29);
            this.scaleBar.TabIndex = 71;
            this.scaleBar.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox8.Location = new System.Drawing.Point(6, 7);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(682, 50);
            this.groupBox8.TabIndex = 70;
            this.groupBox8.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(188, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 25);
            this.label5.TabIndex = 67;
            this.label5.Text = "CAMERA STREAM";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Controls.Add(this.stage1Status);
            this.groupBox9.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox9.Location = new System.Drawing.Point(693, 5);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(358, 50);
            this.groupBox9.TabIndex = 74;
            this.groupBox9.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 25);
            this.label6.TabIndex = 67;
            this.label6.Text = "CONTROLLER 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.stage2Axis1Right);
            this.groupBox2.Controls.Add(this.stage2Axis1);
            this.groupBox2.Controls.Add(this.stage2Axis1Left);
            this.groupBox2.Location = new System.Drawing.Point(695, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 61);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(173, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 25);
            this.label13.TabIndex = 69;
            this.label13.Text = "μm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 67;
            this.label7.Text = "X AXIS:";
            // 
            // stage2Axis1Right
            // 
            this.stage2Axis1Right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stage2Axis1Right.BackgroundImage")));
            this.stage2Axis1Right.Image = ((System.Drawing.Image)(resources.GetObject("stage2Axis1Right.Image")));
            this.stage2Axis1Right.Location = new System.Drawing.Point(290, 16);
            this.stage2Axis1Right.Name = "stage2Axis1Right";
            this.stage2Axis1Right.Size = new System.Drawing.Size(59, 35);
            this.stage2Axis1Right.TabIndex = 43;
            this.stage2Axis1Right.Text = "RIGHT";
            this.stage2Axis1Right.UseMnemonic = false;
            this.stage2Axis1Right.UseVisualStyleBackColor = false;
            this.stage2Axis1Right.Click += new System.EventHandler(this.stage2Axis1Right_Click);
            // 
            // stage2Axis1
            // 
            this.stage2Axis1.Location = new System.Drawing.Point(106, 24);
            this.stage2Axis1.Name = "stage2Axis1";
            this.stage2Axis1.Size = new System.Drawing.Size(65, 20);
            this.stage2Axis1.TabIndex = 41;
            // 
            // stage2Axis1Left
            // 
            this.stage2Axis1Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stage2Axis1Left.BackgroundImage")));
            this.stage2Axis1Left.Image = ((System.Drawing.Image)(resources.GetObject("stage2Axis1Left.Image")));
            this.stage2Axis1Left.Location = new System.Drawing.Point(218, 16);
            this.stage2Axis1Left.Name = "stage2Axis1Left";
            this.stage2Axis1Left.Size = new System.Drawing.Size(59, 35);
            this.stage2Axis1Left.TabIndex = 42;
            this.stage2Axis1Left.Text = "LEFT";
            this.stage2Axis1Left.UseMnemonic = false;
            this.stage2Axis1Left.UseVisualStyleBackColor = false;
            this.stage2Axis1Left.Click += new System.EventHandler(this.stage2Axis1Left_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label14);
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Controls.Add(this.stage2Axis2);
            this.groupBox10.Controls.Add(this.stage2Axis2Left);
            this.groupBox10.Controls.Add(this.stage2Axis2Right);
            this.groupBox10.Location = new System.Drawing.Point(695, 482);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(358, 61);
            this.groupBox10.TabIndex = 76;
            this.groupBox10.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(173, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 25);
            this.label14.TabIndex = 70;
            this.label14.Text = "μm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 68;
            this.label8.Text = "Y AXIS:";
            // 
            // stage2Axis2
            // 
            this.stage2Axis2.Location = new System.Drawing.Point(106, 23);
            this.stage2Axis2.Name = "stage2Axis2";
            this.stage2Axis2.Size = new System.Drawing.Size(65, 20);
            this.stage2Axis2.TabIndex = 46;
            // 
            // stage2Axis2Left
            // 
            this.stage2Axis2Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stage2Axis2Left.BackgroundImage")));
            this.stage2Axis2Left.Image = ((System.Drawing.Image)(resources.GetObject("stage2Axis2Left.Image")));
            this.stage2Axis2Left.Location = new System.Drawing.Point(217, 15);
            this.stage2Axis2Left.Name = "stage2Axis2Left";
            this.stage2Axis2Left.Size = new System.Drawing.Size(59, 35);
            this.stage2Axis2Left.TabIndex = 44;
            this.stage2Axis2Left.Text = "LEFT";
            this.stage2Axis2Left.UseMnemonic = false;
            this.stage2Axis2Left.UseVisualStyleBackColor = false;
            this.stage2Axis2Left.Click += new System.EventHandler(this.stage2Axis2Left_Click);
            // 
            // stage2Axis2Right
            // 
            this.stage2Axis2Right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stage2Axis2Right.BackgroundImage")));
            this.stage2Axis2Right.Image = ((System.Drawing.Image)(resources.GetObject("stage2Axis2Right.Image")));
            this.stage2Axis2Right.Location = new System.Drawing.Point(290, 15);
            this.stage2Axis2Right.Name = "stage2Axis2Right";
            this.stage2Axis2Right.Size = new System.Drawing.Size(57, 35);
            this.stage2Axis2Right.TabIndex = 45;
            this.stage2Axis2Right.Text = "RIGHT";
            this.stage2Axis2Right.UseMnemonic = false;
            this.stage2Axis2Right.UseVisualStyleBackColor = false;
            this.stage2Axis2Right.Click += new System.EventHandler(this.stage2Axis2Right_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label15);
            this.groupBox11.Controls.Add(this.label9);
            this.groupBox11.Controls.Add(this.stage2Axis3);
            this.groupBox11.Controls.Add(this.stage2Axis3Up);
            this.groupBox11.Controls.Add(this.stage2Axis3Down);
            this.groupBox11.Location = new System.Drawing.Point(695, 542);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(358, 61);
            this.groupBox11.TabIndex = 77;
            this.groupBox11.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(173, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 25);
            this.label15.TabIndex = 71;
            this.label15.Text = "μm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(10, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 69;
            this.label9.Text = "Z AXIS:";
            // 
            // stage2Axis3
            // 
            this.stage2Axis3.Location = new System.Drawing.Point(106, 23);
            this.stage2Axis3.Name = "stage2Axis3";
            this.stage2Axis3.Size = new System.Drawing.Size(65, 20);
            this.stage2Axis3.TabIndex = 49;
            // 
            // stage2Axis3Up
            // 
            this.stage2Axis3Up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stage2Axis3Up.BackgroundImage")));
            this.stage2Axis3Up.Image = ((System.Drawing.Image)(resources.GetObject("stage2Axis3Up.Image")));
            this.stage2Axis3Up.Location = new System.Drawing.Point(290, 14);
            this.stage2Axis3Up.Name = "stage2Axis3Up";
            this.stage2Axis3Up.Size = new System.Drawing.Size(59, 34);
            this.stage2Axis3Up.TabIndex = 47;
            this.stage2Axis3Up.Text = "UP";
            this.stage2Axis3Up.UseMnemonic = false;
            this.stage2Axis3Up.UseVisualStyleBackColor = false;
            this.stage2Axis3Up.Click += new System.EventHandler(this.stage2Axis3Up_Click);
            // 
            // stage2Axis3Down
            // 
            this.stage2Axis3Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stage2Axis3Down.BackgroundImage")));
            this.stage2Axis3Down.Image = ((System.Drawing.Image)(resources.GetObject("stage2Axis3Down.Image")));
            this.stage2Axis3Down.Location = new System.Drawing.Point(218, 15);
            this.stage2Axis3Down.Name = "stage2Axis3Down";
            this.stage2Axis3Down.Size = new System.Drawing.Size(59, 35);
            this.stage2Axis3Down.TabIndex = 48;
            this.stage2Axis3Down.Text = "DOWN";
            this.stage2Axis3Down.UseMnemonic = false;
            this.stage2Axis3Down.UseVisualStyleBackColor = false;
            this.stage2Axis3Down.Click += new System.EventHandler(this.stage2Axis3Down_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.comboBox2);
            this.groupBox12.Controls.Add(this.serialPort2Refresh);
            this.groupBox12.Controls.Add(this.connectStage2);
            this.groupBox12.Location = new System.Drawing.Point(695, 357);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(358, 66);
            this.groupBox12.TabIndex = 78;
            this.groupBox12.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(106, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // serialPort2Refresh
            // 
            this.serialPort2Refresh.Location = new System.Drawing.Point(6, 16);
            this.serialPort2Refresh.Name = "serialPort2Refresh";
            this.serialPort2Refresh.Size = new System.Drawing.Size(89, 39);
            this.serialPort2Refresh.TabIndex = 38;
            this.serialPort2Refresh.Text = "REFRESH";
            this.serialPort2Refresh.UseVisualStyleBackColor = true;
            this.serialPort2Refresh.Click += new System.EventHandler(this.serialPort2Refresh_Click);
            // 
            // connectStage2
            // 
            this.connectStage2.Location = new System.Drawing.Point(218, 16);
            this.connectStage2.Name = "connectStage2";
            this.connectStage2.Size = new System.Drawing.Size(131, 39);
            this.connectStage2.TabIndex = 0;
            this.connectStage2.Text = "CONNECT STAGE";
            this.connectStage2.UseVisualStyleBackColor = true;
            this.connectStage2.Click += new System.EventHandler(this.connectStage2_Click);
            // 
            // serialPort2
            // 
            this.serialPort2.BaudRate = 38400;
            this.serialPort2.RtsEnable = true;
            // 
            // cmbEdgeDetection
            // 
            this.cmbEdgeDetection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdgeDetection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdgeDetection.FormattingEnabled = true;
            this.cmbEdgeDetection.Items.AddRange(new object[] {
            "None",
            "Laplacian 3x3",
            "Laplacian 3x3 Grayscale",
            "Laplacian 5x5",
            "Laplacian 5x5 Grayscale",
            "Laplacian of Gaussian",
            "Laplacian 3x3 of Gaussian 3x3",
            "Laplacian 3x3 of Gaussian 5x5 - 1",
            "Laplacian 3x3 of Gaussian 5x5 - 2",
            "Laplacian 5x5 of Gaussian 3x3",
            "Laplacian 5x5 of Gaussian 5x5 - 1",
            "Laplacian 5x5 of Gaussian 5x5 - 2",
            "Sobel 3x3",
            "Sobel 3x3 Grayscale",
            "Prewitt",
            "Prewitt Grayscale",
            "Kirsch",
            "Kirsch Grayscale"});
            this.cmbEdgeDetection.Location = new System.Drawing.Point(694, 18);
            this.cmbEdgeDetection.Name = "cmbEdgeDetection";
            this.cmbEdgeDetection.Size = new System.Drawing.Size(343, 32);
            this.cmbEdgeDetection.TabIndex = 79;
            this.cmbEdgeDetection.SelectedIndexChanged += new System.EventHandler(this.cmbEdgeDetection_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 41);
            this.button1.TabIndex = 80;
            this.button1.Text = "TRANSFORM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // camStart
            // 
            this.camStart.Location = new System.Drawing.Point(412, 12);
            this.camStart.Name = "camStart";
            this.camStart.Size = new System.Drawing.Size(116, 41);
            this.camStart.TabIndex = 81;
            this.camStart.Text = "START CAMERA";
            this.camStart.UseVisualStyleBackColor = true;
            this.camStart.Click += new System.EventHandler(this.camStart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 41);
            this.button2.TabIndex = 82;
            this.button2.Text = "CALIBRATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pixelCounts
            // 
            this.pixelCounts.FormattingEnabled = true;
            this.pixelCounts.Location = new System.Drawing.Point(25, 35);
            this.pixelCounts.Name = "pixelCounts";
            this.pixelCounts.Size = new System.Drawing.Size(110, 134);
            this.pixelCounts.TabIndex = 85;
            // 
            // pixelCounts2
            // 
            this.pixelCounts2.FormattingEnabled = true;
            this.pixelCounts2.Location = new System.Drawing.Point(25, 197);
            this.pixelCounts2.Name = "pixelCounts2";
            this.pixelCounts2.Size = new System.Drawing.Size(110, 147);
            this.pixelCounts2.TabIndex = 86;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(48, 177);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 87;
            this.label18.Text = "Pixel Count";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(48, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 13);
            this.label19.TabIndex = 88;
            this.label19.Text = "Start Pixel";
            // 
            // setScale
            // 
            this.setScale.Location = new System.Drawing.Point(14, 46);
            this.setScale.Name = "setScale";
            this.setScale.Size = new System.Drawing.Size(124, 39);
            this.setScale.TabIndex = 89;
            this.setScale.Text = "SET SCALE";
            this.setScale.UseVisualStyleBackColor = true;
            this.setScale.Click += new System.EventHandler(this.setScale_Click);
            // 
            // zoomSettings
            // 
            this.zoomSettings.FormattingEnabled = true;
            this.zoomSettings.Location = new System.Drawing.Point(14, 16);
            this.zoomSettings.Name = "zoomSettings";
            this.zoomSettings.Size = new System.Drawing.Size(124, 21);
            this.zoomSettings.TabIndex = 90;
            this.zoomSettings.SelectedIndexChanged += new System.EventHandler(this.zoomSettings_SelectedIndexChanged_1);
            // 
            // showScale1
            // 
            this.showScale1.AutoSize = true;
            this.showScale1.Location = new System.Drawing.Point(16, 95);
            this.showScale1.Name = "showScale1";
            this.showScale1.Size = new System.Drawing.Size(122, 17);
            this.showScale1.TabIndex = 92;
            this.showScale1.Text = "SHOW SCALE BAR";
            this.showScale1.UseVisualStyleBackColor = true;
            this.showScale1.CheckedChanged += new System.EventHandler(this.showScale1_CheckedChanged);
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox13.Controls.Add(this.label16);
            this.groupBox13.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox13.Location = new System.Drawing.Point(1058, 5);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(155, 50);
            this.groupBox13.TabIndex = 93;
            this.groupBox13.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(15, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 25);
            this.label16.TabIndex = 67;
            this.label16.Text = "SCALE BAR";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.lineDistance);
            this.groupBox14.Controls.Add(this.dragDistance);
            this.groupBox14.Controls.Add(this.dragDistanceEnable);
            this.groupBox14.Controls.Add(this.showScale1);
            this.groupBox14.Controls.Add(this.zoomSettings);
            this.groupBox14.Controls.Add(this.setScale);
            this.groupBox14.Location = new System.Drawing.Point(1059, 55);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(153, 211);
            this.groupBox14.TabIndex = 94;
            this.groupBox14.TabStop = false;
            // 
            // lineDistance
            // 
            this.lineDistance.AutoSize = true;
            this.lineDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineDistance.Location = new System.Drawing.Point(17, 153);
            this.lineDistance.Name = "lineDistance";
            this.lineDistance.Size = new System.Drawing.Size(121, 13);
            this.lineDistance.TabIndex = 95;
            this.lineDistance.Text = "Line Distance (um) :";
            // 
            // dragDistance
            // 
            this.dragDistance.Location = new System.Drawing.Point(16, 179);
            this.dragDistance.Name = "dragDistance";
            this.dragDistance.Size = new System.Drawing.Size(119, 20);
            this.dragDistance.TabIndex = 94;
            // 
            // dragDistanceEnable
            // 
            this.dragDistanceEnable.AutoSize = true;
            this.dragDistanceEnable.Location = new System.Drawing.Point(16, 119);
            this.dragDistanceEnable.Name = "dragDistanceEnable";
            this.dragDistanceEnable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dragDistanceEnable.Size = new System.Drawing.Size(114, 17);
            this.dragDistanceEnable.TabIndex = 93;
            this.dragDistanceEnable.Text = "DRAG DISTANCE";
            this.dragDistanceEnable.UseVisualStyleBackColor = true;
            this.dragDistanceEnable.CheckedChanged += new System.EventHandler(this.dragDistanceEnable_CheckedChanged);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.button4);
            this.groupBox15.Controls.Add(this.saveImage);
            this.groupBox15.Controls.Add(this.button2);
            this.groupBox15.Controls.Add(this.camStart);
            this.groupBox15.Controls.Add(this.button1);
            this.groupBox15.Controls.Add(this.cmbEdgeDetection);
            this.groupBox15.Location = new System.Drawing.Point(5, 606);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(1048, 61);
            this.groupBox15.TabIndex = 95;
            this.groupBox15.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(43, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 41);
            this.button4.TabIndex = 85;
            this.button4.Text = "RELEASE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // saveImage
            // 
            this.saveImage.Location = new System.Drawing.Point(167, 12);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(116, 41);
            this.saveImage.TabIndex = 83;
            this.saveImage.Text = "SAVE IMAGE";
            this.saveImage.UseVisualStyleBackColor = true;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.label19);
            this.groupBox16.Controls.Add(this.label18);
            this.groupBox16.Controls.Add(this.pixelCounts2);
            this.groupBox16.Controls.Add(this.pixelCounts);
            this.groupBox16.Location = new System.Drawing.Point(1059, 272);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(153, 395);
            this.groupBox16.TabIndex = 96;
            this.groupBox16.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 673);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectStage1;
        private System.Windows.Forms.PictureBox DisplayWindow;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button serialPort1Refresh;
        private System.Windows.Forms.TextBox stage1Status;
        private System.Windows.Forms.TextBox Axis1;
        private System.Windows.Forms.Button axis1Left;
        private System.Windows.Forms.Button axis1Right;
        private System.Windows.Forms.Button axis2Left;
        private System.Windows.Forms.Button axis2Right;
        private System.Windows.Forms.TextBox Axis2;
        private System.Windows.Forms.TextBox Axis3;
        private System.Windows.Forms.Button axis3Down;
        private System.Windows.Forms.Button axis3Up;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox stage2Status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button stage2Axis1Right;
        private System.Windows.Forms.TextBox stage2Axis1;
        private System.Windows.Forms.Button stage2Axis1Left;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox stage2Axis2;
        private System.Windows.Forms.Button stage2Axis2Left;
        private System.Windows.Forms.Button stage2Axis2Right;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox stage2Axis3;
        private System.Windows.Forms.Button stage2Axis3Up;
        private System.Windows.Forms.Button stage2Axis3Down;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button serialPort2Refresh;
        private System.Windows.Forms.Button connectStage2;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbEdgeDetection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button camStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox pixelCounts;
        private System.Windows.Forms.ListBox pixelCounts2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button setScale;
        private System.Windows.Forms.ComboBox zoomSettings;
        private System.Windows.Forms.PictureBox scaleBar;
        private System.Windows.Forms.CheckBox showScale1;
        private System.Windows.Forms.Label Scale;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label lineDistance;
        private System.Windows.Forms.TextBox dragDistance;
        private System.Windows.Forms.CheckBox dragDistanceEnable;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.Button button4;
    }
}

