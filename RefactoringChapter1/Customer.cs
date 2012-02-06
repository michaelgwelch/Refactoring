using System;
using System.Collections.Generic;

namespace RefactoringChapter1
{
	public class Customer
	{
		private string _name;
		private List<Rental> rentals = new List<Rental> ();
		
		public Customer (string name)
		{
			_name = name;
		}
		
		public void AddRental (Rental rental)
		{
			rentals.Add (rental);
		}
		
		public string Name {
			get { return _name; }
		}
		
		public string Statement ()
		{
			double totalAmount = 0;
			int frequentRenterPoints = 0;
			string result = "Rental Record for " + Name + "\n";
			
			// determine ammounts for each line
			foreach (Rental rental in rentals)
			{
				
				frequentRenterPoints += rental.FrequentRenterPoints;
				
				// show figures for this rental
				result += "\t" + rental.Movie.Title + "\t" +
					rental.Charge + "\n";
				
				totalAmount += rental.Charge;
			}
			
			// add footer lines
			result += "Amount owed is " + totalAmount + "\n";
			result += "You earned " + frequentRenterPoints + " frequent renter points";
			return result;
			

			
		}
		

	}
}

