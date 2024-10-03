using System;

class Program
{
    static void Main(string[] args)
    {
        //solicita o usuario o peso em kg
        Console.WriteLine("Digite seu peso (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        //solicita o usuario a altura em metros
        Console.Write("digite sua altura (m): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        //calcula o IMC: peso dividido pela altura ao quadrado
        double imc = peso / (altura * altura);

        //exibe o resultado do IMC
        Console.WriteLine("Seu IMC é: " + imc);

        //classifica o imc com base no valor
        if(imc < 18.5)
        {
            Console.WriteLine("Vc está abaixo do peso.");
        }

        else if(imc >= 18.5 && imc < 24.9)
        {
            Console.WriteLine("Seu peso está normal.");
        }
        else if(imc >= 25 && imc < 29.9)
        {
            Console.WriteLine("vc está acima do peso.");
        }
        else
        {
            Console.WriteLine("vc está obeso.");
        }

        Console.ReadKey();
    }
}