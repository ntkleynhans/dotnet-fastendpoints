using System.Text.RegularExpressions;
using FluentValidation;
using FluentValidation.Results;
using ValueOf;

namespace Server.Domain.Common;

public class EmailAddress: ValueOf<string, EmailAddress>
{
    private static readonly Regex EmailAddressRegex = new Regex(
        "^[\\w!#$%&’*+/=?`{|}~^-]+(?:\\.[\\w!#$%&’*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", RegexOptions.Compiled | RegexOptions.IgnoreCase
    );

    protected override void Validate()
    {
        if(!EmailAddressRegex.IsMatch(Value))
        {
            var message = $"{Value} is not a valid email address";
            throw new ValidationException(message, new []
            {
                new ValidationFailure(nameof(EmailAddress), message)
            });
        }
    }
}
