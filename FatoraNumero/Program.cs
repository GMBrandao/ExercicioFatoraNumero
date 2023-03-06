long result, factor;

Console.WriteLine("Digite o número que deseja fatorar: ");
factor = long.Parse(Console.ReadLine()); ;

result = fat(factor);

Console.WriteLine("O resultado da fatorial é: " +  result);

long fat(long value)
{
    if (value == 0)
    {
        return 1;
    }
    else
    {
        return(value * fat(value-1));
    }
}