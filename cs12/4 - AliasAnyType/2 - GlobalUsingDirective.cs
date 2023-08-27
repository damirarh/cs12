namespace Cs12.AliasAnyType;

using FluentAssertions;

public partial class TypeAliasTests
{
    [Test]
    public void GlobalAliasForTupleType()
    {
        PlayerScore score = ("Damir", 42);

        score.GetType().Should().Be(typeof((string, int)));
    }

    [Test]
    public void GlobalAliasForArrayType()
    {
        DoubleArray items = [1.0, 2.0, 3.0];

        items.GetType().Should().Be(typeof(double[]));
    }

    [Test]
    public void GlobalAliasForGenericType()
    {
        DoubleList items = [1.0, 2.0, 3.0];

        items.GetType().Should().Be(typeof(List<double>));
    }
}
