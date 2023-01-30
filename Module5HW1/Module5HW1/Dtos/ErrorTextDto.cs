using Newtonsoft.Json;

namespace Module5HW1.Dtos;
public class ErrorTextDto
{
    [JsonProperty("error")]
    public string ErrorBody { get; set; }
}
