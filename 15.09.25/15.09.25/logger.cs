using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
namespace _15._09._25
{
    public class logger
    {
        string path = "log.txt";
        DateTime dateTime = DateTime.Now;
        bool isActive = false;

        public void logging (string warning){
            if (!isActive)
            {
                isActive = true;
                Trace.Listeners.Add(new TextWriterTraceListener(path));
                Trace.AutoFlush = true;
            }
            Trace.WriteLine($"{dateTime} warning");
        }
    }
}
