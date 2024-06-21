// See https://aka.ms/new-console-template for more information
using AssessmentFourtitude;
public class Program
{
    public static void Main()
    {
        //=== Task 1
        Console.WriteLine("======= Task 1 =========");
        //=== Task 1 (Basic) - (1)
        double monthlyInstallment = TaskOne.CalculateMonthlyRepayment(100000, 20);
        Console.WriteLine($"Monthly repayment for RM 95,000 loan over 5 years: RM {monthlyInstallment:F2}");

        //=== Task 1 (Advanced) - (1)
        int loanPeriod = TaskOne.CalculateLoanPeriod(30000, 1750);
        Console.WriteLine($"{loanPeriod:F0} years");

        //===Task 1 (Advanced) - (2)
        double desiredPrincipal = TaskOne.CalculatePrincipalToBorrow(750, 20);
        Console.WriteLine($"RM {desiredPrincipal:F2}");
        Console.WriteLine("==========================");


        //=== Task 2
        Console.WriteLine("======= Task 2 =========");
        //=== Task 2 (Basic) - (1)
        int specialDigit = TaskTwo.CalculateSpecialDigit("9729923302749217");
        Console.WriteLine($"Special digit is: {specialDigit}");

        //=== Task 2 (Advance) - (1)
        TaskTwo.AnalyzeSpecialDigitDistribution();
        Console.WriteLine("==========================");
        Console.WriteLine();

        //=== Task 3
        Console.WriteLine("======= Task 3 =========");
        //=== Task 3 (Basic) - 1
        char[] inputTaskThreeBasic = "GHA14SFSD6K92".ToCharArray();
        char[] outputtTaskThreeBasic = TaskThree.orderByAlgorithm(inputTaskThreeBasic, 16);
        Console.WriteLine($"Task 3 basic answer = {new string(outputtTaskThreeBasic)}");

        //=== Task 3 (Advanced) - 1
        char[] inputTaskThreeAdv = " e  rbml s nngeshsr etaet.loaldtryadaimt di ghtoeaeuse aC cuciy afskh ss t ovgo tna atstanmeempaa  Itrf oee!oenotou".ToCharArray();
        char[] outputtTaskThreeAdv = TaskThree.UnorderByAlgorithm(inputTaskThreeAdv, 24);
        Console.WriteLine($"Task 3 advanced answer = {new string(outputtTaskThreeAdv)}");
        Console.WriteLine("==========================");




    }
}
