namespace RoundRobinRunning
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.startBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pBurstText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.pArrivalText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tQuantumText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.processListView = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cpuGroup = new System.Windows.Forms.GroupBox();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.ReadyQueue = new System.Windows.Forms.ColumnHeader();
            this.readyListView = new System.Windows.Forms.ListView();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.resultListView = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.ExitTime = new System.Windows.Forms.ColumnHeader();
            this.Turnaround = new System.Windows.Forms.ColumnHeader();
            this.WaitingTime = new System.Windows.Forms.ColumnHeader("(none)");
            this.TimeViewList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.turnLbl = new System.Windows.Forms.Label();
            this.waitingLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.waitcalc = new System.Windows.Forms.Label();
            this.turnaroundcalc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cpuGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tQuantumText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 793);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1571, 132);
            this.panel1.TabIndex = 0;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.startBtn.Location = new System.Drawing.Point(1376, 35);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(172, 63);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start!";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pBurstText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.pArrivalText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pNameText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(391, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process And Time";
            // 
            // pBurstText
            // 
            this.pBurstText.Location = new System.Drawing.Point(640, 49);
            this.pBurstText.Name = "pBurstText";
            this.pBurstText.Size = new System.Drawing.Size(110, 31);
            this.pBurstText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Burst Time";
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.insert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.insert.Location = new System.Drawing.Point(794, 37);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(141, 52);
            this.insert.TabIndex = 4;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // pArrivalText
            // 
            this.pArrivalText.Location = new System.Drawing.Point(375, 49);
            this.pArrivalText.Name = "pArrivalText";
            this.pArrivalText.Size = new System.Drawing.Size(110, 31);
            this.pArrivalText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Arrival Time";
            // 
            // pNameText
            // 
            this.pNameText.Location = new System.Drawing.Point(106, 51);
            this.pNameText.Name = "pNameText";
            this.pNameText.Size = new System.Drawing.Size(110, 31);
            this.pNameText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // tQuantumText
            // 
            this.tQuantumText.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tQuantumText.Location = new System.Drawing.Point(265, 48);
            this.tQuantumText.Name = "tQuantumText";
            this.tQuantumText.Size = new System.Drawing.Size(89, 35);
            this.tQuantumText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Quantum:";
            // 
            // processListView
            // 
            this.processListView.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processListView.FullRowSelect = true;
            this.processListView.GridLines = true;
            this.processListView.LabelEdit = true;
            this.processListView.Location = new System.Drawing.Point(21, 58);
            this.processListView.Name = "processListView";
            this.processListView.Size = new System.Drawing.Size(215, 562);
            this.processListView.TabIndex = 1;
            this.processListView.UseCompatibleStateImageBehavior = false;
            this.processListView.View = System.Windows.Forms.View.Details;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(44, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 52);
            this.label5.TabIndex = 2;
            // 
            // cpuGroup
            // 
            this.cpuGroup.Controls.Add(this.cpuLabel);
            this.cpuGroup.Controls.Add(this.label5);
            this.cpuGroup.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cpuGroup.Location = new System.Drawing.Point(340, 437);
            this.cpuGroup.Name = "cpuGroup";
            this.cpuGroup.Size = new System.Drawing.Size(224, 145);
            this.cpuGroup.TabIndex = 3;
            this.cpuGroup.TabStop = false;
            this.cpuGroup.Text = "CPU";
            // 
            // cpuLabel
            // 
            this.cpuLabel.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.cpuLabel.Location = new System.Drawing.Point(44, 52);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(142, 58);
            this.cpuLabel.TabIndex = 3;
            this.cpuLabel.Text = "idle";
            this.cpuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReadyQueue
            // 
            this.ReadyQueue.Text = "";
            this.ReadyQueue.Width = 0;
            // 
            // readyListView
            // 
            this.readyListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.readyListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ReadyQueue});
            this.readyListView.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.readyListView.ForeColor = System.Drawing.Color.YellowGreen;
            this.readyListView.GridLines = true;
            this.readyListView.Location = new System.Drawing.Point(111, 681);
            this.readyListView.Name = "readyListView";
            this.readyListView.RightToLeftLayout = true;
            this.readyListView.Size = new System.Drawing.Size(1345, 42);
            this.readyListView.TabIndex = 4;
            this.readyListView.UseCompatibleStateImageBehavior = false;
            this.readyListView.View = System.Windows.Forms.View.Details;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // resultListView
            // 
            this.resultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ExitTime,
            this.Turnaround,
            this.WaitingTime});
            this.resultListView.Location = new System.Drawing.Point(265, 58);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(410, 335);
            this.resultListView.TabIndex = 5;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 80;
            // 
            // ExitTime
            // 
            this.ExitTime.Text = "Exit Time";
            this.ExitTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExitTime.Width = 80;
            // 
            // Turnaround
            // 
            this.Turnaround.Text = "Turnaround Time";
            this.Turnaround.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Turnaround.Width = 135;
            // 
            // WaitingTime
            // 
            this.WaitingTime.Text = "Waiting Time";
            this.WaitingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WaitingTime.Width = 110;
            // 
            // TimeViewList
            // 
            this.TimeViewList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.TimeViewList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TimeViewList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.TimeViewList.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TimeViewList.ForeColor = System.Drawing.Color.White;
            this.TimeViewList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TimeViewList.Location = new System.Drawing.Point(71, 723);
            this.TimeViewList.Name = "TimeViewList";
            this.TimeViewList.OwnerDraw = true;
            this.TimeViewList.Size = new System.Drawing.Size(0, 50);
            this.TimeViewList.TabIndex = 6;
            this.TimeViewList.UseCompatibleStateImageBehavior = false;
            this.TimeViewList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "0";
            this.columnHeader1.Width = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(52, 630);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1463, 143);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gantt Chart";
            // 
            // turnLbl
            // 
            this.turnLbl.AutoSize = true;
            this.turnLbl.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.turnLbl.ForeColor = System.Drawing.Color.YellowGreen;
            this.turnLbl.Location = new System.Drawing.Point(281, 40);
            this.turnLbl.Name = "turnLbl";
            this.turnLbl.Size = new System.Drawing.Size(214, 24);
            this.turnLbl.TabIndex = 8;
            this.turnLbl.Text = "Average Turnaround time";
            // 
            // waitingLbl
            // 
            this.waitingLbl.AutoSize = true;
            this.waitingLbl.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.waitingLbl.ForeColor = System.Drawing.Color.YellowGreen;
            this.waitingLbl.Location = new System.Drawing.Point(302, 153);
            this.waitingLbl.Name = "waitingLbl";
            this.waitingLbl.Size = new System.Drawing.Size(181, 24);
            this.waitingLbl.TabIndex = 9;
            this.waitingLbl.Text = "Average Waiting time";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.waitcalc);
            this.groupBox3.Controls.Add(this.turnaroundcalc);
            this.groupBox3.Controls.Add(this.waitingLbl);
            this.groupBox3.Controls.Add(this.turnLbl);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(705, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(810, 287);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Average";
            // 
            // waitcalc
            // 
            this.waitcalc.AutoSize = true;
            this.waitcalc.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.waitcalc.Location = new System.Drawing.Point(45, 213);
            this.waitcalc.Name = "waitcalc";
            this.waitcalc.Size = new System.Drawing.Size(18, 24);
            this.waitcalc.TabIndex = 11;
            this.waitcalc.Text = "..";
            // 
            // turnaroundcalc
            // 
            this.turnaroundcalc.AutoSize = true;
            this.turnaroundcalc.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.turnaroundcalc.Location = new System.Drawing.Point(45, 101);
            this.turnaroundcalc.Name = "turnaroundcalc";
            this.turnaroundcalc.Size = new System.Drawing.Size(18, 24);
            this.turnaroundcalc.TabIndex = 10;
            this.turnaroundcalc.Text = "..";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(89, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Queue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(864, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 22);
            this.label7.TabIndex = 12;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1571, 925);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.readyListView);
            this.Controls.Add(this.cpuGroup);
            this.Controls.Add(this.processListView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TimeViewList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Round Robin Algorithm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.main_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cpuGroup.ResumeLayout(false);
            this.cpuGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox tQuantumText;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox pNameText;
        private Label label2;
        private Button insert;
        private TextBox pArrivalText;
        private Label label3;
        private TextBox pBurstText;
        private Label label4;
        private ListView processListView;
        private Button startBtn;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
        private GroupBox cpuGroup;
        private Label cpuLabel;
        private ColumnHeader ReadyQueue;
        private System.Windows.Forms.Timer timer2;
        private ListView resultListView;
        private ColumnHeader ID;
        private ColumnHeader ExitTime;
        private ColumnHeader Turnaround;
        private ColumnHeader WaitingTime;
        private ListView readyListView;
        private ListView TimeViewList;
        private ColumnHeader columnHeader1;
        private GroupBox groupBox2;
        private Label turnLbl;
        private Label waitingLbl;
        private GroupBox groupBox3;
        private Label waitcalc;
        private Label turnaroundcalc;
        private Label label6;
        private Label label7;
    }
}