
namespace console
{
    class Program
    {
        static void Main()
        {
            LoggerStartProgram start = new LoggerStartProgram();
            start.startProgram();
            Client client = new Client("dasdsadas","");
            client.AddClient();
        }
    }
}