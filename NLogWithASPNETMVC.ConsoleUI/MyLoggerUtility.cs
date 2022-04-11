using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogWithASPNETMVC.ConsoleUI
{
    public class MyLoggerUtility
    {
        private Logger _logger;
        public MyLoggerUtility()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        public void LogError()
        {
            _logger.Error("Logged Error");
        }

        public void LogInfo()
        {
            _logger.Info("Logged Info");
        }
    }
}