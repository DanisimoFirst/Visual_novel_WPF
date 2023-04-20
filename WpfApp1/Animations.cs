using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
 



namespace WpfApp1
{
    class Animations
    {
        public GameWindow ОписываетАнимацию
        {
            get => default;
            set
            {
            }
        }

        public static DoubleAnimation animationCloseUpperEyelid( )
        {   
            DoubleAnimation animationUpperEyelid = new DoubleAnimation();
            animationUpperEyelid.From = 0;
            animationUpperEyelid.To = 540;
            animationUpperEyelid.Duration = TimeSpan.FromSeconds(0.2);
            return animationUpperEyelid;     
        }

        public static DoubleAnimation animationOpenUpperEyelid()
        {
            DoubleAnimation animationUpperEyelid = new DoubleAnimation();
            animationUpperEyelid.From = 540;
            animationUpperEyelid.To = 0;
            animationUpperEyelid.Duration = TimeSpan.FromSeconds(0.2);
            return animationUpperEyelid;
        }

        public static DoubleAnimation animationCloseDownEyelid()
        {
            DoubleAnimation animationDownEyelid = new DoubleAnimation();
            animationDownEyelid.From = 0;
            animationDownEyelid.To = 540;
            animationDownEyelid.Duration = TimeSpan.FromSeconds(0.2);
            return animationDownEyelid;
        }

        public static DoubleAnimation animationOpenDownEyelid()
        {
            DoubleAnimation animationDownEyelid = new DoubleAnimation();
            animationDownEyelid.From = 540;
            animationDownEyelid.To = 0;
            animationDownEyelid.Duration = TimeSpan.FromSeconds(0.2);
            return animationDownEyelid;
        }

    }
}
