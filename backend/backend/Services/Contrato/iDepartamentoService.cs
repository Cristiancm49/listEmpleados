using backend.Models;

namespace backend.Services.Contrato
{
    public interface iDepartamentoService
    {
        Task<List<Departamento>> GetList();
        Task<Departamento> Get(int idEmpleado);
        Task<Departamento> Add(Departamento modelo);
        Task<bool> Update(Departamento modelo);
        Task<bool> Delete(Departamento modelo);
    }
}
