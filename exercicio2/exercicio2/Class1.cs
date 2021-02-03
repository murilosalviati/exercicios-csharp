using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio2
{
    class Elevador
    {
        int andarAtual = 0;
        int totalAndares = 10;
        int capacidadeMaxima = 7;
        int capacidadeAtual = 0;

        public int ocupacao(int entrar)
        {
            if (capacidadeAtual + entrar <= capacidadeMaxima)
            {
                capacidadeAtual = capacidadeAtual + entrar;
                return capacidadeAtual;
            }
            else
            {
                return -1;
            }
        }

        public int subir(int s)
        {
            if (andarAtual + s <= totalAndares)
            {
                andarAtual = andarAtual + s;
                return andarAtual;
            }
            else
            {
                return -1;
            }

        }


        public int descer(int d)
        {

            if (andarAtual - d < 0)
            {
                andarAtual = andarAtual - d;
                return andarAtual;
            }
            else
            {
                return -1;
            }
        }


        public int sair(int s)
        {
            if (capacidadeAtual - s >= 0)
            {
                capacidadeAtual = capacidadeAtual - s;
                return capacidadeAtual;
            }
            else
            {
                return -1;
            }
        }
    }
}
