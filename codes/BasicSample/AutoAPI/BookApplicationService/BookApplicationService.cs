using Volo.Abp.Application.Services;

namespace BookApplicationService;

public class BookApplicationService : ApplicationService
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