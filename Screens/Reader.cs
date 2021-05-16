using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laps_Remote.Logging;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;


namespace Laps_Remote.Screens
{
	public partial class Reader : Form
	{
		string filePath = "";
		dynamic history;
		public Reader()
		{
			InitializeComponent();
			Logger.log("Reader Open",DateTime.Now, Level.Trace);
		}

		private void Reader_Load(object sender, EventArgs e)
		{
			//Setup chart
			Monitor_A.ChartAreas[0].AxisX.Maximum = double.NaN;
			Monitor_A.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
			Monitor_A.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
			Monitor_A.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
			Monitor_A.ChartAreas[0].AxisX.ScaleView.Size = 111;
			
			//Choose file
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					filePath = openFileDialog.FileName;
					StreamReader reader = new StreamReader(filePath);
					history = JsonConvert.DeserializeObject<dynamic>(reader.ReadToEnd());
				}
				catch
				{
					MessageBox.Show("Unable to open file");
					Application.Exit();
				}
			}
		}
		private void loop()
		{
			if (VitalSelector_A.SelectedIndex == 0)
			{
				for (int i = 0; i != history["Hr"].Count(); i++)
				{
					Monitor_A.Series["Vitals"].Points.AddXY(history["Time"][i]["value"], history["Hr"][i]["value"]);
				}
			}

			else if (VitalSelector_A.SelectedIndex == 1)
			{
				for (int i = 0; i != history["RespRate"].Count(); i++)
				{
					Monitor_A.Series["Vitals"].Points.AddXY(history["Time"][i]["value"], history["RespRate"][i]["value"]);
				}
			}

			else if (VitalSelector_A.SelectedIndex == 2)
			{
				for (int i = 0; i != history["Spo"].Count(); i++)
				{
					Monitor_A.Series["Vitals"].Points.AddXY(history["Time"][i]["value"], history["Spo"][i]["value"]);
				}
			}

			else if (VitalSelector_A.SelectedIndex == 3)
			{
				for (int i = 0; i != history["Temp"].Count(); i++)
				{
					Monitor_A.Series["Vitals"].Points.AddXY(history["Time"][i]["value"], history["Temp"][i]["value"]);
				}
			}
		}
	}
}
