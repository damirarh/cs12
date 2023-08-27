using FluentAssertions;

namespace Cs12.PrimaryConstructors;

public class User(string username)
{
    public string Username { get; set; } = username;

    public override string ToString()
    {
        return username;
    }
}

public partial class PrimaryConstructorTests
{
    [Test]
    public void CanHaveDoubleStorageInSingleClass()
    {
        var user = new User("damir");
        user.Username = "damira";

        user.Username.Should().NotBe(user.ToString());
    }
}