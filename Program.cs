using PokemonRequesting.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    for (int i = 1; i < 150; i++)
    {
        try
        {
            string resposta = await client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{i}/");
            var pokemon = JsonSerializer.Deserialize<Pokemon>(resposta)!;
            //pokemon.ExibirInformacoes();

            // Adiciona o Pokémon à lista
            pokemon.AdicionarPokemonCapturado();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // Gera o arquivo JSON no final do loop
    Pokemon.GerarArquivoJson();
}
