namespace FetchReceiptProcessor.Models
{
	/// <summary>
	/// Model of the result returned by the /receipts/process route
	/// </summary>
	public class ProcessResult
	{
		public string id { get; set; }

		public ProcessResult()
		{
			id = Guid.NewGuid().ToString();
		}
	}
}
