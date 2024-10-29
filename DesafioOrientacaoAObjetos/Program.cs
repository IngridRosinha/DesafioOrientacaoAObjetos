Episodio ep1 = new(3, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Ingrid");
ep1.AdicionarConvidados("Hugo");


Episodio ep2 = new(2, "Técnicas de aprendizado", 65);
ep2.AdicionarConvidados("Ingrid");
ep2.AdicionarConvidados("Ana");
ep2.AdicionarConvidados("Lucas");

Podcast podcast = new("Podcast new", "IngridR");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();


/*Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();*/
