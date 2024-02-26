using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiEver
{
    public class ConsoleTraceWriter : ITraceWriter
    {
        public TraceLevel LevelFilter
        {
            get { return TraceLevel.Verbose;}
        }

        public void Trace(TraceLevel level, string message, Exception? ex)
        {
            //Console.WriteLine(message);
            Debug.WriteLine(message);
        }
    }
}
