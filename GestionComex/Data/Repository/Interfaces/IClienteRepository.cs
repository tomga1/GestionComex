using GestionComex.Models;

namespace GestionComex.Data.Repository.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Clientes>> GetAll();
    }
}
