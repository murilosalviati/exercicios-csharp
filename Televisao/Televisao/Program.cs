using System;

namespace Televisao
{
    class Program
    {
        static void Main(string[] args)
        {
            var controleRemoto = new controleRemoto();
            int canalAtual = 1;
            int volumeAtual = 50;
            Boolean ligado = true;

            while (ligado == true)
            {
                Console.WriteLine("Digite 1 para controlar o volume, ou 2 para controlar o canal");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite 1 para aumentar o volume, 2 para diminuir o volume, 3 para setar um volume");
                        int opcaoVolume = int.Parse(Console.ReadLine());
                        switch (opcaoVolume)
                        {
                            case 1:
                                Console.WriteLine("Digite 1 para aumentar o volume em uma unidade, ou 2 para aumentar em um valor");
                                int opcaoVolumeInterna = int.Parse(Console.ReadLine());
                                if (opcaoVolumeInterna == 1)
                                {
                                    volumeAtual = controleRemoto.aumentarCanalUnidade(volumeAtual);
                                }
                                else
                                {
                                    Console.WriteLine("Digite em quanto você quer aumentar o volume");
                                    int aumento = int.Parse(Console.ReadLine());
                                    volumeAtual = controleRemoto.aumentarVolume(volumeAtual, aumento);
                                }

                                break;

                            case 2:
                                Console.WriteLine("Digite 1 para diminuir o volume em uma unidade, ou 2 para diminuir em um valor");
                                int diminuir = int.Parse(Console.ReadLine());
                                volumeAtual = controleRemoto.diminuirVolume(volumeAtual, diminuir);

                                break;

                            case 3:
                                Console.WriteLine("Digite o volume desejado");
                                int setar = int.Parse(Console.ReadLine());
                                volumeAtual = controleRemoto.setarVolume(volumeAtual, setar);

                                break;
                        }


                        break;
                    case 2:
                        Console.WriteLine("Digite 1 para aumentar o canal, 2 para diminuir o canal, 3 para setar um canal");
                        int opcaoCanalInterna = int.Parse(Console.ReadLine());
                        switch (opcaoCanalInterna)
                        {
                            case 1:
                                Console.WriteLine("Digite 1 para aumentar em uma unidade, ou 2 para aumentar em quantidade");
                                int aumentar = int.Parse(Console.ReadLine());
                                if (aumentar == 1)
                                {
                                    canalAtual = controleRemoto.aumentarCanalUnidade(canalAtual);
                                }
                                else
                                {
                                    Console.WriteLine("Em quantos canais você quer aumentar?");
                                    int aumento = int.Parse(Console.ReadLine());
                                    canalAtual = controleRemoto.aumentarCanal(canalAtual, aumento);
                                }
                                break;


                            case 2:
                                Console.WriteLine("Digite 1 para diminuir em uma unidade, ou 2 para diminuir em quantidade");
                                int diminuir = int.Parse(Console.ReadLine());
                                if (diminuir == 1)
                                {
                                    canalAtual = controleRemoto.diminuirCanalUnidade(canalAtual);
                                }
                                else
                                {
                                    Console.WriteLine("Em quantos canais você quer diminuir?");
                                    int diminuicao = int.Parse(Console.ReadLine());
                                    canalAtual = controleRemoto.diminuirCanal(canalAtual, diminuicao);
                                }
                                break;


                            case 3:
                                Console.WriteLine("Em qual canal você quer colocar?");
                                int setar = int.Parse(Console.ReadLine());
                                canalAtual = controleRemoto.setarCanal(canalAtual, setar);
                                break;

                        }


                        break;
                }

                Console.WriteLine("Você está no canal " + canalAtual + ", e com o volume em " + volumeAtual);
                Console.WriteLine("Se você deseja continuar mexendo na tv, digite 1. Se quiser desligar a tv, digite 2.");
                int continuar = int.Parse(Console.ReadLine());
                if (continuar == 2)
                {
                    ligado = false;
                }
            }

        }


    }
}
