using GestionComex.Models;

namespace GestionComex.Data.Repository.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Clientes>> GetAll();
        Task Add(Clientes clientes);
        Task<Clientes?> getByCUIT(string cuIT);




    }
}
