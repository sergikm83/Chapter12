using System;
using LazyObjectlnstantiation.Classes;

namespace LazyObjectlnstantiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lazy Instantiation *****\n");
            // В этом вызывающем коде получение всех композиций не производится,
            // но косвенно все равно создаются 10 000 объектов!
            MediaPlayer myPlayer = new MediaPlayer();
            myPlayer.Play();
        }
    }
}
