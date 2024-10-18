
using System.Text.Json.Serialization;

namespace GenesisRossA6.Models;

/// <summary>
/// The Class Book
/// </summary>
public class Book
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    [JsonPropertyName("Page Length")]
    public int PageLength { get; set; }
    public string? Genre { get; set; }
    [JsonPropertyName("Year Published")]
    public int YearPublished { get; set; }
    [JsonPropertyName("MSRP")]
    public decimal Msrp { get; set; }

}