namespace AssessmentFourtitude
{
    public class TaskTwo
    {
        public static int CalculateSpecialDigit(string number)
        {
            int sum = 0;

            // Break the number into groups of 5 (or fewer in the last group)
            for (int i = 0; i < number.Length; i += 5)
            {
                // Extract the current group
                string group = number.Substring(i, Math.Min(5, number.Length - i));

                // Calculate A, B, C, D, E for this group
                int A = (group.Length > 0 ? (group[0] - '0') * 10 : 0);
                int B = (group.Length > 1 ? (group[1] - '0') * 8 : 0);
                int C = (group.Length > 2 ? (group[2] - '0') * 6 : 0);
                int D = (group.Length > 3 ? (group[3] - '0') * 4 : 0);
                int E = (group.Length > 4 ? (group[4] - '0') * 2 : 0);

                // Sum A, B, C, D, E
                int groupSum = A + B + C + D + E;

                // Add to total sum
                sum += groupSum;
            }

            // Reduce sum to a single digit
            int specialDigit = ReduceToSingleDigit(sum);

            return specialDigit;
        }

        public static int ReduceToSingleDigit(int number)
        {
            while (number > 9)
            {
                int sum = 0;
                // Sum digits of the number
                foreach (char c in number.ToString())
                {
                    sum += (c - '0');
                }
                number = sum;
            }
            return number;
        }


        public static void AnalyzeSpecialDigitDistribution()
        {
            int[] digitCount = new int[10];  // To count occurrences of each special digit

            // Loop through numbers from 201 to 999
            for (int number = 201; number <= 999; number++)
            {
                int specialDigit = CalculateSpecialDigit(number.ToString());
                digitCount[specialDigit]++;
            }

            // Find most and least frequent special digits
            int maxFrequency = 0, mostFrequentDigit = 0;
            int minFrequency = int.MaxValue, leastFrequentDigit = 0;

            for (int i = 0; i < digitCount.Length; i++)
            {
                if (digitCount[i] > maxFrequency)
                {
                    maxFrequency = digitCount[i];
                    mostFrequentDigit = i;
                }
                if (digitCount[i] < minFrequency && digitCount[i] > 0)
                {
                    minFrequency = digitCount[i];
                    leastFrequentDigit = i;
                }
            }

            // Print results
            Console.WriteLine($"Most frequent special digit: {mostFrequentDigit} (occurs {maxFrequency} times)");
            Console.WriteLine($"Least frequent special digit: {leastFrequentDigit} (occurs {minFrequency} times)");
        }
    }
}
