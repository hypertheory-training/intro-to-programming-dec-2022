
namespace CSharpSyntax;

public class MoreObjectStuff
{
    [Fact]
    public void FormattingNames()
    {
        

        var formattedName = FormatterUtils.FormatName("Luke", "Skywalker", null);
        var formattedName2 = FormatterUtils.FormatName("Luke", "Skywalker", null);

        Assert.Equal(formattedName, formattedName2);
        

        Assert.Equal("Skywalker, Luke", formattedName.FormattedName);
        Assert.Equal(15, formattedName.Length);

        var myName = "joe";
        var myBigName = myName.ToUpper();



       
    }
}


public class FormatterUtils
{
    public static FormattedNameResults FormatName(string firstName, string lastName, string? mi)
    {
        var fullName = $"{lastName}, {firstName}";

        if (mi is not null)
        {
            fullName += $" {mi}.";
        }
        var results = new FormattedNameResults(fullName, fullName.Length);
       
        return results;
    }

}

public record FormattedNameResults
{
    public FormattedNameResults(string formattedName, int length)
    {
        FormattedName = formattedName;
        Length = length;
    }

    public string FormattedName { get;  } = string.Empty;
    public int Length { get;  }

    
}