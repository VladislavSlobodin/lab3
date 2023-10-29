using System;
using System.Runtime.CompilerServices;

namespace lab3_2
{
    [Serializable]
    public class Book
    {
        public Guid Guid { get; private set; }
        public string Name { get; private set; }
        public string Author { get; private set; }
        public string Description { get; private set; }

        public Book(string name, string author, string description)
        {
            Guid = Guid.NewGuid();
            Name = name;
            Author = author;
            Description = description;
        }
    }
}
