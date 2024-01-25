namespace examen.Models.DTOs
{
    public class EvenimentDto
    {
        public Guid Id { get; set; }
        public DateTime data { get; set; }

        public string? descriere { get; set; }
    }
}
