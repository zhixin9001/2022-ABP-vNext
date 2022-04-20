using Volo.Abp.Application.Services;

namespace AuthorApplication.Contract;

public interface IAuthorApplicationService : IApplicationService
{
    Task<string> GetAsync(string id);
}