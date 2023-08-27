using FluentAssertions;
using System.Runtime.CompilerServices;

namespace Cs12.InlineArrays;

[InlineArray(10)]
public struct Buffer10<T>
{
    private T _element0;
}

public class InlineArrayTests
{
    [Test]
    public void AccessedAsArrayInCode()
    {
        var buffer = new Buffer10<int>();
        for (var i = 0; i < 10; i++)
        {
            buffer[i] = i;
            buffer[i].Should().Be(i);
        }
    }

    [Test]
    public void CanBeExposedAsSpan()
    {
        var buffer = new Buffer10<int>();
        for (var i = 0; i < 10; i++)
        {
            buffer[i] = i;
        }

        Span<int> span = buffer;

        span.ToArray().Should().BeEquivalentTo([0, 1, 2, 3, 4, 5, 6, 7, 8, 9]);
    }
}