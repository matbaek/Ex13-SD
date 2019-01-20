using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Books
    {
        int count = 0;
        private String[] books = new string[3];
        public Object GetBook(int id)
        {
            return books[id - 1];
        }
        public void AddBook(string name)
        {
            books[count] = name;
            count++;
        }

        public bool ExistBook(string name)
        {
            if(books.Contains(name))
            {
                return true;
            }
            return false;
        }
    }
}
