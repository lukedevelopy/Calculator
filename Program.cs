class Program
{
    static void Main(string[] args)
    {
        // Soma();
        // Subtracao();
        // Divisao();
        // Multiplicacao();
        Menu();

    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("-------------------");
        Console.WriteLine("Selecione uma opção: ");
        short res = short.Parse(Console.ReadLine());

        switch (res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: Sair(); break;
            default: Menu(); break;
        }

    }
    static void Soma()
    {
        Console.Clear();

        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 + v2;

        Console.WriteLine("");
        Console.WriteLine("O resultado da soma é " + resultado);
        Console.ReadKey();
        Menu();
        // Console.WriteLine($"O resultado da soma é {resultado}");
        // Console.WriteLine($"O resultado da soma é {v1 + v2}");
        // Console.WriteLine("O resultado da soma é " + (v1 + v2));
        // Console.WriteLine("O resultado da soma é " + (resultado));
    }
    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 - v2;

        Console.WriteLine("");
        Console.WriteLine($"O resultado da subtração é {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 / v2;

        Console.WriteLine("");
        Console.WriteLine($"O resultado da divisão é {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 * v2;

        Console.WriteLine("");
        Console.WriteLine($"O resultado da multipicação é {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Sair()
    {
        Console.Clear();
        Console.WriteLine("Obrigado por ultilizar o 'Calculator'!");
        System.Environment.Exit(0);

    }
}