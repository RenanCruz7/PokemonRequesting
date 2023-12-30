using System.Text.Json;
using System.Text.Json.Serialization;
namespace PokemonRequesting.Modelos;

internal class Pokemon
{
    [JsonPropertyName("name")] //Anotação
    public string? Nome { get; set; }

    [JsonPropertyName("types")]
    public List<TipoPokemon>? Tipos { get; set; }

    public static List<Pokemon> PokemonsCapturados { get; } = new List<Pokemon>();

    // Método para adicionar um Pokémon à lista
    public void AdicionarPokemonCapturado()
    {
        PokemonsCapturados.Add(this);
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        if (Tipos != null)
        {
            Console.Write("Tipos: ");
            foreach (var tipo in Tipos)
            {
                Console.Write($"{tipo.DetalhesTipo?.Tipo} ");
            }
            Console.WriteLine();
        }
    }
    public static void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(PokemonsCapturados);
        string nomeDoArquivo = $"Pokemon-Kanto.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Arquivo criado com sucesso");
    }

}
