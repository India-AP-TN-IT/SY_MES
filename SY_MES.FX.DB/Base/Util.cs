using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SY_MES.FX.DB.Base
{
    public class Util
    {

        public static string GetRealIP(string httpAddress)
        {
            string ip = httpAddress.ToLower().Replace("http://", "").Replace("https://", "");
            ip = ip.Split(':')[0];
            ip = ip.Split('/')[0];
            if (ip.Split('.').Length == 4)
            {
                return ip;
            }
            else
            {
                var host = System.Net.Dns.GetHostEntry(ip);
                foreach (var ipV4 in host.AddressList)
                {
                    if (ipV4.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        return ipV4.ToString();
                    }
                }
            }
            throw new Exception("Wrong IP:" + httpAddress);
        }
        public static bool WriteTxtLog(string log, string writeDIR = ".\\DB_LOG")
        {
            bool bRet = true;
            try
            {

                if (!System.IO.Directory.Exists(writeDIR))
                {
                    System.IO.Directory.CreateDirectory(writeDIR);
                }
                string tagetFile = writeDIR + "\\"
                        + System.DateTime.Today.ToString("yyyyMMdd") + ".txt";

                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(tagetFile, true))
                {
                    sw.WriteLine(DateTime.Now + "\t" + log);
                }


            }
            catch (Exception eLog)
            {
                System.Diagnostics.Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
                bRet = false;
            }

            return bRet;
        }

        
    }
}
