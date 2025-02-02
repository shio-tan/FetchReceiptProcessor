using System.Text.Json;
using System.Text.Json.Serialization;

namespace FetchReceiptProcessor.JsonConverters
{
	public class DecimalJsonConverter: JsonConverter<decimal>
	{
		public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var stringValue = reader.GetString();
			decimal result;
			decimal.TryParse(stringValue, out result);
			return result;
		}

		public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToString());
		}
	}
}
