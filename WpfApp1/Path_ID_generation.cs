

namespace WpfApp1 
{
    public static class Path_ID_generation
    {

        public static string ResultPath_B1_GPV()
        {
            string PIDB;
            double firstButtID = GameWindow.ID / 3.5;
            PIDB = @"resourses\B_GPV\" + firstButtID + ".txt";
            return PIDB;
        }

        public static string ResultPath_B2_GPV()
        {
            string PIDB;
            double secondButtID = GameWindow.ID +50;
            PIDB = @"resourses\B_GPV\" + secondButtID + ".txt";
            return PIDB;
        }

        public static string ResultPath_S_GPV()
        {
            string PIDS;
            PIDS = @"resourses\S_GPV\" + GameWindow.ID + ".txt";
            return PIDS;
        }


    }
}
