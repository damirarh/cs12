using FluentAssertions;

namespace Cs12.PrimaryConstructors;

public record Person(string FirstName, string LastName);

public class RecordClassTests
{
    [Test]
    public void HasReadOnlyProperties()
    {
        var person = new Person("Damir", "Arh");

        person.FirstName.Should().Be("Damir");
        person.LastName.Should().Be("Arh");
    }

    [Test]
    public void HasValueEquality()
    {
        var person1 = new Person("Damir", "Arh");
        var person2 = new Person("Damir", "Arh");

        person1.Should().Be(person2);
    }

    [Test]
    public void HasReferenceSemantics()
    {
        var person = new Person("Damir", "Arh");
        var personCopy = person;

        personCopy.Should().BeSameAs(person);
    }

    [Test]
    public void SupportsWithExpressions()
    {
        var person = new Person("Damir", "Arh");
        var newPerson = person with { FirstName = "Dejan" };

        newPerson.FirstName.Should().Be("Dejan");
        newPerson.LastName.Should().Be("Arh");
    }

    [Test]
    public void HasBuiltInFormatting()
    {
        var person = new Person("Damir", "Arh");

        person.ToString().Should().Be("Person { FirstName = Damir, LastName = Arh }");
    }

    [Test]
    public void SupportsDeconstruction()
    {
        var person = new Person("Damir", "Arh");
        (var firstName, var lastName) = person;

        firstName.Should().Be("Damir");
        lastName.Should().Be("Arh");
    }
}