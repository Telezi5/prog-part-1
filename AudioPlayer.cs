using System;
using System.Media;

namespace Prog_part_1.Services
{
    public class AudioPlayer
    {
        public void Greetings()
        {
            try
            {
                string path = @"Assets\welcome.wav"; // correct relative path
                SoundPlayer player = new SoundPlayer(path);

                player.Load();   // ensure the file is loaded before playing
                player.Play();   // or use PlaySync() if you want it to wait
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error playing sound: {e.Message}");
            }
        }
    }
}