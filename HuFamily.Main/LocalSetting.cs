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

            using (StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + @"\hufamily.wireless.conf"))
            using (JsonWriter jsonWriter = new JsonTextWriter(writer))
            {
                jsonSerializer.Serialize(jsonWriter, setting);
            }
        }

        public static string[] ReadSetting()
        {
            string[] setting = { string.Empty };

        }
    }
}
