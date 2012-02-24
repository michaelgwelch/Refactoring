namespace RefactoringChapter1
{
    public class Rental
    {
        private Movie _movie;
        private int _daysRented;

        public Rental(Movie movie, int daysRented)
        {
            _movie = movie;
            _daysRented = daysRented;
        }

        public int DaysRented
        {
            get { return _daysRented; }
        }

        public Movie Movie
        {
            get { return _movie; }
        }

        public double Charge
        {
            get
            {
                double result = 0;
                switch (Movie.PriceCode)
                {
                    case Movie.Regular:
                        result += 2;
                        if (DaysRented > 2)
                        {
                            result += (DaysRented - 2) * 1.5;
                        }
                        break;

                    case Movie.NewRelease:
                        result += DaysRented * 3;
                        break;

                    case Movie.Childrens:
                        result += 1.5;
                        if (DaysRented > 3)
                        {
                            result += (DaysRented - 3) * 1.5;
                        }
                        break;

                }
                return result;
            }
        }

        public int FrequentRenterPoints
        {
            get
            {

                return (Movie.PriceCode == Movie.NewRelease &&
                    DaysRented > 1) ? 2 : 1;

            }
        }
    }


}

