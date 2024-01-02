using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_da_Dio_C_.Models
{
    public class PersonagemSubclasse
    {
    public string Nome { get; set; }
    public int Mana { get; set; }

    public PersonagemSubclasse(string nome, int mana)
    {
        Nome = nome;
        Mana = mana;
    }

    }
}