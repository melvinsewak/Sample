using System.Threading.Tasks;
using Abp.Application.Services;
using Sample.Configuration.Dto;

namespace Sample.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}