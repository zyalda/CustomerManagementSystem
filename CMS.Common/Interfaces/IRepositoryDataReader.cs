namespace CMS.Common.Interfaces
{
    public interface IRepositoryDataReader<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> RetrieveAll();
        IEnumerable<TEntity> FindById(int id);
        //void PrintAll();
        bool Save(TEntity entity);
    }
}
