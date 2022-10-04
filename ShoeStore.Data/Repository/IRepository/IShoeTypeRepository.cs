using ShoeStore.Models;

namespace ShoeStore.Data.Repository.IRepository
{
    public interface IShoeTypeRepository : IRepository<ShoeType>
    {
        void Update(ShoeType obj);
    }
}
