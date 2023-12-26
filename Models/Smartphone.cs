namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string number,string model, string imei, int memory)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            Number = number;
            Model = imei;
            IMEI = imei;
            Mamory = memory;
        }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Number { get; set; }
        private string Model { get; set; }
        private string IMEI { get; set; }
        private int Mamory { get; set; }


        public void Call()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceivingCall()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstallApp(string nameApp);
    }
}