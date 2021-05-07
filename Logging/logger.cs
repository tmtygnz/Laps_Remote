using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;


namespace Laps_Remote.Logging
{
	static class logger
	{
		//Queue of log
		public static Queue<Message> logQueue;
		public static StreamWriter logWriter;

		/// <summary>
		/// Initialize Logger
		/// </summary>
		public static void init()
		{
			string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LapsRemote");
			string logfilePath = Path.Combine(appDataPath, "log.log");
			logQueue = new Queue<Message>();

			//Create folder if app
			if (!Directory.Exists(appDataPath))
				Directory.CreateDirectory(appDataPath);

			//Create log.log does not exist create one
			if (!File.Exists(logfilePath))
				File.Create(logfilePath);

			logWriter = File.AppendText(logfilePath);

			Thread logThread = new Thread(() => logLoop());
			logThread.Start();
		}
		private static void logLoop()
		{
			while (true)
				if (logQueue.Count != 0)
					diskWrite(logQueue.Peek());
		}
		
		public static void log(string logMessage, DateTime time, Level level)
		{
			Message msg = new Message
			{
				message = logMessage,
				time = time,
				level = level
			};
			logQueue.Enqueue(msg);
		}

		public static void diskWrite(Message message)
		{
			string logMessage = $"[{message.time}] [{message.level}] {message.message} \n";
			logWriter.Write(logMessage);
			logQueue.Dequeue();
		}
		public static void kill()
		{
			logQueue.Clear();
			logWriter.Close();
		}
	}
}
