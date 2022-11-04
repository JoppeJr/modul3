namespace Repitisjon
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string _title, string _author, int _pages)
        {
            title = _title;
            author = _author;
            pages = _pages;
        }

        public bool IsLong()
        {
            if (pages >= 400)
            {
                return true;
            }

            return false;
        }
    }
}