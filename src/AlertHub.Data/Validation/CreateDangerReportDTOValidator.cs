using AlertHub.Data.DTOs;
using AlertHub.Data.Entities.Enums;
using FluentValidation;

namespace AlertHub.Data.Validation;

public class CreateDangerReportDTOValidator : AbstractValidator<CreateDangerReportDTO>
{
    public CreateDangerReportDTOValidator()
    {
        RuleFor(report => report.DisasterType).IsEnumName(typeof(DisasterType))
            .WithMessage("The disaster type specified is not supported");

        RuleFor(report => report.Latitude)
            .NotEmpty().WithMessage("The latitude was empty")
            .Must(latitude =>
            {
                var isValidDouble = double.TryParse(latitude, out var latitudeDouble);
                if (isValidDouble == false)
                {
                    return false;
                }

                if (latitudeDouble < -90 || latitudeDouble > 90)
                {
                    return false;
                }

                return true;
            }).WithMessage("The latitude must be between -90 and 90 degrees");

        RuleFor(report => report.Longitude)
            .NotEmpty().WithMessage("The longitude was empty")
            .Must(longitude =>
            {
                var isValidDouble = double.TryParse(longitude, out var longitudeDouble);
                if (isValidDouble == false)
                {
                    return false;
                }

                if (longitudeDouble < -180 || longitudeDouble > 180)
                {
                    return false;
                }

                return true;
            }).WithMessage("The longitude must be between -180 and 180 degrees");

        RuleFor(report => report.ImageFile)
            .Must(imageFile =>
            {
                if (imageFile == null)
                {
                    return true;
                }

                return imageFile.ContentType.Equals("image/jpeg") || imageFile.ContentType.Equals("image/jpg") ||
                       imageFile.ContentType.Equals("image/png");
            })
            .WithMessage("The only supported image types are jpeg, jpg and png");
            

        RuleFor(report => report.Description)
            .MaximumLength(2000).WithMessage("The description can't be larger than 2000 characters");

        RuleFor(report => report.Culture)
            .Must(culture => culture.Equals("en-US") || culture.Equals("el-GR"))
                .WithMessage("Only en-US and el-GR cultures are supported");
    }
}
