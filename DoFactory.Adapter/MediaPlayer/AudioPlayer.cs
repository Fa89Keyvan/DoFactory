using System.Diagnostics;
using System.Linq;

namespace DoFactory.Adapter.MediaPlayer
{
    class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter _mediaAdapter;
        private string   _audioType;
        private string[] _vlcTypes = new string[] { "vlc", "mp4" };

        public AudioPlayer(string audioType)
        {
            _audioType = audioType;
        }

        public void Play(string fileName)
        {
            if (_audioType.ToLower().Equals("mp3"))
                Debug.WriteLine($"Playing mp3 file. Name: {fileName}");
            else if (_vlcTypes.Contains(_audioType))
            {
                _mediaAdapter = new MediaAdapter(_audioType);
                _mediaAdapter.Play(fileName);
            }
            else
                Debug.WriteLine($"Invalid media {_audioType} format not supported");
        }
    }
}
