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
		List<string> TimeList = new List<string>();
		List<float> TempList = new List<float>();
		List<int> RespRateList = new List<int>();
		List<int> SpoList = new List<int>();
		List<int> HrList = new List<int>();

		public Reader()
		{
			InitializeComponent();
			
			Logger.Log("Reader Open", DateTime.Now, Level.Trace);

			VitalSelectorAReader.SelectedIndex = 0;

			OpenFileDialog fileDialog = new OpenFileDialog();
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				filePath = fileDialog.FileName;
				if (Path.GetExtension(filePath) != ".json")
				{
					Logger.MessageBoxLog("Selected Invalid File", DateTime.Now, Level.Error);
					this.Dispose();
				}
			}
			else
			{
				this.Dispose();
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

			//Load Values
			for(int i = 0; i != history["Time"].Count; i++)
			{
				TimeList.Add(history["Time"][i]["value"].ToString());
				TempList.Add((float)history["Temp"][i]["value"]);
				RespRateList.Add((int)history["RespRate"][i]["value"]);
				SpoList.Add((int)history["Spo"][i]["value"]);
				HrList.Add((int)history["Hr"][i]["value"]);
			}
		}

		private void VitalSelectorAReader_SelectedIndexChanged(object sender, EventArgs e)
		{
			MonitorAReader.Series["Vital"].Points.Clear();
			if (VitalSelectorAReader.SelectedIndex == 0)
			{
				for (int i = 0; i != TimeList.Count; i++)
				{
					MonitorAReader.Series["Vital"].Points.AddXY(TimeList[i], HrList[i]);
				}
			}
			else if (VitalSelectorAReader.SelectedIndex == 1)
			{
				for (int i = 0; i != TimeList.Count; i++)
				{
					MonitorAReader.Series["Vital"].Points.AddXY(TimeList[i], RespRateList[i]);
				}
			}

			else if(VitalSelectorAReader.SelectedIndex == 2)
			{
				for (int i = 0; i != TimeList.Count; i++)
				{
					MonitorAReader.Series["Vital"].Points.AddXY(TimeList[i], SpoList[i]);
				}
			}
			else if(VitalSelectorAReader.SelectedIndex == 3)
			{
				for (int i = 0; i != TimeList.Count; i++)
				{
					MonitorAReader.Series["Vital"].Points.AddXY(TimeList[i], TempList[i]);
				}
			}
		}
	}
}
