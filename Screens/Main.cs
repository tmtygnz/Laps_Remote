﻿using System;
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
		int PointsRecorded = 0;
		int SelectedIndexA = 0;
		int SelectedIndexB = 0;

		List<Dictionary<string, string>> TimeList = new List<Dictionary<string, string>>();
		List<Dictionary<string, float>> TempList = new List<Dictionary<string, float>>();
		List<Dictionary<string, int>> RespRateList = new List<Dictionary<string, int>>();
		List<Dictionary<string, int>> SpoList = new List<Dictionary<string, int>>();
		List<Dictionary<string, int>> HrList = new List<Dictionary<string, int>>();
		

		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			VitalSelectorAMain.SelectedIndex = 0;
			VitalSelectorBMain.SelectedIndex = 0;

			MonitorAMain.ChartAreas[0].AxisX.Maximum = double.NaN;
			MonitorAMain.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
			MonitorAMain.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
			MonitorAMain.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
			MonitorAMain.ChartAreas[0].AxisX.ScaleView.Size = 111;

			MonitorBMain.ChartAreas[0].AxisX.Maximum = double.NaN;
			MonitorBMain.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
			MonitorBMain.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
			MonitorBMain.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
			MonitorBMain.ChartAreas[0].AxisX.ScaleView.Size = 111;

			SaveToolStripMenuItem.Enabled = false;

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
				string Time = $"{DateTime.Now.Hour}:{DateTime.Now.Second}";

				//The current data is completely
				float patientTemp = Temp.getRandomTemperature();
				int patienRespRate = Resp.getRandomResp();
				int patientSpo = OSat.getRandomOsat();
				int patientHr = BPM.randomBPM();

				if (!vitalMonitorToolStripMenuItem.Checked)
				{
					if (MonitorAMain.InvokeRequired)
					{
						Invoke((MethodInvoker) delegate
						{
							//Get value
							if (SelectedIndexA == 0)
							{
								MonitorAMain.Series["Vital"].Points.AddXY(Time, patientHr);
							}

							else if (SelectedIndexA == 1)
							{
								MonitorAMain.Series["Vital"].Points.AddXY(Time, patienRespRate);
							}

							else if (SelectedIndexA == 2)
							{
								MonitorAMain.Series["Vital"].Points.AddXY(Time, patientSpo);
							}

							else if (SelectedIndexA == 3)
							{
								MonitorAMain.Series["Vital"].Points.AddXY(Time, patientTemp);
							}
							
							//Remove 0th point if the points.count is more or equal than 3000
							if(MonitorAMain.Series["Vital"].Points.Count >= 3000)
							{
								MonitorAMain.Series["Vital"].Points.RemoveAt(0);
							}

							//scroll
							if (AutoScrollAMain.Checked == true && MonitorAMain.Series["Vital"].Points.Count >= 111)
							{
								MonitorAMain.ChartAreas["vitalArea"].AxisX.ScaleView.Position = MonitorAMain.Series["Vital"].Points.Count - 111;
							}
						});
					}

					if (MonitorBMain.InvokeRequired)
					{
						Invoke((MethodInvoker)delegate 
						{
							//Get Value
							if (SelectedIndexB == 0)
							{
								MonitorBMain.Series["Vital"].Points.AddXY(Time, patientHr);
							}

							else if (SelectedIndexB == 1)
							{
								MonitorBMain.Series["Vital"].Points.AddXY(Time, patienRespRate);
							}

							else if (SelectedIndexB == 2)
							{
								MonitorBMain.Series["Vital"].Points.AddXY(Time, patientSpo);
							}

							else if(SelectedIndexB == 3)
							{
								MonitorBMain.Series["Vital"].Points.AddXY(Time, patientTemp);
							}

							//Remove 0th point if point.count is more than 3000
							if (MonitorBMain.Series["Vital"].Points.Count >= 3000)
							{
								MonitorBMain.Series["Vital"].Points.RemoveAt(0);
							}

							if (AutoScrollBMain.Checked == true && MonitorBMain.Series["Vital"].Points.Count >= 111)
							{
								MonitorBMain.ChartAreas["vitalArea"].AxisX.ScaleView.Position = MonitorBMain.Series["Vital"].Points.Count - 111;
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
						TempGet.Add("value", patientTemp);
						TempList.Add(TempGet);

						//Respiratory Rate, Spo, Hr, time
						Dictionary<string, int> RespRateGet = new Dictionary<string, int>();
						RespRateGet.Add("value", patienRespRate);
						RespRateList.Add(RespRateGet);

						Dictionary<string, int> SpoGet = new Dictionary<string, int>();
						SpoGet.Add("value", patientSpo);
						SpoList.Add(SpoGet);

						Dictionary<string, int> HrGet = new Dictionary<string, int>();
						HrGet.Add("value", patientHr);
						HrList.Add(HrGet);

						Dictionary<string, string> TimeGet = new Dictionary<string, string>();
						TimeGet.Add("value", Time);
						TimeList.Add(TimeGet);

						RecordingStatus.Text = $"Recording: {PointsRecorded} points";
					}
				}
				
			}
		}

		private void VitalSelectorAMain_SelectedIndexChanged(object sender, EventArgs e)
		{
			MonitorAMain.Series["Vital"].Points.Clear();
			MonitorAMain.ChartAreas[0].AxisX.ScaleView.Position = 0;
			SelectedIndexA = VitalSelectorAMain.SelectedIndex;
		}

		private void VitalSelectorBMain_SelectedIndexChanged(object sender, EventArgs e)
		{
			MonitorBMain.Series["Vital"].Points.Clear();
			MonitorBMain.ChartAreas[0].AxisX.ScaleView.Position = 0;
			SelectedIndexB = VitalSelectorBMain.SelectedIndex;
		}

		private void ClearMonitorA_Click(object sender, EventArgs e)
		{
			MonitorAMain.Series["Vital"].Points.Clear();
			MonitorAMain.ChartAreas[0].AxisX.ScaleView.Position = 0;
		}

		private void ClearMonitorBMain_Click(object sender, EventArgs e)
		{
			MonitorBMain.Series["Vital"].Points.Clear();
			MonitorBMain.ChartAreas[0].AxisX.ScaleView.Position = 0;
		}

		private void StartToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Thread beep = new Thread(() => Console.Beep(1000, 100));
			beep.Start();

			recording = true;

			SaveToolStripMenuItem.Enabled = true;
			StartToolStripMenuItem.Enabled = false;

			RecordingStatus.ForeColor = Color.Red;
		}

		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			recording = false;

			RecordingStatus.ForeColor = Color.ForestGreen;
			RecordingStatus.Text = "Not Recording";

			SaveToolStripMenuItem.Enabled = false;
			StartToolStripMenuItem.Enabled = true;

			Save.History(TimeList, TempList, RespRateList, SpoList, HrList);

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
