using AuthorApplication.Contract;
using Volo.Abp.Application.Services;

namespace AuthorApplicationService;

public class AuthorApplicationService : ApplicationService, IAuthorApplicationService
{
    public async Task<string> GetAsync(string id)
    {
        var task = await Task.Run(() =>
        {
            Thread.Sleep(100);
            return id;
        });
        return task;
    }
}