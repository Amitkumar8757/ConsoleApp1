using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

List<emp> employees = new List<emp>();
emp emp1 = new emp { Name = "Deepak", Skills = new List<string> { "C", "C++", "Java" } };
emp emp2 = new emp { Name = "Karan", Skills = new List<string> { "SQL", "C#", ".Net", "C" } };
emp emp3 = new emp { Name = "Lalit", Skills = new List<string> { "C#", "Azure", "MVC" } };
employees.Add(emp1);
employees.Add(emp2);
employees.Add(emp3);

// Write the name of employee whose skill is C#
//test
var names = employees.Where(e => e.Skills.Contains("C#")).Select(h=>h.Name).ToList();

foreach (var name in names)
{
    //Console.WriteLine(name);
    //this comment from naveen kumar
}

public class emp
{
    public string Name { get; set; } = string.Empty;
    public List<string> Skills { get; set; } = new();
}