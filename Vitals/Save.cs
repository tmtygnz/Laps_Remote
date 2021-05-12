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
		public static void All(List<Dictionary<string, float>> val, List<Dictionary<string, int>> RespRate, 
			List<Dictionary<string, int>> Spo, List<Dictionary<string, int>> Hr) 
		{
			VitalRecord record = new VitalRecord { 
				temperature = val,
				respRate = RespRate,
				Spo = Spo,
				Hr = Hr
			};
			string jsonOutput = JsonConvert.SerializeObject(record, Formatting.Indented);
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Title = "Save Vitals Recording";
			dialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				StreamWriter writer = new StreamWriter(dialog.FileName);
				writer.Write(jsonOutput);
				writer.Close();
			}
			else
			{
				MessageBox.Show("File saving is canceled by the user");
			}
		}
	}
}
