int ExamAssignments = 5;

int[] SophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] AndrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] EmmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] LoganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };


string[] StudentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] StudentScores = new int[10];

string CurrentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n");

foreach (string name in StudentNames)
{
    string CurrentStudent = name;

    if (CurrentStudent == "Sophia")
        StudentScores = SophiaScores;

    else if (CurrentStudent == "Andrew")
        StudentScores = AndrewScores;

    else if (CurrentStudent == "Emma")
        StudentScores = EmmaScores;

    else if (CurrentStudent == "Logan")
        StudentScores = LoganScores;
    else if (CurrentStudent == "Becky")
        StudentScores = beckyScores;
    else if (CurrentStudent == "Chris")
        StudentScores = chrisScores;
    else if (CurrentStudent == "Eric")
        StudentScores = ericScores;
    else if (CurrentStudent == "Gregor")
        StudentScores = gregorScores;
    else
        continue;

    int SumAssignmentScores = 0;

    decimal CurrentStudentGrade = 0;

    int GradedAssignments = 0;

    foreach (int score in StudentScores)
    {
        GradedAssignments += 1;

        if (GradedAssignments <= ExamAssignments)
            SumAssignmentScores += score;

        else
            SumAssignmentScores += score / 10;
    }

    CurrentStudentGrade = (decimal)SumAssignmentScores / ExamAssignments;

    if (CurrentStudentGrade >= 97)
        CurrentStudentLetterGrade = "A+";

    else if (CurrentStudentGrade >= 93)
        CurrentStudentLetterGrade = "A";

    else if (CurrentStudentGrade >= 90)
        CurrentStudentLetterGrade = "A-";

    else if (CurrentStudentGrade >= 87)
        CurrentStudentLetterGrade = "B+";

    else if (CurrentStudentGrade >= 83)
        CurrentStudentLetterGrade = "B";

    else if (CurrentStudentGrade >= 80)
        CurrentStudentLetterGrade = "B-";

    else if (CurrentStudentGrade >= 77)
        CurrentStudentLetterGrade = "C+";

    else if (CurrentStudentGrade >= 73)
        CurrentStudentLetterGrade = "C";

    else if (CurrentStudentGrade >= 70)
        CurrentStudentLetterGrade = "C-";

    else if (CurrentStudentGrade >= 67)
        CurrentStudentLetterGrade = "D+";

    else if (CurrentStudentGrade >= 63)
        CurrentStudentLetterGrade = "D";

    else if (CurrentStudentGrade >= 60)
        CurrentStudentLetterGrade = "D-";

    else
        CurrentStudentLetterGrade = "F";

    Console.WriteLine($"{CurrentStudent}:\t\t{CurrentStudentGrade}\t{CurrentStudentLetterGrade}");

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
