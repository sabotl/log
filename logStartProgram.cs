using System;
using System.Net.NetworkInformation;

namespace console
{
    class LoggerStartProgram : Logger
    {
        public void startProgram()
        {
            logInfo = "Program is started";
            logError = "OK";
            logStatus = "debug";
            log();
        }
    }
}
