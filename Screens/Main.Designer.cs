
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.VitalSelector = new System.Windows.Forms.ComboBox();
			this.vital = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.ClearMonitor = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.RecordingStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.ClearMonitorHelp = new System.Windows.Forms.HelpProvider();
			this.AutoScroll = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.vital)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// VitalSelector
			// 
			this.VitalSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VitalSelector.FormattingEnabled = true;
			this.VitalSelector.Items.AddRange(new object[] {
            "Heart Rate",
            "Respiratory Rate",
            "SPo2",
            "Temperature"});
			this.VitalSelector.Location = new System.Drawing.Point(12, 140);
			this.VitalSelector.Name = "VitalSelector";
			this.VitalSelector.Size = new System.Drawing.Size(121, 23);
			this.VitalSelector.TabIndex = 4;
			this.VitalSelector.SelectedIndexChanged += new System.EventHandler(this.VitalSelector_SelectedIndexChanged);
			// 
			// vital
			// 
			this.vital.BackColor = System.Drawing.SystemColors.Control;
			this.vital.BorderlineColor = System.Drawing.Color.Transparent;
			chartArea2.Name = "vitalArea";
			this.vital.ChartAreas.Add(chartArea2);
			legend2.BackColor = System.Drawing.Color.White;
			legend2.Enabled = false;
			legend2.Name = "Legend1";
			this.vital.Legends.Add(legend2);
			this.vital.Location = new System.Drawing.Point(-17, 167);
			this.vital.Name = "vital";
			this.vital.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
			series2.ChartArea = "vitalArea";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Legend = "Legend1";
			series2.Name = "Vital";
			this.vital.Series.Add(series2);
			this.vital.Size = new System.Drawing.Size(391, 238);
			this.vital.TabIndex = 3;
			this.vital.Text = "vital";
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
            this.recordingToolStripMenuItem});
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
			this.recordingToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
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
			// ClearMonitor
			// 
			this.ClearMonitor.Location = new System.Drawing.Point(138, 140);
			this.ClearMonitor.Name = "ClearMonitor";
			this.ClearMonitor.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ClearMonitor.Size = new System.Drawing.Size(91, 23);
			this.ClearMonitor.TabIndex = 5;
			this.ClearMonitor.Text = "Clear Monitor";
			this.ClearMonitor.UseVisualStyleBackColor = true;
			this.ClearMonitor.Click += new System.EventHandler(this.ClearMonitor_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RecordingStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 618);
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
			// AutoScroll
			// 
			this.AutoScroll.AutoSize = true;
			this.AutoScroll.Checked = true;
			this.AutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AutoScroll.Location = new System.Drawing.Point(244, 144);
			this.AutoScroll.Name = "AutoScroll";
			this.AutoScroll.Size = new System.Drawing.Size(75, 19);
			this.AutoScroll.TabIndex = 7;
			this.AutoScroll.Text = "AutoScroll";
			this.AutoScroll.UseVisualStyleBackColor = true;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1466, 640);
			this.Controls.Add(this.AutoScroll);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.ClearMonitor);
			this.Controls.Add(this.HeartRate);
			this.Controls.Add(this.VitalSelector);
			this.Controls.Add(this.Spo);
			this.Controls.Add(this.RespRate);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.vital);
			this.Controls.Add(this.Temperature);
			this.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.Text = "Main";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.vital)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.DataVisualization.Charting.Chart vital;
		private System.Windows.Forms.Label HeartRate;
		private System.Windows.Forms.Label RespRate;
		private System.Windows.Forms.Label Spo;
		private System.Windows.Forms.Label Temperature;
		private System.Windows.Forms.ComboBox VitalSelector;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button ClearMonitor;
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
		private System.Windows.Forms.CheckBox AutoScroll;
	}
}