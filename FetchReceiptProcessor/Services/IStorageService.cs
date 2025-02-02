using FetchReceiptProcessor.Models;

namespace FetchReceiptProcessor.Services
{
	/// <summary>
	/// Interface to interact with storage
	/// </summary>
	public interface IStorageService
	{
		public Receipt? GetReceipt(string id);
		public void StoreReceipt(string Id, Receipt receipt);
	}
}
