using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
namespace _17._09._25
{
    public class logger
    {
        public enum errorType
        {
            Message,
            Warning,
            FatalError
        }
        string path = "log.txt";
        DateTime dateTime = DateTime.Now;
        bool isActive = false;

        public void logging(string warning, errorType errorType)
        {
            if (!isActive)
            {
                isActive = true;
                Trace.Listeners.Add(new TextWriterTraceListener(path));
                Trace.AutoFlush = true;
            } 
            Trace.WriteLine($"{dateTime} {warning}_{errorType}");
        }
    }
}
