using examen.Models.Base;

namespace examen.Models
{
    public class EvenPart: BaseEntity
    {
        public Guid EvenimentId { get; set; }
        public Eveniment Eveniment { get; set; }

        public Guid ParticipantId { get; set; }
        public Participant Participant { get; set; }
    }
}
