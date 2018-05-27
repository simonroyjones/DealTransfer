using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealTransfer
{
    public class gv
    {
        public static string LiveConnStr = "server=CAM-SQL02; database=Moriarty_Live;integrated security=SSPI";
        public static string DevConnStr = "server=CAM-SQL02; database=Moriarty_Dev;integrated security=SSPI";
        public static string inputFileName;
        public static bool OKFlag;
        public static string clipboardData;
    }
}
