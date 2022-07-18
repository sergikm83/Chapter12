using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjectlnstantiation.Classes
{
    // Объект MediaPlayer имеет объекты AllTracks.
    class MediaPlayer
    {
        // Предположим, что эти методы делают что-то полезное.
        public void Play() { }
        public void Pause() { }
        public void Stop() { }
        private Lazy<AllTracks> allSongs = new Lazy<AllTracks>();
        public AllTracks GetAllTracks()
        {
            // вернуть все композиции.
            return allSongs.Value;
        }
    }
}
