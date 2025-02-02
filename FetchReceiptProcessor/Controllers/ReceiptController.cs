using FetchReceiptProcessor.Models;
using FetchReceiptProcessor.Services;
using Microsoft.AspNetCore.Mvc;

namespace FetchReceiptProcessor.Controllers
{
	/// <summary>
	/// Receipt controller
	/// Presumably the /receipts/process and /receipts/id/points routes should be in their own controllers, 
	/// but for this small exercise where there's just one POST and GET, just put them both here. 
	/// </summary>
	[ApiController]
	public class ReceiptController : ControllerBase
	{
		private readonly IStorageService _storageService;
		public ReceiptController(IStorageService storageService)
		{
			_storageService = storageService;
		}

		[HttpPost]
		[Route("receipts/process")]
		public IActionResult Post(Receipt receipt)
		{
			ProcessResult result = new();
			_storageService.StoreReceipt(result.id, receipt);
			return Ok(result);
		}

		[HttpGet]
		[Route("receipts/{id}/points")]
		public IActionResult Get(string id)
		{
			Receipt? receipt = _storageService.GetReceipt(id);
			if (receipt == null) { return NotFound("No receipt found for that ID"); }
			PointsResult result = new(receipt);
			return Ok(result);
		}
	}
}
