using System;
using Primeiro;
using CSharp;
using Interface;

namespace CSharp
{

    
        class Program
        {
        
         static void Main(string[] args)
        {
            Pessoa person = new Pessoa();

            person.Nome = "Nattan";
            person.Idade = 20;
            person.Estado = "Pernambuco";

            var person2 = new Pessoa();

            person2.Nome = "João";
            person2.Idade = 23;
            person2.Estado = "São Paulo";

           Animal animal = new Animal();

           animal.Nome = "Rex";
           animal.NomeDono = "Jason";
           animal.Especie = "Cachorro";

            var animal = new Animal();

            var classe = new Classe();
            var Classe2 = new Segundo.Classe();

            Console.WriteLine("Hello World!");
        }
    }
}
