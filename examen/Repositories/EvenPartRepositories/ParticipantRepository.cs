using examen.Data;
using examen.Helpers.Extensions;
using examen.Models;
using examen.Repositories.GenericRepository;

namespace examen.Repositories.EvenPartRepositories
{
    public class ParticipantRepository : GenericRepository<Participant>, IParticipantRepository
    {
        public ParticipantRepository(ExamenContext ExamenContext) : base(ExamenContext)
        {
        }

        public List<Participant> FindAll()
        {
            return _table.ToList();
        }

        
    }
}
