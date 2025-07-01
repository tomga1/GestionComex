using GestionComex.Models;

namespace GestionComex.Data.Repository.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Clientes>> GetAll();
        Task Add(Clientes clientes);
        Task Delete(int id); 
        Task<Clientes?> getByCUIT(string cuIT);

        Task<Clientes?> getById(int id);


    }
}
