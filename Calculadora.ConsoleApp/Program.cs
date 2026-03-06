bool continuar = true;
while (continuar == true)
{
    Console.Clear();

    Console.WriteLine("----------------");
    Console.WriteLine("Calculadora 2026");
    Console.WriteLine("----------------");

    Console.WriteLine("1 = soma");
    Console.WriteLine("2 = subtração");
    Console.WriteLine("3 = multiplicação");
    Console.WriteLine("4 = divisão");
    Console.WriteLine("5 = tabuada");
    Console.WriteLine("s = sair");

    Console.WriteLine();

    Console.Write("Escolha uma operação: ");
    string? Operacao = Console.ReadLine();

    if (Operacao == "s")
    {
        continuar = false;
        Console.WriteLine("Encerrando a calculadora.");
        break;
    }
    else if (Operacao != "1" && Operacao != "2" && Operacao != "3" && Operacao != "4" && Operacao != "5" && Operacao != "s")
    {
        Console.WriteLine("Operação inválida, escolha outra operação");
        return;
    }

    Console.WriteLine();

    if (Operacao == "5")
    {
        Console.Write("Digite um número para gerar a tabuada: ");
        int TabuadaNumero = Convert.ToInt32(Console.ReadLine());

        for (int contador = 1; contador <= 10; contador++)
        {
            int resultadoTabuada = TabuadaNumero * contador;
            string operacaoTabuada = TabuadaNumero + " x " + contador + " = " + resultadoTabuada;
            Console.WriteLine(operacaoTabuada);
        }
        Console.ReadLine();
        continue;
    }

    Console.Write("Digite o primeiro número: ");
    string? strPrimeiroNumero = Console.ReadLine();

    Console.WriteLine();

    Console.Write("Digite o segundo número: ");
    string? strSegundoNumero = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine("O primeiro número digitado foi: " + strPrimeiroNumero);

    Console.WriteLine();

    Console.WriteLine("O segundo número digitado foi: " + strSegundoNumero);

    Console.WriteLine();

    bool PrimeiroNumeroVazio = string.IsNullOrEmpty(strPrimeiroNumero);
    bool SegundoNumeroVazio = string.IsNullOrEmpty(strSegundoNumero);
    if (PrimeiroNumeroVazio == true || SegundoNumeroVazio == true)
    {
        Console.WriteLine("Digite ambos os números.");
        Console.WriteLine();
        return;
    }

    decimal PrimeiroNumero = Convert.ToDecimal(strPrimeiroNumero);
    decimal SegundoNumero = Convert.ToDecimal(strSegundoNumero);
    decimal resultado = 0;

    switch (Operacao)
    {
        case "1":
            resultado = PrimeiroNumero + SegundoNumero;
            break;
        case "2":
            resultado = PrimeiroNumero - SegundoNumero;
            break;
        case "3":
            resultado = PrimeiroNumero * SegundoNumero;
            break;
        case "4":
            if (SegundoNumero == 0)
            {
                Console.WriteLine("Divisão por zero não é possível.");
                return;
            }
            resultado = PrimeiroNumero / SegundoNumero;
            break;
        default:
            Console.WriteLine("Operação inválida. Escolha uma operação válida.");
            continue;
    }

    Console.WriteLine("O resultado da operação é: " + resultado);

    Console.WriteLine();

    Console.ReadLine();
}