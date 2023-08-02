namespace CourtVillaBank.Repository.Repository.Abstraction
{
    public interface IGenericRepository<T> where T : class
    {
     
        
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
        void Update(T entity);
        Task CreateAsync(T entity);


    }
}
