using examen.Models;

namespace examen.Helpers.Extensions
{
    public static class TotiParticipantii
    {
        public static IQueryable<Participant> GetActiveUsers(this IQueryable<Participant> query)
        {
            return query;
        }
    }
}