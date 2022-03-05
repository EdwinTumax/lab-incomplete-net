namespace CentralTelefonicaLab.Edu.Kinal.Lab.Entities
{
    public class LlamadaInterior : Llamada
    {
        public double PrecioUno {get;set;}
        public double PrecioDos {get;set;}
        public double PrecioTres {get;set;}
        public int Franja {get;set;}
        public LlamadaInterior(string numeroOrigen, string numeroDestino, double duracion, int franja)
        {
            
        }
        override
        public string ToString()
        {
            return "";
        }
        public override double CalcularPrecio()
        {
            return this.Duracion * 0.0;
        }
    }
}