using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_sample
{
    public interface Logger
    {
        void LogMessage(string message);

    }
    public interface TestLogger
    {
        void TestLogMessage(string message);

    }
    public class Consolelogger : Logger,TestLogger   // over come the problem of multiple inheritance
    {
        public void LogMessage(string messsage)
        {
            Console.WriteLine($"Logging as message:{messsage}");
        }
        public void TestLogMessage(string address)
        {
            Console.WriteLine($"Logging as message:{address}");
        }
    }
    internal interface TestInterface
    {
        static void Main(string[] args)
        {
            Consolelogger cl=new Consolelogger();
            cl.LogMessage("hello World");
            cl.TestLogMessage("I am in pune");

        }
     
    }
}
