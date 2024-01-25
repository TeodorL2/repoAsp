using examen.Models;
using examen.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Lab4_23.Services.EvenimentService
{
    public interface IEvenimentService
    {
        Task<List<EvenimentDto>> GetAll();
        Task Create(EvenimentDto eveniment);
    }
}
