using System.Text.RegularExpressions;
using FluentValidation;
using FluentValidation.Results;
using ValueOf;

namespace Server.Domain.Common;

public class LastName : ValueOf<string, LastName>
{
    private static readonly Regex LastNameRegex = 
        new("^[a-z ,.'-]+$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

    protected override void Validate()
    {
        if (!LastNameRegex.IsMatch(Value))
        {
            var message = $"{Value} is not a valid first name";
            throw new ValidationException(message, new []
            {
                new ValidationFailure(nameof(LastName), message)
            });
        }
    }
}
