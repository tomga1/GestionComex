using GestionComex.Models;

namespace GestionComex.Services.IServices
{
    public interface IClienteService
    {
        Task<IEnumerable<Clientes>> GetAll();
        Task Add(Clientes clientes);
        Task<string> GetRazonSocialPorCUIT(string cuit); 
    }
}
        