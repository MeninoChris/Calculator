import java.util.Scanner;

public class EX13_Calc {

    public static void main(String[] args) {

        /*
         * • • Criar uma calculadora de operações básicas:
         * - soma, subtração, multiplicação e divisão
         * – o algoritmo deve ler dois números eo sinal correspondente à operação
         * desejada;
         * – utilize o tipo char para ler a operação;
         * – no final deve ser impresso o resultado.
         * • Restrições:
         * se o sinal digitado não corresponder a uma operação...
         * para a operação de divisão verificar se o divisor é válido (maior que zero)!
         * caso seja menor ou igual a zero, informar a mensagem “Impossível dividir‼”
         */

        Scanner entradaDados = new Scanner(System.in);

        System.out.println("Bem vindo a Calculadora! Vamos começar.");
        System.out.println("Digite: " +
                " 1 - Soma;" +
                " 2 - Subtração;" +
                " 3 - Multiplicação;" +
                " 4 - Divisão;");
        double operacao = entradaDados.nextDouble();
        System.out.println("");

        if (operacao == 1) {
            System.out.print(
                    "Você digitou a operação de soma! Para continuar digite um numero para o primeiro algarismo: ");
            if (!entradaDados.hasNextDouble()) { // Verifica se NÃO é um número
                System.out.println("Entrada Inválida!");
                System.exit(0);
            }
            double num1 = entradaDados.nextDouble();

            System.out.print("Agora digite o segundo numero: ");
            if (!entradaDados.hasNextDouble()) { // Verifica se NÃO é um número
                System.out.println("Entrada Inválida!");
                System.exit(0);
            }

            double num2 = entradaDados.nextDouble();
            System.out.println("");
            double resultadoSoma = num1 + num2;
            System.out.println("Os numeros que você colocou foi: " + num1 + " e " + num2
                    + " seu resultado da Soma será: " + resultadoSoma);

        } else if (operacao == 2) {
            System.out.print(
                    "Você digitou a operação de Subtração! Para continuar digite um numero para o primeiro algarismo: ");
            if (!entradaDados.hasNextDouble()) {
                System.out.println("Entrada Inválida!");
                System.exit(0);
            }
            double num1 = entradaDados.nextDouble();

            System.out.print("Agora digite o segundo numero: ");
            if (!entradaDados.hasNextDouble()) {
                System.out.println("Entrada Inválida!");
                System.exit(0);
            }
            double num2 = entradaDados.nextDouble();

            System.out.println("");
            double resultadoSub = num1 - num2;
            System.out.println("Os numeros que você colocou foi: " + num1 + " e " + num2
                    + " seu resultado da Subtração será: " + resultadoSub);

        } else if (operacao == 3) {
            System.out.print(
                    "Você digitou a operação de Multiplicação! Para continuar digite um numero para o primeiro algarismo: ");
            if (!entradaDados.hasNextDouble()) {
                System.out.println("Entrada Inválida!");
                System.exit(0);
            }
            double num1 = entradaDados.nextDouble();

            System.out.print("Agora digite o segundo numero: ");
            if (!entradaDados.hasNextDouble()) {
                System.out.println("Entrada Inválida!");
                System.exit(0);
            }
            double num2 = entradaDados.nextDouble();
            System.out.println("");
            double resultadoMult = num1 * num2;
            System.out.println("Os numeros que você colocou foi: " + num1 + " e " + num2
                    + " seu resultado da Multiplicação será: " + resultadoMult);

        } else if (operacao == 4) {
            System.out.print(
                    "Você digitou a operação de Divisão! Para continuar digite um numero para o primeiro algarismo: ");
            if (!entradaDados.hasNextDouble()) { // Verifica se NÃO é um número
                System.out.println("Entrada Inválida!");
                System.exit(0);
            }
            double num1 = entradaDados.nextDouble();
            if (num1 <= 0) {
                System.out.println("Numero Invalido!");
                System.exit(0);
            }

            System.out.print("Agora digite o segundo numero: ");
            if (!entradaDados.hasNextDouble()) { // Verifica se NÃO é um número
                System.out.println("Entrada Inválida!");
                System.exit(0);
            }
            double num2 = entradaDados.nextDouble();
            if (num1 <= 0) {
                System.out.println("Numero Invalido!");
                System.exit(0);
            }
            System.out.println("");
            double resultadoDiv = num1 / num2;
            if (resultadoDiv == 0) {
                System.out.println("Operação Invalida");
                System.exit(0);
            }
            System.out.println("Os numeros que você colocou foi: " + num1 + " e " + num2
                    + " seu resultado da divisão será: " + resultadoDiv);
        }
        entradaDados.close();

    }
}
