using System;

namespace ConsoleApp10
{
    internal class one
    {
        private static void Main(string[] args)
        {
            //cria uma matriz com o tamanho desejado
            Console.WriteLine("Digite um número:");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            //recebe a sequência de números sendo identificados de forma diferente através do split.
            Console.WriteLine("Digite a sequência:");
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                //matriz recebe os valores adicionados
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            //demonstra a matriz diagonal
            Console.WriteLine("Diagonal principal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            //pula uma linha para visuais.
            Console.WriteLine();
            //declara variável count
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //encontra todos números negativos e adiciona à conta.
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            //mostra a quantidade de números negativos
            Console.WriteLine("Números negativos: ");
            Console.WriteLine(count);
        }
    }
}