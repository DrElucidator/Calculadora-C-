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
    Console.WriteLine("s = sair");

    Console.WriteLine();

    Console.Write("Escolha uma operação: ");
    string Operacao = Console.ReadLine();

    if (Operacao == "s")
    {
        continuar = false;
        Console.WriteLine("Encerrando a calculadora.");
        break;
    }
    else if (Operacao != "1" && Operacao != "2" && Operacao != "3" && Operacao != "4" && Operacao != "s")
    {
        Console.WriteLine("Operação inválida, escolha outra operação");
        return;
    }

    System.Console.WriteLine();

    Console.Write("Digite o primeiro número: ");
    string PrimeiroNumero = Console.ReadLine();

    Console.WriteLine();

    Console.Write("Digite o segundo número: ");
    string SegundoNumero = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine("O primeiro número digitado foi: " + PrimeiroNumero);

    Console.WriteLine();

    Console.WriteLine("O segundo número digitado foi: " + SegundoNumero);

    Console.WriteLine();

    int PrimeiroNumeroInt = Convert.ToInt32(PrimeiroNumero);
    int SegundoNumeroInt = Convert.ToInt32(SegundoNumero);
    int resultado = 0;

    if (Operacao == "1")
    {
        resultado = PrimeiroNumeroInt + SegundoNumeroInt;
    }
    else if (Operacao == "2")
    {
        resultado = PrimeiroNumeroInt - SegundoNumeroInt;
    }
    else if (Operacao == "3")
    {
        resultado = PrimeiroNumeroInt * SegundoNumeroInt;
    }
    else if (Operacao == "4")
    {
        if (SegundoNumeroInt == 0)
        {
            Console.WriteLine("Divisão por zero não é possível.");
            return;
        }
        resultado = PrimeiroNumeroInt / SegundoNumeroInt;
    }
    else
    {
        Console.WriteLine("Operação inválida. Por favor, escolha uma operação válida.");
    }

    Console.WriteLine("O resultado da operação é: " + resultado);

    Console.WriteLine();

    Console.ReadLine();
}