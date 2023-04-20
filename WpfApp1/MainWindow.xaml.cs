using System;

using System.Windows;

using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

   
        

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Audio.PlayerForMainMenu_Play();
            Button_Continue.IsEnabled = Saver_Loader.Checker();
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        public void Button_Continue_Click(object sender, RoutedEventArgs e)
        {
            Audio.PlayerForMainMenu_Stop();
            GameWindow window1 = new GameWindow();
            GameWindow.ID = Saver_Loader.Loader();
            window1.Background = GrapicsChanger.GrapicChanger();
            window1.Label_Chapter.Text = PlotClass.PlotConverter();
            window1.button_One.Content = ButtonChoiseClass.ButtonContentConverter();
            window1.Button_Two.Content = ButtonChoiseClass.ButtonContentConverter1();
            window1.Show();


            this.Close();
        }

        private void Button_NewGame_Click(object sender, RoutedEventArgs e)
        {
            Saver_Loader.Killer();
            Audio.PlayerForMainMenu_Stop();
            GameWindow window1 = new GameWindow();
         //   window1.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\IDS\C#\IDSgame\WpfApp1\WpfApp1\resourses\Graphics\1000.jpg")));
            window1.Label_Chapter.Text = PlotClass.PlotConverter();
            window1.button_One.Content = ButtonChoiseClass.ButtonContentConverter();
            window1.Button_Two.Content = ButtonChoiseClass.ButtonContentConverter1();
            window1.Show();
            this.Close();
        }

        private void Button_Settings_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            this.Close();
        }
    }
}
// диаграмма классов