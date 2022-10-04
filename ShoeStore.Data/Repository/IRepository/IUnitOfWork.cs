namespace ShoeStore.Data.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category {  get; }
        IShoeTypeRepository ShoeType {  get; }
        IProductRepository Product { get; }
        ICompanyRepository Company {  get; }
        IShoppingCartRepository ShoppingCart {  get; }
        IApplicationUserRepository ApplicationUser {  get; }
        IOrderDetailRepository OrderDetail {  get; }
        IOrderHeaderRepository OrderHeader {  get; }

        void Save();
    }
}
