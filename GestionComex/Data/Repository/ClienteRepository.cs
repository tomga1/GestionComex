using GestionComex.Data.Repository.Interfaces;
using GestionComex.DTOs;
using GestionComex.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;


namespace GestionComex.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _context;
        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context; 
        }


        public async Task<IEnumerable<Clientes>> GetAll()
        {
            var clientes = await _context.Clientes.ToListAsync();
            return clientes; 
        }


        public async Task<Clientes?> getByCUIT(string cuit)
        {
            return await _context.Clientes.FirstOrDefaultAsync(c => c.CUIT == cuit);
        }


        public async Task<Clientes?> getById(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }


        public async Task Add(Clientes cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }


        public async Task Delete(int id)
        {
            var cliente = await getById(id);

            if(cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Edit(ClienteEditDTO clientesDTO)
        {
           var clienteExistente = await _context.Clientes.FindAsync(clientesDTO.Id);

            if(clienteExistente == null)
            {
                throw new Exception("Cliente no encontrado"); 
            }

            clienteExistente.Telefono = clientesDTO.Telefono;
            clienteExistente.Direccion = clientesDTO.Direccion;
            clienteExistente.Activo = clientesDTO.Activo;

            await _context.SaveChangesAsync();  
        }
    }
}
