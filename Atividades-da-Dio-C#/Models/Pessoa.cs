using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_da_Dio_C_.Models
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string GetNome()
        {
            return Nome;
        }

        public int GetIdade()
        {
            return Idade;
        }

         public void apresentar()
    {
      Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }

    }
}