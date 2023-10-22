
namespace console
{
    class LoggerStartProgram : Logger
    {
        infoLogStatus startStatus;
        public void startProgram()
        {
            startStatus = infoLogStatus.debug;

            logInfo = "Program is started";
            logError = "OK";
            logStatus = startStatus;
            log();
        }
    }
}
