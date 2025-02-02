namespace FetchReceiptProcessor.Models
{
	/// <summary>
	/// Model of the result returned by the /receipts/{id}/points route
	/// Calculates how many points a given receipt is worth
	/// </summary>
	public class PointsResult
	{
		private int _points;
		public int points => _points;
		public PointsResult(Receipt receipt) 
		{
			foreach(char c in receipt.retailer)
			{
				if (char.IsLetterOrDigit(c)) { _points += 1; }
			}

			if ((int)receipt.total == receipt.total) { _points += 50; }

			if (receipt.total % (decimal)0.25 == 0) { _points += 25; }

			if (receipt.items != null) { _points += 5 * (receipt.items.Count() / 2); }

			foreach(ReceiptItem item in receipt.items)
			{
				string trimmedDescipription = new string(item.shortDescription.Trim().Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == '-').ToArray());
				if (trimmedDescipription.Length % 3 == 0)
				{
					_points += (int)Math.Ceiling(item.price * (decimal).2);
				}
			}

			if (receipt.purchaseDate.Day % 2 == 1) { _points += 6; }

			if (receipt.purchaseTime.IsBetween(new TimeOnly(14, 0), new TimeOnly(16, 0))) { _points += 10; }
		}
	}
}
