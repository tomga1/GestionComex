using GestionComex.DTOs;
using GestionComex.Models;

namespace GestionComex.Data.Repository.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Clientes>> GetAll();
        Task<Clientes?> getById(int id);
        Task<Clientes?> getByCUIT(string cuIT);


        Task Add(Clientes clientes);
        Task Edit(ClienteEditDTO clientesDTO);
        Task Delete(int id); 


    }
}
