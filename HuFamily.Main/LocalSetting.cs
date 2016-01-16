using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace HuFamily.Main
{
    public class LocalSetting
    {
        public class Setting
        {
            public string SSID { get; set; }  
            public string Password { get; set; } 
            public bool Enable { get; set; }  
            public bool AutoStart { get; set; }  

            public Setting()
            {
                SSID = "";
                Password = "";
                Enable = true;
                AutoStart = true;
            }
        }

        public static void WriteSetting(string ssid, string password = "", bool enable = true, bool autostart = true)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            jsonSerializer.NullValueHandling = NullValueHandling.Include;
            Setting setting = new Setting();
            setting.SSID = ssid;
            setting.Password = password;
            setting.Enable = enable;
            setting.AutoStart = autostart;
            Directory.CreateDirectory(Environment.CurrentDirectory + @"\settings");

            using (StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + @"\settings\hufamily.wireless.conf"))
            using (JsonWriter jsonWriter = new JsonTextWriter(writer))
            {
                jsonSerializer.Serialize(jsonWriter, setting);
                writer.Dispose();
            }
        }

        public static string[] ReadSetting()
        {
            string[] settingSend = new string[10];
            string jsonContent = File.ReadAllText(Environment.CurrentDirectory + @"\settings\hufamily.wireless.conf");
            Setting setting = JsonConvert.DeserializeObject<Setting>(jsonContent);
            settingSend[0] = setting.SSID;
            settingSend[1] = setting.Password;
            settingSend[2] = setting.Enable.ToString();
            settingSend[3] = setting.AutoStart.ToString();
            return settingSend;
        }
    }
}
