using System.Globalization;

public class Program
{
    static void Main(string [] args)
    {
        Cliente c = new Cliente("Douglas", 51);
        ValorTotalSeguro valorSeguro = new ValorTotalSeguro(c,100);
        valorSeguro.GetValorTotal();
        System.Console.WriteLine($"R$ {valorSeguro.GetValorTotal().ToString("F4", CultureInfo.InvariantCulture)}");
        
    }
}
