using System;
using System.Net.NetworkInformation;
namespace console
{
    internal class Logger
    {
        protected string logInfo { get; set; }
        protected string logError { get; set; }
        protected string logStatus { get; set; }

        protected string SetLog()
        {
            string result;
            //Set client info
            var adapters = NetworkInterface.GetAllNetworkInterfaces();
            string username = "", userId = "";

            //Name Project
            string nameProject = "Looger Project";

            foreach (NetworkInterface adapter in adapters)
            {
                username = Convert.ToString(adapter.Name);
                userId = Convert.ToString(adapter.Id);
            }
            result = @"{
""Log_info"":""" + logInfo + @""",

""user_id"":""" + userId + @""",
""user_name"":""" + username + @""",
""project_id"": """ + nameProject + @""",
""error"":""" + logError + @""",
""status_error"":""" + logStatus + @""",
""data_time"":""" + DateTime.Now.ToString() + @"""
}
";

            return result;
        }
        protected string placeLog()
        {
            string path = Directory.GetCurrentDirectory();
            string relativePath = "temp.log";
            string fileName = Path.Combine(path, relativePath);
            return fileName;
        }

        protected void log()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(placeLog(), true))
                {
                    sw.WriteLine($"{SetLog()}");
                    Console.WriteLine($"Данные были успешно добавлены:\n{SetLog()}");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }

    }
}
