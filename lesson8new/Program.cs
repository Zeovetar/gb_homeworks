using System;
using lesson8new.Properties;
using System.Configuration;

namespace lesson8new
{
    class Program
    {
        static void Main(string[] args)
        {
            var appSettings = ConfigurationManager.AppSettings;
            Console.WriteLine("Old preferences:");
            Console.WriteLine(ConfigurationManager.AppSettings["UserName"]);
            Console.WriteLine(ConfigurationManager.AppSettings["UserAge"]);
            Console.WriteLine(ConfigurationManager.AppSettings["UserProfession"] + "\n\n\n");

            string[] data = new string[3];
            Console.WriteLine($"Resource greetings: {Resources.Name}"); //resource greetings
            data[0] = Console.ReadLine();
            Console.WriteLine(Resources.Age);
            data[1] = Console.ReadLine();
            Console.WriteLine(Resources.Profession);
            data[2] = Console.ReadLine();


            string exePath = System.IO.Path.Combine(Environment.CurrentDirectory, "lesson8new.dll"); //settings read
            Configuration roaming = ConfigurationManager.OpenExeConfiguration(exePath);
            var filemap = new ExeConfigurationFileMap { ExeConfigFilename = roaming.FilePath };
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(filemap, ConfigurationUserLevel.None);
            var userName = config.AppSettings.Settings["UserName"].Value;
            config.AppSettings.Settings["UserName"].Value = $"{data[0]}";
            config.AppSettings.Settings["UserAge"].Value = $"{data[1]}";
            config.AppSettings.Settings["UserProfession"].Value = $"{data[2]}";
            config.Save();                                                                           //settings write
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            Console.WriteLine("\nNew preferences:");
            Console.WriteLine(ConfigurationManager.AppSettings["UserName"]);
            Console.WriteLine(ConfigurationManager.AppSettings["UserAge"]);
            Console.WriteLine(ConfigurationManager.AppSettings["UserProfession"] + "\n");
        }
    }
}
 