using AlertHub.Api.Extensions;
using AlertHub.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.AddStandardServices();
builder.AddHealthCheckServices();
builder.AddAuthServices();
builder.AddCustomServices();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer("name=Default", 
        sqlServer => sqlServer.UseNetTopologySuite());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.UseStaticFiles();

app.MapHealthChecks("/health").AllowAnonymous();

app.Run();
