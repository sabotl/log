
namespace console
{
    class Client : Logger
    {
        infoLogStatus clientStatus;
        public string Name { get; set; }
        public string Password { get; set; }
        public Client(string name, string password)
        {
            Name = name;
            Password = password;
        }
        private bool checkDataName()
        {
            if (Name.Length == 0 || Name.Length > 26)
            {
                return false;
            }
            return true;
        }
        private bool checkDataPassword()
        {
            if (Password.Length == 0 || Name.Length > 21)
            {

                return false;
            }
            return true;
        }
        public void AddClient()
        {
            if (checkDataName() && checkDataPassword())
            {
                clientStatus = infoLogStatus.info;

                Console.WriteLine("Аккаунт успешно создан!");
                logError = "ОК";
                logStatus = clientStatus;
                logInfo = $"User: {Name} created account";
                log();
            }
            else if (!checkDataName() && !checkDataPassword())
            {
                clientStatus = infoLogStatus.error;

                logError = "Input error";
                logInfo = "User did not enter data";
                logStatus = clientStatus;
                log();
            }
            else if (!checkDataName() && checkDataPassword())
            {
                clientStatus = infoLogStatus.error;

                logError = "Input error";
                logInfo = "User did not enter name";
                logStatus = clientStatus;
                log();
            }
            else if (checkDataName() && !checkDataPassword())
            {
                clientStatus = infoLogStatus.warning;

                logError = "Input error";
                logInfo = $"User did not enter password";
                logStatus = clientStatus;
                log();
            }
            else
            {
                clientStatus = infoLogStatus.fatal;

                logError = "Input error";
                logInfo = "Invalid error";
                logStatus = clientStatus;
                log();
            }
        } 
    }
}


