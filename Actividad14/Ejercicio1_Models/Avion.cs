
namespace Ejercicio1_Models;

[Serializable]
public class Avion:Transporte
{
    public string Identificador { get; set; }

    public Avion (string destino, double precio, string identificador) : base(destino,precio)
    {
        Identificador = identificador;
    }
    override public double CalcularPrecioFinal()
    {
        double impuesto= base.CalcularPrecioFinal() * 30.0/100;
        double precio= base.CalcularPrecioFinal() + impuesto;
        double iva = precio * 11.5 / 100;
        return precio + iva;
    }
}
