using System.Collections.Generic;
using System.Linq;


public class GradeSchool
{
    private SortedList<string, int> students = new SortedList<string, int>();


    public void Add(string student, int grade) => students.Add(student, grade);
    public IEnumerable<string> Roster() => students.OrderBy(s => s.Value).Select(s => s.Key);
    public IEnumerable<string> Grade(int grade) => students.Where(s => s.Value == grade).Select(s => s.Key);
}
