namespace CMS.Common.Interfaces
{
    public interface IRepositoryData<TEntity> : IRepositoryDataReader<TEntity> where TEntity : class
    {
        List<TEntity> Entitys { get; set; }
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(int id);
    }
}
