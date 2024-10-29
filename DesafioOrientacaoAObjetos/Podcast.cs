//nome, host, total de episodios, ja nasce com o objeto tipo podcast

class Podcast
{
    private List<Episodio> episodios = new(); //sera inicializado por isso string vazia
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }//apenas vamos receber os valores da propriedade
    public string Host { get; }

    public int TotalEpisodios=> episodios.Count; //contagem da lista

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host} \n");
        foreach(var episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n Este Podcast possui {TotalEpisodios} episódios.");
    }
}