using FluentAssertions;

namespace Cs12.PrimaryConstructors;

public readonly struct Vector(int x, int y)
{
    public int X { get; } = x;
    public int Y { get; } = y;
}

public partial class PrimaryConstructorTests
{
    [Test]
    public void RequiresExplicitProperties()
    {
        var vector = new Vector(4, 2);

        vector.X.Should().Be(4);
        vector.Y.Should().Be(2);
    }
}