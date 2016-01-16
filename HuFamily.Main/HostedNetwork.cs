/* 
       HuFamily Software Router Toolkit - Wireless Configurator
       Microsoft NetSh Wrapper for .NET/Mono 
       For Windows 7 or Windows Server 2008r2 English Edition only,
       DUE TO SOME ISSUES ON REGEX-RELATED VARIABLES, DO NOT TRY IT ON CHINESE PLATFORM!!!
       IT WILL NOT WORK AT ALL!!!

       由于部分正则表达式原因，本程序不适用于中文系统。

       By Jackson Ming Hu @ RMIT University, Melbourne, Australia.

*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuFamily.Main
{
    public class HostedNetwork
    {
        public static string[] GetHostedWirelessStatus()
        {
            /*
                It will generate this kind of output:

                Hosted network settings
                -----------------------
                    Mode                   : Allowed
                    SSID name              : "hu-test"
                    Max number of clients  : 100
                    Authentication         : WPA2-Personal
                    Cipher                 : CCMP

                Hosted network status
                ---------------------
                    Status                 : Started
                    BSSID                  : 00:00:00:00:00:00
                    Radio type             : 802.11ac
                    Channel                : 9
                    Number of clients      : 2
                        00:ff:ff:ff:ff:ff        Authenticated
                        01:ff:ff:ff:ff:ff        Authenticated
            */

            string optResult = RunNetsh("wlan show hostednetwork");
            string[] status = optResult.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            string[] lineResult = { string.Empty }, finalResult = new string[1000];

            for (int i = 0; i < status.Length; i++)
            {
                string lineStr = status[i];

                if (lineStr.Contains("Mode"))
                {
                    lineResult = lineStr.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    finalResult[0] = lineResult[1];
                }
                else if (lineStr.Contains("SSID name"))
                {
                    lineResult = lineStr.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    lineResult[1].Replace("\"", ""); // Remove quotation mark
                    finalResult[1] = lineResult[1];
                }
                else if (lineStr.Contains("Max number of clients"))
                {
                    lineResult = lineStr.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    finalResult[2] = lineResult[1];
                }
                else if (lineStr.Contains("Authentication"))
                {
                    lineResult = lineStr.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    finalResult[3] = lineResult[1];
                }
                else if (lineStr.Contains("Cipher"))
                {
                    lineResult = lineStr.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    finalResult[4] = lineResult[1];
                }
                else if (lineStr.Contains(@"Status                 :"))
                {
                    lineResult = lineStr.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    finalResult[5] = lineResult[1];
                }
                else if (lineStr.Contains("BSSID"))
                {
                    lineResult = lineStr.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    finalResult[6] = lineResult[1];
                }
                else if (lineStr.Contains("Radio type"))
                {
                    lineResult = lineStr.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    finalResult[7] = lineResult[1];
                }
                else if (lineStr.Contains("Channel"))
                {
                    lineResult = lineStr.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    finalResult[8] = lineResult[1];
                }
                else if (lineStr.Contains("Number of clients "))
                {
                    lineResult = lineStr.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    finalResult[9] = lineResult[1];
                }
                else if (lineStr.Contains("Authenticated"))
                {
                    int clientCount = 0;
                    lineResult = lineStr.Split(new string[] { "        " }, StringSplitOptions.RemoveEmptyEntries);
                    lineResult[0].Replace(" ", ""); // Remove quotation mark
                    finalResult[10 + clientCount] = lineResult[0];
                    clientCount++;
                }

            }

            return finalResult;

        }

        public static string SetHostedNetwork(string ssid, string password)
        {
            string result = string.Empty;
            if(password != "")
            {
               result = RunNetsh(
                "wlan set hostednetwork mode=allow" +
                " ssid=" + ssid +
                " key=" + password
                );
            }
            else
            {
                result = RunNetsh(
                "wlan set hostednetwork mode=allow" +
                " ssid=" + ssid 
                );
            }
            return result;
        }

        public static string SetStatus(bool enable)
        {
            string result = string.Empty;
            if(enable)
            {
                result = RunNetsh("wlan start hostednetwork");
            }
            else
            {
                result = RunNetsh("wlan stop hostednetwork");
            }
            return result;
        }
        

        public static string RunNetsh(string args)
        {
            Process netshProcess = new Process();
            netshProcess.StartInfo.UseShellExecute = false;
            netshProcess.StartInfo.RedirectStandardOutput = true;
            netshProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            netshProcess.StartInfo.FileName = "netsh";
            netshProcess.StartInfo.Arguments = args;
            netshProcess.Start();
            string netshOpt = netshProcess.StandardOutput.ReadToEnd();
            netshProcess.WaitForExit();
            return netshOpt;
        }
    }
}
