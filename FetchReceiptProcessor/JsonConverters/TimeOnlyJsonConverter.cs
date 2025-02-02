using System.Text.Json;
using System.Text.Json.Serialization;

namespace FetchReceiptProcessor.JsonConverters
{
	public class TimeOnlyJsonConverter: JsonConverter<TimeOnly>
	{
		public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var stringValue = reader.GetString();
			TimeOnly result;
			TimeOnly.TryParse(stringValue, out result);
			return result;
		}

		public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToString());
		}
	}
}
