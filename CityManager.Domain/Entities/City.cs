using CityManager.Domain.Interfaces;

namespace CityManager.Domain.Entities
{
    public class City : IEntity<long>
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Population {  get; set; }

        public string Country { get; set; }
    }
}
