

namespace WpfApp1
{
 public   class EndOfGameChecker
    {
        public GameWindow ПроверяетНеЗакончилсяЛиСюжет
        {
            get => default;
            set
            {
            }
        }

        public static bool endOfGameCheckerF(double S_GPV) 
        {
            bool endOfGame = false;

            if (S_GPV == 1100 || S_GPV == 285.7142857142857)
            {
                return endOfGame = true;
            }
            else return endOfGame = false;
            
        }

    }
}
