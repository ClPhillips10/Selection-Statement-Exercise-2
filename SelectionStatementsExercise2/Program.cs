namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your favorite school subject? ");
            var FavSubj = Console.ReadLine();
            

            switch (FavSubj.ToLower())
            {
                case "math":
                    Console.WriteLine("That is the only right answer");
                    break;
                case "science":
                    Console.WriteLine($"{FavSubj.ToUpper()} Is okay but not my favorite");
                    break;
                case "history":
                    Console.WriteLine($"I dont like {FavSubj} very much.");
                    break;
                case "english":
                    Console.WriteLine("Ingles es muy difícil");
                    break;
                case "lunch":
                    Console.WriteLine("This is everyones favorite");
                    break;
                default:
                    Console.WriteLine($"I've never heard of {FavSubj} before");
                    break;




            }

            }


    }
}