using System.Text.Json;
using System.Text.Json.Serialization;


namespace GasPoint.Infrastructure.Converters
{
    public class DateConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if(reader.TokenType == JsonTokenType.Null)
            {
                return DateTime.MinValue;
            }
            return reader.GetDateTime();
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(DateTime) == typeToConvert;
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
