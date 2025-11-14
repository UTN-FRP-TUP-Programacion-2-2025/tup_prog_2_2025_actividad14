
namespace Ejercicio1_Models;

[Serializable]
public abstract class Transporte
{
    private double precio;

    public Transporte(string destino, double precio)
    {
        Destino = destino;
        this.precio = precio;
    }

    public double PrecioBase { get; set; }
    public string Destino { get; set; }


    virtual public double CalcularPrecioFinal()
    {
        return PrecioBase;
    }
}
