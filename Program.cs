using System;

namespace console
{
    class Program
    {
        static void Main()
        {
            LoggerStartProgram start = new LoggerStartProgram();
            start.startProgram();
            Client client = new Client("Name","Password");
            client.AddClient();
        }
    }
}