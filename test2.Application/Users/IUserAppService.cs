using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using test2.Roles.Dto;
using test2.Users.Dto;

namespace test2.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}