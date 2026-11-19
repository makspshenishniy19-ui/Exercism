using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly Dictionary<string, int> _studentGrades = new Dictionary<string, int>(StringComparer.Ordinal);

    public bool Add(string student, int grade)
    {
        if (string.IsNullOrWhiteSpace(student))
            return false;

        if (_studentGrades.ContainsKey(student))
            return false;

        _studentGrades[student] = grade;
        return true;
    }

    public IEnumerable<string> Roster()
    {
        return _studentGrades
            .OrderBy(entry => entry.Value)
            .ThenBy(entry => entry.Key, StringComparer.Ordinal)
            .Select(entry => entry.Key)
            .ToList();
    }

    public IEnumerable<string> Grade(int grade)
    {
        return _studentGrades
            .Where(entry => entry.Value == grade)
            .OrderBy(entry => entry.Key, StringComparer.Ordinal)
            .Select(entry => entry.Key)
            .ToList();
    }
}