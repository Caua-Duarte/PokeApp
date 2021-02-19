using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pooJogo_Pokemon
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
        }
        private List<PokemonPlus> pokemons;
        public List<PokemonPlus> Pokemons
        {
            get { return this.pokemons; }
        }
        private void InicializaLista()
        {
            // istanciar a lista
            this.pokemons = new List<PokemonPlus>();
            PokemonPlus p = new PokemonPlus("Pikachu", "Tipo eletrico", 120);
            this.pokemons.Add(p);
            p = new PokemonPlus("Bulbassauro", "Tipo folha", 90);
            this.pokemons.Add(p); 
            p = new PokemonPlus("Charmander", "Tipo fogo", 110);
            this.pokemons.Add(p); 
            p = new PokemonPlus("Squirtul", "Tipo agua", 100);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mewtwo", "Tipo psiquico", 900);
            this.pokemons.Add(p);
        }

        public void ListarPokemons()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                Console.WriteLine("Código do pókemon: " + i);
                this.Pokemons[i].ExibirDadosPokemon();
            }
        }
    }
}