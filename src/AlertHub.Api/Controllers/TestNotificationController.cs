using AlertHub.Api.Models.FCM;
using AlertHub.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlertHub.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TestNotificationController : ControllerBase
{
    private readonly INotificationService _notificationService;
    public TestNotificationController(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    //[AllowAnonymous]
    [NonAction]
    public async Task<IActionResult> SendNotification(NotificationModel notificationModel)
    {
        var result = await _notificationService.SendNotificationAsync(notificationModel);
        return Ok(result);
    }
}
