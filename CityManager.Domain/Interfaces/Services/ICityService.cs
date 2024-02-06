using CityManager.Domain.Dto;

namespace CityManager.Domain.Interfaces.Services
{
    public interface ICityService
    {
        Task<IEnumerable<CityDto>> GetAllAsync();

        Task<CityDto> GetByIdAsync(int id);

        Task<CityDto> GetByNameAsync(string name);

        Task<CityDto> CreateReportAsync(CityDto city);

        Task<CityDto> UpdateReportAsync(CityDto city);

        Task<CityDto> DeleteReportAsync(int id);
    }
}
