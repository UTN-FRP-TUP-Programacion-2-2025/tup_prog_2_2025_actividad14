

namespace Ejercicio1_Models;

public class Sistema
{
    List<Ticket> tickets=new List<Ticket>();
    List<Transporte> transportes=new List<Transporte>();

    public void AgregarTransporte(Transporte transporte)
    {
        transportes.Add(transporte);
    }

    public void CrearTicket(string cuit, string nombre, string telefono, string tarjeta)
    {
        Ticket t=new Ticket(cuit, nombre, telefono, tarjeta);
        tickets.Add(t);
    }

    public string[] VerTickets()
    {
        string[] lista = new string[tickets.Count];

        tickets.Sort();

        int n = 0;
        foreach (Ticket t in tickets)
        {
            lista[n++] = t.ToString();
        }

        return lista;
    }
}
