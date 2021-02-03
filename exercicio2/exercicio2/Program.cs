using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            var elevador = new Elevador();

            Console.WriteLine("Quantas pessoas vão entrar no elevador?");
            int entrar = int.Parse(Console.ReadLine());
            entrar = elevador.ocupacao(entrar);
            if (entrar > 0)
            {
                Console.WriteLine(entrar + " pessoas entraram no elevador");


                Console.WriteLine("Digite 1 para subir, 2 para descer, 3 para empinar e rebolar");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Quantos andares o elevador vai subir?");
                        int subir = int.Parse(Console.ReadLine());
                        subir = elevador.subir(subir);
                        if (subir >= 0)
                        {
                            Console.WriteLine("O elevador está no " + subir + "º andar");

                        }
                        else
                        {
                            Console.WriteLine("Andar inválido");
                        }

                        break;
                    case 2:
                        int descer = int.Parse(Console.ReadLine());
                        descer = elevador.descer(descer);
                        if (descer >= 0)
                        {
                            Console.WriteLine("O elevador está no " + descer + "º andar");
                        }
                        else
                        {
                            Console.WriteLine("Andar inválido");
                        }
                        break;
                    case 3:
                        Console.WriteLine("TODA BONITA TODA GOSTOSAAA");
                        break;

                }


                Console.WriteLine("Quantas pessoas vão sair do elevador?");
                int sair = int.Parse(Console.ReadLine());
                sair = elevador.sair(sair);
                Console.WriteLine("Tem " + sair + " pessoas no elevador");
            }
            else
            {
                Console.WriteLine("Vai dar não bambam");
            }

        }

    }
}
