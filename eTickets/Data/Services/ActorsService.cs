using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public class ActorsService: EntityBaseRepositorycs<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context):base(context) { }
    }
}
