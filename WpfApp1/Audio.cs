using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;



namespace WpfApp1
{
    public class Audio
    {
        // TODO ИСПРАВИТЬ БАГ С МЕНЮ (КОНЦОМ ИГРЫ)\

        public static string audioForMainMenuPath = @"resourses\Audio\MainMenu.wav";

        public static SoundPlayer playerForMainMenu = new SoundPlayer(audioForMainMenuPath);
        public static SoundPlayer playerForGame = new SoundPlayer(PathOfAudioConstructor());

        public MainWindow ОписываетАудиоДляГлавногоМеню
        {
            get => default;
            set
            {
            }
        }

        public GameWindow ОписываетАудиоДляИгры
        {
            get => default;
            set
            {
            }
        }

        public static void GameAudioPlayed()
        {
            playerForGame.Play();
        }
        public static void GameAudioReloaded()
        {
            playerForGame.Stop();
            playerForGame.Dispose();
            playerForGame.SoundLocation = PathOfAudioConstructor();
            playerForGame.Play();
        }
        public static void GameAudioStop()
        {
            playerForGame.Stop();
        }

        public static void GameAudioDispose()
        {
            playerForGame.Dispose();
        }
        public static void PlayerForMainMenu_Play()
        {
            playerForMainMenu.Play();

        }
        public static void PlayerForMainMenu_Stop()
        {
            playerForMainMenu.Stop();

        }
        public static string PathOfAudioConstructor()
        {
            string PathOFAudio;
            PathOFAudio = null;
            PathOFAudio = @"resourses\Audio\" + GameWindow.ID + ".wav";
            return PathOFAudio;
        }

    }

}
