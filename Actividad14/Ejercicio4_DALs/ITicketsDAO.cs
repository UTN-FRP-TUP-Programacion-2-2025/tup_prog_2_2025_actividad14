using Ejercicio1_Models;

namespace Ejercicio4_DALs;

public interface ITicketsDAO
{
    public List<Ticket> List();//alguno usan getall otros list
    public List<Ticket> Get(int id);
    public Ticket Add(Ticket nuevo);
    public Ticket Save(Ticket ticket);
    
    public void Remove(Ticket ticket);
}
