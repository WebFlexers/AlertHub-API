using System.Configuration;
using AlertHub.Api.Extensions;
using AlertHub.Api.Models.FCM;
using AlertHub.Api.Services;
using AlertHub.Data;
using CorePush.Apple;
using CorePush.Google;
using Hangfire;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

const string myAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.AddStandardServices();
builder.AddHealthCheckServices();
builder.AddAuthServices();
builder.AddCustomServices();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins,
    policy =>
    {
      policy.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

builder.Services.AddHttpClient();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer("name=Default", 
        sqlServer => sqlServer.UseNetTopologySuite());
});

GlobalConfiguration.Configuration.UseSerializerSettings(new JsonSerializerSettings
{
    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
});
var connectionString = builder.Configuration.GetValue<string>("ConnectionStrings:Default");
builder.Services.AddHangfire(x => x.UseSqlServerStorage(connectionString));
builder.Services.AddHangfireServer();

builder.Services.AddTransient<INotificationService, NotificationService>();
builder.Services.AddHttpClient<FcmSender>();
builder.Services.AddHttpClient<ApnSender>();

// Configure strongly typed settings objects
var fcmSettingsSection = builder.Configuration.GetSection("FcmNotification");
builder.Services.Configure<FcmNotificationSettings>(fcmSettingsSection);


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseHangfireDashboard();

//app.UseHttpsRedirection();

app.UseCors(myAllowSpecificOrigins);

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MapHealthChecks("/health").AllowAnonymous();

app.Run();
