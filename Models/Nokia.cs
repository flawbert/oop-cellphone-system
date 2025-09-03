namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string number, string model, string imei, int storage)
            : base(number, model, imei, storage)
        {
        }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Installing {appName} on Nokia...");
        }
    }
}