

namespace Ejercicio1_Models;

[Serializable]
public class Bus:Transporte
{
    public string Patente { get; set; } 
    public string  Clase { get; set; }

    public Bus (string destino, double precio, string patente, string clase) : base (destino, precio)
    {
        Patente = patente;
        Clase = clase;
    }

    override public double CalcularPrecioFinal()
    {
        double precio = base.CalcularPrecioFinal();
        double iva = precio * 21.5 / 100;
        return precio + iva;
    }
}
