using System.Diagnostics;

namespace DoFactory.Adapter.MediaPlayer
{
    class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Debug.WriteLine($"Playing mp4 file. Name: {fileName}");
        }

        public void PlayVlc(string fileName)
        {
            return;
        }
    }
}
