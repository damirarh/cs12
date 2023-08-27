using FluentAssertions;

namespace Cs12.LambdaParameters;

public class DefaultParametersTests
{
    [Test]
    public void SupportsDefaultParameters()
    {
        var quote = (string value, char quoteChar = '"') =>
            $"{quoteChar}{value}{quoteChar}";

        var result = quote("lambdas");

        result.Should().Be("\"lambdas\"");
    }

    delegate string QuoteDelegate(string value, char quoteChar = '"');

    [Test]
    public void DelegateTypeCanBeDefined()
    {
        QuoteDelegate quote = (value, quoteChar) =>
            $"{quoteChar}{value}{quoteChar}";

        var result = quote("lambdas");

        result.Should().Be("\"lambdas\"");
    }

    [Test]
    public void DefaultValueIsAccessibleThroughReflection()
    {
        var quote = (string value, char quoteChar = '"') =>
            $"{quoteChar}{value}{quoteChar}";

        var defaultValue = quote.Method.GetParameters()[1].DefaultValue;

        defaultValue.Should().Be('"');
    }
}
