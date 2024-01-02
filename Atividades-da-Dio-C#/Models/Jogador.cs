using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_da_Dio_C_.Models
{
    public class Jogador
    {
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador(string nome, string nacionalidade, int idade, string posicao)
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
        Idade = idade;
        Posicao = posicao;
    }

    public void NovoJogador()
    {
        Console.WriteLine("Jogador criado");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Nacionalidade: {Nacionalidade}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Posição: {Posicao}");
    }



    }
}