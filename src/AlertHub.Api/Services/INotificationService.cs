using AlertHub.Api.Models.FCM;

namespace AlertHub.Api.Services;

public interface INotificationService
{
    Task<ResponseModel> SendNotificationAsync(NotificationModel notificationModel);
}
