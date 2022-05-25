using System;
using System.Collections.Generic;

namespace jumper
{
    class Word
    {
        public void getNewWord()
        {
            var random = new Random();
            var list = new List<string> {"abuse", "brain", "dance", "layer"};
            int index = random.Next(list.Count);
            Console.WriteLine(list[index]);
        }
    }
}