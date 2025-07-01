using GestionComex.Data.Repository;
using GestionComex.Data.Repository.Interfaces;
using GestionComex.DTOs;
using GestionComex.Models;
using GestionComex.Services.IServices;

namespace GestionComex.Services
{
   
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly HttpClient _httpClient;
        public ClienteService(IClienteRepository clienteRepository, HttpClient httpClient)
        {
            _clienteRepository = clienteRepository;
            _httpClient = httpClient;   
        }


        public async Task<IEnumerable<Clientes>> GetAll()
        {
            return await _clienteRepository.GetAll();
        }


        public async Task<Clientes?> getById(int id)
        {
            return await _clienteRepository.getById(id);
        }


        public async Task<string> GetRazonSocialPorCUIT(string cuit)
        {
            if (string.IsNullOrWhiteSpace(cuit) || cuit.Length != 11)
                throw new ArgumentException("El CUIT debe tener 11 dígitos.", nameof(cuit));

            var url = $"https://sistemaintegracomex.com.ar/Account/GetNombreByCuit?cuit={cuit}";
            var response = await _httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();
            var razonSocial = await response.Content.ReadAsStringAsync();
            return razonSocial;
        }


        public async Task Add(Clientes clientes)
        {
            var existente = await _clienteRepository.getByCUIT(clientes.CUIT);
            
            if(existente is not null)
            {
                throw new InvalidOperationException($"Ya existe un cliente con CUIT {clientes.CUIT}");

            }

            await _clienteRepository.Add(clientes);
        }


        public async Task Delete(int id)
        {
            await _clienteRepository.Delete(id);
        }

        public async Task Edit(ClienteEditDTO clientesDTO)
        {
            await _clienteRepository.Edit(clientesDTO);
        }
    }
}
