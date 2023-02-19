using AlertHub.Data.DTOs.Auth;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AlertHub.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly ILogger<AuthController> _logger;
    private readonly IConfiguration _config;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IValidator<RegisterAccountDataDTO> _accountDataValidator;

    public AuthController(ILogger<AuthController> logger, IConfiguration config,
                          UserManager<IdentityUser> userManager, IValidator<RegisterAccountDataDTO> accountDataValidator)
    {
        _logger = logger;
        _config = config;
        _userManager = userManager;
        _accountDataValidator = accountDataValidator;
    }

    [HttpPost("Register")]
    [AllowAnonymous]
    public async Task<ActionResult> Register([FromBody] RegisterAccountDataDTO accountData, CancellationToken cancellationToken)
    {
        var validationResult = await _accountDataValidator.ValidateAsync(accountData, cancellationToken);

        if (validationResult.IsValid == false)
        {
            _logger.LogWarning("Registration with email: {email} failed", accountData.Email);
            var errorsByProperty = new Dictionary<string, string>();
            validationResult.Errors.ForEach(validationFailure => 
                errorsByProperty.Add(validationFailure.PropertyName, validationFailure.ErrorMessage));
            return Unauthorized(new { succeeded = false, errors = errorsByProperty });
        }

        try
        {
            var existingUser = await _userManager.FindByEmailAsync(accountData.Email);

            if (existingUser != null)
            {
                return Unauthorized(IdentityResult.Failed(new IdentityError
                {
                    Code = "DuplicateEmail",
                    Description = "Email address is already in use."
                }));
            }

            var user = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = accountData.Email,
                UserName = accountData.Username,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var result = await _userManager.CreateAsync(user, accountData.Password);

            if (result.Succeeded == false)
            {
                return Unauthorized(result);
            }

            await _userManager.AddToRoleAsync(user, "SIMPLE_USER");

            var token = GenerateToken(user);

            return Ok(new {succeeded = true, token = token});
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Exception thrown when trying to create user with email: {email}", accountData.Email);
            return Unauthorized("An unusual error occurred during register");
        }
    }

    [HttpPost("Login")]
    [AllowAnonymous]
    public async Task<ActionResult> Login(LoginDataDTO loginData, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByNameAsync(loginData.Username);

        if (user == null)
        {
            return Unauthorized();
        }

        var passwordIsCorrect = await _userManager.CheckPasswordAsync(user, loginData.Password);

        if (passwordIsCorrect == false)
        {
            return Unauthorized();
        }

        return Ok(GenerateToken(user));
    }


    private string GenerateToken(IdentityUser userAccount)
    {
        var secretKey = new SymmetricSecurityKey(
            Encoding.ASCII.GetBytes(
                _config.GetValue<string>("Authentication:SecretKey")!));

        var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

        List<Claim> claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.Sub, userAccount.Id),
            new(JwtRegisteredClaimNames.Email, userAccount.Email!),
            new(JwtRegisteredClaimNames.UniqueName, userAccount.UserName!),
        };

        var token = new JwtSecurityToken(
            issuer: _config.GetValue<string>("Authentication:Issuer"),
            audience: _config.GetValue<string>("Authentication:Audience"),
            claims: claims,
            notBefore: DateTime.UtcNow,
            expires: DateTime.UtcNow.AddDays(1),
            signingCredentials: signingCredentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
