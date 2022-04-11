using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogWithASPNETMVC.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var loggerClass = new MyLoggerUtility();
            loggerClass.LogInfo();
            loggerClass.LogError();

            Console.ReadLine();
        }
    }
}