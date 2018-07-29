namespace DoFactory.Adapter.MediaPlayer
{
    class MediaAdapter : IMediaPlayer
    {
        IAdvancedMediaPlayer _advancedMediaPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.ToLower().Equals("vlc"))
                _advancedMediaPlayer = new VlcPlayer();
            if (audioType.ToLower().Equals("mp4"))
                _advancedMediaPlayer = new Mp4Player();
        }

        public void Play(string fileName)
        {
            if (_advancedMediaPlayer.GetType() == typeof(VlcPlayer))
                _advancedMediaPlayer.PlayVlc(fileName);
            if (_advancedMediaPlayer.GetType() == typeof(Mp4Player))
                _advancedMediaPlayer.PlayMp4(fileName);
        }
    }
}