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
using System.Threading;
using Laps_Remote.Vitals;
using Laps_Remote.Utils;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laps_Remote.Screens
{
	public partial class Main : Form
	{
		bool recording = false;
		List<Dictionary<string, float>> TempList = new List<Dictionary<string, float>>();
		List<Dictionary<string, int>> RespRateList = new List<Dictionary<string, int>>();
		List<Dictionary<string, int>> SpoList = new List<Dictionary<string, int>>();
		List<Dictionary<string, int>> HrList = new List<Dictionary<string, int>>();
		int PointsRecorded = 0;


		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			VitalSelector.SelectedIndex = 0;

			vital.ChartAreas[0].AxisX.Maximum = double.NaN;
			vital.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
			vital.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
			vital.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
			vital.ChartAreas[0].AxisX.ScaleView.Size = 111;

			saveToolStripMenuItem.Enabled = false;

			Thread vitalLoopThread = new Thread(() => VitalLoop());
			Threads.addThread("vitalLoopThread", vitalLoopThread);
			vitalLoopThread.Start();
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			Logger.kill();
			Threads.killThreads();
		}

		private void VitalLoop()
		{
			while (true)
			{
				Thread.Sleep(100);
				string Time = $"{DateTime.Now.Hour}:{DateTime.Now.Second}.{DateTime.Now.Second}";

				//All data here will be change in to a real one later
				float patientTemp = Temp.getRandomTemperature();
				int patienRespRate = Resp.getRandomResp();
				int patientSpo = OSat.getRandomOsat();
				int patientHr = BPM.randomBPM();

				if (!vitalMonitorToolStripMenuItem.Checked)
				{
					if (vital.InvokeRequired)
					{
						Invoke((MethodInvoker) delegate
						{
							//Get value
							if (VitalSelector.SelectedIndex == 0)
							{
								vital.Series["Vital"].Points.AddXY(Time, patientHr);
							}
							
							else if (VitalSelector.SelectedIndex == 1)
							{
								vital.Series["Vital"].Points.AddXY(Time, patienRespRate);
							}

							else if (VitalSelector.SelectedIndex == 2)
							{
								vital.Series["Vital"].Points.AddXY(Time, patientSpo);
							}

							else if (VitalSelector.SelectedIndex == 3)
							{
								vital.Series["Vital"].Points.AddXY(Time, patientTemp);
							}
							
							//Remove 0th point if the points.count is more or equal than 1000
							if(vital.Series["Vital"].Points.Count >= 3000)
							{
								vital.Series["Vital"].Points.RemoveAt(0);
							}

							//scroll
							if (vital.Series["Vital"].Points.Count >= 110)
							{
								vital.ChartAreas[0].AxisX.ScaleView.Position = vital.Series["Vital"].Points.Count - 111;
							}
						});
					}

					//Update vital text
					if (Temperature.InvokeRequired)
					{
						Invoke((MethodInvoker)delegate
						{
							Temperature.Text = $"Temperature: {patientTemp}";
						});
					}

					if (RespRate.InvokeRequired)
					{
						Invoke((MethodInvoker)delegate
						{
							RespRate.Text = $"Resp Rate: {patienRespRate}";
						});
					}

					if (Spo.InvokeRequired)
					{
						Invoke((MethodInvoker)delegate
						{
							Spo.Text = $"Spo2: {patientSpo}";
						});
					}

					if (HeartRate.InvokeRequired)
					{
						Invoke((MethodInvoker)delegate
						{
							HeartRate.Text = $"BPM: {patientHr}";
						});
					}

					//Record
					if (recording == true)
					{
						PointsRecorded++;

						//Temperature
						Dictionary<string, float> Temp = new Dictionary<string, float>();
						Temp.Add($"{Time}", patientTemp);
						TempList.Add(Temp);

						//Respiratory Rate, Spo, Hr
						Dictionary<string, int> RespRate = new Dictionary<string, int>();
						RespRate.Add($"{Time}", patienRespRate);
						RespRateList.Add(RespRate);

						Dictionary<string, int> Spo = new Dictionary<string, int>();
						Spo.Add($"{Time}", patientSpo);
						SpoList.Add(Spo);

						Dictionary<string, int> Hr = new Dictionary<string, int>();
						Hr.Add($"{Time}", patientHr);
						HrList.Add(Hr);
						RecordingStatus.Text = $"Recording: {PointsRecorded} points";
					}

				}
				
			}
		}

		private void VitalSelector_SelectedIndexChanged(object sender, EventArgs e)
		{
			vital.Series["Vital"].Points.Clear();
			vital.ChartAreas[0].AxisX.ScaleView.Position = 0;
		}

		private void ClearMonitor_Click(object sender, EventArgs e)
		{
			vital.Series["Vital"].Points.Clear();
			vital.ChartAreas[0].AxisX.ScaleView.Position = 0;
		}

		private void SaveData_Click(object sender, EventArgs e)
		{
			MessageBox.Show(vital.Series["Vital"].Points.ToString());
		}

		private void startToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Thread beep = new Thread(() => Console.Beep(1000, 100));
			beep.Start();

			recording = true;

			saveToolStripMenuItem.Enabled = true;
			startToolStripMenuItem.Enabled = false;

			RecordingStatus.ForeColor = Color.Red;
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			recording = false;

			RecordingStatus.ForeColor = Color.ForestGreen;
			RecordingStatus.Text = "Not Recording";

			saveToolStripMenuItem.Enabled = false;
			startToolStripMenuItem.Enabled = true;

			Save.All(TempList,RespRateList,SpoList,HrList);
		}
	}
}
