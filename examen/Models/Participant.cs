using examen.Models.Base;
using examen.Models.Enums;

namespace examen.Models
{
    public class Participant: BaseEntity
    {
        public string Nume {  get; set; }

        public string? Prenume { get; set; }

        public Tip Tip { get; set; }

        public ICollection<EvenPart> EvenPart { get; set;}
    }
}
