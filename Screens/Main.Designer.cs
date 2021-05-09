
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.vital)).BeginInit();
			this.menuStrip1.SuspendLayout();
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
			this.VitalSelector.Location = new System.Drawing.Point(11, 116);
			this.VitalSelector.Name = "VitalSelector";
			this.VitalSelector.Size = new System.Drawing.Size(121, 21);
			this.VitalSelector.TabIndex = 4;
			this.VitalSelector.SelectedIndexChanged += new System.EventHandler(this.VitalSelector_SelectedIndexChanged);
			// 
			// vital
			// 
			this.vital.BackColor = System.Drawing.SystemColors.Control;
			this.vital.BorderlineColor = System.Drawing.Color.Transparent;
			chartArea1.Name = "vitalArea";
			this.vital.ChartAreas.Add(chartArea1);
			legend1.BackColor = System.Drawing.Color.White;
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.vital.Legends.Add(legend1);
			this.vital.Location = new System.Drawing.Point(-15, 143);
			this.vital.Name = "vital";
			this.vital.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
			series1.ChartArea = "vitalArea";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Legend = "Legend1";
			series1.Name = "Vital";
			this.vital.Series.Add(series1);
			this.vital.Size = new System.Drawing.Size(391, 382);
			this.vital.TabIndex = 3;
			this.vital.Text = "vital";
			// 
			// HeartRate
			// 
			this.HeartRate.AutoSize = true;
			this.HeartRate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HeartRate.Location = new System.Drawing.Point(240, 71);
			this.HeartRate.Name = "HeartRate";
			this.HeartRate.Size = new System.Drawing.Size(50, 22);
			this.HeartRate.TabIndex = 3;
			this.HeartRate.Text = "BPM:";
			// 
			// RespRate
			// 
			this.RespRate.AutoSize = true;
			this.RespRate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RespRate.Location = new System.Drawing.Point(12, 71);
			this.RespRate.Name = "RespRate";
			this.RespRate.Size = new System.Drawing.Size(120, 22);
			this.RespRate.TabIndex = 2;
			this.RespRate.Text = "Resp Rate: ";
			// 
			// Spo
			// 
			this.Spo.AutoSize = true;
			this.Spo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Spo.Location = new System.Drawing.Point(240, 35);
			this.Spo.Name = "Spo";
			this.Spo.Size = new System.Drawing.Size(70, 22);
			this.Spo.TabIndex = 1;
			this.Spo.Text = "Spo2: ";
			// 
			// Temperature
			// 
			this.Temperature.AutoSize = true;
			this.Temperature.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Temperature.Location = new System.Drawing.Point(12, 35);
			this.Temperature.Name = "Temperature";
			this.Temperature.Size = new System.Drawing.Size(140, 22);
			this.Temperature.TabIndex = 0;
			this.Temperature.Text = "Temperature: ";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(138, 116);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Reset Monitor";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1466, 537);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.HeartRate);
			this.Controls.Add(this.VitalSelector);
			this.Controls.Add(this.Spo);
			this.Controls.Add(this.RespRate);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.vital);
			this.Controls.Add(this.Temperature);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.Text = "Main";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.vital)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
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
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vitalMonitorToolStripMenuItem;
	}
}