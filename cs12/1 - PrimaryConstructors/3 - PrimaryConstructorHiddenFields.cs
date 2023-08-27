using FluentAssertions;

namespace Cs12.PrimaryConstructors;

public interface IDependency
{
    string GetName();
}

public class WorldDependency : IDependency
{
    public string GetName()
    {
        return "world";
    }
}

public class Service(IDependency dependency)
{
    public string Hello()
    {
        return $"Hello {dependency.GetName()}!";
    }
}

public partial class PrimaryConstructorTests
{
    [Test]
    public void CanReferenceParametersInMembers()
    {
        var dependency = new WorldDependency();
        var service = new Service(dependency);
        var hello = service.Hello();

        hello.Should().Be("Hello world!");
    }
}