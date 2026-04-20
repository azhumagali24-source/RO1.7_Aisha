using System;

class Student
{
    public string Name;
    public int Grade1;
    public int Grade2;
    public int Grade3;

    public double GetAverage()
    {
        return (Grade1 + Grade2 + Grade3) / 3.0;
    }

    public string GetLetterGrade()
    {
        double avg = GetAverage();

        if (avg >= 90) return "A";
        else if (avg >= 75) return "B";
        else if (avg >= 60) return "C";
        else return "F";
    }

    public void Print()
    {
        Console.WriteLine($"{Name} | Avg: {GetAverage():F2} | Grade: {GetLetterGrade()}");
    }
}

class Program
{
    static void Main()
    {
        Student[] roster = new Student[]
        {
            new Student { Name = "Aisha", Grade1 = 98, Grade2 = 95, Grade3 = 97 },
            new Student { Name = "Symbat", Grade1 = 78, Grade2 = 80, Grade3 = 76 },
            new Student { Name = "Saida", Grade1 = 65, Grade2 = 68, Grade3 = 70 },
            new Student { Name = "Dias", Grade1 = 40, Grade2 = 45, Grade3 = 38 }
        };

        foreach (Student s in roster)
        {
            s.Print();
        }

        Student best = roster[0];

        foreach (Student s in roster)
        {
            if (s.GetAverage() > best.GetAverage())
            {
                best = s;
            }
        }

        Console.WriteLine($"\nBest student: {best.Name} with average {best.GetAverage():F2}");
    }
}