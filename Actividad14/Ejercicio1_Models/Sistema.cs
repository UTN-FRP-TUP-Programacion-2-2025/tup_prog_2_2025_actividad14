


namespace Ejercicio1_Models;

[Serializable]
public class Sistema
{
    List<Ticket> tickets=new List<Ticket>();
    List<Transporte> transportes=new List<Transporte>();

    public void AgregarTransporte(Transporte transporte)
    {
        transportes.Add(transporte);
    }

    public void CrearTicket(string cuit, string nombre, string telefono, string tarjeta,string destino, string tipo)
    {
        Transporte t=ResuelvaTransporte(destino, tipo);

        if (t != null)
        {
            Ticket ticket = new Ticket(cuit, nombre, telefono, tarjeta);
            ticket.Destino = destino;
            ticket.PrecioFinal = t.CalcularPrecioFinal();
            tickets.Add(ticket);
        }
        else
        { 
            throw new Exception("No existe transporte para el destino y tipo solicitado");
        }
    }

    public Transporte ResuelvaTransporte(string destino,string tipo)
    {
        Transporte buscado = null;
        for (int n = 0; n < transportes.Count && buscado == null; n++)
        {
            if (transportes[n].Destino == destino
                      && ( (transportes[n] is Bus && tipo == "Bus")
                      || (transportes[n] is Avion && tipo == "Avion")))
            { 
                buscado= transportes[n];
            }
        }
        return buscado;
    }

    public void ImportarTransporte(FileStream fs)
    {
        StreamReader sr = new StreamReader(fs);

        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();

            string[] campos = line.Split(';');

            string destino = campos[0];
            double precio = Convert.ToDouble(campos[1]);

            Transporte transporte = null;
            if (campos.Length == 3)
            {
                string identificador = campos[2];

                transporte = new Avion(destino, precio, identificador);
            }
            else if (campos.Length == 4)
            {
                string patente = campos[2];
                string clase = campos[3];
                transporte = new Bus(destino, precio, patente, clase);
            }
            else
            {
                throw new Exception("Error");
            }

            AgregarTransporte(transporte);
        }
            

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
