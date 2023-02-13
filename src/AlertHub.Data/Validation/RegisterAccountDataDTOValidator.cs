using AlertHub.Data.DTOs.Auth;
using FluentValidation;

namespace AlertHub.Data.Validation;

public class RegisterAccountDataDTOValidator : AbstractValidator<RegisterAccountDataDTO>
{
    public RegisterAccountDataDTOValidator()
    {
        RuleFor(account => account.Username)
            .NotNull().WithMessage("Username can't be empty")
            .NotEmpty().WithMessage("Username can't be empty")
            .MinimumLength(3).WithMessage("Username must have a length of at least 3");

        RuleFor(account => account.Password)
            .NotNull().WithMessage("Password can't be empty")
            .NotEmpty().WithMessage("Password can't be empty")
            .MinimumLength(6).WithMessage("Password must have a length of at least 6")
            .Matches(@"^[a-zA-Z0-9!@#$%^&*]+$")
            .WithMessage("Password can contain only US letters, numbers or the following symbols: !@#$%^&*");

        RuleFor(account => account.ConfirmPassword)
            .Must((account, confirmPassword) => 
                account.Password.Equals(confirmPassword)).WithMessage("Passwords don't match");

        RuleFor(account => account.Email)
            .NotNull().WithMessage("Email can't be empty")
            .NotEmpty().WithMessage("Email can't be empty")
            .EmailAddress().WithMessage("Email address is invalid");
    }
}
