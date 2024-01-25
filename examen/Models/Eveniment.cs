using examen.Models.Base;

namespace examen.Models
{
    public class Eveniment : BaseEntity
    {
        public DateTime data { get; set; }

        public string? descriere { get; set; }

        public ICollection<EvenPart> EvenPart { get; set; }
    }
}
