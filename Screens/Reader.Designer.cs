
namespace Laps_Remote.Screens
{
	partial class Reader
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
			this.MonitorAReader = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.VitalSelectorAReader = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.MonitorAReader)).BeginInit();
			this.SuspendLayout();
			// 
			// MonitorAReader
			// 
			this.MonitorAReader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MonitorAReader.BackColor = System.Drawing.SystemColors.Control;
			this.MonitorAReader.BorderlineColor = System.Drawing.Color.Transparent;
			chartArea1.Name = "vitalArea";
			this.MonitorAReader.ChartAreas.Add(chartArea1);
			legend1.BackColor = System.Drawing.Color.White;
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.MonitorAReader.Legends.Add(legend1);
			this.MonitorAReader.Location = new System.Drawing.Point(-3, 45);
			this.MonitorAReader.Name = "MonitorAReader";
			this.MonitorAReader.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
			series1.ChartArea = "vitalArea";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series1.Legend = "Legend1";
			series1.Name = "Vital";
			this.MonitorAReader.Series.Add(series1);
			this.MonitorAReader.Size = new System.Drawing.Size(776, 393);
			this.MonitorAReader.TabIndex = 4;
			this.MonitorAReader.Text = "vital";
			// 
			// VitalSelectorAReader
			// 
			this.VitalSelectorAReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VitalSelectorAReader.FormattingEnabled = true;
			this.VitalSelectorAReader.Items.AddRange(new object[] {
            "Heart Rate",
            "Respiratory Rate",
            "SPo2",
            "Temperature"});
			this.VitalSelectorAReader.Location = new System.Drawing.Point(66, 27);
			this.VitalSelectorAReader.Name = "VitalSelectorAReader";
			this.VitalSelectorAReader.Size = new System.Drawing.Size(121, 21);
			this.VitalSelectorAReader.TabIndex = 10;
			this.VitalSelectorAReader.SelectedIndexChanged += new System.EventHandler(this.VitalSelectorAReader_SelectedIndexChanged);
			// 
			// Reader
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.VitalSelectorAReader);
			this.Controls.Add(this.MonitorAReader);
			this.Name = "Reader";
			this.Text = "Reader";
			this.Load += new System.EventHandler(this.Reader_Load);
			((System.ComponentModel.ISupportInitialize)(this.MonitorAReader)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart MonitorAReader;
		private System.Windows.Forms.ComboBox VitalSelectorAReader;
	}
}