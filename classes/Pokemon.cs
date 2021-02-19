using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogo_Pokemon
{
    public class Pokemon
    {
        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }
        public Pokemon(string nome, string descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }
        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set 
            { 
                string texto = value;
                this.nome = texto; 
            }
        }

        private string descricao;
        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
        
        
        public void ExibirDadosPokemon()
        {

            Console.WriteLine (" ");
            Console.WriteLine ("Nome do Pokémon: " + this.Nome);
            Console.WriteLine ("Descrição do Pokémon: " + this.Descricao);
            Console.WriteLine (" ");
        }
       
        public void ExibirDadosPokemon(Boolean formatado)
        {       
            if (formatado == true)
            {
                Console.WriteLine ("Pokémon " + this.Nome + " " + this.Descricao);
            }
            else
            {
                Console.WriteLine ("Nome do Pokémon: " + this.Nome);
                Console.WriteLine ("Descrição do Pokémon: " + this.Descricao);
            }
        }
    }
}