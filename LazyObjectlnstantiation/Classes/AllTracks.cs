using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjectlnstantiation.Classes
{
    class AllTracks
    {
        // Наш проигрыватель может содержать
        // максимум 10 000 композиций.
        private Song[] allSongs = new Song[10000];
        public AllTracks()
        {
            // Предположим, что здесь выполняется
            // заполнение массива объектов Song.
            Console.WriteLine("Filling up the songs!");
        }
    }
}
