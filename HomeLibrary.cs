using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace lab3_2
{
    [Serializable]
    public class HomeLibrary
    {
        private ArrayList _books;

        public List<Book> Books => _books.ToArray().Select(o => (Book)o).ToList();

        public HomeLibrary() => _books = new ArrayList();

        public void Add(Book book) => _books.Add(book);

        public void Remove(Book book) => _books.Remove(book);

        public void Edit(Book book, Book newBook)
        {
            _books.Remove(book);
            _books.Add(newBook);
        }

        public void Save(string path, IFormatter formatter)
        {
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(fileStream, this);
            }
        }

        public static HomeLibrary FromFile(string path, IFormatter formatter)
        {
            using (var fileStream = new FileStream(path, FileMode.Open))
            {
                return (HomeLibrary)formatter.Deserialize(fileStream);
            }
        }
    }
}
