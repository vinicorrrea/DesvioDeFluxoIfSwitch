using System;

namespace OperacoesCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comentario em linha (in-line)

            /*
                Comentario em bloco (in-block)
            */

            // Declaração da variavel peração, ela sera do tipo inteira -numeros inteiros- (int)
            int operacao;

            // Declaração das variaveis n1 e n2, elas seram do tipo double -numeros quebrados- (double)
            double n1, n2;

            // Para limpar a tela de comando a cada execução ultilizaremos o comando ( Console.Clear() )
            //OBS Clear significa limpar
            Console.Clear();

            //Para a exibição das opções de operação, vamos usar o comando ( Console.Writeline() ) e, nele usaremos um comando
            //de quebra de linha ( \n ), assim, as operações ficarão uma abaixo da outra.
            Console.WriteLine("Escolha uma das operações abaixo:");
            Console.WriteLine("1-Somar\n2-Subtrair\n3-Multiplicar\n4-Dividir");

            operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            n2 = double.Parse(Console.ReadLine());
            
















            



        }
    }
}
