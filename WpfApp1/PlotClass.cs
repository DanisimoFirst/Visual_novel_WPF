
using System.IO;
using System.Text;


namespace WpfApp1
{
    class PlotClass
    {
        public static string plot { get; set; }

       

        public static string PlotConverter()
        {
            string streamreaderPath = Path_ID_generation.ResultPath_S_GPV();
            StreamReader SR = new StreamReader(streamreaderPath, Encoding.UTF8);
            plot = null;
            plot = SR.ReadToEnd();
            SR.Close();
            return plot;
        }
    }
}
