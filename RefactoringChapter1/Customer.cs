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
			string result = "Rental Record for " + Name + "\n";
			
			// determine ammounts for each line
			foreach (Rental rental in rentals)
			{
				
				// show figures for this rental
				result += "\t" + rental.Movie.Title + "\t" +
					rental.Charge + "\n";
				
			}
			
			// add footer lines
			result += "Amount owed is " + TotalCharge + "\n";
			result += "You earned " + TotalFrequentRenterPoints + " frequent renter points";
			return result;
			

			
		}
		
		private double TotalCharge
		{
			get
			{
				double result = 0;
				foreach(Rental each in rentals)
				{
					result += each.Charge;
				}
				return result;
			}
		}
		
		private int TotalFrequentRenterPoints
		{
			get
			{
				int result = 0;
				foreach(Rental each in rentals)
				{
					result += each.FrequentRenterPoints;
				}
				return result;
			}
		}

	}
}

