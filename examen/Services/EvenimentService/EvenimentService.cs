using AutoMapper;
using examen.Models;
using examen.Models.DTOs;
using examen.Repositories.EvenPartRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Lab4_23.Services.EvenimentService
{
    public class EvenimentService : IEvenimentService
    {
        public IEvenimentRepository _EvenimentRepository;
        public IMapper _mapper;

        public EvenimentService(IEvenimentRepository EvenimentRepository, IMapper mapper)
        {
            _EvenimentRepository = EvenimentRepository;
            _mapper = mapper;
        }


        public async Task<List<EvenimentDto>> GetAll()
        {
            var EvenimentList = await _EvenimentRepository.GetAllAsync();
            return _mapper.Map<List<EvenimentDto>>(EvenimentList);
        }

        public async Task Create(EvenimentDto eveniment)
        {
            Eveniment newEv = _mapper.Map<Eveniment>(eveniment);
            await _EvenimentRepository.CreateAsync(newEv);
        }
    }
}
