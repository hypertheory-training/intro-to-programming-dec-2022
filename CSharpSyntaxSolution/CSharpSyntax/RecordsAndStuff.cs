

namespace CSharpSyntax;

public class RecordsAndStuff
{
    [Fact]
    public void DoingThingsWithRecords()
    {
        var emp = new EmployeeInformation { EmployeeId = 3, Salary = 80_000 };

        ////var employeeWithRaise = emp with { Salary = emp.Salary + 500 };

        //Assert.Equal(3, emp.EmployeeId);
        //Assert.Equal(80_000, emp.Salary);

        //Assert.Equal(3, employeeWithRaise.EmployeeId);
        //Assert.Equal(80_500, employeeWithRaise.Salary);

        var name = "Jill";

        var newName = name.ToUpper();

        Assert.Equal("Jill", name);
        Assert.Equal("JILL", newName);
    }

    [Fact]
    public void MutatingObjects()
    {
        var jeff = new EmployeeInformation { EmployeeId = 99, Salary = 50_000 };

        var updatedEmployee = HrServices.GiveRaiseTo(jeff, 50);

        Assert.Equal(50_000, jeff.Salary);

        Assert.Equal(50_050, updatedEmployee.Salary);


    }
}


public record EmployeeInformation
{
    public int EmployeeId { get; init; }
    public decimal Salary { get; init; }
   
}


public class HrServices
{
    public static EmployeeInformation GiveRaiseTo(EmployeeInformation emp, decimal raiseAmount)
    {
        // whatever business rules, etc.
        // Hidden Side Effect.
        return emp with { Salary = raiseAmount + emp.Salary };
    }
}