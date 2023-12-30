using System.Text.Json.Serialization;
namespace PokemonRequesting.Modelos;

internal class TipoDetalhes
{
    [JsonPropertyName("name")]
    public string? Tipo { get; set; }
}
