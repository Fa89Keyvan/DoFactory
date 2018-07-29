using System.Diagnostics;

namespace DoFactory.Adapter.MediaPlayer
{
    class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Debug.WriteLine($"Playing vlc file. Name: {fileName}");
        }

        public void PlayVlc(string fileName)
        {
            return;
        }
    }
}
