using System;

namespace RefactoringChapter1
{
    public class Movie
    {
        public const int Childrens = 2;
        public const int Regular = 0;
        public const int NewRelease = 1;

        private string _title;
        private Price _price;

        public Movie(string title, int priceCode)
        {
            _title = title;
            PriceCode = priceCode;
        }

        public int PriceCode
        {
            get { return _price.PriceCode; }
            set {
                switch (value)
                {
                    case Regular:
                        _price = new RegularPrice();
                        break;

                    case Childrens:
                        _price = new ChildrensPrice();
                        break;

                    case NewRelease:
                        _price = new NewReleasePrice();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException("value","Incorrect price code");


                }
            }
        }

        public string Title
        {
            get { return _title; }
        }

        public double GetCharge(int daysRented)
        {
            return _price.GetCharge(daysRented);
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

