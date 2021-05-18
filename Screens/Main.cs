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
using Laps_Remote.Screens;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laps_Remote.Screens
{
	public partial class Main : Form
	{
		bool recording = false;
		List<Dictionary<string, string>> TimeList = new List<Dictionary<string, string>>();
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
			VitalSelector_A.SelectedIndex = 0;
			VitalSelector_B.SelectedIndex = 0;

			Monitor_A.ChartAreas[0].AxisX.Maximum = double.NaN;
			Monitor_A.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
			Monitor_A.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
			Monitor_A.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
			Monitor_A.ChartAreas[0].AxisX.ScaleView.Size = 111;

			Monitor_B.ChartAreas[0].AxisX.Maximum = double.NaN;
			Monitor_B.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
			Monitor_B.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
			Monitor_B.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
			Monitor_B.ChartAreas[0].AxisX.ScaleView.Size = 111;

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
					if (Monitor_A.InvokeRequired)
					{
						Invoke((MethodInvoker) delegate
						{
							//Get value
							if (VitalSelector_A.SelectedIndex == 0)
							{
								Monitor_A.Series["Vital"].Points.AddXY(Time, patientHr);
							}
							
							else if (VitalSelector_A.SelectedIndex == 1)
							{
								Monitor_A.Series["Vital"].Points.AddXY(Time, patienRespRate);
							}

							else if (VitalSelector_A.SelectedIndex == 2)
							{
								Monitor_A.Series["Vital"].Points.AddXY(Time, patientSpo);
							}

							else if (VitalSelector_A.SelectedIndex == 3)
							{
								Monitor_A.Series["Vital"].Points.AddXY(Time, patientTemp);
							}
							
							//Remove 0th point if the points.count is more or equal than 3000
							if(Monitor_A.Series["Vital"].Points.Count >= 3000)
							{
								Monitor_A.Series["Vital"].Points.RemoveAt(0);
							}

							//scroll
							if (AutoScroll_A.Checked == true && Monitor_A.Series["Vital"].Points.Count >= 111)
							{
								Monitor_A.ChartAreas["vitalArea"].AxisX.ScaleView.Position = Monitor_A.Series["Vital"].Points.Count - 111;
							}
						});
					}

					if (Monitor_B.InvokeRequired)
					{
						Invoke((MethodInvoker)delegate 
						{
							//Get Value
							if (VitalSelector_B.SelectedIndex == 0)
							{
								Monitor_B.Series["Vital"].Points.AddXY(Time, patientHr);
							}

							else if (VitalSelector_B.SelectedIndex == 1)
							{
								Monitor_B.Series["Vital"].Points.AddXY(Time, patienRespRate);
							}

							else if (VitalSelector_B.SelectedIndex == 2)
							{
								Monitor_B.Series["Vital"].Points.AddXY(Time, patientSpo);
							}

							else if(VitalSelector_B.SelectedIndex == 3)
							{
								Monitor_B.Series["Vital"].Points.AddXY(Time, patientTemp);
							}

							//Remove 0th point if point.count is more than 3000
							if (Monitor_B.Series["Vital"].Points.Count >= 3000)
							{
								Monitor_B.Series["Vital"].Points.RemoveAt(0);
							}

							if (AutoScroll_B.Checked == true && Monitor_B.Series["Vital"].Points.Count >= 111)
							{
								Monitor_B.ChartAreas["vitalArea"].AxisX.ScaleView.Position = Monitor_B.Series["Vital"].Points.Count - 111;
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
						Dictionary<string, float> TempGet = new Dictionary<string, float>();
						TempGet.Add(Time, patientTemp);
						TempList.Add(TempGet);

						//Respiratory Rate, Spo, Hr, time
						Dictionary<string, int> RespRateGet = new Dictionary<string, int>();
						RespRateGet.Add(Time, patienRespRate);
						RespRateList.Add(RespRateGet);

						Dictionary<string, int> SpoGet = new Dictionary<string, int>();
						SpoGet.Add(Time, patientSpo);
						SpoList.Add(SpoGet);

						Dictionary<string, int> HrGet = new Dictionary<string, int>();
						HrGet.Add(Time, patientHr);
						HrList.Add(HrGet);

						Dictionary<string, string> TimeGet = new Dictionary<string, string>();
						TimeGet.Add("value", Time);
						TimeList.Add(TimeGet);

						RecordingStatus.Text = $"Recording: {PointsRecorded} points";
					}

				}
				
			}
		}

		private void VitalSelector_SelectedIndexChanged(object sender, EventArgs e)
		{
			Monitor_A.Series["Vital"].Points.Clear();
			Monitor_A.ChartAreas[0].AxisX.ScaleView.Position = 0;
		}

		private void VitalSelector_B_SelectedIndexChanged(object sender, EventArgs e)
		{
			Monitor_B.Series["Vital"].Points.Clear();
			Monitor_B.ChartAreas[0].AxisX.ScaleView.Position = 0;
		}

		private void ClearMonitor_Click(object sender, EventArgs e)
		{
			Monitor_A.Series["Vital"].Points.Clear();
			Monitor_A.ChartAreas[0].AxisX.ScaleView.Position = 0;
		}

		private void ClearMonitor_B_Click(object sender, EventArgs e)
		{
			Monitor_B.Series["Vital"].Points.Clear();
			Monitor_B.ChartAreas[0].AxisX.ScaleView.Position = 0;
		}

		private void SaveData_Click(object sender, EventArgs e)
		{
			MessageBox.Show(Monitor_A.Series["Vital"].Points.ToString());
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

			Save.History(TimeList,TempList,RespRateList,SpoList,HrList);

			TimeList.Clear();
			TempList.Clear();
			RespRateList.Clear();
			SpoList.Clear();
			HrList.Clear();
		}

		private void readHIstoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Reader reader = new Reader();
			reader.Show();
		}
	}
}
