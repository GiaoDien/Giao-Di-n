using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expLog
{
    class Program
    {
        //Coppy dòng này cho tất cả các log
       // private static readonly log4net.ILog log =
      //     log4net.LogManager.GetLogger(
        //    System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
       private static readonly ILog log =
       LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            log.Info("cùi bap");

            try
            {
                string s = "abc";
                int i = int.Parse(s);
            }
            catch (Exception ex)
            {
                log.Debug(ex);
            }

            log.Info("Nhom nhu quan");
        }
    }
}
