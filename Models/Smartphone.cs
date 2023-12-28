namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // Implementado!!
        protected string modelo;
        protected string imei;
        protected int memoria;

        public Smartphone(string numero, string modeloCelular, string nImei, int memoriaCelular)
        {
            Numero = numero;
            // Implementado!!
            modelo = modeloCelular;
            imei = nImei;
            memoria = memoriaCelular;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}