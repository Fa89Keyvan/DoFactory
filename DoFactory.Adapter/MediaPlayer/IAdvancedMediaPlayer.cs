using System;

namespace DoFactory.Adapter.MediaPlayer
{
    interface IAdvancedMediaPlayer
    {
        void PlayVlc(String fileName);
        void PlayMp4(String fileName);
    }
}
