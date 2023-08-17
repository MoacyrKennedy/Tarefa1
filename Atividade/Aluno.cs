using System.Globalization;
using System.Net.Mime;

namespace Atividade;

public class Aluno
{
    //Atributos
    public double nota1, nota2, nota3, nota4;
    
    
    //Cálculo da Média
    public double Media()
    {
        return (nota1 + nota2 + nota3 + nota4) / 4;
    }
    //Situação
    public string Avaliacao(double media)
    {
        String retorno;
        //Condicional
        if(media <4.9)
        {
            retorno = "Infelizmente você foi reprovado";
        }

         if (media >= 5 && media <= 6.9)
        {
            retorno = "Você está em Recuperação";
        }
        else 
        {
            retorno = "Parabéns você foi Aprovado!";
        }
        return retorno;
    }
    public void mensagem()
    {
        //Obter o cálculo
        double obterCalculo = Media();

        //Obter situação
        string obterSituacao = Avaliacao(obterCalculo);

        //Exibir mensagem
        Console.WriteLine("Sua média "+obterCalculo);
        Console.WriteLine("Sua média"+obterSituacao);
        Console.WriteLine("Sua média "+obterCalculo);
        Console.WriteLine("Sua média "+obterCalculo);
        Console.WriteLine("Sua média "+obterCalculo);
    }
}