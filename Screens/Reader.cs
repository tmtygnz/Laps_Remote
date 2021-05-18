using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Laps_Remote.Logging;
using System.IO;

namespace Laps_Remote.Screens
{
	public partial class Reader : Form
	{
		string filePath;
		dynamic history;
		List<Dictionary<string, string>> Time;
		List<Dictionary<string, int>> RespRate;
		
		public Reader()
		{
			InitializeComponent();
			
			Logger.log("Reader Open", DateTime.Now, Level.Trace);

			OpenFileDialog fileDialog = new OpenFileDialog();
			if (fileDialog.ShowDialog() == DialogResult.OK) 
			{
				if (Path.GetExtension(filePath) == "json")
				{
					MessageBox.Show(Path.GetExtension(filePath));
					filePath = fileDialog.FileName;
				}

				else
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
			StreamReader reader = new StreamReader(filePath);
			history = JsonConvert.DeserializeObject<dynamic>(reader.ReadToEnd());
			MessageBox.Show(history);
		}
	}
}
