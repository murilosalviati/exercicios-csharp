using System;
using System.Collections.Generic;
using System.Text;

namespace Televisao
{
    class controleRemoto
    {

        public int consultaVolume(int volumeAtual)
        {
            return volumeAtual;
        }

        public int aumentarVolumeUnidade(int volumeAtual)
        {
            if (volumeAtual + 1 <= 100)
            {
                return volumeAtual = volumeAtual + 1;
            }
            else
            {
                return 100;
            }

        }

        public int diminuirVolumeUnidade(int volumeAtual)
        {
            if (volumeAtual - 1 >= 0)
            {
                return volumeAtual = volumeAtual - 1;
            }
            else
            {
                return 0;
            }
        }

        public int aumentarVolume(int volumeAtual, int aumento)
        {
            if (volumeAtual + aumento <= 100)
            {
                return volumeAtual = volumeAtual + aumento;
            }
            else
            {
                return 100;
            }
        }

        public int diminuirVolume(int volumeAtual, int diminuir)
        {
            if (volumeAtual - diminuir >= 0)
            {
                return volumeAtual = volumeAtual - diminuir;
            }
            else
            {
                return 0;
            }
        }

        public int setarVolume(int volumeAtual, int setar)
        {
            if (setar >= 0 && setar <= 100)
            {
                return volumeAtual = setar;
            }
            else
            {
                return volumeAtual;
            }
        }

        public int consultaCanal(int canalAtual)
        {
            return canalAtual;
        }

        public int aumentarCanalUnidade(int canalAtual)
        {
            return canalAtual = canalAtual + 1;
        }

        public int diminuirCanalUnidade(int canalAtual)
        {
            if (canalAtual > 1)
            {
                return canalAtual = canalAtual - 1;
            }
            else
            {
                return 1;
            }

        }

        public int aumentarCanal(int canalAtual, int aumentar)
        {
            return canalAtual = canalAtual + aumentar;
        }

        public int diminuirCanal(int canalAtual, int diminuir)
        {
            if (canalAtual - diminuir >= 1)
            {
                return canalAtual = canalAtual - diminuir;
            }
            else
            {
                return 1;
            }
        }

        public int setarCanal(int canalAtual, int setar)
        {
            if (setar >= 1)
            {
                return canalAtual = setar;
            }
            else
            {
                return 1;
            }
        }

    }
}
