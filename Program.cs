// Soma();
// Subtracao();
// Divisao();
//Multiplicacao();
Menu();
static void Menu(){
    Console.Clear();
    bool continua = true;
    do{
    Console.WriteLine("-----------------");
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Fechar");
    Console.WriteLine("-----------------");
    Console.WriteLine("Digite a opção desejada:");
    short opcao = short.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Soma();
            break;
            case 2:
            Subtracao();
            break;
            case 3:
            Multiplicacao();
            break;
            case 4:
            Multiplicacao();
            break;
            case 5:
            continua = false;
            break;
        default:
            Console.Error.WriteLine($"Opção não reconhecida\n");
            break;
    }
    }while(continua);
    Console.WriteLine("Saindo...");
}

static void Soma()
{
    Console.WriteLine("Primeiro Valor:");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo Valor");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");
    float resultado = v1 + v2;
    Console.WriteLine($"Soma dos valores é {resultado}");
    Console.ReadKey();
}

static void Subtracao(){
    Console.WriteLine("Primeiro Valor:");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo Valor:");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");
    float resultado = v1 - v2;
    Console.WriteLine($"Subtração dos valores é {resultado}");
    Console.ReadKey();
}

static void Divisao(){
    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");
    float resultado = v1/v2;
    Console.WriteLine($"Divisão dos valores é {resultado}");
    Console.ReadKey();
}

static void Multiplicacao(){
    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");
    float resultado = v1*v2;
    Console.WriteLine($"Multiplicação dos valores é {resultado}");
    Console.ReadKey();
}