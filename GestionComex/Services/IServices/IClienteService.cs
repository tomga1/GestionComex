using GestionComex.Models;

namespace GestionComex.Services.IServices
{
    public interface IClienteService
    {
        Task<IEnumerable<Clientes>> GetAll();
        Task<Clientes?> getById(int id); 
        Task Add(Clientes clientes);
        Task<string> GetRazonSocialPorCUIT(string cuit);
        Task Delete(int id);
    }
}
        