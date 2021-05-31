
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.VitalSelectorAMain = new System.Windows.Forms.ComboBox();
			this.MonitorAMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
			this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.readHIstoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.ClearMonitorA = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.RecordingStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.AutoScrollAMain = new System.Windows.Forms.CheckBox();
			this.MonitorBMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.VitalSelectorBMain = new System.Windows.Forms.ComboBox();
			this.ClearMonitorBMain = new System.Windows.Forms.Button();
			this.AutoScrollBMain = new System.Windows.Forms.CheckBox();
			this.LoggerNotifIcon = new System.Windows.Forms.NotifyIcon(this.components);
			((System.ComponentModel.ISupportInitialize)(this.MonitorAMain)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MonitorBMain)).BeginInit();
			this.SuspendLayout();
			// 
			// VitalSelectorAMain
			// 
			this.VitalSelectorAMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VitalSelectorAMain.FormattingEnabled = true;
			this.VitalSelectorAMain.Items.AddRange(new object[] {
            "Heart Rate",
            "Respiratory Rate",
            "SPo2",
            "Temperature"});
			this.VitalSelectorAMain.Location = new System.Drawing.Point(12, 140);
			this.VitalSelectorAMain.Name = "VitalSelectorAMain";
			this.VitalSelectorAMain.Size = new System.Drawing.Size(121, 23);
			this.VitalSelectorAMain.TabIndex = 4;
			this.VitalSelectorAMain.SelectedIndexChanged += new System.EventHandler(this.VitalSelectorAMain_SelectedIndexChanged);
			// 
			// MonitorAMain
			// 
			this.MonitorAMain.BackColor = System.Drawing.SystemColors.Control;
			this.MonitorAMain.BorderlineColor = System.Drawing.Color.Transparent;
			chartArea1.Name = "vitalArea";
			this.MonitorAMain.ChartAreas.Add(chartArea1);
			legend1.BackColor = System.Drawing.Color.White;
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.MonitorAMain.Legends.Add(legend1);
			this.MonitorAMain.Location = new System.Drawing.Point(-17, 167);
			this.MonitorAMain.Name = "MonitorAMain";
			this.MonitorAMain.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
			series1.ChartArea = "vitalArea";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series1.Legend = "Legend1";
			series1.Name = "Vital";
			this.MonitorAMain.Series.Add(series1);
			this.MonitorAMain.Size = new System.Drawing.Size(391, 253);
			this.MonitorAMain.TabIndex = 3;
			this.MonitorAMain.Text = "vital";
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
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			// 
			// preferencesToolStripMenuItem
			// 
			this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vitalMonitorToolStripMenuItem});
			this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
			this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.StartToolStripMenuItem,
            this.SaveToolStripMenuItem});
			this.recordingToolStripMenuItem.Name = "recordingToolStripMenuItem";
			this.recordingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.recordingToolStripMenuItem.Text = "Recording";
			// 
			// StartToolStripMenuItem
			// 
			this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
			this.StartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.StartToolStripMenuItem.Text = "Start";
			this.StartToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
			// 
			// SaveToolStripMenuItem
			// 
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.SaveToolStripMenuItem.Text = "Stop and Save";
			this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
			// 
			// readHIstoryToolStripMenuItem
			// 
			this.readHIstoryToolStripMenuItem.Name = "readHIstoryToolStripMenuItem";
			this.readHIstoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.readHIstoryToolStripMenuItem.Text = "Read History";
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
			// ClearMonitorA
			// 
			this.ClearMonitorA.Location = new System.Drawing.Point(138, 140);
			this.ClearMonitorA.Name = "ClearMonitorA";
			this.ClearMonitorA.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ClearMonitorA.Size = new System.Drawing.Size(91, 23);
			this.ClearMonitorA.TabIndex = 5;
			this.ClearMonitorA.Text = "Clear Monitor";
			this.ClearMonitorA.UseVisualStyleBackColor = true;
			this.ClearMonitorA.Click += new System.EventHandler(this.ClearMonitorA_Click);
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
			// AutoScrollAMain
			// 
			this.AutoScrollAMain.AutoSize = true;
			this.AutoScrollAMain.Checked = true;
			this.AutoScrollAMain.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AutoScrollAMain.Location = new System.Drawing.Point(244, 144);
			this.AutoScrollAMain.Name = "AutoScrollAMain";
			this.AutoScrollAMain.Size = new System.Drawing.Size(75, 19);
			this.AutoScrollAMain.TabIndex = 7;
			this.AutoScrollAMain.Text = "AutoScroll";
			this.AutoScrollAMain.UseVisualStyleBackColor = true;
			// 
			// MonitorBMain
			// 
			this.MonitorBMain.BackColor = System.Drawing.SystemColors.Control;
			this.MonitorBMain.BorderlineColor = System.Drawing.Color.Transparent;
			chartArea2.Name = "vitalArea";
			this.MonitorBMain.ChartAreas.Add(chartArea2);
			legend2.BackColor = System.Drawing.Color.White;
			legend2.Enabled = false;
			legend2.Name = "Legend1";
			this.MonitorBMain.Legends.Add(legend2);
			this.MonitorBMain.Location = new System.Drawing.Point(-17, 444);
			this.MonitorBMain.Name = "MonitorBMain";
			this.MonitorBMain.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
			series2.ChartArea = "vitalArea";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series2.Legend = "Legend1";
			series2.Name = "Vital";
			this.MonitorBMain.Series.Add(series2);
			this.MonitorBMain.Size = new System.Drawing.Size(391, 253);
			this.MonitorBMain.TabIndex = 8;
			this.MonitorBMain.Text = "vital";
			// 
			// VitalSelectorBMain
			// 
			this.VitalSelectorBMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VitalSelectorBMain.FormattingEnabled = true;
			this.VitalSelectorBMain.Items.AddRange(new object[] {
            "Heart Rate",
            "Respiratory Rate",
            "SPo2",
            "Temperature"});
			this.VitalSelectorBMain.Location = new System.Drawing.Point(11, 426);
			this.VitalSelectorBMain.Name = "VitalSelectorBMain";
			this.VitalSelectorBMain.Size = new System.Drawing.Size(121, 23);
			this.VitalSelectorBMain.TabIndex = 9;
			this.VitalSelectorBMain.SelectedIndexChanged += new System.EventHandler(this.VitalSelectorBMain_SelectedIndexChanged);
			// 
			// ClearMonitorBMain
			// 
			this.ClearMonitorBMain.Location = new System.Drawing.Point(138, 426);
			this.ClearMonitorBMain.Name = "ClearMonitorBMain";
			this.ClearMonitorBMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ClearMonitorBMain.Size = new System.Drawing.Size(91, 23);
			this.ClearMonitorBMain.TabIndex = 10;
			this.ClearMonitorBMain.Text = "Clear Monitor";
			this.ClearMonitorBMain.UseVisualStyleBackColor = true;
			this.ClearMonitorBMain.Click += new System.EventHandler(this.ClearMonitorBMain_Click);
			// 
			// AutoScrollBMain
			// 
			this.AutoScrollBMain.AutoSize = true;
			this.AutoScrollBMain.Checked = true;
			this.AutoScrollBMain.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AutoScrollBMain.Location = new System.Drawing.Point(241, 430);
			this.AutoScrollBMain.Name = "AutoScrollBMain";
			this.AutoScrollBMain.Size = new System.Drawing.Size(75, 19);
			this.AutoScrollBMain.TabIndex = 11;
			this.AutoScrollBMain.Text = "AutoScroll";
			this.AutoScrollBMain.UseVisualStyleBackColor = true;
			// 
			// LoggerNotifIcon
			// 
			this.LoggerNotifIcon.Visible = true;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1466, 722);
			this.Controls.Add(this.AutoScrollBMain);
			this.Controls.Add(this.ClearMonitorBMain);
			this.Controls.Add(this.VitalSelectorBMain);
			this.Controls.Add(this.MonitorBMain);
			this.Controls.Add(this.AutoScrollAMain);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.ClearMonitorA);
			this.Controls.Add(this.HeartRate);
			this.Controls.Add(this.VitalSelectorAMain);
			this.Controls.Add(this.Spo);
			this.Controls.Add(this.RespRate);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.MonitorAMain);
			this.Controls.Add(this.Temperature);
			this.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.Text = "Laps Remote";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.MonitorAMain)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MonitorBMain)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.DataVisualization.Charting.Chart MonitorAMain;
		private System.Windows.Forms.Label HeartRate;
		private System.Windows.Forms.Label RespRate;
		private System.Windows.Forms.Label Spo;
		private System.Windows.Forms.Label Temperature;
		private System.Windows.Forms.ComboBox VitalSelectorAMain;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button ClearMonitorA;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vitalMonitorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vitalsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem recordingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel RecordingStatus;
		private System.Windows.Forms.CheckBox AutoScrollAMain;
		private System.Windows.Forms.DataVisualization.Charting.Chart MonitorBMain;
		private System.Windows.Forms.ComboBox VitalSelectorBMain;
		private System.Windows.Forms.Button ClearMonitorBMain;
		private System.Windows.Forms.CheckBox AutoScrollBMain;
		private System.Windows.Forms.ToolStripMenuItem readHIstoryToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon LoggerNotifIcon;
	}
}