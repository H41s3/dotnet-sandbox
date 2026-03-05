static string GetGrade(int score)
{
    if (score >= 90)
        return "A 🌟";
    else if (score >= 70)
        return "B 😊";
    else if (score >= 50)
        return "C 😐";
    else
        return "F 💪 keep going!";
}

for (int = 1; i <= 3; i++)
{
    Console.WriteLine("Student" + i);
    Console.WriteLine("Grade: " + GetGrade(i * 30));
}