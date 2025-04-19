using System.Text.Json;
using System.Text.Json.Serialization;
using ShapesProject.Domain.Shapes;

namespace ShapeProject.Application.Services;

public class ShapeConverter : JsonConverter<Shape>
{
    public override Shape? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var jsonDocument = JsonDocument.ParseValue(ref reader);
        var jsonObject = jsonDocument.RootElement;

        var type = jsonObject.GetProperty("Type").GetString();

        return type switch
        {
            nameof(Circle) => JsonSerializer.Deserialize<Circle>(jsonObject.GetRawText(), options),
            nameof(RectangleShape) => JsonSerializer.Deserialize<RectangleShape>(jsonObject.GetRawText(), options),
            nameof(Parallelogram) => JsonSerializer.Deserialize<Parallelogram>(jsonObject.GetRawText(), options),
            nameof(Rhombus) => JsonSerializer.Deserialize<Rhombus>(jsonObject.GetRawText(), options),
            nameof(Trapezoid) => JsonSerializer.Deserialize<Trapezoid>(jsonObject.GetRawText(), options),
            nameof(Triangle) => JsonSerializer.Deserialize<Triangle>(jsonObject.GetRawText(), options),
            _ => throw new NotSupportedException($"Shape type {type} is not supported.")
        };
    }
    
    public override void Write(Utf8JsonWriter writer, Shape value, JsonSerializerOptions options)
    {
        var type = value.GetType().Name;
        writer.WriteStartObject();
        writer.WriteString("Type", type);

        var json = JsonSerializer.Serialize(value, value.GetType(), options);
        using var jsonDocument = JsonDocument.Parse(json);
        
        var objectEnumerator = jsonDocument.RootElement.EnumerateObject();
        foreach (var property in objectEnumerator)
        {
            property.WriteTo(writer);
        }

        writer.WriteEndObject();
    }
}