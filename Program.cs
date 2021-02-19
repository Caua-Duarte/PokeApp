using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogo_Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int resp = 100;
            while (resp != 0)
            {

                resp = Menu();
                if ( resp == 1)
                {
                    pokedex.ListarPokemons();
                    Console.ReadKey();
                    Console.Clear();
                }
                if ( resp == 2)
                {
                    pokedex.ListarPokemons();
                    Console.Write("Digite o código do pókemon: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    
                    // pegar pokemon do player

                    PokemonPlus pPlayer = pokedex.Pokemons[codigo];
                    
                    // pegar pokemon do pc

                    Random r = new Random();
                    codigo = r.Next (0, pokedex.Pokemons.Count);
                    PokemonPlus pPC = pokedex.Pokemons[codigo];
                    
                    // batalha
                    
                    if (pPlayer.Poder >= pPC.Poder)
                    {
                        Console.Clear();
                        Console.WriteLine(" ");                        
                        Console.WriteLine("Dados do seu pokemon: ");     
                        pPlayer.ExibirDadosPokemonPlus();                   
                        Console.WriteLine("Dados do pokemon selvagem: ");
                        pPC.ExibirDadosPokemonPlus();                        
                        Console.WriteLine(" ");                        
                        Console.WriteLine ("PARABÊNS, VOCÊ GANHOU!!!");
                        Console.WriteLine(" ");    
                    }
                    else
                    {   
                        Console.Clear();
                        Console.WriteLine(" ");                        
                        Console.WriteLine("Dados do seu pokemon: ");     
                        pPlayer.ExibirDadosPokemonPlus();                   
                        Console.WriteLine("Dados do pokemon selvagem: ");
                        pPC.ExibirDadosPokemonPlus(); 
                        Console.WriteLine(" ");
                        Console.WriteLine ("QUE PENA, VOCE PERDEU!!!");
                        Console.WriteLine(" ");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        static int Menu()
        {

            Console.WriteLine("*****************************");
            Console.WriteLine("APP-POKEMON----Battle Game!!!");
            Console.WriteLine("*****************************");
            Console.WriteLine(" ");
            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine(" ");
            Console.WriteLine("0 - Sair do PokeApp");
            Console.WriteLine("1 - Listar todos os Pokemons da pokedex");
            Console.WriteLine("2 - Batalhar");
            Console.WriteLine(" ");
            Console.Write ("Made your choice: ");
            Console.Write(" ");

            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;

        }

    }
}
