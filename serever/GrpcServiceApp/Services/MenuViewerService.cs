using Grpc.Core;

namespace GrpcServiceApp.Services;

public class MenuViewerService : MenuViewer.MenuViewerBase
{
    private readonly ILogger<MenuViewerService> _logger;

    public MenuViewerService(ILogger<MenuViewerService> logger)
    {
        _logger = logger;
    }

    public override Task<Reply> ShowMenu(Request request, ServerCallContext context)
    {
        return Task.FromResult(new Reply()
        {
            Id = "1",
            Title = "123"
        });
    }
}