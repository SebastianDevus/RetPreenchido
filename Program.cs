Console.Clear();

Console.WriteLine("Insira as dimensões do retângulo.");

try
{
    Console.Write("Altura...: ");
    int altura = Convert.ToInt32(Console.ReadLine());
    Console.Write("Largura..: ");
    int largura = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    for (int i = 1; i <= altura; i++)
    {
        for (int i2 = 1; i2 <= largura; i2++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nConcluído.");
}
catch (Exception e)
{
    Console.Beep();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\n{e.Message}");
}
finally
{
    Console.ResetColor();
}
Console.WriteLine();