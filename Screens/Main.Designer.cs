﻿
namespace Laps_Remote.Screens
{
	partial class Main
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.VitalSelector_A = new System.Windows.Forms.ComboBox();
			this.Monitor_A = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.HeartRate = new System.Windows.Forms.Label();
			this.RespRate = new System.Windows.Forms.Label();
			this.Spo = new System.Windows.Forms.Label();
			this.Temperature = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vitalMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vitalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recordingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.readHIstoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.ClearMonitor_A = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.RecordingStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.ClearMonitorHelp = new System.Windows.Forms.HelpProvider();
			this.AutoScroll_A = new System.Windows.Forms.CheckBox();
			this.Monitor_B = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.VitalSelector_B = new System.Windows.Forms.ComboBox();
			this.ClearMonitor_B = new System.Windows.Forms.Button();
			this.AutoScroll_B = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.Monitor_A)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Monitor_B)).BeginInit();
			this.SuspendLayout();
			// 
			// VitalSelector_A
			// 
			this.VitalSelector_A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VitalSelector_A.FormattingEnabled = true;
			this.VitalSelector_A.Items.AddRange(new object[] {
            "Heart Rate",
            "Respiratory Rate",
            "SPo2",
            "Temperature"});
			this.VitalSelector_A.Location = new System.Drawing.Point(12, 140);
			this.VitalSelector_A.Name = "VitalSelector_A";
			this.VitalSelector_A.Size = new System.Drawing.Size(121, 23);
			this.VitalSelector_A.TabIndex = 4;
			this.VitalSelector_A.SelectedIndexChanged += new System.EventHandler(this.VitalSelector_SelectedIndexChanged);
			// 
			// Monitor_A
			// 
			this.Monitor_A.BackColor = System.Drawing.SystemColors.Control;
			this.Monitor_A.BorderlineColor = System.Drawing.Color.Transparent;
			chartArea1.Name = "vitalArea";
			this.Monitor_A.ChartAreas.Add(chartArea1);
			legend1.BackColor = System.Drawing.Color.White;
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.Monitor_A.Legends.Add(legend1);
			this.Monitor_A.Location = new System.Drawing.Point(-17, 167);
			this.Monitor_A.Name = "Monitor_A";
			this.Monitor_A.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
			series1.ChartArea = "vitalArea";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Legend = "Legend1";
			series1.Name = "Vital";
			this.Monitor_A.Series.Add(series1);
			this.Monitor_A.Size = new System.Drawing.Size(391, 253);
			this.Monitor_A.TabIndex = 3;
			this.Monitor_A.Text = "vital";
			// 
			// HeartRate
			// 
			this.HeartRate.AutoSize = true;
			this.HeartRate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HeartRate.Location = new System.Drawing.Point(240, 82);
			this.HeartRate.Name = "HeartRate";
			this.HeartRate.Size = new System.Drawing.Size(50, 22);
			this.HeartRate.TabIndex = 3;
			this.HeartRate.Text = "BPM:";
			// 
			// RespRate
			// 
			this.RespRate.AutoSize = true;
			this.RespRate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RespRate.Location = new System.Drawing.Point(12, 82);
			this.RespRate.Name = "RespRate";
			this.RespRate.Size = new System.Drawing.Size(120, 22);
			this.RespRate.TabIndex = 2;
			this.RespRate.Text = "Resp Rate: ";
			// 
			// Spo
			// 
			this.Spo.AutoSize = true;
			this.Spo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Spo.Location = new System.Drawing.Point(240, 40);
			this.Spo.Name = "Spo";
			this.Spo.Size = new System.Drawing.Size(70, 22);
			this.Spo.TabIndex = 1;
			this.Spo.Text = "Spo2: ";
			// 
			// Temperature
			// 
			this.Temperature.AutoSize = true;
			this.Temperature.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Temperature.Location = new System.Drawing.Point(12, 40);
			this.Temperature.Name = "Temperature";
			this.Temperature.Size = new System.Drawing.Size(140, 22);
			this.Temperature.TabIndex = 0;
			this.Temperature.Text = "Temperature: ";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.vitalsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1466, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.preferencesToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			// 
			// preferencesToolStripMenuItem
			// 
			this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vitalMonitorToolStripMenuItem});
			this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
			this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.preferencesToolStripMenuItem.Text = "Preferences";
			// 
			// vitalMonitorToolStripMenuItem
			// 
			this.vitalMonitorToolStripMenuItem.CheckOnClick = true;
			this.vitalMonitorToolStripMenuItem.Name = "vitalMonitorToolStripMenuItem";
			this.vitalMonitorToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.vitalMonitorToolStripMenuItem.Text = "Stop Monitor";
			// 
			// vitalsToolStripMenuItem
			// 
			this.vitalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordingToolStripMenuItem,
            this.readHIstoryToolStripMenuItem});
			this.vitalsToolStripMenuItem.Name = "vitalsToolStripMenuItem";
			this.vitalsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.vitalsToolStripMenuItem.Text = "Vitals";
			// 
			// recordingToolStripMenuItem
			// 
			this.recordingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.saveToolStripMenuItem});
			this.recordingToolStripMenuItem.Name = "recordingToolStripMenuItem";
			this.recordingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.recordingToolStripMenuItem.Text = "Recording";
			// 
			// startToolStripMenuItem
			// 
			this.startToolStripMenuItem.Name = "startToolStripMenuItem";
			this.startToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.startToolStripMenuItem.Text = "Start";
			this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.saveToolStripMenuItem.Text = "Stop and Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// readHIstoryToolStripMenuItem
			// 
			this.readHIstoryToolStripMenuItem.Name = "readHIstoryToolStripMenuItem";
			this.readHIstoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.readHIstoryToolStripMenuItem.Text = "Read HIstory";
			this.readHIstoryToolStripMenuItem.Click += new System.EventHandler(this.readHIstoryToolStripMenuItem_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Temperature",
            "Resperatory Rate ",
            "SPo2",
            "Heart Rate"});
			this.comboBox1.Location = new System.Drawing.Point(87, 165);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 4;
			// 
			// ClearMonitor_A
			// 
			this.ClearMonitor_A.Location = new System.Drawing.Point(138, 140);
			this.ClearMonitor_A.Name = "ClearMonitor_A";
			this.ClearMonitor_A.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ClearMonitor_A.Size = new System.Drawing.Size(91, 23);
			this.ClearMonitor_A.TabIndex = 5;
			this.ClearMonitor_A.Text = "Clear Monitor";
			this.ClearMonitor_A.UseVisualStyleBackColor = true;
			this.ClearMonitor_A.Click += new System.EventHandler(this.ClearMonitor_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RecordingStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 700);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1466, 22);
			this.statusStrip1.TabIndex = 6;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// RecordingStatus
			// 
			this.RecordingStatus.ForeColor = System.Drawing.Color.ForestGreen;
			this.RecordingStatus.Name = "RecordingStatus";
			this.RecordingStatus.Size = new System.Drawing.Size(84, 17);
			this.RecordingStatus.Text = "Not Recording";
			// 
			// AutoScroll_A
			// 
			this.AutoScroll_A.AutoSize = true;
			this.AutoScroll_A.Checked = true;
			this.AutoScroll_A.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AutoScroll_A.Location = new System.Drawing.Point(244, 144);
			this.AutoScroll_A.Name = "AutoScroll_A";
			this.AutoScroll_A.Size = new System.Drawing.Size(75, 19);
			this.AutoScroll_A.TabIndex = 7;
			this.AutoScroll_A.Text = "AutoScroll";
			this.AutoScroll_A.UseVisualStyleBackColor = true;
			// 
			// Monitor_B
			// 
			this.Monitor_B.BackColor = System.Drawing.SystemColors.Control;
			this.Monitor_B.BorderlineColor = System.Drawing.Color.Transparent;
			chartArea2.Name = "vitalArea";
			this.Monitor_B.ChartAreas.Add(chartArea2);
			legend2.BackColor = System.Drawing.Color.White;
			legend2.Enabled = false;
			legend2.Name = "Legend1";
			this.Monitor_B.Legends.Add(legend2);
			this.Monitor_B.Location = new System.Drawing.Point(-17, 444);
			this.Monitor_B.Name = "Monitor_B";
			this.Monitor_B.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
			series2.ChartArea = "vitalArea";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Legend = "Legend1";
			series2.Name = "Vital";
			this.Monitor_B.Series.Add(series2);
			this.Monitor_B.Size = new System.Drawing.Size(391, 253);
			this.Monitor_B.TabIndex = 8;
			this.Monitor_B.Text = "vital";
			// 
			// VitalSelector_B
			// 
			this.VitalSelector_B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VitalSelector_B.FormattingEnabled = true;
			this.VitalSelector_B.Items.AddRange(new object[] {
            "Heart Rate",
            "Respiratory Rate",
            "SPo2",
            "Temperature"});
			this.VitalSelector_B.Location = new System.Drawing.Point(11, 426);
			this.VitalSelector_B.Name = "VitalSelector_B";
			this.VitalSelector_B.Size = new System.Drawing.Size(121, 23);
			this.VitalSelector_B.TabIndex = 9;
			this.VitalSelector_B.SelectedIndexChanged += new System.EventHandler(this.VitalSelector_B_SelectedIndexChanged);
			// 
			// ClearMonitor_B
			// 
			this.ClearMonitor_B.Location = new System.Drawing.Point(138, 426);
			this.ClearMonitor_B.Name = "ClearMonitor_B";
			this.ClearMonitor_B.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ClearMonitor_B.Size = new System.Drawing.Size(91, 23);
			this.ClearMonitor_B.TabIndex = 10;
			this.ClearMonitor_B.Text = "Clear Monitor";
			this.ClearMonitor_B.UseVisualStyleBackColor = true;
			this.ClearMonitor_B.Click += new System.EventHandler(this.ClearMonitor_B_Click);
			// 
			// AutoScroll_B
			// 
			this.AutoScroll_B.AutoSize = true;
			this.AutoScroll_B.Checked = true;
			this.AutoScroll_B.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AutoScroll_B.Location = new System.Drawing.Point(241, 430);
			this.AutoScroll_B.Name = "AutoScroll_B";
			this.AutoScroll_B.Size = new System.Drawing.Size(75, 19);
			this.AutoScroll_B.TabIndex = 11;
			this.AutoScroll_B.Text = "AutoScroll";
			this.AutoScroll_B.UseVisualStyleBackColor = true;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1466, 722);
			this.Controls.Add(this.AutoScroll_B);
			this.Controls.Add(this.ClearMonitor_B);
			this.Controls.Add(this.VitalSelector_B);
			this.Controls.Add(this.Monitor_B);
			this.Controls.Add(this.AutoScroll_A);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.ClearMonitor_A);
			this.Controls.Add(this.HeartRate);
			this.Controls.Add(this.VitalSelector_A);
			this.Controls.Add(this.Spo);
			this.Controls.Add(this.RespRate);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.Monitor_A);
			this.Controls.Add(this.Temperature);
			this.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.Text = "Laps Remote";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.Monitor_A)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Monitor_B)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.DataVisualization.Charting.Chart Monitor_A;
		private System.Windows.Forms.Label HeartRate;
		private System.Windows.Forms.Label RespRate;
		private System.Windows.Forms.Label Spo;
		private System.Windows.Forms.Label Temperature;
		private System.Windows.Forms.ComboBox VitalSelector_A;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button ClearMonitor_A;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vitalMonitorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vitalsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem recordingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel RecordingStatus;
		private System.Windows.Forms.HelpProvider ClearMonitorHelp;
		private System.Windows.Forms.CheckBox AutoScroll_A;
		private System.Windows.Forms.DataVisualization.Charting.Chart Monitor_B;
		private System.Windows.Forms.ComboBox VitalSelector_B;
		private System.Windows.Forms.Button ClearMonitor_B;
		private System.Windows.Forms.CheckBox AutoScroll_B;
		private System.Windows.Forms.ToolStripMenuItem readHIstoryToolStripMenuItem;
	}
}