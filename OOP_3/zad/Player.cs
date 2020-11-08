using System;
using System.Collections.Generic;

namespace zad
{
    public class Player
    {
        public List<Song> list = new List<Song>();

        public void Add(Song song)
        {
            list.Add(song);
        }

        public void Remove(int index)
        {
            list.RemoveAt(index);
        }
    }
}
