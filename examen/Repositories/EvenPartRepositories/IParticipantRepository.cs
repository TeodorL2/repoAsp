using examen.Models;
using examen.Repositories.GenericRepository;

namespace examen.Repositories.EvenPartRepositories
{
    public interface IParticipantRepository: IGenericRepository<Participant>
    {
        List<Participant> FindAll();
    }
}
