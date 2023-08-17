using Atividade;
using System;
using static Atividade.Aluno;


//Instânciar Aluno

// Aluno a = new Aluno();
// a.nota1 = 7;
// a.nota2 = 6;
// a.nota3 = 5;
// a.nota4 =  7.5;

using System.Globalization;
using System.Net.Mime;



using System;

namespace Atividade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
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
