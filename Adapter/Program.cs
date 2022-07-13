using System;
using System.Collections.Generic;

namespace Adapter
{
    interface IAudioFile
    {
        void Play();
    }

    class Mp3 : IAudioFile
    {
        public void Play()
        {
            Console.WriteLine("Mp3 is playing");
        }
    }

    class Wav : IAudioFile
    {
        public void Play()
        {
            Console.WriteLine("Wav is playing");
        }
    }

    class FLAC : IAudioFile
    {
        public void Play()
        {
            Console.WriteLine("FLAC is playing");
        }
    }


    // Nuget
    class OGG
    {
        public void PlaySomethingInteresting(bool repeat)
        {
            Console.WriteLine("Olalala");
            Console.WriteLine("Olalala");
        }
    }


    //// Object Adapter
    //class OggMp3Adapter : IAudioFile
    //{
    //    public OGG OGG { get; set; } = new OGG();

    //    public void Play()
    //    {
    //        // Convert
    //        OGG.PlaySomethingInteresting(false);
    //    }
    //}



    //// Class Adapter
    class OggMp3Adapter : OGG, IAudioFile
    {
        public void Play()
        {
            // Convert
            this.PlaySomethingInteresting(false);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}
