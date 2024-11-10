try
{
    Console.Write("Введите k:");
    int k = int.Parse(Console.ReadLine());
    double s = 0;
    for (int i = 1; i <= k; i++)
    {
        double t = Math.Pow(-1, i) * Math.Pow(i - 3, 2) / Factorial(i);
        s += t;
    }
    Console.WriteLine($"Результат: {s:F2}");

    double Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}