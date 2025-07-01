using GestionComex.DTOs;
using GestionComex.Models;

namespace GestionComex.Services.IServices
{
    public interface IClienteService
    {
        Task<IEnumerable<Clientes>> GetAll();
        Task<Clientes?> getById(int id); 
        Task<string> GetRazonSocialPorCUIT(string cuit);

        Task Add(Clientes clientes);
        Task Edit(ClienteEditDTO clientesDTO);   
        Task Delete(int id);
    }
}
        