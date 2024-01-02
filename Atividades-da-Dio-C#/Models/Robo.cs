using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_da_Dio_C_.Models
{
    public class Robo
    {
    public int VelocidadeAtual { get; set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }

        public Robo(int vmin, int vmax)
    {
        VelocidadeMinima = vmin;
        VelocidadeMaxima = vmax;
        VelocidadeAtual = vmin;
    }

        public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        }
    }

        public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        }
    }

    public int Comandos(string comandos)
    {
        for(int i = 0; i < comandos.Length; i++)
        {
            if(comandos[i] == 'A')
            {
                Acelerar();
            }

            else if(comandos[i] == 'D')
            {
                Desacelerar();
            }
        }
        return VelocidadeAtual;
    }

    }

}