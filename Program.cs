using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
internal class Program
{
    static void Main(string[] args)
    {
      Nokia nokia = new Nokia("12534123124553", "Smartphone Nokia C2", "fgx123f4g2x34trx23r4", 32);
      Iphone iphone = new Iphone("12532343244553", "Iphone 15 Pro Max", "fgx123f4ggf32xc4trx23r4", 512);

      nokia.InstallApp("Instagram");
      nokia.Call();
      nokia.ReceivingCall();

      iphone.InstallApp("Twitter");
      iphone.Call();
      iphone.ReceivingCall();
    }
}