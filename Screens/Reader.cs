using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Laps_Remote.Logging;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laps_Remote.Screens
{
	public partial class Reader : Form
	{
		static string filePath = "";
		dynamic history;
		List<Dictionary<string, string>> Time = new List<Dictionary<string, string>>();
		List<Dictionary<string, int>> RespRate = new List<Dictionary<string, int>>();
		
		public Reader()
		{
			InitializeComponent();
			
			Logger.log("Reader Open", DateTime.Now, Level.Trace);

			OpenFileDialog fileDialog = new OpenFileDialog();
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				filePath = fileDialog.FileName;
				if (Path.GetExtension(filePath) != ".json")
				{
					MessageBox.Show(filePath);
					Logger.log("Selected Invalid File", DateTime.Now, Level.Error);
					MessageBox.Show("Please select a valid file");
					this.Hide();
				}
			}
		}

		private void Reader_Load(object sender, EventArgs e)
		{
			MonitorAReader.ChartAreas[0].AxisX.Maximum = double.NaN;
			MonitorAReader.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
			MonitorAReader.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
			MonitorAReader.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
			MonitorAReader.ChartAreas[0].AxisX.ScaleView.Size = 111;

			StreamReader reader = new StreamReader(filePath);
			history = JsonConvert.DeserializeObject<dynamic>(reader.ReadToEnd());
			for (int i = 0; i != history["Time"].Count; i++)
			{
				MonitorAReader.Series["Vital"].Points.AddXY(history["Time"][i]["value"].ToString(), (float)history["Temp"][i]["value"]);
			}
		}
	}
}
