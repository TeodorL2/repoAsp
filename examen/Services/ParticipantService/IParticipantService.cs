using examen.Models;
using examen.Models.DTOs;

namespace Lab4_23.Services.ParticipantService
{
    public interface IParticipantService
    {
        Task<List<ParticipantDto>> GetAll();
    }
}
