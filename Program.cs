using System;
using Primeiro;
using CSharp;
using Interface;
using Enum;

namespace CSharp
{

    
        class Program
        {
        
         static void Main(string[] args)
        {
            var     pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Julia;
            Pessoas pessoa3 = (Pessoas)4


             Animal animal = new Animal();

             animal.Nome = "Rex";
             animal.NomeDono = "Jason";
             animal.Especie = "Cachorro";

             Pessoa person = new Pessoa();

             person.Nome = "Nathan";
             person.Idade = 20;
             person.Estado = "Pernambuco";

             var person2 = new Pessoa();

             person2.Nome = "João";
             person2.Idade = 23;
             person2.Estado = "São Paulo";

             var classe = new Classe();
             var Classe2 = new Segundo.Classe();

             Console.WriteLine(pessoa3);
        }
    }
}

