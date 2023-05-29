namespace Assignment
{

    public static class ArrayReplicator
    {

        public static int[] ReplicateArray(int[] original)
        {
            // Get the size of the original array
            int size = original.Length;

            // Create a new array to store the copied elements
            int[] copyArray = new int[size];

            // Copy each element from the original array to the copy array
            for (int i = 0; i < size; ++i)
            {
                copyArray[i] = original[i];
            }
            // Return the copied array
            return copyArray;
        }


        public static int AskForNumber(string text)
        {
            // Display the provided text to prompt the user for input
            Console.Write(text);

            // Read the user's input from the console
            string userInput = Console.ReadLine()!;

            // Convert the user's input to an integer
            int number = Convert.ToInt32(userInput);

            // Return the converted number
            return number;
        }


        public static int AskForNumber(string text, int min, int max)
        {
            // Ask the user for input using the provided text
            int userInput = AskForNumber(text);

            // Check if the user's input falls beyond the anticipated scope
            while (userInput < min || userInput > max)
            {
                // Prompt the user to enter a valid input
                userInput = AskForNumber("Your previous input is not valid, try again.");
            }
            // Return the valid user input
            return userInput;
        }
    }

    static class Program
    {
        static void Main()
        {
            const int Min = 0;
            const int Max = 10;
            const int PrintOffset = 4;

            // Prompt the user to enter the size of the array within the specified range
            int size = ArrayReplicator.AskForNumber("Enter the array size: ", Min, Max);

            // Create an array to store user-specified integers
            int[] original = new int[size];

            // Fill the actual array with user specified integers
            for (int item = 0; item < size; ++item)
            {
                // Prompt the user to enter a number for each item in the array
                original[item] = ArrayReplicator.AskForNumber("Enter a number: ");
            }

            // Create a copy of the original array
            int[] copy = ArrayReplicator.ReplicateArray(original);

            // Verify actual  and replicated array are alike.
            for (int index = 0; index < size; ++index)
                Console.WriteLine($"Original {original[index],-PrintOffset}  {copy[index],4} Copy");
        }
    }
}
