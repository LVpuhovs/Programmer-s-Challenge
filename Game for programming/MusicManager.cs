using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Game_for_programming
{
    public static class MusicManager
    {
        private static WindowsMediaPlayer player;
        private static string[] playlist;
        private static int currentid = 0;
        private static Random random = new Random();

        public static void initialize(string musicFolder)
        {
            playlist = Directory.GetFiles(musicFolder, "*.mp3");
            if (playlist.Length == 0)
                return;

            Shuffle(playlist);

            player = new WindowsMediaPlayer {
                settings = {volume = 40}
            };
            
            player.settings.setMode("loop", false);
            player.PlayStateChange += OnEnd;
            Play();
        }

        
        private static void Shuffle(string[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }

        private static void Play()
        {
            player.URL = playlist[currentid];
            player.controls.play();
        }

        private static void OnEnd(int state)
        {
            if((WMPPlayState)state == WMPPlayState.wmppsMediaEnded || (WMPPlayState)state == WMPPlayState.wmppsStopped)
            {
                Task.Delay(50).ContinueWith(t =>
                {
                    currentid = (currentid + 1) % playlist.Length;
                    if (currentid == 0)
                        Shuffle(playlist);
                    Play();
                });
                
            }
        }

        public static void SetVolume(int v) => player.settings.volume = v;
    }
}
