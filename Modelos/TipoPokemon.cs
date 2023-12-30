using System.Text.Json.Serialization;

namespace PokemonRequesting.Modelos;

internal class TipoPokemon
{
    [JsonPropertyName("type")]
    public TipoDetalhes? DetalhesTipo { get; set; }
}
