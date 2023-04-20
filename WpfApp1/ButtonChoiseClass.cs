using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class ButtonChoiseClass
    {
        public static string Button1Content { get; set; }
        public static string Button2Content { get; set; }

        public static string ButtonContentConverter()
        {
            string streamreaderPath = Path_ID_generation.ResultPath_B1_GPV();
            StreamReader SR = new StreamReader(streamreaderPath, Encoding.UTF8);
            return Button1Content = SR.ReadToEnd();
        }
        public static string ButtonContentConverter1()
        {
            string streamreaderPath1 = Path_ID_generation.ResultPath_B2_GPV();
            StreamReader SR1 = new StreamReader(streamreaderPath1, Encoding.UTF8);
            return Button2Content = SR1.ReadToEnd();
        }        
    }
}
