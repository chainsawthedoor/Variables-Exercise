namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Jeff";
            int age = 30;
            double avg = 98.7;
            decimal bankAccount = 123.33m;
            char initial = 's';
            bool isMarried = false;
            
            Console.WriteLine($"Hey, my name is {myName}\nAge: {age}: {avg}\n Money: {bankAccount}Initial: {initial}\n Married: {isMarried}");
        }
    }
}
