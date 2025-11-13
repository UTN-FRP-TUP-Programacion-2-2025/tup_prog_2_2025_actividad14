

namespace Ejercicio1_Models;

public class Ticket : IComparable<Ticket>
{
    public DateTime Fecha { get; set; }
    public double PrecioFinal { get; set; }
   
    public string Destino { get; set; }

    public string Transporte { get; set; }

    string cuit;
    string nombre;
    string telefono;
    string tarjeta;

    public Ticket(string cuit, string nombre, string telefono, string tarjeta)
    {
        if (ValidarCuit(cuit) == false)
        {
            throw new Exception("cuit no válido");
        }
        if (ValidarTarjeta(tarjeta) == false)
        {
            throw new Exception("tarjeta no válida");
        }
        this.cuit = cuit;
        this.nombre = nombre;
        this.telefono = telefono;
        this.tarjeta = tarjeta;
    }

    protected bool ValidarCuit(string cuit)
    {
        return cuit.Length == 11;
    }

    protected bool ValidarTarjeta(string tarjeta)
    {
        return tarjeta.Length == 16;
        //podriamos hacer un restapi hacia mastercard
    }

    public int CompareTo(Ticket other)
    {
        if (other != null) Destino.CompareTo(other.Destino);
        return -1;
    }

    override public string ToString()
    {
        return $"{nombre}({cuit}) {Destino} ${PrecioFinal:f2}";
    }
}
