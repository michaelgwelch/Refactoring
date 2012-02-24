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
            get { return Movie.GetCharge(DaysRented); }
        }

        public int FrequentRenterPoints
        {
            get { return Movie.GetFrequentRenterPoints(DaysRented); }
        }
    }


}

