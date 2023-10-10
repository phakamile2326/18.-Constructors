using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructors
{
    internal class book
    {
        public string title;
        public string author;
        public int pages;

        //this method below is callaed a constructor, it is called by default when a book
        public book(string title, string author, int pages)
        {
            title = "aTitle";
            author = "aAuthor";
            pages = 200;
        }
    }
}
