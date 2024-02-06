using CityManager.Domain.Dto;
using CityManager.Domain.Interfaces.Services;

namespace CityManager.Application.Services
{
    public class CityService : ICityService
    {
        public Task<CityDto> CreateReportAsync(CityDto city)
        {
            throw new NotImplementedException();
        }

        public Task<CityDto> DeleteReportAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CityDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CityDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CityDto> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<CityDto> UpdateReportAsync(CityDto city)
        {
            throw new NotImplementedException();
        }
    }
}
