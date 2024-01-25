using examen.Models;
using examen.Models.DTOs;

using examen.Repositories.GenericRepository;

namespace examen.Repositories.EvenPartRepositories
{
    public interface IEvenimentRepository : IGenericRepository<Eveniment>
    {
        List<Eveniment> FindAll();
    }
}
