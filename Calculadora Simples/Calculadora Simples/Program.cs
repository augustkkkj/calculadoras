using System;

class Program
{
    //ponto de entrada principal da aplicação
    static void Main(string[] args)
    {
        //exibe uma mensagem para usuario
        Console.WriteLine("Calculadora Simples!");

        //Solicita o primeiro número ao usuário
        Console.WriteLine("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        //solicita o segundo número ao usuario
        Console.WriteLine("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        //Solicita o usuario a escolher operação
        Console.Write("Escolha uma operação (+, -, * e /): ");
        char operacao = Console.ReadLine()[0];


        //Declara uma variavel para armazernar o resultado
        double resultado = 0;

        //Verifica qual operação foi escolhida e executa a operação correspondente
        switch (operacao)
        {
            case '+':
                resultado = num1 + num2;
                break;

            case '-':
                resultado = num1 - num2;
                break;

            case '*':
                resultado = num1! * num2;
                break;

            case '/':
                resultado = num1 / num2;
                break;

            default:
                Console.WriteLine("Operação Invalida!");
                break;

        }

        //exibe o resultado da operação
        Console.WriteLine("O resultado é: " + resultado);

        //Mantém a janela abarta até que o usuário pressione uma tecla
        Console.ReadKey();
    }
}

