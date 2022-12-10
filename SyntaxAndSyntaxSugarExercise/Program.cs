namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int answer = 4;
            //string response;

            //if (answer < 9)
            //{
            //response = answer + " is less than nine";
            //}
            //else
            //{
            // response = answer + " greater than or equal to 9";
            // }

            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is gretaer than 9";

            Console.WriteLine(response);
        }
    }
}
