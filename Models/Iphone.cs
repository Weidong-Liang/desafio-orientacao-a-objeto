namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        public Iphone(string numero, int memoria, string modelo, string imei) : base (numero, memoria, modelo, imei)
        {
           
        }       
         public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando " + nomeApp);
        }
        
        public override void ApresentarAparelho()
        {
            Console.WriteLine("Numero do aparelho: " + Numero + 
            "\nMemoria de: " + Memoria + "\nModelo: " + Modelo + 
            "\nIMEI: "+ IMEI);
        }
    }
}