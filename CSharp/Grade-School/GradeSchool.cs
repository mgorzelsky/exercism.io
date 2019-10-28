using System;
using System.Collections.Generic;

public class GradeSchool
{
    private List<string> grade1 = new List<string>();
    private List<string> grade2 = new List<string>();
    private List<string> grade3 = new List<string>();
    private List<string> grade4 = new List<string>();
    private List<string> grade5 = new List<string>();
    private List<string> grade6 = new List<string>();
    private List<string> grade7 = new List<string>();
    private List<string> grade8 = new List<string>();

    public void Add(string student, int grade)
    {
        switch (grade)
        {
            case (1):
                grade1.Add(student);
                grade1.Sort();
                break;
            case (2):
                grade2.Add(student);
                grade2.Sort();
                break;
            case (3):
                grade3.Add(student);
                grade3.Sort();
                break;
            case (4):
                grade4.Add(student);
                grade4.Sort();
                break;
            case (5):
                grade5.Add(student);
                grade5.Sort();
                break;
            case (6):
                grade6.Add(student);
                grade6.Sort();
                break;
            case (7):
                grade7.Add(student);
                grade7.Sort();
                break;
            case (8):
                grade8.Add(student);
                grade8.Sort();
                break;
        }
    }

    public IEnumerable<string> Roster()
    {
        List<string> rosterBuilder = new List<string>();
        ListBuilder(grade1, ref rosterBuilder);
        ListBuilder(grade2, ref rosterBuilder);
        ListBuilder(grade3, ref rosterBuilder);
        ListBuilder(grade4, ref rosterBuilder);
        ListBuilder(grade5, ref rosterBuilder);
        ListBuilder(grade6, ref rosterBuilder);
        ListBuilder(grade7, ref rosterBuilder);
        ListBuilder(grade8, ref rosterBuilder);

        String[] fullRoster = new string[rosterBuilder.Count];
        rosterBuilder.CopyTo(fullRoster);
        return fullRoster;
    }

    public IEnumerable<string> Grade(int grade)
    {
        string[] studentsInGrade;
        switch (grade)
        {
            case (1):
                studentsInGrade = new string[grade1.Count];
                grade1.CopyTo(studentsInGrade);
                return studentsInGrade;
            case (2):
                studentsInGrade = new string[grade2.Count];
                grade2.CopyTo(studentsInGrade);
                return studentsInGrade;
            case (3):
                studentsInGrade = new string[grade3.Count];
                grade3.CopyTo(studentsInGrade);
                return studentsInGrade;
            case (4):
                studentsInGrade = new string[grade4.Count];
                grade4.CopyTo(studentsInGrade);
                return studentsInGrade;
            case (5):
                studentsInGrade = new string[grade5.Count];
                grade5.CopyTo(studentsInGrade);
                return studentsInGrade;
            case (6):
                studentsInGrade = new string[grade6.Count];
                grade6.CopyTo(studentsInGrade);
                return studentsInGrade;
            case (7):
                studentsInGrade = new string[grade7.Count];
                grade7.CopyTo(studentsInGrade);
                return studentsInGrade;
            case (8):
                studentsInGrade = new string[grade8.Count];
                grade8.CopyTo(studentsInGrade);
                return studentsInGrade;
        }
        studentsInGrade = new string[0];
        return studentsInGrade;
    }

    private void ListBuilder(List<string> referenceList, ref List<string> masterList)
    {
        foreach (string student in referenceList)
            masterList.Add(student);
    }
}