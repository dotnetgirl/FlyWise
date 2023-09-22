using System.Linq.Expressions;
using FlyWise.Service.DTOs.Users;

namespace FlyWise.Service.Interfaces
{
    public interface IUserService
    {
        Task<UserForResultDto> CreateAsync(UserForCreationDto userForCreationDto);
        Task<UserForResultDto> UpdateAsync(Expression<Func<UserForCreationDto, bool>> expression, UserForResultDto userForResultDto);
        Task<bool> DeleteAsync(Expression<Func<UserForCreationDto, bool>> expression);
        Task<UserForResultDto> GetAsync(Expression<Func<UserForCreationDto, bool>> expression);
        Task<IEnumerable<UserForResultDto>> GetAllAsync();
    }
}
