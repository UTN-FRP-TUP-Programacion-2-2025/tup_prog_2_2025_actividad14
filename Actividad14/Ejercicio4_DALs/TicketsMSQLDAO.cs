
using Ejercicio1_Models;
using Microsoft.Data.SqlClient;

namespace Ejercicio4_DALs;

public class TicketsMSQLDAO : ITicketsDAO
{
    string stringConnection = "Server=localhost;Database=Actividad14_DB;Trusted_Connection=True;";

    public Ticket Add(Ticket nuevo)
    {
        using SqlConnection conn =new SqlConnection(stringConnection);

        conn.Open();
        string sqlInsert = "INSERT INTO Tickets (Fecha, PrecioFinal, Destino, Transporte) " +
                           "VALUES (@Fecha, @PrecioFinal, @Destino, @Transporte); " +
                           "SELECT SCOPE_IDENTITY();";

        using SqlCommand cmd = new SqlCommand(sqlInsert, conn);
        cmd.Parameters.AddWithValue("@Fecha", nuevo.Fecha);
        cmd.Parameters.AddWithValue("@PrecioFinal", nuevo.PrecioFinal);
        cmd.Parameters.AddWithValue("@Destino", nuevo.Destino);
        cmd.Parameters.AddWithValue("@Transporte", nuevo.Transporte);

        int id = Convert.ToInt32(cmd.ExecuteScalar());

        //nuevo.Id =id ;
        return nuevo;
    }

    public List<Ticket> Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<Ticket> List()
    {
        throw new NotImplementedException();
    }

    public void Remove(Ticket ticket)
    {
        throw new NotImplementedException();
    }

    public Ticket Save(Ticket ticket)
    {
        throw new NotImplementedException();
    }
}
