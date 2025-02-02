using FetchReceiptProcessor.JsonConverters;
using System.Text.Json.Serialization;

namespace FetchReceiptProcessor.Models
{
	/// <summary>
	/// One item in a receipt
	/// </summary>
	public class ReceiptItem
	{
		public string? shortDescription { get; set; }
		[JsonConverter(typeof(DecimalJsonConverter))]
		public decimal price { get; set; }
	}
}
