using System;

namespace Calculator;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu();

    }
    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Bem vindo ao Calculator! O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Potenciação");
        Console.WriteLine("6 - Raiz Quadrada");
        Console.WriteLine("0 - Sair");

        Console.WriteLine("-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|");
        Console.WriteLine("Selecione uma opção: ");
        short resultado = short.Parse(Console.ReadLine());

        switch (resultado)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: Potenciacao(); break;
            case 6: Radicializacao(); break;
            default: Finalizacao(); break;
        }
    }

    static void Soma()
    {
        // Para limpar o terminal antes de rodar
        Console.Clear();

        // Inserindo o primeiro valor
        Console.WriteLine("Insira o primeiro valor: ");
        double valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        // Inserindo o segundo valor 
        Console.WriteLine("Insira um segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());



        double resultado = valor1 + valor2;

        Console.WriteLine("O resultado da soma é: " + resultado);
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {

        Console.Clear();

        Console.WriteLine("Insira o primeiro valor: ");
        double valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        // Inserindo o segundo valor 
        Console.WriteLine("Insira um segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = valor1 - valor2;
        Console.WriteLine($"O resultado da subtração é: {resultado}");
        Console.ReadKey();
        Menu();

    }

    static void Divisao()
    {

        Console.Clear();

        Console.WriteLine("Insira o primeiro valor");
        double valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        // Inserindo o segundo valor 
        Console.WriteLine("Insira um segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = valor1 / valor2;
        Console.WriteLine($"O resultado da subtração é: {resultado}");
        Console.ReadKey();
        Menu();

    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("Insira o primeiro valor: ");
        double valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine("Insira o segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = valor1 * valor2;
        Console.WriteLine($"Seu resultado é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Finalizacao()
    {
        Console.WriteLine("Programa finalizado com sucesso, obrigado por utilizar  o Calculator! Tenha um otimo dia.");
        System.Environment.Exit(0);
    }

    static void Potenciacao()
    {
        Console.Clear();

        Console.WriteLine("Insira o numero de base: ");
        double valorBase = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine("Insira o numero de expoente: ");
        double valorExpoente = double.Parse(Console.ReadLine());

        Console.WriteLine("");
        double resultado = Math.Pow(valorBase, valorExpoente);

        Console.WriteLine($"O numero {valorBase} elevado a '{valorExpoente}' é igual à: {resultado}");

        Console.ReadKey();
        Menu();
    }

    static void Radicializacao()
    {
        Console.Clear();

        Console.WriteLine("Insira o numero a ser racionalizado: ");
        double valorRad = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultadoRad = Math.Sqrt(valorRad);

        Console.WriteLine("");

        Console.WriteLine($"Sua raiz quadrada é: {resultadoRad}");

        Console.ReadKey();
        Menu();
    }
}



