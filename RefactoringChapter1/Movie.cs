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
            PriceCode = priceCode;
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

        public double GetCharge(int daysRented)
        {

            double result = 0;
            switch (PriceCode)
            {
                case Regular:
                    result += 2;
                    if (daysRented > 2)
                    {
                        result += (daysRented - 2) * 1.5;
                    }
                    break;

                case NewRelease:
                    result += daysRented * 3;
                    break;

                case Childrens:
                    result += 1.5;
                    if (daysRented > 3)
                    {
                        result += (daysRented - 3) * 1.5;
                    }
                    break;

            }
            return result;

        }

        public int GetFrequentRenterPoints(int daysRented)
        {
            return (PriceCode == NewRelease &&
                    daysRented > 1)
                       ? 2
                       : 1;
        }

    }
}

