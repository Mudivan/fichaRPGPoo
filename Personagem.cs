namespace fichaRpg
{
    internal class Personagem
    {
        //Identifi~cação 
        public string Nome { get; set; }
        public string Classe { get; set; }

        //Atributos da Ficha
        public int Forca { get; set; }
        public int Habilidade { get; set; }
        public int Resistencia { get; set; }
        public int Armadura { get; set; }
        public int PoderDeFogo { get; set; }


        //Recursos
        public int PontosDeVida {  get; set; }
        public int PontosDeMagia { get; set; }

        //Outros
        public List<string> MagiasConhecidas { get; set; }
        public List<string> Vantagens {  get; set; }
        public List<string> Desvantagens { get; set; }
        public List<string> Itens {  get; set; }

        //Metódos
        public void Atacar()
        {
            Console.WriteLine($"{Nome} atacou com seu {Itens[0]}!");
        }

        public void Defender()
        {
            Console.WriteLine($"{Nome} se defendeu com Armadura {Armadura}!");
        }

        public void LançarMagia(string magia)
        {
            if (MagiasConhecidas.Contains(magia) && PontosDeMagia > 0)
            {
                PontosDeMagia -= 1; // Gasta 1 PM
                Console.WriteLine($"{Nome} lançou a magia {magia}!");
            }
            else
            {
                Console.WriteLine($"{Nome} tentou lançar {magia}, mas falhou!");
            }
        }


    }
}
