namespace ConsoleSample;

public class HelloAbpService : IHelloAbpService
{
    public void SayHello()
    {
        Console.WriteLine("Hello ABP vNext");
    }
}