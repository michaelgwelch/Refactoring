namespace RefactoringChapter1
{
    public class Movie
    {
        public const int Childrens = 2;
        public const int Regular = 0;
        public const int NewRelease = 1;

        private string _title;
        private int _priceCode;

        public Movie(string title, int priceCode)
        {
            _title = title;
            _priceCode = priceCode;
        }

        public int PriceCode
        {
            get { return _priceCode; }
            set { _priceCode = value; }
        }

        public string Title
        {
            get { return _title; }
        }


    }
}

