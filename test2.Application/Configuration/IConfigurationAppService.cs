using System.Threading.Tasks;
using Abp.Application.Services;
using test2.Configuration.Dto;

namespace test2.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}