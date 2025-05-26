namespace dotnet_core_ci_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine($"3 + 5 = {calc.Add(3, 5)}");
        }
    }
}
