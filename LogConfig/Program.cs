using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;

namespace LogConfig
{
    internal class Program
    {
        static IConfiguration config;
        static Logger logger;

        static void InitConfig()
        {
            config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        }       

        static void InitLog()
        {
            logger = new LoggerConfiguration().WriteTo.File("logs\\" + DateTime.Now.ToString("dd.MM.yyyy") + ".log",
            outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}").CreateLogger();            
        }

        static void getValuesConfig()
        {
            var Files = config.GetSection("Files");
            Console.WriteLine(File.ReadAllText(Files["file1"]));

            Console.WriteLine(File.ReadAllText(config["Files:file1"]));
            Console.WriteLine(File.ReadAllText(config.GetSection("Files:file1").Value));
            Console.WriteLine(File.ReadAllText(config.GetValue(typeof(string), "Files:file1").ToString()));

            return;
            Console.WriteLine(config["param1"]);
            Console.WriteLine(config["param2"]);
            Console.WriteLine(config.GetConnectionString("conOracleXE"));
            Console.WriteLine(config.GetSection("ConnectionStrings:conOracleXE").Value);



            var array = config.GetSection("param4").Get<string[]>();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            var array2 = config.GetSection("param3").Get<ConfigParam3Data[]>();
            foreach (var item in array2)
            {
                Console.WriteLine($"{item.p1} {item.p2}");
            }
        }

        static void Main(string[] args)
        {
            InitConfig();
            //getValuesConfig();
            InitLog();
            logger.Information("started"); 
            
            
            try
            {
                int p = 0;
                var res = 10 / p;
            }
            catch (Exception err)
            {
                logger.Error(err.Message);
            }

            try
            {
                int[] arr  = new int[2];
                arr[10] = 10;
            }
            catch (Exception err)
            {
                logger.Error(err.Message);
            }

            logger.Information("finished");
        }
    }

    class ConfigParam3Data
    {
        public string p1 { get; set; }
        public string p2 { get; set; }
    }
}