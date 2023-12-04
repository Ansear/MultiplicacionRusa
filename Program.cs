internal class Program
{
    private static void Main(string[] args)
    {
        int result = 0;
        Console.WriteLine("Ingrese Multiplicador");
        int multiplica = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Ingrese Multiplicando");
        int multiplican = Convert.ToInt16(Console.ReadLine());
        while (multiplica != 1)
        {
            if (multiplica % 2 != 0)
            {
                result += multiplican;
            }
            multiplican *= 2;
            multiplica /= 2;
        }
        result += multiplican;
        Console.WriteLine("Resultado: " + result);
        Console.ReadKey();

    }
}   