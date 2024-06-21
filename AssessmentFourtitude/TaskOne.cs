namespace AssessmentFourtitude
{
    public class TaskOne
    {
        public static double CalculateMonthlyRepayment(double principal, int loanPeriodInYears)
        {
            double annualInterestRate = 0;
            if (principal >= 5000 && principal <= 20000)
            {
                annualInterestRate = 8.0;
            }
            else if (principal > 20000 && principal <= 50000)
            {
                annualInterestRate = 7.0;
            }
            else if (principal > 50000 && principal <= 100000)
            {
                annualInterestRate = 6.5;
            }


            double monthlyInterestRate = annualInterestRate / 12 / 100;
            int numberOfPayments = loanPeriodInYears * 12;

            double monthlyRepayment = principal * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, numberOfPayments) /
                                      (Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1);

            return monthlyRepayment;
        }
        public static double CalculatePrincipalToBorrow(double desiredMonthlyPayment, int loanPeriodInYears)
        {
            double annualInterestRate = 0;
           
            if (desiredMonthlyPayment <= CalculateMonthlyRepayment(20000, loanPeriodInYears))
            {
                annualInterestRate = 8.0;
            }
            else if (desiredMonthlyPayment <= CalculateMonthlyRepayment(50000, loanPeriodInYears))
            {
                annualInterestRate = 7.0;
            }
            else if (desiredMonthlyPayment <= CalculateMonthlyRepayment(100000, loanPeriodInYears))
            {
                annualInterestRate = 6.5;
            }
            


            double monthlyInterestRate = annualInterestRate / 12 / 100;
            int numberOfPayments = loanPeriodInYears * 12;

            double principal = desiredMonthlyPayment * ((1 - Math.Pow(1 + monthlyInterestRate, -numberOfPayments)) / monthlyInterestRate);

            //P =  r x (1+r)n/((1+r)n-1) * A


            return principal;
        }

        public static int CalculateLoanPeriod(double principal, double desiredMonthlyPayment)
        {

            int loanPeriod = 1; // Start with 1 year

            double annualInterestRate = 0;
            if (principal >= 5000 && principal <= 20000)
            {
                annualInterestRate = 8.0;
            }
            else if (principal > 20001 && principal <= 50000)
            {
                annualInterestRate = 7.0;
            }
            else if (principal > 50001 && principal <= 100000)
            {
                annualInterestRate = 6.5;
            }

            double monthlyInterestRate = annualInterestRate / 12 / 100;

            while (loanPeriod <= 50) // Assume a maximum loan period of 50 years
            {
                int numberOfPayments = loanPeriod * 12;

                double monthlyRepayment = principal * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, numberOfPayments) /
                                          (Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1);

                if (monthlyRepayment <= desiredMonthlyPayment)
                {
                    return loanPeriod;
                }

                loanPeriod++;
            }

            return -1; // If no feasible loan period is found
        }
    }
}
