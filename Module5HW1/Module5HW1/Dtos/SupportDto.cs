using Newtonsoft.Json;

namespace Module5HW1.Dtos;

public class SupportDto
{
    [JsonProperty("url")]
    public string Url { get; set; } = null!;

    [JsonProperty("text")]
    public string Text { get; set; } = null!;
}