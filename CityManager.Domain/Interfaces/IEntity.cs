namespace CityManager.Domain.Interfaces
{
    public interface IEntity<T> where T : struct
    {
        public T Id { get; set; }
    }
}
