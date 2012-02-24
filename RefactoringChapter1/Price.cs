namespace RefactoringChapter1
{
    public abstract class Price
    {
        public abstract int PriceCode { get; }
    }

    public class ChildrensPrice : Price
    {
        public override int PriceCode
        {
            get { return Movie.Childrens; }
        }
    }

    public class NewReleasePrice : Price
    {
        public override int PriceCode
        {
            get { return Movie.NewRelease; }
        }
    }

    public class RegularPrice : Price
    {
        public override int PriceCode
        {
            get { return Movie.Regular; }
        }
    }
}
