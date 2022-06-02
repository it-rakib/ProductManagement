namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWorkRepository
    {
        ICategoryRepository Category { get; }
        ICoverType CoverType { get; }
        IProductRepository Product { get; }

        void Save();
    }
}
