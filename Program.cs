namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("Escolha uma opção");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("--------------");
      Console.WriteLine("Selecione uma opção:");
      Console.WriteLine("5 - Sair");
      short res = short.Parse(Console.ReadLine());

      switch (res)
      {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: Environment.Exit(0); break;
        default: Menu(); break;
      }
    }

    static void Soma()
    {
      Console.Clear();
      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());


      float soma = v1 + v2;
      Console.WriteLine("O resultado é:" + soma);
      Console.WriteLine(v1);
      Menu();
    }

    static void Subtracao()
    {
      Console.Clear();
      Console.WriteLine("Primeiro Valor:");
      float v1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Segundo Valor:");
      float v2 = float.Parse(Console.ReadLine());

      float subtracao = v1 - v2;
      Console.WriteLine("O resultado é:" + subtracao);
      Console.ReadKey();
      Menu();
    }

    static void Divisao()
    {
      Console.Clear();
      Console.WriteLine("Primeiro Valor:");
      float v1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      float divisao = v1 / v2;
      Console.WriteLine("O resultado é:" + divisao);
      Console.ReadKey();
      Menu();
    }

    static void Multiplicacao()
    {
      Console.WriteLine("Primeiro Valor:");
      float v1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Segundo Valor:");
      float v2 = float.Parse(Console.ReadLine());

      float multiplicacao = v1 * v2;
      Console.WriteLine("o valor da soma é + " + multiplicacao);
      Console.ReadKey();
      Menu();
    }
  }
}