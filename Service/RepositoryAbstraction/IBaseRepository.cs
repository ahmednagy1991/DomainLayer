

namespace Service.RepositoryAbstraction
{
    public interface IBaseRepository<T>
    {
        T CreateNew(T model);
        T Update(T model);
        T GetById(long id);
        void Delete(long id);
    }
}
