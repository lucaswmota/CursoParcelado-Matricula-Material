using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoMatriculaMaterial
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                
                // valor do curso

                Console.WriteLine("Informe o valor TOTAL do curso: ");
                double curso = double.Parse(Console.ReadLine());

                while (curso <= 0)
                {
                    Console.WriteLine("Informe um valor maior do que 0 (Zero)" +
                        "\nTente Novamente.");
                    Console.WriteLine("Informe o valor TOTAL do curso: ");
                    curso = double.Parse(Console.ReadLine());
                }

                // quantidade de parcelas

                Console.WriteLine("Em quantas Parcelas você quer dividir o valor total?");
                int quantidadeParcelas = int.Parse(Console.ReadLine());

                while (quantidadeParcelas < 1)
                {
                    Console.WriteLine("A quantidade de parcelas não pode ser menor do que 1 (um)");
                    Console.WriteLine("Em quantas vezes você quer dividir o valor total?");
                    quantidadeParcelas = int.Parse(Console.ReadLine());
                }

                double valorParcela = curso / quantidadeParcelas;

                // Valor do Material
                
                Console.WriteLine("Informe um valor ou digite 0 caso não houver custo com material:");
                double material = double.Parse(Console.ReadLine());

                while (material < 0)
                {
                    Console.WriteLine("O Valor não pode ser menor do que 0 (Zero).");
                    Console.WriteLine("Informe um valor ou digite 0 caso não houver custo com material:" +
                        "\nTente Novamente.");
                    material = material = double.Parse(Console.ReadLine());
                }

                // Valor da Matricula

                
                Console.WriteLine("Informe um valor ou digite 0 caso não houver custo com Matricula:");
                double matricula = double.Parse(Console.ReadLine());

                while (matricula < 0)
                {
                    Console.WriteLine("O Valor não pode ser menor do que 0 (Zero)" +
                        "\nTente novamente.");
                    Console.WriteLine("Informe um valor ou digite 0 caso não houver custo com Matricula:");
                    matricula = double.Parse(Console.ReadLine());
                }

                // Processamento

                double primeiraParcela = valorParcela + matricula + material;

                // Saida

                Console.WriteLine("Curso Dividido em " + quantidadeParcelas + " Parcela(s)" +
                    "\nValor da Primeira Parcela (Incluindo Matricula e Material): " + primeiraParcela.ToString("C") +
                    "\nValor das Parcelas restantes (" + (quantidadeParcelas - 1) + "x) de " + valorParcela.ToString("C"));
                
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Insira apenas numeros." +
                    "\nPrograma Encerrado.");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
