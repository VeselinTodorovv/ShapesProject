using System.Text.Json;
using System.Text.Json.Serialization;
using ShapesProject.Domain.Shapes;

namespace ShapeProject.Application.Services;

public class CustomShapeConverter : JsonConverter<Shape>
{

    public override Shape? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var jsonDocument = JsonDocument.ParseValue(ref reader);
        var jsonObject = jsonDocument.RootElement;

        // Determine the type of shape from the "Type" property
        var type = jsonObject.GetProperty("Type").GetString();

        return type switch
        {
            "Circle" => JsonSerializer.Deserialize<Circle>(jsonObject.GetRawText(), options),
            "RectangleShape" => JsonSerializer.Deserialize<RectangleShape>(jsonObject.GetRawText(), options),
            _ => throw new NotSupportedException($"Shape type {type} is not supported.")
        };
    }
    
    public override void Write(Utf8JsonWriter writer, Shape value, JsonSerializerOptions options)
    {
        // Write the "Type" property to distinguish the shape type
        var type = value.GetType().Name;
        writer.WriteStartObject();
        writer.WriteString("Type", type);

        // Write the shape-specific properties
        var json = JsonSerializer.Serialize(value, value.GetType(), options);
        using var jsonDocument = JsonDocument.Parse(json);
        foreach (var property in jsonDocument.RootElement.EnumerateObject())
        {
            property.WriteTo(writer);
        }

        writer.WriteEndObject();
    }
}