using ShoeStore.Data.Repository.IRepository;
using ShoeStore.Models;

namespace ShoeStore.Data.Repository
{
    public class ShoeTypeRepository : Repository<ShoeType>, IShoeTypeRepository
    {
        private ApplicationDbContext _db;

        public ShoeTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(ShoeType obj)
        {
            _db.ShoeTypes.Update(obj);
        }
    }
}
