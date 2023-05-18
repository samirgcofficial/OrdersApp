namespace BlazorApp1.Services
{
    public interface IDbService
    {
        Task<T> GetAsync<T>(string command, object parms);
        Task<List<T>> GetAll<T>(string command, object parms);
        Task<T> Insert<T>(string command, object parms);
    }
}
