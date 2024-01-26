using System.Text.Json.Serialization;
public class Pony
{
    [JsonPropertyName("id")]
    public int Id {get;set;}

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("kind")]
    public List<string> Kind { get; set; }

    [JsonPropertyName("occupation")]
    public string Occupation { get; set; }

    [JsonPropertyName("alias")]
    public string Alias { get; set; }

    [JsonPropertyName("season")]
    public string Season { get; set; }
}

