using FluentAssertions;

namespace Cs12.CollectionExpressions;


public partial class CollectionExpressionTests
{
    private string ToString(IEnumerable<int> input)
    {
        return string.Join(',', input);
    }

    [Test]
    public void CanBeUsedAsArguments()
    {
        var result1 = ToString(new[] { 1, 2, 3 });
        var result2 = ToString([1, 2, 3]);

        result2.Should().BeEquivalentTo(result1);
    }
}
