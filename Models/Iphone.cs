namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string number, string model, string imei, int storage)
            : base(number, model, imei, storage)
        {
        }
        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Installing {appName} on Iphone...");
        }
    }
}