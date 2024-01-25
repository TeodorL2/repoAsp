using examen.Data;
using examen.Helpers.Extensions;
using examen.Models;
using examen.Models.DTOs;
using examen.Repositories.GenericRepository;
using Microsoft.AspNetCore.Http.HttpResults;

namespace examen.Repositories.EvenPartRepositories
{
    public class EvenimentRepository : GenericRepository<Eveniment>, IEvenimentRepository
    {
        public EvenimentRepository(ExamenContext ExamenContext) : base(ExamenContext)
        {
        }

        public List<Eveniment> FindAll()
        {
            return _table.ToList();
        }


    }
}
