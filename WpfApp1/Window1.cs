using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Media.Animation;

namespace WpfApp1
{


    public partial class GameWindow : Window
    {

    
        public static double ID = 1000;
       

        public GameWindow()
        {
            InitializeComponent();
            Audio.GameAudioPlayed();
        }

       

        private void ExitToMenu_Click(object sender, RoutedEventArgs e)
        {
            Saver_Loader.Saver();
            Audio.GameAudioStop();
            MainWindow MenuWindow = new MainWindow();
            MenuWindow.Show();
            this.Close();
            
        }

        private void button_One_Click(object sender, RoutedEventArgs e)
        {
            ID = ID / 3.5;
            endOfGameChecker(EndOfGameChecker.endOfGameCheckerF(GameWindow.ID));
            AnimationsEyelidStarter();
            
            Audio.GameAudioReloaded();
            Background = GrapicsChanger.GrapicChanger(); 
            Label_Chapter.Text = PlotClass.PlotConverter();
            button_One.Content = ButtonChoiseClass.ButtonContentConverter();
            Button_Two.Content = ButtonChoiseClass.ButtonContentConverter1();


        }

        private void button_Two_Click(object sender, RoutedEventArgs e)
        {
            ID = ID + 50;
            endOfGameChecker(EndOfGameChecker.endOfGameCheckerF(GameWindow.ID));
            AnimationsEyelidStarter();
            Audio.GameAudioReloaded();
            Background = GrapicsChanger.GrapicChanger();
            Label_Chapter.Text = PlotClass.PlotConverter();
            button_One.Content = ButtonChoiseClass.ButtonContentConverter();
            Button_Two.Content = ButtonChoiseClass.ButtonContentConverter1();
        }


        public void AnimationsEyelidStarter()
        {
            LabelUpperEyelid.BeginAnimation(HeightProperty, Animations.animationCloseUpperEyelid());
            LabelDownEyelid.BeginAnimation(HeightProperty, Animations.animationCloseDownEyelid());
            LabelUpperEyelid.BeginAnimation(HeightProperty, Animations.animationOpenUpperEyelid());
            LabelDownEyelid.BeginAnimation(HeightProperty, Animations.animationOpenDownEyelid());
        }

        public void endOfGameChecker(bool EOG)
        {
            if(EOG == true)
            {
                Audio.GameAudioStop();
                Audio.GameAudioDispose();
                MainWindow MenuWindow = new MainWindow();
                MenuWindow.Show();
                this.Close();
            }
        }

    }
}
