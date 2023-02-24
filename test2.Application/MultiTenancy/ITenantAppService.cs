using Abp.Application.Services;
using Abp.Application.Services.Dto;
using test2.MultiTenancy.Dto;

namespace test2.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
