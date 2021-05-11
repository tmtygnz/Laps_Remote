using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laps_Remote.Vitals.Structures
{
	struct VitalRecord
	{
		public List<Dictionary<string, float>> temperature;
		public List<Dictionary<string, int>> respRate;
		public List<Dictionary<string, int>> Spo;
		public List<Dictionary<string, int>> Hr;

	}
}
