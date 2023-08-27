using FluentAssertions;

namespace Cs12.PrimaryConstructors;

public record struct Point(int X, int Y);

public class RecordStructTests
{
    [Test]
    public void HasReadOnlyProperties()
    {
        var point = new Point(4, 2);

        point.X.Should().Be(4);
        point.Y.Should().Be(2);
    }

    [Test]
    public void HasValueEquality()
    {
        var point1 = new Point(4, 2);
        var point2 = new Point(4, 2);

        point1.Should().Be(point2);
    }

    [Test]
    public void HasValueSemantics()
    {
        var point = new Point(4, 2);
        var pointCopy = point;

        point.Should().NotBeSameAs(pointCopy);
    }

    [Test]
    public void SupportsWithExpressions()
    {
        var point = new Point(4, 2);
        var newPoint = point with { Y = 1 };

        newPoint.X.Should().Be(4);
        newPoint.Y.Should().Be(1);
    }

    [Test]
    public void HasBuiltInFormatting()
    {
        var point = new Point(4, 2);

        point.ToString().Should().Be("Point { X = 4, Y = 2 }");
    }

    [Test]
    public void SupportsDeconstruction()
    {
        var point = new Point(4, 2);
        (var x, var y) = point;

        x.Should().Be(4);
        y.Should().Be(2);
    }
}