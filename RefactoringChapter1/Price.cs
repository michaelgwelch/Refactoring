namespace RefactoringChapter1
{
    public abstract class Price
    {
        public abstract int PriceCode { get; }

        public abstract double GetCharge(int daysRented);

        public virtual int GetFrequentRenterPoints(int daysRented)
        {
            return 1;
        }

    }

    public class ChildrensPrice : Price
    {
        public override int PriceCode
        {
            get { return Movie.Childrens; }
        }
        public override double GetCharge(int daysRented)
        {
            double result = 1.5;
            if (daysRented > 3)
            {
                result += (daysRented - 3) * 1.5;
            }
            return result;
        }

    }

    public class NewReleasePrice : Price
    {
        public override int PriceCode
        {
            get { return Movie.NewRelease; }
        }

        public override double GetCharge(int daysRented)
        {
            return daysRented * 3;
        }

        public override int GetFrequentRenterPoints(int daysRented)
        {
            return 2;
        }

    }

    public class RegularPrice : Price
    {
        public override int PriceCode
        {
            get { return Movie.Regular; }
        }

        public override double GetCharge(int daysRented)
        {
            double result = 2;
            if (daysRented > 2)
            {
                result += (daysRented - 2) * 1.5;
            }
            return result;
        }
    }
}
