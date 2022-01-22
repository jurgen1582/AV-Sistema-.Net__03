using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Respostas
{
    class Resposta2
    {
        static void Main(string[] args)
        {
            int idAluno;
            double n1 = 0.0;
            double n2 = 0.0;
            double n3 = 0.0;
            double peso1;
            double peso2;
            double peso3;

            do
            {
                Console.WriteLine("Insira o Código do Aluno, para sair digite 0: ");
                idAluno = int.Parse(Console.ReadLine());
                if (idAluno == 0)
                    break;
                Console.WriteLine("Insira a nota N1: ");
                n1 = double.Parse(Console.ReadLine().Replace('.', ','));
                Console.WriteLine("Insira a nota N2: ");
                n2 = double.Parse(Console.ReadLine().Replace('.', ','));
                Console.WriteLine("Insira a nota N3: ");
                n3 = double.Parse(Console.ReadLine().Replace('.', ','));

                if (n1 > n2 && n1 > n3)
                {
                    peso1 = n1;
                    peso2 = n2;
                    peso3 = n3;
                }
                else if (n2 > n3)
                {
                    peso1 = n2;
                    peso2 = n1;
                    peso3 = n3;
                }
                else
                {
                    peso1 = n3;
                    peso2 = n1;
                    peso3 = n2;
                }

                double mediaP = (peso1 * 4 + peso2 * 3 + peso3 *3) / (4 + 3 + 3);
                Console.WriteLine("Código do aluno: " + idAluno + ", " + "Nota1: " + n1 + ", " + "Nota2: " + n2 + ", " + "Nota3: " + n3 + ", " + "Média Poderada: " + mediaP);

                if (mediaP > 6.0)
                    Console.WriteLine("APROVADO!!");
                else
                    Console.WriteLine("REPROVADO!");

            } while (idAluno != 0);
        }
    }
}
