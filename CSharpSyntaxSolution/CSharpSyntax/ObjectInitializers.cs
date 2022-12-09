using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax;

public class ObjectInitializers
{
    [Fact]
    public void MakingACat()
    {
        var bailey = new Cat()
        {
            Name = "Bailey",
            Breed = "Blue Tip Burmese",
        };
        bailey.Age = 1;

        var scrumpty = new Cat() // Object Initializer
        {
            Name = "Scrumpy",
            Age = 19
        };


    }
}


public class Cat
{
    public string Name { get; init; } = string.Empty;
    public string Breed { get; init; } = string.Empty;
    public int Age { get; set; }

}
