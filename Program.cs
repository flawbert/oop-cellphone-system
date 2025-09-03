using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 16);
nokia.Call();
nokia.ReceiveCall();
nokia.InstallApp("Snake");

Console.WriteLine("\nSmartphone Iphone:");
Iphone iphone = new Iphone("987654321", "iPhone 13", "987654321098765", 128);
iphone.Call();
iphone.ReceiveCall();
iphone.InstallApp("Instagram");