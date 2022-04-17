namespace AutofacDemo;

public class DateWriter:IDateWriter
{
    public void WriteDate()
    {
        Console.WriteLine(DateTime.Now);
    }
}