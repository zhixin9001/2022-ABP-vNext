using AuthorApplication.Contract;
using Volo.Abp;
using Volo.Abp.Application.Services;

namespace BookApplicationService;

public class BookApplicationService : ApplicationService
{
    private readonly IAuthorApplicationService _authorApplicationService;

    public BookApplicationService(IAuthorApplicationService authorApplicationService)
    {
        _authorApplicationService = authorApplicationService;
    }

    [RemoteService(IsMetadataEnabled = true)]
    public async Task<string> GetAsync(string id)
    {
        var author = await _authorApplicationService.GetAsync("axmf");
        var task = await Task.Run(() =>
        {
            Thread.Sleep(100);
            return id + "-" + author;
        });
        return task;
    }
}