namespace Cs12.AliasAnyType;

using FluentAssertions;
using Coords = (double latitude, double longitude);
using IntArray = int[];
using IntList = List<int>;

public partial class TypeAliasTests
{
    [Test]
    public void AliasForTupleType()
    {
        Coords portoroz = (45.51429, 13.59206);

        portoroz.GetType().Should().Be(typeof((double, double)));
    }

    [Test]
    public void AliasForArrayType()
    {
        IntArray items = [1, 2, 3];

        items.GetType().Should().Be(typeof(int[]));
    }

    [Test]
    public void AliasForGenericType()
    {
        IntList items = [1, 2, 3];

        items.GetType().Should().Be(typeof(List<int>));
    }
}
