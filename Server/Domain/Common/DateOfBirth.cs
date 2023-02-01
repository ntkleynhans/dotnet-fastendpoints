using FluentValidation;
using FluentValidation.Results;
using ValueOf;

namespace Server.Domain.Common;

public class DateOfBirth : ValueOf<DateOnly, DateOfBirth>
{
    protected override void Validate()
    {
        if(Value > DateOnly.FromDateTime(DateTime.Now))
        {
            const string message = "Birth date in the future";
            throw new ValidationException(message, new []
            {
                new ValidationFailure(nameof(DateOfBirth), message)
            });
        }
    }
}
