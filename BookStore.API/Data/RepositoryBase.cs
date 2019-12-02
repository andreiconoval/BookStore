namespace BookStore.API.Data
{
    public class RepositoryBase
    {
        protected readonly DataContext _context;
        public RepositoryBase(DataContext context) {
            _context = context;
        }
    }
}