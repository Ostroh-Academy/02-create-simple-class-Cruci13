using System;

class ArithmeticProgression
{
    private double a0; // перший член
    private double d;  // різниця
    private int n;     // кількість членів

    public ArithmeticProgression(double firstTerm, double difference, int numberOfTerms)
    {
        a0 = firstTerm;
        d = difference;
        n = numberOfTerms;
    }

    public double Sum()
    {
        return n * (2 * a0 + (n - 1) * d) / 2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад використання класу ArithmeticProgression
        double firstTerm = 1.0;
        double difference = 2.5;
        int numberOfTerms = 5;

        ArithmeticProgression progression = new ArithmeticProgression(firstTerm, difference, numberOfTerms);
        Console.WriteLine($"Сума арифметичної прогресії: {progression.Sum()}");

        // Визначення власних значень для першого члена, різниці та кількості членів
        double customFirstTerm = 2.0;
        double customDifference = 1.5;
        int customNumberOfTerms = 10;

        ArithmeticProgression customProgression = new ArithmeticProgression(customFirstTerm, customDifference, customNumberOfTerms);
        Console.WriteLine($"Сума арифметичної прогресії: {customProgression.Sum()}");
    }
}