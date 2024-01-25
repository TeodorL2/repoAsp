using examen.Models.Enums;

namespace examen.Models.DTOs
{
    public class ParticipantDto
    {
        public Guid Id { get; set; }

        public string Nume { get; set; }

        public string? Prenume { get; set; }

        public Tip Tip { get; set; }
    }
}
