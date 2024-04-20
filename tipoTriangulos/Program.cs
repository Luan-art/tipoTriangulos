float ladoA = 0, ladoB = 0, ladoC = 0;

do
{
Console.WriteLine("Digite o lado de um triangulo: ");
ladoA = float.Parse(Console.ReadLine());
} while (ladoA <= 0);

do
{
Console.WriteLine("Digite o outro lado de um triangulo: ");
ladoB = float.Parse(Console.ReadLine());
} while (ladoB <= 0);


do
{
Console.WriteLine("Digite o último lado de um triangulo: ");
ladoC = float.Parse(Console.ReadLine());

} while (ladoC <= 0);

if(ladoA + ladoB < ladoC || ladoB + ladoC < ladoA || ladoA + ladoC < ladoB)
{
    Console.WriteLine("Não é um triangulo");
}
else
{
    if (ladoA == ladoB && ladoB == ladoC)
    {
        Console.WriteLine("triângulo equilátero ");

    }
    else
    {
        if ((ladoA == ladoB && ladoB != ladoC) || (ladoA == ladoC && ladoC != ladoB) || (ladoC == ladoB && ladoB != ladoA))
        {
            Console.WriteLine("triângulo isósceles ");

        }
        else
        {
            Console.WriteLine("triângulo escaleno ");

        }
    }
}




