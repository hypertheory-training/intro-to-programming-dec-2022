
namespace SomeNewDotNetSevenStuff;

public class Customer
{
    public required string Name { get; init; } = string.Empty;
    public required decimal CreditLimit { get; init; }
    public string EmailAddress { get; set; } = string.Empty;
}
