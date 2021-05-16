using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Laps_Remote.Vitals.Structures;
using System.Windows.Forms;
using System.IO;

namespace Laps_Remote.Vitals
{
	class Save
	{
		public static void History(List<Dictionary<string, string>> Time, List<Dictionary<string, float>> Temp,
			List<Dictionary<string, int>> RespRate, List<Dictionary<string, int>> Spo, List<Dictionary<string, int>> Hr)
		{
			VitalRecord record = new VitalRecord()
			{
				Time = Time,
				Temp = Temp,
				RespRate = RespRate,
				Hr = Hr,
				Spo = Spo
			};
			string OutputFile = JsonConvert.SerializeObject(record, Formatting.Indented);

			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Title = "Save Vitals Recording";
			dialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					StreamWriter writer = new StreamWriter(dialog.FileName);
					writer.Write(OutputFile);
					writer.Close();
				}
				catch (Exception e)
				{
					MessageBox.Show(e.StackTrace);
				}
			}
			else
			{
				MessageBox.Show("Operation canceled by the user");
			}
		}
	}
}
