namespace DesafioPOO.Models
{
   
    public class Nokia : Smartphone
    {
        public Nokia(string numero, int memoria, string modelo, string imei) : base(numero, memoria, modelo, imei)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine(nomeApp + " está sendo instalado no celular Nokia");
        }
        public override void ApresentarAparelho()
        {
            Console.WriteLine("Numero do aparelho: " + Numero +
            "\nMemoria de: " + Memoria + "\nModelo: " + Modelo + 
            "\nIMEI: "+ IMEI);
        }
        
    }
}