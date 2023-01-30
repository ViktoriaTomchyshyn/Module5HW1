using Newtonsoft.Json;

namespace Module5HW1.Dtos;

public class UserDto
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; } = null!;

    [JsonProperty("first_name")]
    public string FirstName { get; set; }

    [JsonProperty("last_name")]
    public string LastName { get; set; }

    [JsonProperty("avatar")]
    public string UrlAvatar { get; set; }
}