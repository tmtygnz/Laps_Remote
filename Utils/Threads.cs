using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Laps_Remote.Utils
{
	static class Threads
	{
		public static Dictionary<string, Thread> threadDictionary;
		public static void init()
		{
			threadDictionary = new Dictionary<string, Thread>();
		}

		public static void addThread(String threadName,Thread thread)
		{
			threadDictionary.Add(threadName, thread);
		}

		public static void killThreads()
		{
			foreach(KeyValuePair<string,Thread> th in threadDictionary)
			{
				th.Value.Abort();
			}
		}
	}
}
