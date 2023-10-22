using System;
using System.Net.NetworkInformation;

namespace console
{
    class Client : Logger
    {
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
                Console.WriteLine("Аккаунт успешно создан!");
                logError = "ОК";
                logStatus = "info";
                logInfo = $"User: {Name} created account";
                log();
            }
            else if (!checkDataName() && !checkDataPassword())
            {
                logError = "Input error";
                logInfo = "User did not enter data";
                logStatus = "error";
                log();
            }
            else if (!checkDataName() && checkDataPassword())
            {
                logError = "Input error";
                logInfo = "User did not enter name";
                logStatus = "warning";
                log();
            }
            else if (checkDataName() && !checkDataPassword())
            {
                logError = "Input error";
                logInfo = $"User did not enter password";
                logStatus = "warning";
                log();
            }
            else
            {
                logError = "Input error";
                logInfo = "Invalid error";
                logStatus = "Fatal";
                log();
            }
        } 
    }
}


