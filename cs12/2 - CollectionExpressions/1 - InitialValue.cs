using FluentAssertions;

namespace Cs12.CollectionExpressions;

public partial class CollectionExpressionTests
{
    [Test]
    public void InitializesList()
    {
        var list1 = new List<int> { 1, 2, 3 };
        List<int> list2 = [1, 2, 3];

        list2.Should().BeEquivalentTo(list1);
    }

    [Test]
    public void InitializesArray()
    {
        var array1 = new[] { 1, 2, 3 };
        int[] array2 = [1, 2, 3];

        array2.Should().BeEquivalentTo(array1);
    }

    [Test]
    public void Initializes2dArray()
    {
        var array1 = new[]
        {
            new[] { 1, 2 },
            new[] { 3, 4 },
            new[] { 5, 6 },
        };
        int[][] array2 = [[1, 2], [3, 4], [5, 6]];

        array2.Should().BeEquivalentTo(array1);
    }

    [Test]
    public void InitializesSpan()
    {
        var array = new[] { 1, 2, 3 };
        Span<int> span = [1, 2, 3];

        span.ToArray().Should().BeEquivalentTo(array);
    }

    [Test]
    public void SupportsSpreadOperator()
    {
        int[] array = [1, 2];
        Span<int> span = [3, 4];
        List<int> list = [5, 6];
        int[] finalArray = [.. array, .. span, .. list];

        finalArray.Should().ContainInOrder(1, 2, 3, 4, 5, 6);
    }
}