using FetchReceiptProcessor.Models;

namespace FetchReceiptProcessor.Services
{
	/// <summary>
	/// Local storage service that saves to a Dictionary
	/// </summary>
	public class LocalStorageService : IStorageService
	{
		private Dictionary<string, Receipt> ReceiptStore = new Dictionary<string, Receipt>();
		public Receipt? GetReceipt(string id)
		{
			if (ReceiptStore.ContainsKey(id)) return ReceiptStore[id];
			else return null;
		}

		public void StoreReceipt(string Id, Receipt receipt)
		{
			if (ReceiptStore.ContainsKey (Id)) { return; }
			ReceiptStore.Add(Id, receipt);
			return;
		}
	}
}
