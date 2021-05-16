
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
			this.Monitor_A = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.VitalSelector_A = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.Monitor_A)).BeginInit();
			this.SuspendLayout();
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
			this.Monitor_A.Location = new System.Drawing.Point(12, 54);
			this.Monitor_A.Name = "Monitor_A";
			this.Monitor_A.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
			series1.ChartArea = "vitalArea";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Legend = "Legend1";
			series1.Name = "Vital";
			this.Monitor_A.Series.Add(series1);
			this.Monitor_A.Size = new System.Drawing.Size(748, 384);
			this.Monitor_A.TabIndex = 4;
			this.Monitor_A.Text = "vital";
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
			this.VitalSelector_A.Location = new System.Drawing.Point(74, 36);
			this.VitalSelector_A.Name = "VitalSelector_A";
			this.VitalSelector_A.Size = new System.Drawing.Size(121, 21);
			this.VitalSelector_A.TabIndex = 5;
			// 
			// Reader
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.VitalSelector_A);
			this.Controls.Add(this.Monitor_A);
			this.Name = "Reader";
			this.Text = "Reader";
			this.Load += new System.EventHandler(this.Reader_Load);
			((System.ComponentModel.ISupportInitialize)(this.Monitor_A)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart Monitor_A;
		private System.Windows.Forms.ComboBox VitalSelector_A;
	}
}