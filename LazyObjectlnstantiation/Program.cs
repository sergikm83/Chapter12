using System;
using LazyObjectlnstantiation.Classes;

namespace LazyObjectlnstantiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lazy Instantiation *****\n");
            // Память под объект AllTracks здесь не выделяется!
            MediaPlayer myPlayer = new MediaPlayer();
            myPlayer.Play();
            // Размещение объекта AllTracks происходит
            // только в случае вызыва метода GetAllTracks().
            MediaPlayer yourPlayer = new MediaPlayer();
            AllTracks yourMusic = yourPlayer.GetAllTracks();
        }
    }
}
