
namespace HWtest3
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RAMusage = new System.Windows.Forms.Label();
            this.Tempchange = new System.Windows.Forms.Button();
            this.cpuNumTemp = new System.Windows.Forms.Label();
            this.gpu1NumTemp = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CpuProgressBar = new CircularProgressBar.CircularProgressBar();
            this.Gpu1ProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cpuTempBar = new CircularProgressBar.CircularProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CPUnamebar = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Gpu2ProgressBar = new CircularProgressBar.CircularProgressBar();
            this.CPUusage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GPU1RealTimeUsage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.VRAMbar1 = new ProgressBarSample.TextProgressBar();
            this.RAMProgressBar1 = new ProgressBarSample.TextProgressBar();
            this.GPUSpeed = new System.Windows.Forms.Label();
            this.CPUSpeed = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // RAMusage
            // 
            this.RAMusage.AutoSize = true;
            this.RAMusage.BackColor = System.Drawing.Color.Transparent;
            this.RAMusage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAMusage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RAMusage.Location = new System.Drawing.Point(112, 362);
            this.RAMusage.Name = "RAMusage";
            this.RAMusage.Size = new System.Drawing.Size(99, 37);
            this.RAMusage.TabIndex = 30;
            this.RAMusage.Text = "___%";
            this.RAMusage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tempchange
            // 
            this.Tempchange.Location = new System.Drawing.Point(557, 653);
            this.Tempchange.Name = "Tempchange";
            this.Tempchange.Size = new System.Drawing.Size(136, 45);
            this.Tempchange.TabIndex = 42;
            this.Tempchange.Text = "Fahrenheit";
            this.Tempchange.UseVisualStyleBackColor = true;
            this.Tempchange.Click += new System.EventHandler(this.Tempchange_Click);
            // 
            // cpuNumTemp
            // 
            this.cpuNumTemp.AutoSize = true;
            this.cpuNumTemp.BackColor = System.Drawing.Color.Transparent;
            this.cpuNumTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuNumTemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cpuNumTemp.Location = new System.Drawing.Point(37, 175);
            this.cpuNumTemp.Name = "cpuNumTemp";
            this.cpuNumTemp.Size = new System.Drawing.Size(107, 37);
            this.cpuNumTemp.TabIndex = 43;
            this.cpuNumTemp.Text = "___°F";
            this.cpuNumTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpu1NumTemp
            // 
            this.gpu1NumTemp.AutoSize = true;
            this.gpu1NumTemp.BackColor = System.Drawing.Color.Transparent;
            this.gpu1NumTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu1NumTemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpu1NumTemp.Location = new System.Drawing.Point(407, 175);
            this.gpu1NumTemp.Name = "gpu1NumTemp";
            this.gpu1NumTemp.Size = new System.Drawing.Size(102, 37);
            this.gpu1NumTemp.TabIndex = 44;
            this.gpu1NumTemp.Text = "___°F";
            this.gpu1NumTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            // 
            // CpuProgressBar
            // 
            this.CpuProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CpuProgressBar.AnimationSpeed = 500;
            this.CpuProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.CpuProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpuProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CpuProgressBar.InnerColor = System.Drawing.Color.Transparent;
            this.CpuProgressBar.InnerMargin = 2;
            this.CpuProgressBar.InnerWidth = -1;
            this.CpuProgressBar.Location = new System.Drawing.Point(181, 112);
            this.CpuProgressBar.MarqueeAnimationSpeed = 2000;
            this.CpuProgressBar.Name = "CpuProgressBar";
            this.CpuProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.CpuProgressBar.OuterMargin = -10;
            this.CpuProgressBar.OuterWidth = 10;
            this.CpuProgressBar.ProgressColor = System.Drawing.Color.Blue;
            this.CpuProgressBar.ProgressWidth = 10;
            this.CpuProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpuProgressBar.Size = new System.Drawing.Size(147, 151);
            this.CpuProgressBar.StartAngle = 270;
            this.CpuProgressBar.Step = 1;
            this.CpuProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CpuProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CpuProgressBar.SubscriptText = "";
            this.CpuProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CpuProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CpuProgressBar.SuperscriptText = "";
            this.CpuProgressBar.TabIndex = 54;
            this.CpuProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.CpuProgressBar.Value = 68;
            // 
            // Gpu1ProgressBar
            // 
            this.Gpu1ProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Gpu1ProgressBar.AnimationSpeed = 500;
            this.Gpu1ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.Gpu1ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpu1ProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gpu1ProgressBar.InnerColor = System.Drawing.Color.Transparent;
            this.Gpu1ProgressBar.InnerMargin = 2;
            this.Gpu1ProgressBar.InnerWidth = -1;
            this.Gpu1ProgressBar.Location = new System.Drawing.Point(373, 112);
            this.Gpu1ProgressBar.MarqueeAnimationSpeed = 2000;
            this.Gpu1ProgressBar.Name = "Gpu1ProgressBar";
            this.Gpu1ProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.Gpu1ProgressBar.OuterMargin = -10;
            this.Gpu1ProgressBar.OuterWidth = 10;
            this.Gpu1ProgressBar.ProgressColor = System.Drawing.Color.Blue;
            this.Gpu1ProgressBar.ProgressWidth = 10;
            this.Gpu1ProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpu1ProgressBar.Size = new System.Drawing.Size(147, 151);
            this.Gpu1ProgressBar.StartAngle = 270;
            this.Gpu1ProgressBar.Step = 1;
            this.Gpu1ProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Gpu1ProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Gpu1ProgressBar.SubscriptText = "";
            this.Gpu1ProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Gpu1ProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Gpu1ProgressBar.SuperscriptText = "";
            this.Gpu1ProgressBar.TabIndex = 56;
            this.Gpu1ProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Gpu1ProgressBar.Value = 68;
            this.Gpu1ProgressBar.Click += new System.EventHandler(this.Gpu1ProgressBar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(431, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "TEMP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(608, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "LOAD";
            // 
            // cpuTempBar
            // 
            this.cpuTempBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpuTempBar.AnimationSpeed = 500;
            this.cpuTempBar.BackColor = System.Drawing.Color.Transparent;
            this.cpuTempBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTempBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpuTempBar.InnerColor = System.Drawing.Color.Transparent;
            this.cpuTempBar.InnerMargin = 2;
            this.cpuTempBar.InnerWidth = -1;
            this.cpuTempBar.Location = new System.Drawing.Point(10, 112);
            this.cpuTempBar.MarqueeAnimationSpeed = 2000;
            this.cpuTempBar.Name = "cpuTempBar";
            this.cpuTempBar.OuterColor = System.Drawing.Color.Gray;
            this.cpuTempBar.OuterMargin = -10;
            this.cpuTempBar.OuterWidth = 10;
            this.cpuTempBar.ProgressColor = System.Drawing.Color.Blue;
            this.cpuTempBar.ProgressWidth = 10;
            this.cpuTempBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTempBar.Size = new System.Drawing.Size(147, 151);
            this.cpuTempBar.StartAngle = 270;
            this.cpuTempBar.Step = 1;
            this.cpuTempBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpuTempBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpuTempBar.SubscriptText = "";
            this.cpuTempBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpuTempBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpuTempBar.SuperscriptText = "";
            this.cpuTempBar.TabIndex = 63;
            this.cpuTempBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpuTempBar.Value = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(63, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "TEMP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(237, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "LOAD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(18, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "CPU:";
            // 
            // CPUnamebar
            // 
            this.CPUnamebar.AutoSize = true;
            this.CPUnamebar.BackColor = System.Drawing.Color.Transparent;
            this.CPUnamebar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.CPUnamebar.Location = new System.Drawing.Point(54, 73);
            this.CPUnamebar.Name = "CPUnamebar";
            this.CPUnamebar.Size = new System.Drawing.Size(157, 13);
            this.CPUnamebar.TabIndex = 67;
            this.CPUnamebar.Text = "_________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.Location = new System.Drawing.Point(460, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "_________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(424, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 68;
            this.label12.Text = "GPU:";
            // 
            // Gpu2ProgressBar
            // 
            this.Gpu2ProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Gpu2ProgressBar.AnimationSpeed = 500;
            this.Gpu2ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.Gpu2ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpu2ProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gpu2ProgressBar.InnerColor = System.Drawing.Color.Transparent;
            this.Gpu2ProgressBar.InnerMargin = 2;
            this.Gpu2ProgressBar.InnerWidth = -1;
            this.Gpu2ProgressBar.Location = new System.Drawing.Point(546, 112);
            this.Gpu2ProgressBar.MarqueeAnimationSpeed = 2000;
            this.Gpu2ProgressBar.Name = "Gpu2ProgressBar";
            this.Gpu2ProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.Gpu2ProgressBar.OuterMargin = -10;
            this.Gpu2ProgressBar.OuterWidth = 10;
            this.Gpu2ProgressBar.ProgressColor = System.Drawing.Color.Blue;
            this.Gpu2ProgressBar.ProgressWidth = 10;
            this.Gpu2ProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpu2ProgressBar.Size = new System.Drawing.Size(147, 151);
            this.Gpu2ProgressBar.StartAngle = 270;
            this.Gpu2ProgressBar.Step = 1;
            this.Gpu2ProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Gpu2ProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Gpu2ProgressBar.SubscriptText = "";
            this.Gpu2ProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Gpu2ProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Gpu2ProgressBar.SuperscriptText = "";
            this.Gpu2ProgressBar.TabIndex = 74;
            this.Gpu2ProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Gpu2ProgressBar.Value = 68;
            this.Gpu2ProgressBar.Click += new System.EventHandler(this.Gpu2ProgressBar_Click);
            // 
            // CPUusage
            // 
            this.CPUusage.AutoSize = true;
            this.CPUusage.BackColor = System.Drawing.Color.Transparent;
            this.CPUusage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUusage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CPUusage.Location = new System.Drawing.Point(213, 175);
            this.CPUusage.Name = "CPUusage";
            this.CPUusage.Size = new System.Drawing.Size(99, 37);
            this.CPUusage.TabIndex = 5;
            this.CPUusage.Text = "___%";
            this.CPUusage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CPUusage.TextChanged += new System.EventHandler(this.Form1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(127, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "LOAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(407, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 82;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(368, 374);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 25);
            this.label20.TabIndex = 85;
            this.label20.Text = "VRAM";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(7, 463);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 25);
            this.label21.TabIndex = 86;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 38);
            this.panel1.TabIndex = 93;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Font = new System.Drawing.Font("Adobe Arabic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(622, 5);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(28, 26);
            this.button3.TabIndex = 2;
            this.button3.Text = "[]";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(579, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "__";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(664, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GPU1RealTimeUsage
            // 
            this.GPU1RealTimeUsage.AutoSize = true;
            this.GPU1RealTimeUsage.BackColor = System.Drawing.Color.Transparent;
            this.GPU1RealTimeUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPU1RealTimeUsage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GPU1RealTimeUsage.Location = new System.Drawing.Point(573, 175);
            this.GPU1RealTimeUsage.Name = "GPU1RealTimeUsage";
            this.GPU1RealTimeUsage.Size = new System.Drawing.Size(99, 37);
            this.GPU1RealTimeUsage.TabIndex = 94;
            this.GPU1RealTimeUsage.Text = "___%";
            this.GPU1RealTimeUsage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(499, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 96;
            this.label5.Text = "LOAD";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(484, 362);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 37);
            this.label22.TabIndex = 95;
            this.label22.Text = "___%";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 97;
            this.label6.Text = "RAM";
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.comboBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(463, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 21);
            this.comboBox1.TabIndex = 98;
            // 
            // VRAMbar1
            // 
            this.VRAMbar1.CustomText = "";
            this.VRAMbar1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.VRAMbar1.Location = new System.Drawing.Point(373, 411);
            this.VRAMbar1.Name = "VRAMbar1";
            this.VRAMbar1.ProgressColor = System.Drawing.Color.Blue;
            this.VRAMbar1.Size = new System.Drawing.Size(328, 97);
            this.VRAMbar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.VRAMbar1.TabIndex = 89;
            this.VRAMbar1.Tag = "hello";
            this.VRAMbar1.TextColor = System.Drawing.Color.White;
            this.VRAMbar1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.VRAMbar1.VisualMode = ProgressBarSample.ProgressBarDisplayMode.CustomText;
            this.VRAMbar1.Click += new System.EventHandler(this.VRAMbar1_Click);
            // 
            // RAMProgressBar1
            // 
            this.RAMProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RAMProgressBar1.CustomText = "";
            this.RAMProgressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.RAMProgressBar1.Location = new System.Drawing.Point(0, 412);
            this.RAMProgressBar1.Name = "RAMProgressBar1";
            this.RAMProgressBar1.ProgressColor = System.Drawing.Color.Blue;
            this.RAMProgressBar1.Size = new System.Drawing.Size(328, 96);
            this.RAMProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.RAMProgressBar1.TabIndex = 79;
            this.RAMProgressBar1.Tag = "hello";
            this.RAMProgressBar1.TextColor = System.Drawing.Color.White;
            this.RAMProgressBar1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAMProgressBar1.VisualMode = ProgressBarSample.ProgressBarDisplayMode.CustomText;
            // 
            // GPUSpeed
            // 
            this.GPUSpeed.AutoSize = true;
            this.GPUSpeed.BackColor = System.Drawing.Color.Transparent;
            this.GPUSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUSpeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GPUSpeed.Location = new System.Drawing.Point(474, 275);
            this.GPUSpeed.Name = "GPUSpeed";
            this.GPUSpeed.Size = new System.Drawing.Size(0, 37);
            this.GPUSpeed.TabIndex = 100;
            this.GPUSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUSpeed
            // 
            this.CPUSpeed.AutoSize = true;
            this.CPUSpeed.BackColor = System.Drawing.Color.Transparent;
            this.CPUSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CPUSpeed.Location = new System.Drawing.Point(104, 275);
            this.CPUSpeed.Name = "CPUSpeed";
            this.CPUSpeed.Size = new System.Drawing.Size(0, 37);
            this.CPUSpeed.TabIndex = 99;
            this.CPUSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 22);
            this.button4.TabIndex = 101;
            this.button4.Text = "Show All Hardware Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::HWtest3.Properties.Resources.backdrop;
            this.ClientSize = new System.Drawing.Size(701, 710);
            this.Controls.Add(this.GPUSpeed);
            this.Controls.Add(this.CPUSpeed);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.GPU1RealTimeUsage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VRAMbar1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RAMProgressBar1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CPUnamebar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpu1NumTemp);
            this.Controls.Add(this.cpuNumTemp);
            this.Controls.Add(this.Tempchange);
            this.Controls.Add(this.RAMusage);
            this.Controls.Add(this.CPUusage);
            this.Controls.Add(this.CpuProgressBar);
            this.Controls.Add(this.Gpu1ProgressBar);
            this.Controls.Add(this.cpuTempBar);
            this.Controls.Add(this.Gpu2ProgressBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label RAMusage;
        private System.Windows.Forms.Button Tempchange;
        private System.Windows.Forms.Label cpuNumTemp;
        private System.Windows.Forms.Label gpu1NumTemp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CircularProgressBar.CircularProgressBar CpuProgressBar;
        private CircularProgressBar.CircularProgressBar Gpu1ProgressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private CircularProgressBar.CircularProgressBar cpuTempBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CPUnamebar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private CircularProgressBar.CircularProgressBar Gpu2ProgressBar;
        private ProgressBarSample.TextProgressBar RAMProgressBar1;
        private System.Windows.Forms.Label CPUusage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private ProgressBarSample.TextProgressBar VRAMbar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label GPU1RealTimeUsage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label GPUSpeed;
        private System.Windows.Forms.Label CPUSpeed;
        private System.Windows.Forms.Button button4;
    }
}

