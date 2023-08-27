using FluentAssertions;

namespace Cs12.LambdaParameters;

public class ParamsParametersTests
{
    [Test]
    public void SupportsParamsParameters()
    {
        var average = (params int[] items) =>
            items.Average();

        var result = average(1, 2, 3);

        result.Should().Be(2);
    }

    delegate double AverageDelegate(params int[] items);

    [Test]
    public void DelegateTypeCanBeDefined()
    {
        AverageDelegate average = (items) => items.Average();

        var result = average(1, 2, 3);

        result.Should().Be(2);
    }
}
