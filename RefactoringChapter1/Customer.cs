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
				double thisAmount = 0;
				
				switch (rental.Movie.PriceCode) 
				{
				case Movie.Regular:
					thisAmount += 2;
					if (rental.DaysRented > 2) {
						thisAmount += (rental.DaysRented - 2) * 1.5;
					}
					break;
					
				case Movie.NewRelease:
					thisAmount += rental.DaysRented * 3;
					break;
					
				case Movie.Childrens:
					thisAmount += 1.5;
					if (rental.DaysRented > 3) {
						thisAmount += (rental.DaysRented - 3) * 1.5;
					}
					break;
						
				}
				
				// add frequent renter points
				frequentRenterPoints++;
			
				// add bonus for a two day new release rental
				if (rental.Movie.PriceCode == Movie.NewRelease &&
				    rental.DaysRented > 1)
				{
					frequentRenterPoints++;
				}
				
				// show figures for this rental
				result += "\t" + rental.Movie.Title + "\t" +
					thisAmount + "\n";
				
				totalAmount += thisAmount;
			}
			
			// add footer lines
			result += "Amount owed is " + totalAmount + "\n";
			result += "You earned " + frequentRenterPoints + " frequent renter points";
			return result;
			

			
		}
	}
}

