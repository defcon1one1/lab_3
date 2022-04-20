using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lab_3.Logger
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {
            DateTime utcTime = DateTime.UtcNow;
            writer.Write(utcTime.ToString("yyyy-MM-ddTHH:mm:sszzz") + ": ");
            foreach (string message in messages)
            {
                writer.Write(message + " ");
            }
            writer.Write("\n");

            writer.Flush();
        }

        public abstract void Dispose();
    }
}
/* 2022-03-23T00:18:17+00:00: Example message 1 ...
2022-03-23T00:18:17+00:00: Example message 2 ...
2022-03-23T00:18:17+00:00: Example message 3 ... value 1 value 2 value 3 */