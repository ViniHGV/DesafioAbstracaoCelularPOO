namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstallApp(string nameApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nameApp}");
        }
    }
}