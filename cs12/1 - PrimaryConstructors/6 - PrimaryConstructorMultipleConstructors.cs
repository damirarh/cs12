using FluentAssertions;

namespace Cs12.PrimaryConstructors;

public class Customer(string firstName, string lastName)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public string? MiddleName { get; set; }

    public Customer(string firstName, string middleName, string lastName)
        : this(firstName, lastName)
    {
        MiddleName = middleName;
    }
}

public partial class PrimaryConstructorTests
{
    [Test]
    public void CanHaveAdditionalConstructors()
    {
        var customer = new Customer("Donald", "Ervin", "Knuth");

        customer.FirstName.Should().Be("Donald");
        customer.MiddleName.Should().Be("Ervin");
        customer.LastName.Should().Be("Knuth");
    }
}