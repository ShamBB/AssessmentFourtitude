namespace AssessmentFourtitude
{
    public class TaskThree
    {
        public static char[] orderByAlgorithm(char[] input, int ordering)
        {
            List<char> inputList = new List<char>(input);
            List<char> outputList = new List<char>();
            int index = 0;

            while (inputList.Count > 0)
            {
                // Calculate the next index using modulo to wrap around
                index = (index + ordering - 1) % inputList.Count;

                // Add the character to the output list
                outputList.Add(inputList[index]);

                // Remove the character from the input list
                inputList.RemoveAt(index);

                // Insert "-" after every 3rd character added to output list
                if (outputList.Count % 4 == 3 && inputList.Count > 0)
                {
                    outputList.Add('-');
                }
            }

            return outputList.ToArray();
        }

        public static char[] UnorderByAlgorithm(char[] input, int ordering)
        {
            int size = input.Length;
            char[] newArray = new char[size];
            int currentIndex = 0;

            for (int i = 0; i < size; i++)
            {
                int count = 0;

                while (count < ordering)
                {
                    if (newArray[currentIndex] == '\0')
                    {
                        count++;
                        if (count == ordering)
                        {
                            newArray[currentIndex] = input[i];
                            break;
                        }
                    }
                    currentIndex = (currentIndex + 1) % size;
                }
            }


            return newArray;
        }
    }
}
