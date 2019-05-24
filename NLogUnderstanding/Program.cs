using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogUnderstanding
{
    class Program
    {
        public static readonly Logger logger = LogManager.GetLogger("logapi");

        static void Main(string[] args)
        {
            try
            {
                int a = 0;
                int b = 2 / a;
            }
            catch (Exception ex)
            {
                
                GlobalDiagnosticsContext.Set("personalaccount", "636030134");
                GlobalDiagnosticsContext.Set("urlapi", "_getuserinfo");
                GlobalDiagnosticsContext.Set("StatusCode", "Error");
                GlobalDiagnosticsContext.Set("Success", "false");
                GlobalDiagnosticsContext.Set("ip", "195.88.27.140");
                GlobalDiagnosticsContext.Set("response", ex.Message);
                logger.Info("");
            }
            //Logger logger = LogManager.GetLogger("logapi");


            //logger.Info("log");

        }
    }
}
