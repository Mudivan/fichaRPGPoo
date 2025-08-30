using fichaRpg;

class Program
{
    static void Main()
    {
        Personagem heroi = new Personagem
        {
            Nome = "Kratos",
            Classe = "Guerreiro",
            Forca = 3,
            Habilidade = 2,
            Resistencia = 4,
            Armadura = 1,
            PoderDeFogo = 0,
            PontosDeVida = 20,
            PontosDeMagia = 5,
            MagiasConhecidas = new List<string> { "Cura", "Bola de fogo" },
            Vantagens = new List<string> { "Ataque Preciso" },
            Desvantagens = new List<string> { "Medo de Altura" },
            Itens = new List<string> { "Machado Barbáro", "Escudo" }
        };

        heroi.Atacar();
        heroi.Defender();
        heroi.LançarMagia("cura");
    }

}