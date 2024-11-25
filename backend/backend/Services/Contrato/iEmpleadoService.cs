using backend.Models;

namespace backend.Services.Contrato
{
    public interface iEmpleadoService
    {
        Task<List<Empleado>> GetList();
    }
}
