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
			
			Thread vitalLoopThread = new Thread(() => VitalChartloop());
			Threads.addThread("vitalLoopThread", vitalLoopThread);
			vitalLoopThread.Start();
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			Logger.kill();
			Threads.killThreads();
		}

		private void VitalChartloop()
		{
			while (true)
			{
				Thread.Sleep(100);
				string Time = $"{DateTime.Now.Hour}:{DateTime.Now.Second}.{DateTime.Now.Second}";

				//All data here will be change in to a real one later
				float patientTemp = Temp.getRandomTemperature();
				float patienRespRate = Resp.getRandomResp();
				float patientSpo = OSat.getRandomOsat();
				float pateintHr = BPM.randomBPM();

				if (!vitalMonitorToolStripMenuItem.Checked)
				{
					if (vital.InvokeRequired)
					{
						Invoke((MethodInvoker) delegate
						{
							//Get value
							if (VitalSelector.SelectedIndex == 0)
							{
								vital.Series["Vital"].Points.AddXY(Time, pateintHr);
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
							if(vital.Series["Vital"].Points.Count >= 1000)
							{
								vital.Series["Vital"].Points.RemoveAt(0);
							}

							//scroll
							if (vital.Series["Vital"].Points.Count >= 111)
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
							HeartRate.Text = $"BPM: {pateintHr}";
						});
					}
				}
				
			}
		}

		private void VitalSelector_SelectedIndexChanged(object sender, EventArgs e)
		{
			vital.Series["Vital"].Points.Clear();
		}

		private void ClearMonitor_Click(object sender, EventArgs e)
		{
			vital.Series["Vital"].Points.Clear();
		}
	}
}
