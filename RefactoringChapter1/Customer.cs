using System.Linq;
using System.Collections.Generic;

namespace RefactoringChapter1
{
    public class Customer
    {
        private string _name;
        private List<Rental> _rentals = new List<Rental>();

        public Customer(string name)
        {
            _name = name;
        }

        public void AddRental(Rental rental)
        {
            _rentals.Add(rental);
        }

        public string Name
        {
            get { return _name; }
        }

        public string Statement()
        {
            string result = "Rental Record for " + Name + "\n";

            // determine ammounts for each line
            result += _rentals.Aggregate("", (lines, rental) => lines +
                                          "\t" + rental.Movie.Title +
                                          "\t" + rental.Charge + "\n");

            // add footer lines
            result += "Amount owed is " + TotalCharge + "\n";
            result += "You earned " + TotalFrequentRenterPoints + " frequent renter points";
            return result;



        }

        public string HtmlStatement()
        {
            string result = "<H1>Rentals for <EM>" + Name + "</EM></H1><P>\n";

            // add all lines
            result += _rentals.Aggregate("", (lines, rental) =>
                                        lines + rental.Movie.Title + ": " +
                                        rental.Charge + "<BR>\n");

            // add footer lines
            result += "<P>You owe <EM>" + TotalCharge + "</EM><P>\n";
            result += "On this rental you earned <EM>" + TotalFrequentRenterPoints +
                "</EM> frequent renter points<P>";
            return result;
        }

        private double TotalCharge
        {
            get
            {

                return _rentals.Sum(rental => rental.Charge);

            }
        }

        private int TotalFrequentRenterPoints
        {
            get
            {
                return _rentals.Sum(rental => rental.FrequentRenterPoints);
            }
        }

    }
}

