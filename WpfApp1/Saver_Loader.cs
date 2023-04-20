using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public  class Saver_Loader
    {
        public static string Save_Path = @"saves\save.txt";

        public MainWindow ЗагружаетСохроненнуюЧастьМеняяIDВGameWindow
        {
            get => default;
            set
            {
            }
        }

        public GameWindow СохраняетСюжетПриВыходеИзИгры
        {
            get => default;
            set
            {
            }
        }

        public static void Saver()
        {
            string NeedSave = Convert.ToString(GameWindow.ID);
            using (StreamWriter sw = new StreamWriter(Save_Path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(NeedSave);
                sw.Close();
            }
            
        }
        static public double Loader()
        {
            double Loaded_ID;
            try
            {
                using (StreamReader sr = new StreamReader(Save_Path))
                {
                    string Loaded_Id = sr.ReadToEnd();
                    Loaded_ID = Convert.ToDouble(Loaded_Id);
                    sr.Close();
                    return Loaded_ID;




                }
            } catch { return Loaded_ID = 0; }
          

            
        }
        static public bool Checker()
        {
            bool checker;

            if (Loader() == null || Loader() == 0)
            {
                checker = false;
                return checker;
            }
            else
            {
               return checker = true;
            }
        }
        static public void Killer()
        {
                GameWindow.ID = 1000;
                File.Delete(Save_Path);    
        }
    }
}
