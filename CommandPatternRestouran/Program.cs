using CommandPatternRestouran;

internal class Program
{
    private static void Main(string[] args)
    {
        var client = new Client("Николай");
        var busBoy = new BusBoy("Федор");

        busBoy.Hello();
        client.Hello();
        client.SayAboutNewZakaz();
        busBoy.ViewMenu();
        client.CreateZakaz("Пельмени");

    }
}