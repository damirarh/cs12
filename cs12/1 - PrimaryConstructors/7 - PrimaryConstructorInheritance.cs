using FluentAssertions;

namespace Cs12.PrimaryConstructors;

public class Article(string author, string title)
{
    public string Author => author;
    public string Title => title;

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public override string ToString()
    {
        return $"{author}: {title}";
    }
}

public class PrintedArticle(string author, string title, int noPages)
    : Article(author, title)
{
    public int NoPages => noPages;

    public override string ToString()
    {
        return $"{author}: {title} ({noPages} pages)";
    }
}

public partial class PrimaryConstructorTests
{
    [Test]
    public void IsSupportedInDerivedTypes()
    {
        var article = new PrintedArticle("Damir Arh", "What's new in C# 12", 10);

        article.Author.Should().Be("Damir Arh");
        article.Title.Should().Be("What's new in C# 12");
        article.NoPages.Should().Be(10);
    }

    [Test]
    public void CanHaveDoubleStorageWithInheritance()
    {
        var article = new PrintedArticle("Damir Arh", "What's new in C# 12", 10);
        article.SetTitle("New features in C# 12");

        article.Title.Should().Be("New features in C# 12");
        article.ToString().Should().Be("Damir Arh: What's new in C# 12 (10 pages)");
    }
}