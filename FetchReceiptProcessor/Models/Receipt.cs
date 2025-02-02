using FetchReceiptProcessor.JsonConverters;
using System.Text.Json.Serialization;

namespace FetchReceiptProcessor.Models
{
	/// <summary>
	/// Receipt model
	/// </summary>
	public class Receipt
	{
		public string retailer { get; set; }
		public DateOnly purchaseDate { get; set; }
		[JsonConverter(typeof(TimeOnlyJsonConverter))]
		public TimeOnly purchaseTime { get; set; }
		public IEnumerable<ReceiptItem>? items { get; set; }
		[JsonConverter(typeof(DecimalJsonConverter))]
		public decimal total { get; set; }
	}
}
