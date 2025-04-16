using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace modul8_103022300153
{
    class BankTransferConfig
    {
        private const string ConfigFileName = "bank_transfer_config.json";
        public string lang { get; set; } = "en";

        class Config
        {
            class transfer
            {
                public int threshold { get; set; } = 25000000;
                public int low_fee { get; set; } = 6500;
                public int high_fee { get; set; } = 15000;
            }
            public string methods { get; set; } = "“RTO", "(real-time)”", "“SKN”", "“RTGS”", "“BI", "FAST”";
        
            class confirmation
            {
                public string en { get; set; } = "yes";
                public string id { get; set; } = "ya";
            }
        }

        public BankTransferConfig ReadConfigFile()
        {
            Config config = new Config();
            String configJsonData = File.ReadAllText(ConfigFileName);
            config = JsonSerializer.Deserialize<BankTransferConfig>(configJsonData);
            return config;
        }

        public void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            String jsonString = JsonSerializer.Serialize(configJsonData, options);
            File.WriteAllText(ConfigFileName, jsonString);
        }
    }
}
