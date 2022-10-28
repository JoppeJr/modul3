using System;
using System.Collections.Generic;

namespace JokeGeneratorWMarEw
{
    public class Joke
    {
        
        public string Text { get; set; }
        public string Genre { get; set; }

        public Joke(string joke, string genre)
        {
            Text = joke;
            Genre = genre;
        }

        public void PrintJoke()
        {
            Console.WriteLine($"The joke: {Text} ");
      
        }
      
    }
}