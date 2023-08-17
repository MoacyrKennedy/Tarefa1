using Atividade;
using System;
using static Atividade.Aluno;
using System.Globalization;
using System.Net.Mime;


namespace Atividade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (double i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Entre com as notas do Aluno {i}:");
                double nota1 = Convert.ToDouble(Console.ReadLine());
                double nota2 = Convert.ToDouble(Console.ReadLine());
                double nota3 = Convert.ToDouble(Console.ReadLine());
                double nota4 = Convert.ToDouble(Console.ReadLine());

                Aluno aluno = new Aluno();
                aluno.nota1 = nota1;
                aluno.nota2 = nota2;
                aluno.nota3 = nota3;
                aluno.nota4 = nota4;

                aluno.mensagem();
                Console.WriteLine();
            }
        }
    }
}
