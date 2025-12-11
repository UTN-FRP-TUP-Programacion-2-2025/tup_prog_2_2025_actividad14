
namespace Ejercicio1_Models;

[Serializable]
public abstract class Transporte
{
    private double PrecioBase { get; set; }
    public string Destino { get; set; }

    public Transporte(string destino, double precio)
    {
        Destino = destino;
        this.PrecioBase = precio;
    }


    virtual public double CalcularPrecioFinal()
    {
        return PrecioBase;
    }
}
