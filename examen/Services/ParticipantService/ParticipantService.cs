using AutoMapper;
using examen.Models.DTOs;
using examen.Repositories.EvenPartRepositories;

namespace Lab4_23.Services.ParticipantService
{
    public class ParticipantService : IParticipantService
    {
        public IParticipantRepository _ParticipantRepository;
        public IMapper _mapper;

        public ParticipantService(IParticipantRepository ParticipantRepository, IMapper mapper)
        {
            _ParticipantRepository = ParticipantRepository;
            _mapper = mapper;
        }


        public async Task<List<ParticipantDto>> GetAll()
        {
            var ParticipantList = await _ParticipantRepository.GetAllAsync();
            return _mapper.Map<List<ParticipantDto>>(ParticipantList);
        }
    }
}
