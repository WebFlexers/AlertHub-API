using AlertHub.Api.Models.FCM;
using CorePush.Google;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
namespace AlertHub.Api.Services;

public class NotificationService : INotificationService
{
    private readonly ILogger<NotificationService> _logger;
    private readonly IHttpClientFactory _clientFactory;
    private readonly FcmNotificationSettings _fcmNotificationSettings;

    public NotificationService(ILogger<NotificationService> logger, IOptions<FcmNotificationSettings> settings, 
        IHttpClientFactory clientFactory)
    {
        _logger = logger;
        _clientFactory = clientFactory;
        _fcmNotificationSettings = settings.Value;
    }

    public async Task<ResponseModel> SendNotificationAsync(NotificationModel notificationModel)
    {
        var response = new ResponseModel();
        try
        {
            if (notificationModel.IsAndroidDevice == false)
            {
                response.IsSuccess = false;
                response.Message = "Currently we only support push notifications for android";
                return response;
            }

            /* FCM Sender (Android Device) */
            var settings = new FcmSettings()
            {
                SenderId = _fcmNotificationSettings.SenderId,
                ServerKey = _fcmNotificationSettings.ServerKey
            };

            var httpClient = _clientFactory.CreateClient();

            var authorizationKey = $"key={settings.ServerKey}";
            var deviceToken = notificationModel.DeviceId;

            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", authorizationKey);
            httpClient.DefaultRequestHeaders.Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var dataPayload = new DataPayload
            {
                Title = notificationModel.Title,
                Body = notificationModel.Body
            };

            var notification = new GoogleNotification
            {
                Data = dataPayload,
                Notification = dataPayload
            };

            var fcm = new FcmSender(settings, httpClient);
            var fcmSendResponse = await fcm.SendAsync(deviceToken, notification);

            if (fcmSendResponse.IsSuccess()) {
                response.IsSuccess = true;
                response.Message = "Notification sent successfully";
                return response;
            } else {
                response.IsSuccess = false;
                response.Message = fcmSendResponse.Results[0].Error;
                return response;
            }
        }
        catch (Exception ex) {
            _logger.LogError(ex, "An error occurred while trying to send a push notification");
            response.IsSuccess = false;
            response.Message = "Something went wrong";
            return response;
        }
    }
}